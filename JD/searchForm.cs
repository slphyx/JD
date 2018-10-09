using RDotNet;
using System;
using System.IO;
using System.Windows.Forms;

namespace JD
{
    public partial class searchForm : Form
    {
        public searchForm()
        {
            InitializeComponent();
            this.SizeChanged += new EventHandler(searchForm_SizeChanged);
        }

        public string Code { get; set; }

        public string TempImagePath { get; set; }

        public REngine Engine { get; set; }

        public DataFrame df;

        public string dbfile;

        private void mainForm_Load(object sender, EventArgs e)
        {
            Engine = REngine.GetInstance();
            Engine.Evaluate(string.Format("db <- dbConnect(SQLite(),'{0}')", dbfile.Replace("\\", "/"))); 

            InitCols();
        }

        private void plotbutton_Click(object sender, EventArgs e)
        {
            //var engine = REngine.GetInstance();
            
            Engine.Evaluate(string.Format("png('{0}', {1}, {2})", TempImagePath.Replace('\\', '/'), this.graph_pictureBox.Width, this.graph_pictureBox.Height));
            Engine.Evaluate(Code);
            Engine.Evaluate("dev.off()");
            this.graph_pictureBox.ImageLocation = TempImagePath;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainForm_Closing(object sender, FormClosedEventArgs e)
        {
            //if (e.CloseReason == CloseReason.UserClosing)
            //    //
            //if (e.CloseReason == CloseReason.WindowsShutDown)
            //    //
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            string id = ID_textBox.Text;
            ShowData(id);
            PlotData(id);

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchForm_SizeChanged(Object sender, EventArgs e)
        {
            string id = ID_textBox.Text;
            PlotData(id);
        }


        //for plotting the graph
        //it uses PlotData function from libs.R
        private void PlotData(string id)
        {
            if (string.IsNullOrEmpty(id) == false)
            {
                Engine.Evaluate(string.Format("png('{0}', {1}, {2})", TempImagePath.Replace('\\', '/'), graph_pictureBox.Width, graph_pictureBox.Height));
                Code = string.Format("PlotData('{0}',db)", id);
                Engine.Evaluate(Code);
                Engine.Evaluate("dev.off()");
                graph_pictureBox.ImageLocation = TempImagePath;
            }
            
        }


        //initial state of all checkboxes
        private void InitCols()
        {
            CalcAgeSample_hours_checkBox.Checked = true;
            SBR_SBR_checkBox.Checked = true;
            MSBR_SBR_checkBox.Checked = true;
            sbr_thrmod_checkBox.Checked = true;
            sbr_thret_checkBox.Checked = true;
            Nhclinic_checkBox.Checked = true;

            photo_link_checkBox.Checked = true;
            Start_photo_checkBox.Checked = true;
            Stop_photo_checkBox.Checked = true;
            PhotoType_photo_checkBox.Checked = true;
            EGA_checkBox.Checked = true;
            EGAw_checkBox.Checked = true;

            dev_Sex_checkBox.Checked = true;
            NB_ethnicity_6cat_checkBox.Checked = true;
            Primip_anc_checkBox.Checked = true;

            BIM_del_2cat_checkBox.Checked = true;
            dev_Syntocinon_checkBox.Checked = true;
            ABOIncompa_checkBox.Checked = true;
            hematoma_checkBox.Checked = true;

            SGA_checkBox.Checked = true;
            G6PD_Birth_bb_checkBox.Checked = true;
            Def_SevereInfect_checkBox.Checked = true;
            sbrcount_checkBox.Checked = true;

        }

        //for checking the checkbox states
        private string CheckBoxStates()
        {
            string states = "";
            bool[] chks = new bool[] { CalcAgeSample_hours_checkBox.Checked, SBR_SBR_checkBox.Checked, MSBR_SBR_checkBox.Checked,
                sbr_thrmod_checkBox.Checked, sbr_thret_checkBox.Checked, Nhclinic_checkBox.Checked, photo_link_checkBox.Checked,
                Start_photo_checkBox.Checked,Stop_photo_checkBox.Checked, PhotoType_photo_checkBox.Checked,EGA_checkBox.Checked,
                EGAw_checkBox.Checked,dev_Sex_checkBox.Checked, NB_ethnicity_6cat_checkBox.Checked,Primip_anc_checkBox.Checked,
                BIM_del_2cat_checkBox.Checked, dev_Syntocinon_checkBox.Checked, ABOIncompa_checkBox.Checked, hematoma_checkBox.Checked,
                SGA_checkBox.Checked, G6PD_Birth_bb_checkBox.Checked, Def_SevereInfect_checkBox.Checked, sbrcount_checkBox.Checked
            };

            string[] chkboxes = new string[] { "'CalcAgeSample_hours'", "'SBR_SBR'", "'MSBR_SBR'",
                "'sbr_thrmod'", "'sbr_thret'","'Nhclinic'", "'photo_link'","'Start_photo'","'Stop_photo'","'PhotoType_photo'","'EGA'",
                "'EGAw'","'dev_Sex'","'NB_ethnicity_6cat'","'Primip_anc'",
                "'BIM_del_2cat'", "'dev_Syntocinon'", "'ABOIncompa'", "'hematoma'",
                "'SGA'", "'G6PD_Birth_bb'", "'Def_SevereInfect'", "'sbrcount'"};

            for (int i = 0; i < chkboxes.Length; i++)
            {
                if (chks[i] == true)
                {
                    states = states + "," + chkboxes[i];
                }
            }

            return states;
        }


        //for showing the data in the datagrid view
        private void ShowData(string id)
        {

            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            string checkboxes = CheckBoxStates();

            //string id = ID_textBox.Text;
            if (id != null)
            {
                try
                {
                    //Engine.Evaluate(string.Format("df <- dataID('{0}', db)", id));
                    Engine.Evaluate(string.Format("df <- dbGetQuery(db,'SELECT * FROM jdb WHERE Code == {0}')", id));
                    df = Engine.Evaluate(string.Format("df[c('Code'{0})]", checkboxes)).AsDataFrame();
                    var ncol = df.ColumnCount;

                    dataGridView.ColumnCount = ncol;
                    //add column names
                    for (int i = 0; i < ncol; i++)
                    {
                        //dataGridView.ColumnCount++;
                        dataGridView.Columns[i].Name = df.ColumnNames[i];
                    }
                    for (int i = 0; i < df.RowCount; ++i)
                    {
                        dataGridView.RowCount++;
                        dataGridView.Rows[i].HeaderCell.Value = df.RowNames[i];

                        for (int k = 0; k < df.ColumnCount; ++k)
                        {
                            dataGridView[k, i].Value = df[i, k];
                        }

                    }
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.Message, "Error", MessageBoxButtons.OK);
                }
            }

        }


        private void Updatecols_button_Click(object sender, EventArgs e)
        {
            string id = ID_textBox.Text;
            ShowData(id);
        }
    }   
}
