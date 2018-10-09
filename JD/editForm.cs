using System;
using System.Windows.Forms;
using RDotNet;
using System.IO;
using System.Data;

namespace JD
{
    
    public partial class editForm : Form
    {
        public editForm()
        {
            InitializeComponent();
            
            //for checking the tab
            Code_textBox.PreviewKeyDown += new PreviewKeyDownEventHandler(Code_textBox_PreviewKeyDown);


        }

        //public event PreviewKeyDownEventHandler PreviewKeyDown;

        public string Code { get; set; }

        public string TempImagePath { get; set; }

        public REngine Engine { get; set; }

        public DataFrame df;

        public string dbfile;

        private void editForm_Load(object sender, EventArgs e)
        {
            Engine = REngine.GetInstance();
            Engine.Evaluate(string.Format("db <- dbConnect(SQLite(),'{0}')", dbfile.Replace("\\", "/")));


            ToolTip tip = new ToolTip();

            // Set up the delays for the ToolTip.
            tip.AutoPopDelay = 10000;
            tip.InitialDelay = 500;
            tip.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            tip.ShowAlways = true;

            tip.IsBalloon = true;

            // Set up the ToolTip text for the Button and Checkbox.
            tip.SetToolTip(this.Code_textBox, "Study ID patient");
            tip.SetToolTip(this.CalcAgeSample_hours_textBox, "Postnatal age at bilirubin (SBR) sample - in hours");
            tip.SetToolTip(this.CalcAgeSample_hours_checkBox, "Postnatal age at bilirubin (SBR) sample - in hours");

            tip.SetToolTip(this.SBR_SBR_textBox, "Bilirubin level measured in the serum in umol/l at that postnatal age");
            tip.SetToolTip(this.MSBR_SBR_checkBox, "Bilirubin level measured in the serum in umol/l at that postnatal age");

            tip.SetToolTip(this.MSBR_SBR_textBox, "Created variable with SBR value of the previous observation carried forward to\n 'fill the SBR value blank' when phototherapy start/stop \n(the age at SBR measured is usually earlier than the age at start the phototherapy and later than \nthe age at stop phototherapy as you need the blood result to start/stop)");
            tip.SetToolTip(this.MSBR_SBR_checkBox, "Created variable with SBR value of the previous observation carried forward to\n 'fill the SBR value blank' when phototherapy start/stop \n(the age at SBR measured is usually earlier than the age at start the phototherapy and later than \nthe age at stop phototherapy as you need the blood result to start/stop)");

            tip.SetToolTip(this.sbr_thrmod_textBox, "Value of SBR which signals Phototherapy threshold (the solid line on the graph);\n this value depends on postnatal age and gestational age)-\n data obtained from UK guidelines spreadsheets");
            tip.SetToolTip(this.sbr_thrmod_checkBox, "Value of SBR which signals Phototherapy threshold (the solid line on the graph);\n this value depends on postnatal age and gestational age)-\n data obtained from UK guidelines spreadsheets");

            tip.SetToolTip(this.sbr_thret_textBox, "Value of SBR which signals Exchange transfusion threshold\n (the dotted line on the graph) - same principle as variable sbr_thrmod");
            tip.SetToolTip(this.sbr_thret_checkBox, "Value of SBR which signals Exchange transfusion threshold\n (the dotted line on the graph) - same principle as variable sbr_thrmod");


            tip.SetToolTip(this.Nhclinic_textBox, "1= SBR value used to make the diagnosis of the first Jaundice episode and take the decision to start the first  phototherapy\n" +
                "2= SBR value used to make the diagnosis of the second Jaundice episode and take the decision to start the second  phototherapy\n" +
                "3= SBR value used to make the diagnosis of the third Jaundice episode and take the decision to start the third \nphototherapy and so on up to 7 episodes");
            tip.SetToolTip(this.Nhclinic_checkBox, "1= SBR value used to make the diagnosis of the first Jaundice episode and take the decision to start the first  phototherapy\n" +
                "2= SBR value used to make the diagnosis of the second Jaundice episode and take the decision to start the second  phototherapy\n" +
                "3= SBR value used to make the diagnosis of the third Jaundice episode and take the decision to start the third \nphototherapy and so on up to 7 episodes");

            tip.SetToolTip(this.photo_link_textBox, "Created variable that tells us which course of\n phototherapy ( 1st, 2nd, 3rd …) was started after the diagnosis of jaundice with this SBR");
            tip.SetToolTip(this.photo_link_checkBox, "Created variable that tells us which course of\n phototherapy ( 1st, 2nd, 3rd …) was started after the diagnosis of jaundice with this SBR");

            tip.SetToolTip(this.Start_photo_textBox, "1= when first phototherapy course was started,\n 2= when second photo was started 3= when the 3th photo was started  etc up to 7 episodes");
            tip.SetToolTip(this.Start_photo_checkBox, "1= when first phototherapy course was started,\n 2= when second photo was started 3= when the 3th photo was started  etc up to 7 episodes");

            tip.SetToolTip(this.Stop_photo_textBox, "1= when the first phototherapy was stopped,\n 2= when the second phototherapy was stopped, etc up to 7 episodes");
            tip.SetToolTip(this.Stop_photo_checkBox, "1= when the first phototherapy was stopped,\n 2= when the second phototherapy was stopped, etc up to 7 episodes");

            tip.SetToolTip(this.PhotoType_photo_textBox, "Type of phototherapy (we have different types 'of phototherapy boxes' \nthat might be influencing the response to jaundice):\n 1'LED' 2'wooden' 3'metal' 4'other'");
            tip.SetToolTip(this.PhotoType_photo_checkBox, "Type of phototherapy (we have different types 'of phototherapy boxes' \nthat might be influencing the response to jaundice):\n 1'LED' 2'wooden' 3'metal' 4'other'");

            tip.SetToolTip(this.EGA_textBox, "gestational age weeks, days");
            tip.SetToolTip(this.EGA_checkBox, "gestational age weeks, days");

            tip.SetToolTip(this.EGAw_textBox, "gestaional age in weeks, rounded");
            tip.SetToolTip(this.EGAw_checkBox, "gestaional age in weeks, rounded");

            tip.SetToolTip(this.dev_Sex_textBox, "baby gender male=1 female=2");
            tip.SetToolTip(this.dev_Sex_checkBox, "baby gender male=1 female=2");

            tip.SetToolTip(this.NB_ethnicity_6cat_textBox, "0=burman 1=sgaw karen 2=poe karen 3=burmese muslim 4=other 5=mixed");
            tip.SetToolTip(this.NB_ethnicity_6cat_checkBox, "0=burman 1=sgaw karen 2=poe karen 3=burmese muslim 4=other 5=mixed");

            tip.SetToolTip(this.Primip_anc_textBox, "1= Primipara=first pregnancy, first baby; 0 = Multipara=had at least one previous pregnancy");
            tip.SetToolTip(this.Primip_anc_checkBox, "1= Primipara=first pregnancy, first baby; 0 = Multipara=had at least one previous pregnancy");

            tip.SetToolTip(this.BIM_del_2cat_textBox, "Mother body mass index (kg/m2) during last trimester of pregnancy:\n 1= BMI before del=>27 = obese, \n0= BMI before del<27=normal weight gain in pregnancy");
            tip.SetToolTip(this.BIM_del_2cat_checkBox, "Mother body mass index (kg/m2) during last trimester of pregnancy:\n 1= BMI before del=>27 = obese, \n0= BMI before del<27=normal weight gain in pregnancy");

            tip.SetToolTip(this.dev_Syntocinon_textBox, "1= The mother received oxytocine during the delivery\n0= the mother did not received oxytocine during pregnancy");
            tip.SetToolTip(this.dev_Syntocinon_checkBox, "1= The mother received oxytocine during the delivery\n0= the mother did not received oxytocine during pregnancy");

            tip.SetToolTip(this.ABOIncompa_textBox, "1= Blood group incompatibility between the mother and the baby \n0= no imcompatbility");
            tip.SetToolTip(this.ABOIncompa_checkBox, "1= Blood group incompatibility between the mother and the baby \n0= no imcompatbility");

            tip.SetToolTip(this.hematoma_textBox, "1= baby had bruising on the head or the body after delivery\n 0=no bruising");
            tip.SetToolTip(this.hematoma_checkBox, "1= baby had bruising on the head or the body after delivery\n 0=no bruising");

            tip.SetToolTip(this.SGA_textBox, "1= small for gestational age (weight at birth below the 10th centile of international standard for weight by gestational age adjusted for gender)\n0 =not small for gestational age");
            tip.SetToolTip(this.SGA_checkBox, "1= small for gestational age (weight at birth below the 10th centile of international standard for weight by gestational age adjusted for gender)\n0 =not small for gestational age");

            tip.SetToolTip(this.G6PD_Birth_bb_textBox, "G6PD deficiency tested with the fluorecent spot test at birth :\n 2 = deficient/abnormal \n1= normal ");
            tip.SetToolTip(this.G6PD_Birth_bb_checkBox, "G6PD deficiency tested with the fluorecent spot test at birth :\n 2 = deficient/abnormal \n1= normal ");

            tip.SetToolTip(this.Def_SevereInfect_textBox, "1= when a diagnosis of clinical severe infection was made");
            tip.SetToolTip(this.Def_SevereInfect_checkBox, "1= when a diagnosis of clinical severe infection was made");

            tip.SetToolTip(this.sbrcount_textBox, "total number of SBR measurements done per baby");
            tip.SetToolTip(this.sbrcount_checkBox, "total number of SBR measurements done per baby");

            // start focus
            this.ActiveControl = Code_textBox;


            //status
            datafile_toolStripStatusLabel.Text = "loaded data:" + Path.GetFileName(dbfile);


            InitCols();


            //BindingNavigator bindingNavigator = new BindingNavigator(true);


        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
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

        //check if tab is pressed in Code_textBox
        private void Code_textBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                string id = Code_textBox.Text;
                if (id != "")
                {
                    int idexist;
                    idexist = Engine.Evaluate(string.Format("IDMemberQ({0})", id)).AsInteger().ToArray()[0];
                    if (idexist == 1)
                    {
                        //MessageBox.Show("This is an existed ID.");
                        id_toolStripStatusLabel.Text = "This is an existed id.";
                        id_toolStripStatusLabel.ForeColor = System.Drawing.Color.Red;

                        //binding the data for the navigator
                        ClearTextBoxBinding();  
                        Navigates(id);
                    }
                    else
                    {
                        MessageBox.Show("You are entering a new ID.");
                    }

                    CalcAgeSample_hours_textBox.Focus();
                    ShowData(Code_textBox.Text);
                }
                else
                {
                    CalcAgeSample_hours_textBox.Focus();

                }
                e.IsInputKey = true;

            }

        }

        private void Code_textBox_TextChanged(object sender, EventArgs e)
        {

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


        private void ClearTextBoxes()
        {
            Code_textBox.Text = "";
            CalcAgeSample_hours_textBox.Text = "";
            SBR_SBR_textBox.Text = "";
            MSBR_SBR_textBox.Text = "";
            sbr_thrmod_textBox.Text = "";
            sbr_thret_textBox.Text = "";
            Nhclinic_textBox.Text = "";

            photo_link_textBox.Text = "";
            Start_photo_textBox.Text = "";
            Stop_photo_textBox.Text = "";
            PhotoType_photo_textBox.Text = "";
            EGA_textBox.Text = "";
            EGAw_textBox.Text = "";

            dev_Sex_textBox.Text = "";
            NB_ethnicity_6cat_textBox.Text = "";
            Primip_anc_textBox.Text = "";

            BIM_del_2cat_textBox.Text = "";
            dev_Syntocinon_textBox.Text = "";
            ABOIncompa_textBox.Text = "";
            hematoma_textBox.Text = "";

            SGA_textBox.Text = "";
            G6PD_Birth_bb_textBox.Text = "";
            Def_SevereInfect_textBox.Text = "";
            sbrcount_textBox.Text = "";
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

            for(int i = 0; i < chkboxes.Length; i++)
            {
                if (chks[i] == true)
                {
                    states = states + "," + chkboxes[i];
                }
            }

            return states;
        }

        private void Updatecols_button_Click(object sender, EventArgs e)
        {
            string id = Code_textBox.Text;
            ShowData(id);
        }

        //check null or empty
        private string CheckNull()
        {
            string[] chkboxes = new string[] { CalcAgeSample_hours_textBox.Text , MSBR_SBR_textBox.Text , MSBR_SBR_textBox.Text ,
                sbr_thrmod_textBox.Text , sbr_thret_textBox.Text , Nhclinic_textBox.Text , photo_link_textBox.Text , Start_photo_textBox.Text ,
                Stop_photo_textBox.Text , PhotoType_photo_textBox.Text , EGA_textBox.Text ,
                EGAw_textBox.Text , dev_Sex_textBox.Text , NB_ethnicity_6cat_textBox.Text , Primip_anc_textBox.Text ,
                BIM_del_2cat_textBox.Text , dev_Syntocinon_textBox.Text , ABOIncompa_textBox.Text , hematoma_textBox.Text ,
                SGA_textBox.Text , G6PD_Birth_bb_textBox.Text , Def_SevereInfect_textBox.Text , sbrcount_textBox.Text};

            string outstr = Code_textBox.Text;

            for(int i = 0; i < chkboxes.Length; i++)
            {
                if (string.IsNullOrEmpty(chkboxes[i]))
                {
                    outstr = outstr + "," + "NULL";
                }
                else
                {
                    outstr = outstr + "," + chkboxes[i];
                }
            }

            return (outstr);
        }


        //adding new record
        private void AddData()
        {
            //string SQLstatement_Add = "INSERT INTO jdb (Code,CalcAgeSample_hours,SBR_SBR,MSBR_SBR," +
            //    "sbr_thrmod,sbr_thret,Nhclinic, photo_link,Start_photo,Stop_photo,PhotoType_photo,EGA," +
            //    "EGAw,dev_Sex,NB_ethnicity_6cat,Primip_anc," +
            //    "BIM_del_2cat,dev_Syntocinon, ABOIncompa, hematoma," +
            //    "SGA,G6PD_Birth_bb,Def_SevereInfect, sbrcount)" +
            //    "VALUES" + "(" +
            //    Code_textBox.Text + "," + CalcAgeSample_hours_textBox.Text + "," + MSBR_SBR_textBox.Text + "," + MSBR_SBR_textBox.Text + "," +
            //    sbr_thrmod_textBox.Text + "," + sbr_thret_textBox.Text + "," + Nhclinic_textBox.Text + "," + photo_link_textBox.Text + "," + Start_photo_textBox.Text + "," + Stop_photo_textBox.Text + "," + PhotoType_photo_textBox.Text + "," + EGA_textBox.Text + "," +
            //    EGAw_textBox.Text + "," + dev_Sex_textBox.Text + "," + NB_ethnicity_6cat_textBox.Text + "," + Primip_anc_textBox.Text + "," +
            //    BIM_del_2cat_textBox.Text + "," + dev_Syntocinon_textBox.Text + "," + ABOIncompa_textBox.Text + "," + hematoma_textBox.Text + "," +
            //    SGA_textBox.Text + "," + G6PD_Birth_bb_textBox.Text + "," + Def_SevereInfect_textBox.Text + "," + sbrcount_textBox.Text + ")";

            if (string.IsNullOrEmpty(Code_textBox.Text))
            {
                MessageBox.Show("Code ID must be given.");
            }
            else
            {
                string txtbox = CheckNull();

                string SQLstatement_Add = "INSERT INTO jdb (Code,CalcAgeSample_hours,SBR_SBR,MSBR_SBR," +
                    "sbr_thrmod,sbr_thret,Nhclinic, photo_link,Start_photo,Stop_photo,PhotoType_photo,EGA," +
                    "EGAw,dev_Sex,NB_ethnicity_6cat,Primip_anc," +
                    "BIM_del_2cat,dev_Syntocinon, ABOIncompa, hematoma," +
                    "SGA,G6PD_Birth_bb,Def_SevereInfect, sbrcount)" +
                    "VALUES" + "(" + txtbox + ")";
                Engine.Evaluate(string.Format("sql <- dbExecute(db, '{0}')", SQLstatement_Add));

                //int sql = Engine.GetSymbol("sql").AsInteger()[0];
                //MessageBox.Show(string.Format("sql <- dbExecute(db, '{0}')", SQLstatement_Add));

                MessageBox.Show("This record has been added.");
                ClearTextBoxes();
            }


        }


        private void Add_button_Click(object sender, EventArgs e)
        {
            string currentID = Code_textBox.Text;
            AddData();
            ShowData(currentID);
        }


        //get the dataset/datatable of the selected ID
        private DataTable DataFrameToDataTable()
        {

            string[] colnames = df.ColumnNames;
            int ncol = colnames.Length;
            int nrow = df.RowCount;

            NumericMatrix dfm = Engine.GetSymbol("df").AsNumericMatrix();

            //DataTable navdata = DataFrameToDataTable();
            DataSet ds = new DataSet("DB");

            DataTable dt = new DataTable("data");
            
            for(int i = 0; i < ncol; i++)
            {
                dt.Columns.Add(colnames[i]);
            }
            
            for (int i = 0; i < nrow; i++)
            {
                for(int j = 0; j < ncol; j++)
                {
                    dt.Rows.Add(dfm[i, j]);
                }
            }


            ds.Tables.Add(dt);
            return dt;
            //return ds;
        }


        //for showing the data in the datagrid view
        private void Navigates(string id)
        {

            //dataGridView.Rows.Clear();
            //dataGridView.Refresh();
            string checkboxes = CheckBoxStates();

            //string id = ID_textBox.Text;
            if (id != null)
            {
                try
                {
                    //Engine.Evaluate(string.Format("df <- dataID('{0}', db)", id));
                    Engine.Evaluate(string.Format("df <- dbGetQuery(db,'SELECT * FROM jdb WHERE Code == {0}')", id));
                    //df = Engine.Evaluate(string.Format("df[c('Code'{0})]", checkboxes)).AsDataFrame();
                    df = Engine.Evaluate("df").AsDataFrame();

                    string[] colnames = df.ColumnNames;
                    int ncol = colnames.Length;
                    int nrow = df.RowCount;

                    DataSet ds = new DataSet("DB");

                    DataTable dt = new DataTable("data");
                    BindingSource bind;

                    for (int i = 0; i < ncol; i++)
                    {
                        dt.Columns.Add(colnames[i]);
                    }

                    for (int i = 0; i < nrow; i++)
                    {
                        string[] dr = Engine.Evaluate(string.Format("df[{0},]", i + 1)).AsCharacter().ToArray();
                        dt.Rows.Add(dr);
                           
                    }

                    ds.Tables.Add(dt);
                    
                    bind = new BindingSource(ds, "data");

                    //bindingNavigator_editform.BindingSource = new BindingSource(dt, "data");
                    bindingNavigator_editform.BindingSource = bind;

                    //start at the last position
                    bind.Position = nrow + 1;
                    

                    // link all textbox with the data
                    CalcAgeSample_hours_textBox.DataBindings.Add("Text", bind, "CalcAgeSample_hours");
                    SBR_SBR_textBox.DataBindings.Add("Text", bind, "SBR_SBR");
                    MSBR_SBR_textBox.DataBindings.Add("Text", bind, "MSBR_SBR");
                    sbr_thrmod_textBox.DataBindings.Add("Text", bind, "sbr_thrmod");
                    sbr_thret_textBox.DataBindings.Add("Text", bind, "sbr_thret");
                    Nhclinic_textBox.DataBindings.Add("Text", bind, "Nhclinic");
                    photo_link_textBox.DataBindings.Add("Text", bind, "photo_link");
                    Start_photo_textBox.DataBindings.Add("Text", bind, "Start_photo");
                    Stop_photo_textBox.DataBindings.Add("Text", bind, "Stop_photo");
                    PhotoType_photo_textBox.DataBindings.Add("Text", bind, "PhotoType_photo");
                    EGA_textBox.DataBindings.Add("Text", bind, "EGA");
                    EGAw_textBox.DataBindings.Add("Text", bind, "EGAw");
                    dev_Sex_textBox.DataBindings.Add("Text", bind, "dev_Sex");
                    NB_ethnicity_6cat_textBox.DataBindings.Add("Text", bind, "NB_ethnicity_6cat");
                    Primip_anc_textBox.DataBindings.Add("Text", bind, "Primip_anc");
                    BIM_del_2cat_textBox.DataBindings.Add("Text", bind, "BIM_del_2cat");
                    dev_Syntocinon_textBox.DataBindings.Add("Text", bind, "dev_Syntocinon");
                    ABOIncompa_textBox.DataBindings.Add("Text", bind, "ABOIncompa");
                    hematoma_textBox.DataBindings.Add("Text", bind, "hematoma");
                    SGA_textBox.DataBindings.Add("Text", bind, "SGA");
                    G6PD_Birth_bb_textBox.DataBindings.Add("Text", bind, "G6PD_Birth_bb");
                    Def_SevereInfect_textBox.DataBindings.Add("Text", bind, "Def_SevereInfect");
                    sbrcount_textBox.DataBindings.Add("Text", bind, "sbrcount");

                    
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.Message, "Error", MessageBoxButtons.OK);
                }
            }

        }


        //for clearing the data binding
        private void ClearTextBoxBinding()
        {
            Code_textBox.DataBindings.Clear();
            CalcAgeSample_hours_textBox.DataBindings.Clear();
            SBR_SBR_textBox.DataBindings.Clear();
            MSBR_SBR_textBox.DataBindings.Clear();
            sbr_thrmod_textBox.DataBindings.Clear();
            sbr_thret_textBox.DataBindings.Clear();
            Nhclinic_textBox.DataBindings.Clear();
            photo_link_textBox.DataBindings.Clear();
            Start_photo_textBox.DataBindings.Clear();
            Stop_photo_textBox.DataBindings.Clear();
            PhotoType_photo_textBox.DataBindings.Clear();
            EGA_textBox.DataBindings.Clear();
            EGAw_textBox.DataBindings.Clear();
            dev_Sex_textBox.DataBindings.Clear();
            NB_ethnicity_6cat_textBox.DataBindings.Clear();
            Primip_anc_textBox.DataBindings.Clear();
            BIM_del_2cat_textBox.DataBindings.Clear();
            dev_Syntocinon_textBox.DataBindings.Clear();
            ABOIncompa_textBox.DataBindings.Clear();
            hematoma_textBox.DataBindings.Clear();
            SGA_textBox.DataBindings.Clear();
            G6PD_Birth_bb_textBox.DataBindings.Clear();
            Def_SevereInfect_textBox.DataBindings.Clear();
            sbrcount_textBox.DataBindings.Clear();

        }


    }
}
