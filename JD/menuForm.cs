using System;
using System.Windows.Forms;
using RDotNet;
using System.IO;
using System.Configuration;

namespace JD
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        public string Code { get; set; }

        public string TempImagePath { get; set; }

        public REngine Engine { get; set; }

        public string sdbfile; // selected database file

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.MdiParent = this;
            about.Show();

        }

        private void Add_button_Click(object sender, EventArgs e)
        {

        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(searchForm))
                {
                    form.Activate();
                    return;
                }
            }

            searchForm pf = new searchForm()
            {
                //Engine = this.Engine,
                dbfile = this.sdbfile,
                TempImagePath = this.TempImagePath
            };
 
            pf.Left = 0;
            pf.Top = 0;

            pf.MdiParent = this;
            pf.Width = this.Width - 100;
            pf.Height = this.Height - 250;

            pf.Show();
            
        }
           

        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dbfile = new OpenFileDialog();
            dbfile.Filter = "Database file (*.db)|*.db";
            dbfile.FilterIndex = 1;

            dbfile.Multiselect = false;
            //dbfile.ShowDialog();

            if (dbfile.ShowDialog() == DialogResult.OK)
            {
                //sdbfile = dbfile.FileName.Replace("\\","/");
                sdbfile = dbfile.FileName;

                TempImagePath = Path.Combine(Path.GetTempPath(), Path.GetTempFileName() + ".png");

                try
                {
                    var appSettings = ConfigurationManager.AppSettings;

                    string rpath = appSettings["RPATH"];
                    string rhome = appSettings["RHOME"];

                    REngine.SetEnvironmentVariables(rpath, rhome);
                    //REngine rengine = REngine.GetInstance();
                    Engine = REngine.GetInstance();

                    //Application.ThreadExit += (sender, e) => rengine.Dispose();

                    Engine.Initialize();

                    //libs.R 
                    var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                    string libsPath = Path.Combine(projectPath, "Resources\\libs.R");

                    Engine.Evaluate(string.Format("source('{0}')", libsPath.Replace('\\', '/')));

                    //load selected database file (sdbfile)
                    Engine.Evaluate(string.Format("db <- dbConnect(SQLite(),'{0}')", sdbfile.Replace('\\', '/')));

                    MessageBox.Show(Path.GetFileName(sdbfile) + " has been loaded.");


                    //disable load menu item
                    //loadDataToolStripMenuItem.Enabled = false;

                    addEditToolStripMenuItem.Enabled = true;
                    searchToolStripMenuItem.Enabled = true;

                    exportAsCSVFileToolStripMenuItem.Enabled = true;

                }
                catch (FormatException rinit)
                {
                    MessageBox.Show(rinit.Message, "REngine error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            addEditToolStripMenuItem.Enabled = false;
            searchToolStripMenuItem.Enabled = false;

            exportAsCSVFileToolStripMenuItem.Enabled = false;
        }

        private void addEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(editForm))
                {
                    form.Activate();
                    return;
                }
            }

            editForm ed = new editForm()
            {
                //Engine = this.Engine,
                dbfile = this.sdbfile,
                TempImagePath = this.TempImagePath
            };

            ed.Left = 0;
            ed.Top = 0;
            ed.MdiParent = this;           
            ed.Show();

        }

        private void generateNewDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string newfilename;
            //string emptydb = "emptydb.db";

            //emptydb.db
            var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string emptydb = Path.Combine(projectPath, "Resources\\emptydb.db");


            SaveFileDialog newdb = new SaveFileDialog();

            newdb.Filter = "db files (*.db)|*.db|All files (*.*)|*.*";
            newdb.FilterIndex = 1;
            newdb.RestoreDirectory = true;

            if (newdb.ShowDialog() == DialogResult.OK)
            {
                newfilename = newdb.FileName;
                try
                {
                    File.Copy(emptydb, newfilename);
                    MessageBox.Show("New database : " + newfilename + " has been created.");
                }
                catch
                {
                    MessageBox.Show("Error!! New database cannot be created.\nTry to change the file name.");
                }
                
            }

        }

        private void exportAsCSVFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog csvfile = new SaveFileDialog();
            csvfile.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            csvfile.FilterIndex = 1;
            csvfile.RestoreDirectory = true;

            if (csvfile.ShowDialog() == DialogResult.OK)
            {
                string newcsv = csvfile.FileName;

                try
                {
                    //export csv; this can be put in the lib file
                    Engine.Evaluate(string.Format("db <- dbConnect(SQLite(),'{0}')", this.sdbfile.Replace('\\', '/')));
                    string exportCSV = "SELECT * FROM jdb";
                    Engine.Evaluate(string.Format("newdf <- dbGetQuery(db, '{0}')", exportCSV));
                    Engine.Evaluate(string.Format("write.csv(newdf, file = '{0}')", newcsv.Replace('\\', '/')));

                    MessageBox.Show(Path.GetFileName(newcsv) + " has been written.");

                }
                catch
                {
                    MessageBox.Show("The CSV file cannot be exported.");
                }
                
            }

        }
    }
}
