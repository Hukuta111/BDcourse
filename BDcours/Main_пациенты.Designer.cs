namespace BDcours
{
    partial class Main_пациенты
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_пациенты));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.записатсяbtn = new System.Windows.Forms.ToolStripButton();
            this.exitbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.nameanimaltxtbox = new System.Windows.Forms.TextBox();
            this.typeanimaltxtbox = new System.Windows.Forms.TextBox();
            this.breedanimaltxtbox = new System.Windows.Forms.TextBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.typelbl = new System.Windows.Forms.Label();
            this.breedlbl = new System.Windows.Forms.Label();
            this.doctorDataGridView = new System.Windows.Forms.DataGridView();
            this.serviceDataGriedView = new System.Windows.Forms.DataGridView();
            this.recordanimalbtn = new System.Windows.Forms.Button();
            this.datelbl = new System.Windows.Forms.Label();
            this.birthtxtbox = new System.Windows.Forms.DateTimePicker();
            this.daterecord = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.recordbtn = new System.Windows.Forms.Button();
            this.карткаdataGriedView = new System.Windows.Forms.DataGridView();
            this.labelкарти = new System.Windows.Forms.Label();
            this.searchкарткиbtn = new System.Windows.Forms.Button();
            this.nameanimallbl = new System.Windows.Forms.Label();
            this.nametxtbox = new System.Windows.Forms.TextBox();
            this.idкарткиtxtbox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.iddoctortxtbox = new System.Windows.Forms.NumericUpDown();
            this.timetxtbox = new System.Windows.Forms.NumericUpDown();
            this.idservicetxtbox = new System.Windows.Forms.NumericUpDown();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataGriedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.карткаdataGriedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iddoctortxtbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetxtbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idservicetxtbox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSlateGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.записатсяbtn,
            this.exitbtn,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1075, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            // 
            // записатсяbtn
            // 
            this.записатсяbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.записатсяbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.записатсяbtn.Image = ((System.Drawing.Image)(resources.GetObject("записатсяbtn.Image")));
            this.записатсяbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.записатсяbtn.Name = "записатсяbtn";
            this.записатсяbtn.Size = new System.Drawing.Size(141, 22);
            this.записатсяbtn.Text = "Записатися на прийом";
            this.записатсяbtn.Click += new System.EventHandler(this.записатсяbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitbtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.exitbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exitbtn.Font = new System.Drawing.Font("Wide Latin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitbtn.ForeColor = System.Drawing.Color.Red;
            this.exitbtn.Image = ((System.Drawing.Image)(resources.GetObject("exitbtn.Image")));
            this.exitbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(32, 22);
            this.exitbtn.Text = "X";
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(127, 22);
            this.toolStripButton1.Text = "Амбулаторна картка";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Font = new System.Drawing.Font("Wide Latin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripButton2.ForeColor = System.Drawing.Color.Khaki;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(26, 22);
            this.toolStripButton2.Text = "__";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // nameanimaltxtbox
            // 
            this.nameanimaltxtbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nameanimaltxtbox.Location = new System.Drawing.Point(498, 151);
            this.nameanimaltxtbox.Name = "nameanimaltxtbox";
            this.nameanimaltxtbox.Size = new System.Drawing.Size(217, 21);
            this.nameanimaltxtbox.TabIndex = 3;
            this.nameanimaltxtbox.Visible = false;
            // 
            // typeanimaltxtbox
            // 
            this.typeanimaltxtbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.typeanimaltxtbox.Location = new System.Drawing.Point(498, 196);
            this.typeanimaltxtbox.Name = "typeanimaltxtbox";
            this.typeanimaltxtbox.Size = new System.Drawing.Size(217, 21);
            this.typeanimaltxtbox.TabIndex = 4;
            this.typeanimaltxtbox.Visible = false;
            // 
            // breedanimaltxtbox
            // 
            this.breedanimaltxtbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.breedanimaltxtbox.Location = new System.Drawing.Point(498, 235);
            this.breedanimaltxtbox.Name = "breedanimaltxtbox";
            this.breedanimaltxtbox.Size = new System.Drawing.Size(217, 21);
            this.breedanimaltxtbox.TabIndex = 5;
            this.breedanimaltxtbox.Visible = false;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(383, 156);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(28, 15);
            this.namelbl.TabIndex = 6;
            this.namelbl.Text = "Ім\'я";
            this.namelbl.Visible = false;
            // 
            // typelbl
            // 
            this.typelbl.AutoSize = true;
            this.typelbl.Location = new System.Drawing.Point(383, 199);
            this.typelbl.Name = "typelbl";
            this.typelbl.Size = new System.Drawing.Size(78, 15);
            this.typelbl.TabIndex = 7;
            this.typelbl.Text = "Вид тварини";
            this.typelbl.Visible = false;
            // 
            // breedlbl
            // 
            this.breedlbl.AutoSize = true;
            this.breedlbl.Location = new System.Drawing.Point(383, 240);
            this.breedlbl.Name = "breedlbl";
            this.breedlbl.Size = new System.Drawing.Size(51, 15);
            this.breedlbl.TabIndex = 8;
            this.breedlbl.Text = "Порода";
            this.breedlbl.Visible = false;
            // 
            // doctorDataGridView
            // 
            this.doctorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorDataGridView.Location = new System.Drawing.Point(531, 28);
            this.doctorDataGridView.Name = "doctorDataGridView";
            this.doctorDataGridView.RowTemplate.Height = 23;
            this.doctorDataGridView.Size = new System.Drawing.Size(532, 201);
            this.doctorDataGridView.TabIndex = 9;
            this.doctorDataGridView.Visible = false;
            // 
            // serviceDataGriedView
            // 
            this.serviceDataGriedView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceDataGriedView.Location = new System.Drawing.Point(531, 240);
            this.serviceDataGriedView.Name = "serviceDataGriedView";
            this.serviceDataGriedView.Size = new System.Drawing.Size(532, 202);
            this.serviceDataGriedView.TabIndex = 10;
            this.serviceDataGriedView.Visible = false;
            // 
            // recordanimalbtn
            // 
            this.recordanimalbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recordanimalbtn.Location = new System.Drawing.Point(400, 391);
            this.recordanimalbtn.Name = "recordanimalbtn";
            this.recordanimalbtn.Size = new System.Drawing.Size(299, 36);
            this.recordanimalbtn.TabIndex = 11;
            this.recordanimalbtn.Text = "Записатися";
            this.recordanimalbtn.UseVisualStyleBackColor = true;
            this.recordanimalbtn.Visible = false;
            this.recordanimalbtn.Click += new System.EventHandler(this.recorbtn_Click);
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Location = new System.Drawing.Point(383, 280);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(109, 15);
            this.datelbl.TabIndex = 13;
            this.datelbl.Text = "Дата народження";
            this.datelbl.Visible = false;
            // 
            // birthtxtbox
            // 
            this.birthtxtbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.birthtxtbox.Location = new System.Drawing.Point(498, 274);
            this.birthtxtbox.Name = "birthtxtbox";
            this.birthtxtbox.Size = new System.Drawing.Size(217, 21);
            this.birthtxtbox.TabIndex = 14;
            this.birthtxtbox.Visible = false;
            // 
            // daterecord
            // 
            this.daterecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daterecord.Location = new System.Drawing.Point(322, 225);
            this.daterecord.Name = "daterecord";
            this.daterecord.Size = new System.Drawing.Size(200, 21);
            this.daterecord.TabIndex = 19;
            this.daterecord.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Виберіть ідентифікатор лікаря";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Виберіть ідентифікатор послуги";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Виберіть день на який ви хочете записатися";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Виберіть годину на яку ви хочете прийти";
            this.label4.Visible = false;
            // 
            // recordbtn
            // 
            this.recordbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recordbtn.Location = new System.Drawing.Point(123, 391);
            this.recordbtn.Name = "recordbtn";
            this.recordbtn.Size = new System.Drawing.Size(299, 36);
            this.recordbtn.TabIndex = 21;
            this.recordbtn.Text = "Записатися на прийом";
            this.recordbtn.UseVisualStyleBackColor = true;
            this.recordbtn.Visible = false;
            this.recordbtn.Click += new System.EventHandler(this.recordbtn_Click);
            // 
            // карткаdataGriedView
            // 
            this.карткаdataGriedView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.карткаdataGriedView.Location = new System.Drawing.Point(428, 28);
            this.карткаdataGriedView.Name = "карткаdataGriedView";
            this.карткаdataGriedView.RowTemplate.Height = 23;
            this.карткаdataGriedView.Size = new System.Drawing.Size(635, 414);
            this.карткаdataGriedView.TabIndex = 22;
            this.карткаdataGriedView.Visible = false;
            // 
            // labelкарти
            // 
            this.labelкарти.AutoSize = true;
            this.labelкарти.Location = new System.Drawing.Point(30, 184);
            this.labelкарти.Name = "labelкарти";
            this.labelкарти.Size = new System.Drawing.Size(228, 15);
            this.labelкарти.TabIndex = 24;
            this.labelкарти.Text = "Введіть особистий номер вашої картки";
            this.labelкарти.Visible = false;
            this.labelкарти.Click += new System.EventHandler(this.labelкарти_Click);
            // 
            // searchкарткиbtn
            // 
            this.searchкарткиbtn.Location = new System.Drawing.Point(67, 349);
            this.searchкарткиbtn.Name = "searchкарткиbtn";
            this.searchкарткиbtn.Size = new System.Drawing.Size(299, 36);
            this.searchкарткиbtn.TabIndex = 25;
            this.searchкарткиbtn.Text = "Знайти";
            this.searchкарткиbtn.UseVisualStyleBackColor = true;
            this.searchкарткиbtn.Visible = false;
            this.searchкарткиbtn.Click += new System.EventHandler(this.searchкарткиbtn_Click);
            // 
            // nameanimallbl
            // 
            this.nameanimallbl.AutoSize = true;
            this.nameanimallbl.Location = new System.Drawing.Point(30, 228);
            this.nameanimallbl.Name = "nameanimallbl";
            this.nameanimallbl.Size = new System.Drawing.Size(123, 15);
            this.nameanimallbl.TabIndex = 26;
            this.nameanimallbl.Text = "Введіть ім\'я тварини";
            this.nameanimallbl.Visible = false;
            // 
            // nametxtbox
            // 
            this.nametxtbox.Location = new System.Drawing.Point(266, 222);
            this.nametxtbox.Name = "nametxtbox";
            this.nametxtbox.Size = new System.Drawing.Size(100, 21);
            this.nametxtbox.TabIndex = 27;
            this.nametxtbox.Visible = false;
            // 
            // idкарткиtxtbox
            // 
            this.idкарткиtxtbox.Location = new System.Drawing.Point(266, 178);
            this.idкарткиtxtbox.Name = "idкарткиtxtbox";
            this.idкарткиtxtbox.Size = new System.Drawing.Size(100, 21);
            this.idкарткиtxtbox.TabIndex = 28;
            this.idкарткиtxtbox.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // iddoctortxtbox
            // 
            this.iddoctortxtbox.Location = new System.Drawing.Point(322, 150);
            this.iddoctortxtbox.Name = "iddoctortxtbox";
            this.iddoctortxtbox.Size = new System.Drawing.Size(200, 21);
            this.iddoctortxtbox.TabIndex = 29;
            this.iddoctortxtbox.Visible = false;
            // 
            // timetxtbox
            // 
            this.timetxtbox.Location = new System.Drawing.Point(322, 268);
            this.timetxtbox.Name = "timetxtbox";
            this.timetxtbox.Size = new System.Drawing.Size(200, 21);
            this.timetxtbox.TabIndex = 29;
            this.timetxtbox.Visible = false;
            // 
            // idservicetxtbox
            // 
            this.idservicetxtbox.Location = new System.Drawing.Point(322, 185);
            this.idservicetxtbox.Name = "idservicetxtbox";
            this.idservicetxtbox.Size = new System.Drawing.Size(200, 21);
            this.idservicetxtbox.TabIndex = 29;
            this.idservicetxtbox.Visible = false;
            // 
            // Main_пациенты
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 454);
            this.Controls.Add(this.timetxtbox);
            this.Controls.Add(this.idservicetxtbox);
            this.Controls.Add(this.iddoctortxtbox);
            this.Controls.Add(this.idкарткиtxtbox);
            this.Controls.Add(this.nametxtbox);
            this.Controls.Add(this.nameanimallbl);
            this.Controls.Add(this.searchкарткиbtn);
            this.Controls.Add(this.labelкарти);
            this.Controls.Add(this.recordbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.daterecord);
            this.Controls.Add(this.birthtxtbox);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.recordanimalbtn);
            this.Controls.Add(this.serviceDataGriedView);
            this.Controls.Add(this.doctorDataGridView);
            this.Controls.Add(this.breedlbl);
            this.Controls.Add(this.typelbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.breedanimaltxtbox);
            this.Controls.Add(this.typeanimaltxtbox);
            this.Controls.Add(this.nameanimaltxtbox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.карткаdataGriedView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_пациенты";
            this.Text = "Ветеринарна лікарня";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_пациенты_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataGriedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.карткаdataGriedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iddoctortxtbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetxtbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idservicetxtbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton записатсяbtn;
        private TextBox nameanimaltxtbox;
        private TextBox typeanimaltxtbox;
        private TextBox breedanimaltxtbox;
        private Label namelbl;
        private Label typelbl;
        private Label breedlbl;
        private DataGridView doctorDataGridView;
        private DataGridView serviceDataGriedView;
        private Button recordanimalbtn;
        private Label datelbl;
        private DateTimePicker birthtxtbox;
        private DateTimePicker daterecord;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button recordbtn;
        private ToolStripButton exitbtn;
        private ToolStripButton toolStripButton1;
        private DataGridView карткаdataGriedView;
        private Label labelкарти;
        private Button searchкарткиbtn;
        private Label nameanimallbl;
        private TextBox nametxtbox;
        private TextBox idкарткиtxtbox;
        private ToolStripButton toolStripButton2;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private NumericUpDown timetxtbox;
        private NumericUpDown iddoctortxtbox;
        private NumericUpDown idservicetxtbox;
    }
}