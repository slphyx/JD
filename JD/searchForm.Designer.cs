namespace JD
{
    partial class searchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.close_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.graph_pictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Updatecols_button = new System.Windows.Forms.Button();
            this.sbrcount_checkBox = new System.Windows.Forms.CheckBox();
            this.Def_SevereInfect_checkBox = new System.Windows.Forms.CheckBox();
            this.G6PD_Birth_bb_checkBox = new System.Windows.Forms.CheckBox();
            this.SGA_checkBox = new System.Windows.Forms.CheckBox();
            this.hematoma_checkBox = new System.Windows.Forms.CheckBox();
            this.ABOIncompa_checkBox = new System.Windows.Forms.CheckBox();
            this.dev_Syntocinon_checkBox = new System.Windows.Forms.CheckBox();
            this.BIM_del_2cat_checkBox = new System.Windows.Forms.CheckBox();
            this.Primip_anc_checkBox = new System.Windows.Forms.CheckBox();
            this.NB_ethnicity_6cat_checkBox = new System.Windows.Forms.CheckBox();
            this.dev_Sex_checkBox = new System.Windows.Forms.CheckBox();
            this.EGAw_checkBox = new System.Windows.Forms.CheckBox();
            this.EGA_checkBox = new System.Windows.Forms.CheckBox();
            this.PhotoType_photo_checkBox = new System.Windows.Forms.CheckBox();
            this.Stop_photo_checkBox = new System.Windows.Forms.CheckBox();
            this.Start_photo_checkBox = new System.Windows.Forms.CheckBox();
            this.photo_link_checkBox = new System.Windows.Forms.CheckBox();
            this.Nhclinic_checkBox = new System.Windows.Forms.CheckBox();
            this.sbr_thret_checkBox = new System.Windows.Forms.CheckBox();
            this.CalcAgeSample_hours_checkBox = new System.Windows.Forms.CheckBox();
            this.sbr_thrmod_checkBox = new System.Windows.Forms.CheckBox();
            this.SBR_SBR_checkBox = new System.Windows.Forms.CheckBox();
            this.MSBR_SBR_checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.close_button);
            this.splitContainer1.Panel1.Controls.Add(this.search_button);
            this.splitContainer1.Panel1.Controls.Add(this.ID_textBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1214, 717);
            this.splitContainer1.SplitterDistance = 329;
            this.splitContainer1.TabIndex = 0;
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(134, 84);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(81, 26);
            this.close_button.TabIndex = 3;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(26, 82);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(81, 28);
            this.search_button.TabIndex = 2;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // ID_textBox
            // 
            this.ID_textBox.Location = new System.Drawing.Point(83, 46);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(86, 20);
            this.ID_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Code";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.graph_pictureBox);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer2.Size = new System.Drawing.Size(881, 717);
            this.splitContainer2.SplitterDistance = 314;
            this.splitContainer2.TabIndex = 0;
            // 
            // graph_pictureBox
            // 
            this.graph_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graph_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.graph_pictureBox.Name = "graph_pictureBox";
            this.graph_pictureBox.Size = new System.Drawing.Size(881, 314);
            this.graph_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.graph_pictureBox.TabIndex = 0;
            this.graph_pictureBox.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(881, 399);
            this.dataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Updatecols_button);
            this.groupBox1.Controls.Add(this.sbrcount_checkBox);
            this.groupBox1.Controls.Add(this.Def_SevereInfect_checkBox);
            this.groupBox1.Controls.Add(this.G6PD_Birth_bb_checkBox);
            this.groupBox1.Controls.Add(this.SGA_checkBox);
            this.groupBox1.Controls.Add(this.hematoma_checkBox);
            this.groupBox1.Controls.Add(this.ABOIncompa_checkBox);
            this.groupBox1.Controls.Add(this.dev_Syntocinon_checkBox);
            this.groupBox1.Controls.Add(this.BIM_del_2cat_checkBox);
            this.groupBox1.Controls.Add(this.Primip_anc_checkBox);
            this.groupBox1.Controls.Add(this.NB_ethnicity_6cat_checkBox);
            this.groupBox1.Controls.Add(this.dev_Sex_checkBox);
            this.groupBox1.Controls.Add(this.EGAw_checkBox);
            this.groupBox1.Controls.Add(this.EGA_checkBox);
            this.groupBox1.Controls.Add(this.PhotoType_photo_checkBox);
            this.groupBox1.Controls.Add(this.Stop_photo_checkBox);
            this.groupBox1.Controls.Add(this.Start_photo_checkBox);
            this.groupBox1.Controls.Add(this.photo_link_checkBox);
            this.groupBox1.Controls.Add(this.Nhclinic_checkBox);
            this.groupBox1.Controls.Add(this.sbr_thret_checkBox);
            this.groupBox1.Controls.Add(this.CalcAgeSample_hours_checkBox);
            this.groupBox1.Controls.Add(this.sbr_thrmod_checkBox);
            this.groupBox1.Controls.Add(this.SBR_SBR_checkBox);
            this.groupBox1.Controls.Add(this.MSBR_SBR_checkBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 424);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Columns";
            // 
            // Updatecols_button
            // 
            this.Updatecols_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Updatecols_button.Location = new System.Drawing.Point(104, 287);
            this.Updatecols_button.Name = "Updatecols_button";
            this.Updatecols_button.Size = new System.Drawing.Size(99, 31);
            this.Updatecols_button.TabIndex = 25;
            this.Updatecols_button.Text = "Update Columns";
            this.Updatecols_button.UseVisualStyleBackColor = true;
            this.Updatecols_button.Click += new System.EventHandler(this.Updatecols_button_Click);
            // 
            // sbrcount_checkBox
            // 
            this.sbrcount_checkBox.AutoSize = true;
            this.sbrcount_checkBox.Location = new System.Drawing.Point(122, 230);
            this.sbrcount_checkBox.Name = "sbrcount_checkBox";
            this.sbrcount_checkBox.Size = new System.Drawing.Size(67, 17);
            this.sbrcount_checkBox.TabIndex = 24;
            this.sbrcount_checkBox.Text = "sbrcount";
            this.sbrcount_checkBox.UseVisualStyleBackColor = true;
            // 
            // Def_SevereInfect_checkBox
            // 
            this.Def_SevereInfect_checkBox.AutoSize = true;
            this.Def_SevereInfect_checkBox.Location = new System.Drawing.Point(6, 230);
            this.Def_SevereInfect_checkBox.Name = "Def_SevereInfect_checkBox";
            this.Def_SevereInfect_checkBox.Size = new System.Drawing.Size(110, 17);
            this.Def_SevereInfect_checkBox.TabIndex = 23;
            this.Def_SevereInfect_checkBox.Text = "Def_SevereInfect";
            this.Def_SevereInfect_checkBox.UseVisualStyleBackColor = true;
            // 
            // G6PD_Birth_bb_checkBox
            // 
            this.G6PD_Birth_bb_checkBox.AutoSize = true;
            this.G6PD_Birth_bb_checkBox.Location = new System.Drawing.Point(104, 207);
            this.G6PD_Birth_bb_checkBox.Name = "G6PD_Birth_bb_checkBox";
            this.G6PD_Birth_bb_checkBox.Size = new System.Drawing.Size(100, 17);
            this.G6PD_Birth_bb_checkBox.TabIndex = 22;
            this.G6PD_Birth_bb_checkBox.Text = "G6PD_Birth_bb";
            this.G6PD_Birth_bb_checkBox.UseVisualStyleBackColor = true;
            // 
            // SGA_checkBox
            // 
            this.SGA_checkBox.AutoSize = true;
            this.SGA_checkBox.Location = new System.Drawing.Point(6, 207);
            this.SGA_checkBox.Name = "SGA_checkBox";
            this.SGA_checkBox.Size = new System.Drawing.Size(48, 17);
            this.SGA_checkBox.TabIndex = 21;
            this.SGA_checkBox.Text = "SGA";
            this.SGA_checkBox.UseVisualStyleBackColor = true;
            // 
            // hematoma_checkBox
            // 
            this.hematoma_checkBox.AutoSize = true;
            this.hematoma_checkBox.Location = new System.Drawing.Point(104, 184);
            this.hematoma_checkBox.Name = "hematoma_checkBox";
            this.hematoma_checkBox.Size = new System.Drawing.Size(75, 17);
            this.hematoma_checkBox.TabIndex = 20;
            this.hematoma_checkBox.Text = "hematoma";
            this.hematoma_checkBox.UseVisualStyleBackColor = true;
            // 
            // ABOIncompa_checkBox
            // 
            this.ABOIncompa_checkBox.AutoSize = true;
            this.ABOIncompa_checkBox.Location = new System.Drawing.Point(6, 184);
            this.ABOIncompa_checkBox.Name = "ABOIncompa_checkBox";
            this.ABOIncompa_checkBox.Size = new System.Drawing.Size(89, 17);
            this.ABOIncompa_checkBox.TabIndex = 19;
            this.ABOIncompa_checkBox.Text = "ABOIncompa";
            this.ABOIncompa_checkBox.UseVisualStyleBackColor = true;
            // 
            // dev_Syntocinon_checkBox
            // 
            this.dev_Syntocinon_checkBox.AutoSize = true;
            this.dev_Syntocinon_checkBox.Location = new System.Drawing.Point(104, 161);
            this.dev_Syntocinon_checkBox.Name = "dev_Syntocinon_checkBox";
            this.dev_Syntocinon_checkBox.Size = new System.Drawing.Size(103, 17);
            this.dev_Syntocinon_checkBox.TabIndex = 18;
            this.dev_Syntocinon_checkBox.Text = "dev_Syntocinon";
            this.dev_Syntocinon_checkBox.UseVisualStyleBackColor = true;
            // 
            // BIM_del_2cat_checkBox
            // 
            this.BIM_del_2cat_checkBox.AutoSize = true;
            this.BIM_del_2cat_checkBox.Location = new System.Drawing.Point(6, 161);
            this.BIM_del_2cat_checkBox.Name = "BIM_del_2cat_checkBox";
            this.BIM_del_2cat_checkBox.Size = new System.Drawing.Size(92, 17);
            this.BIM_del_2cat_checkBox.TabIndex = 17;
            this.BIM_del_2cat_checkBox.Text = "BIM_del_2cat";
            this.BIM_del_2cat_checkBox.UseVisualStyleBackColor = true;
            // 
            // Primip_anc_checkBox
            // 
            this.Primip_anc_checkBox.AutoSize = true;
            this.Primip_anc_checkBox.Location = new System.Drawing.Point(209, 138);
            this.Primip_anc_checkBox.Name = "Primip_anc_checkBox";
            this.Primip_anc_checkBox.Size = new System.Drawing.Size(78, 17);
            this.Primip_anc_checkBox.TabIndex = 16;
            this.Primip_anc_checkBox.Text = "Primip_anc";
            this.Primip_anc_checkBox.UseVisualStyleBackColor = true;
            // 
            // NB_ethnicity_6cat_checkBox
            // 
            this.NB_ethnicity_6cat_checkBox.AutoSize = true;
            this.NB_ethnicity_6cat_checkBox.Location = new System.Drawing.Point(90, 138);
            this.NB_ethnicity_6cat_checkBox.Name = "NB_ethnicity_6cat_checkBox";
            this.NB_ethnicity_6cat_checkBox.Size = new System.Drawing.Size(113, 17);
            this.NB_ethnicity_6cat_checkBox.TabIndex = 15;
            this.NB_ethnicity_6cat_checkBox.Text = "NB_ethnicity_6cat";
            this.NB_ethnicity_6cat_checkBox.UseVisualStyleBackColor = true;
            // 
            // dev_Sex_checkBox
            // 
            this.dev_Sex_checkBox.AutoSize = true;
            this.dev_Sex_checkBox.Location = new System.Drawing.Point(6, 138);
            this.dev_Sex_checkBox.Name = "dev_Sex_checkBox";
            this.dev_Sex_checkBox.Size = new System.Drawing.Size(68, 17);
            this.dev_Sex_checkBox.TabIndex = 14;
            this.dev_Sex_checkBox.Text = "dev_Sex";
            this.dev_Sex_checkBox.UseVisualStyleBackColor = true;
            // 
            // EGAw_checkBox
            // 
            this.EGAw_checkBox.AutoSize = true;
            this.EGAw_checkBox.Location = new System.Drawing.Point(177, 115);
            this.EGAw_checkBox.Name = "EGAw_checkBox";
            this.EGAw_checkBox.Size = new System.Drawing.Size(56, 17);
            this.EGAw_checkBox.TabIndex = 13;
            this.EGAw_checkBox.Text = "EGAw";
            this.EGAw_checkBox.UseVisualStyleBackColor = true;
            // 
            // EGA_checkBox
            // 
            this.EGA_checkBox.AutoSize = true;
            this.EGA_checkBox.Location = new System.Drawing.Point(123, 115);
            this.EGA_checkBox.Name = "EGA_checkBox";
            this.EGA_checkBox.Size = new System.Drawing.Size(48, 17);
            this.EGA_checkBox.TabIndex = 12;
            this.EGA_checkBox.Text = "EGA";
            this.EGA_checkBox.UseVisualStyleBackColor = true;
            // 
            // PhotoType_photo_checkBox
            // 
            this.PhotoType_photo_checkBox.AutoSize = true;
            this.PhotoType_photo_checkBox.Location = new System.Drawing.Point(6, 115);
            this.PhotoType_photo_checkBox.Name = "PhotoType_photo_checkBox";
            this.PhotoType_photo_checkBox.Size = new System.Drawing.Size(111, 17);
            this.PhotoType_photo_checkBox.TabIndex = 11;
            this.PhotoType_photo_checkBox.Text = "PhotoType_photo";
            this.PhotoType_photo_checkBox.UseVisualStyleBackColor = true;
            // 
            // Stop_photo_checkBox
            // 
            this.Stop_photo_checkBox.AutoSize = true;
            this.Stop_photo_checkBox.Location = new System.Drawing.Point(177, 92);
            this.Stop_photo_checkBox.Name = "Stop_photo_checkBox";
            this.Stop_photo_checkBox.Size = new System.Drawing.Size(81, 17);
            this.Stop_photo_checkBox.TabIndex = 10;
            this.Stop_photo_checkBox.Text = "Stop_photo";
            this.Stop_photo_checkBox.UseVisualStyleBackColor = true;
            // 
            // Start_photo_checkBox
            // 
            this.Start_photo_checkBox.AutoSize = true;
            this.Start_photo_checkBox.Location = new System.Drawing.Point(90, 92);
            this.Start_photo_checkBox.Name = "Start_photo_checkBox";
            this.Start_photo_checkBox.Size = new System.Drawing.Size(81, 17);
            this.Start_photo_checkBox.TabIndex = 9;
            this.Start_photo_checkBox.Text = "Start_photo";
            this.Start_photo_checkBox.UseVisualStyleBackColor = true;
            // 
            // photo_link_checkBox
            // 
            this.photo_link_checkBox.AutoSize = true;
            this.photo_link_checkBox.Location = new System.Drawing.Point(6, 92);
            this.photo_link_checkBox.Name = "photo_link_checkBox";
            this.photo_link_checkBox.Size = new System.Drawing.Size(75, 17);
            this.photo_link_checkBox.TabIndex = 8;
            this.photo_link_checkBox.Text = "photo_link";
            this.photo_link_checkBox.UseVisualStyleBackColor = true;
            // 
            // Nhclinic_checkBox
            // 
            this.Nhclinic_checkBox.AutoSize = true;
            this.Nhclinic_checkBox.Location = new System.Drawing.Point(177, 65);
            this.Nhclinic_checkBox.Name = "Nhclinic_checkBox";
            this.Nhclinic_checkBox.Size = new System.Drawing.Size(64, 17);
            this.Nhclinic_checkBox.TabIndex = 7;
            this.Nhclinic_checkBox.Text = "Nhclinic";
            this.Nhclinic_checkBox.UseVisualStyleBackColor = true;
            // 
            // sbr_thret_checkBox
            // 
            this.sbr_thret_checkBox.AutoSize = true;
            this.sbr_thret_checkBox.Location = new System.Drawing.Point(90, 65);
            this.sbr_thret_checkBox.Name = "sbr_thret_checkBox";
            this.sbr_thret_checkBox.Size = new System.Drawing.Size(67, 17);
            this.sbr_thret_checkBox.TabIndex = 6;
            this.sbr_thret_checkBox.Text = "sbr_thret";
            this.sbr_thret_checkBox.UseVisualStyleBackColor = true;
            // 
            // CalcAgeSample_hours_checkBox
            // 
            this.CalcAgeSample_hours_checkBox.AutoSize = true;
            this.CalcAgeSample_hours_checkBox.Location = new System.Drawing.Point(6, 19);
            this.CalcAgeSample_hours_checkBox.Name = "CalcAgeSample_hours_checkBox";
            this.CalcAgeSample_hours_checkBox.Size = new System.Drawing.Size(133, 17);
            this.CalcAgeSample_hours_checkBox.TabIndex = 2;
            this.CalcAgeSample_hours_checkBox.Text = "CalcAgeSample_hours";
            this.CalcAgeSample_hours_checkBox.UseVisualStyleBackColor = true;
            // 
            // sbr_thrmod_checkBox
            // 
            this.sbr_thrmod_checkBox.AutoSize = true;
            this.sbr_thrmod_checkBox.Location = new System.Drawing.Point(6, 65);
            this.sbr_thrmod_checkBox.Name = "sbr_thrmod_checkBox";
            this.sbr_thrmod_checkBox.Size = new System.Drawing.Size(78, 17);
            this.sbr_thrmod_checkBox.TabIndex = 5;
            this.sbr_thrmod_checkBox.Text = "sbr_thrmod";
            this.sbr_thrmod_checkBox.UseVisualStyleBackColor = true;
            // 
            // SBR_SBR_checkBox
            // 
            this.SBR_SBR_checkBox.AutoSize = true;
            this.SBR_SBR_checkBox.Location = new System.Drawing.Point(6, 42);
            this.SBR_SBR_checkBox.Name = "SBR_SBR_checkBox";
            this.SBR_SBR_checkBox.Size = new System.Drawing.Size(76, 17);
            this.SBR_SBR_checkBox.TabIndex = 3;
            this.SBR_SBR_checkBox.Text = "SBR_SBR";
            this.SBR_SBR_checkBox.UseVisualStyleBackColor = true;
            // 
            // MSBR_SBR_checkBox
            // 
            this.MSBR_SBR_checkBox.AutoSize = true;
            this.MSBR_SBR_checkBox.Location = new System.Drawing.Point(90, 42);
            this.MSBR_SBR_checkBox.Name = "MSBR_SBR_checkBox";
            this.MSBR_SBR_checkBox.Size = new System.Drawing.Size(85, 17);
            this.MSBR_SBR_checkBox.TabIndex = 4;
            this.MSBR_SBR_checkBox.Text = "MSBR_SBR";
            this.MSBR_SBR_checkBox.UseVisualStyleBackColor = true;
            // 
            // searchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 717);
            this.Controls.Add(this.splitContainer1);
            this.Name = "searchForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graph_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox graph_pictureBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Updatecols_button;
        private System.Windows.Forms.CheckBox sbrcount_checkBox;
        private System.Windows.Forms.CheckBox Def_SevereInfect_checkBox;
        private System.Windows.Forms.CheckBox G6PD_Birth_bb_checkBox;
        private System.Windows.Forms.CheckBox SGA_checkBox;
        private System.Windows.Forms.CheckBox hematoma_checkBox;
        private System.Windows.Forms.CheckBox ABOIncompa_checkBox;
        private System.Windows.Forms.CheckBox dev_Syntocinon_checkBox;
        private System.Windows.Forms.CheckBox BIM_del_2cat_checkBox;
        private System.Windows.Forms.CheckBox Primip_anc_checkBox;
        private System.Windows.Forms.CheckBox NB_ethnicity_6cat_checkBox;
        private System.Windows.Forms.CheckBox dev_Sex_checkBox;
        private System.Windows.Forms.CheckBox EGAw_checkBox;
        private System.Windows.Forms.CheckBox EGA_checkBox;
        private System.Windows.Forms.CheckBox PhotoType_photo_checkBox;
        private System.Windows.Forms.CheckBox Stop_photo_checkBox;
        private System.Windows.Forms.CheckBox Start_photo_checkBox;
        private System.Windows.Forms.CheckBox photo_link_checkBox;
        private System.Windows.Forms.CheckBox Nhclinic_checkBox;
        private System.Windows.Forms.CheckBox sbr_thret_checkBox;
        private System.Windows.Forms.CheckBox CalcAgeSample_hours_checkBox;
        private System.Windows.Forms.CheckBox sbr_thrmod_checkBox;
        private System.Windows.Forms.CheckBox SBR_SBR_checkBox;
        private System.Windows.Forms.CheckBox MSBR_SBR_checkBox;
    }
}

