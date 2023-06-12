namespace BDcours
{
    partial class Main_врачи
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_врачи));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.картаbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.приемbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.врачиbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.clearbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.картаврачиbtn = new System.Windows.Forms.Button();
            this.пацієнтиGridView = new System.Windows.Forms.DataGridView();
            this.діагноз = new System.Windows.Forms.TextBox();
            this.призначення = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idлікаря = new System.Windows.Forms.NumericUpDown();
            this.датавідвідування = new System.Windows.Forms.DateTimePicker();
            this.idпацієнта = new System.Windows.Forms.TextBox();
            this.прізвищелікарtxtbox = new System.Windows.Forms.TextBox();
            this.імяtxtbox = new System.Windows.Forms.TextBox();
            this.спеціалізаціяtxtbox = new System.Windows.Forms.TextBox();
            this.розкладtxtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.лікаріbtn = new System.Windows.Forms.Button();
            this.назвапослугиtxtbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.заповнитипослугиbtn = new System.Windows.Forms.Button();
            this.вартістьtxtbox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.idкартиtxtbox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пацієнтиGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idлікаря)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idкартиtxtbox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(447, 28);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(705, 190);
            this.dataGridView.TabIndex = 1;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.LightSlateGray;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.картаbtn,
            this.приемbtn,
            this.врачиbtn,
            this.услугиbtn});
            this.toolStripDropDownButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripDropDownButton1.Text = "Таблиці";
            // 
            // картаbtn
            // 
            this.картаbtn.Name = "картаbtn";
            this.картаbtn.Size = new System.Drawing.Size(254, 22);
            this.картаbtn.Text = "Электронні амбулаторні картки";
            this.картаbtn.Click += new System.EventHandler(this.картаbtn_Click);
            // 
            // приемbtn
            // 
            this.приемbtn.Name = "приемbtn";
            this.приемbtn.Size = new System.Drawing.Size(254, 22);
            this.приемbtn.Text = "Записи пациентів на прийом";
            this.приемbtn.Click += new System.EventHandler(this.приемbtn_Click);
            // 
            // врачиbtn
            // 
            this.врачиbtn.Name = "врачиbtn";
            this.врачиbtn.Size = new System.Drawing.Size(254, 22);
            this.врачиbtn.Text = "Лікарі";
            this.врачиbtn.Click += new System.EventHandler(this.врачиbtn_Click);
            // 
            // услугиbtn
            // 
            this.услугиbtn.Name = "услугиbtn";
            this.услугиbtn.Size = new System.Drawing.Size(254, 22);
            this.услугиbtn.Text = "Послуги";
            this.услугиbtn.Click += new System.EventHandler(this.услугиbtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.clearbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clearbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearbtn.Image = ((System.Drawing.Image)(resources.GetObject("clearbtn.Image")));
            this.clearbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(63, 22);
            this.clearbtn.Text = "Очистить";
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSlateGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.clearbtn,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1164, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.BackColor = System.Drawing.Color.LightSlateGray;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Wide Latin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripButton1.ForeColor = System.Drawing.Color.Red;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripButton1.Text = "X";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.BackColor = System.Drawing.Color.LightSlateGray;
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
            // картаврачиbtn
            // 
            this.картаврачиbtn.Location = new System.Drawing.Point(255, 378);
            this.картаврачиbtn.Name = "картаврачиbtn";
            this.картаврачиbtn.Size = new System.Drawing.Size(155, 36);
            this.картаврачиbtn.TabIndex = 2;
            this.картаврачиbtn.Text = "Заповнити";
            this.картаврачиbtn.UseVisualStyleBackColor = true;
            this.картаврачиbtn.Visible = false;
            this.картаврачиbtn.Click += new System.EventHandler(this.картаврачиbtn_Click);
            // 
            // пацієнтиGridView
            // 
            this.пацієнтиGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.пацієнтиGridView.Location = new System.Drawing.Point(447, 248);
            this.пацієнтиGridView.Name = "пацієнтиGridView";
            this.пацієнтиGridView.RowTemplate.Height = 23;
            this.пацієнтиGridView.Size = new System.Drawing.Size(705, 190);
            this.пацієнтиGridView.TabIndex = 1;
            // 
            // діагноз
            // 
            this.діагноз.Location = new System.Drawing.Point(152, 212);
            this.діагноз.Name = "діагноз";
            this.діагноз.Size = new System.Drawing.Size(258, 21);
            this.діагноз.TabIndex = 6;
            this.діагноз.Visible = false;
            // 
            // призначення
            // 
            this.призначення.Location = new System.Drawing.Point(152, 239);
            this.призначення.Name = "призначення";
            this.призначення.Size = new System.Drawing.Size(258, 21);
            this.призначення.TabIndex = 8;
            this.призначення.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ідентифікатор пацієнта";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ідентифікатор лікаря";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Дата відвідування";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Діагноз";
            this.label4.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Призначення";
            this.label6.Visible = false;
            // 
            // idлікаря
            // 
            this.idлікаря.Location = new System.Drawing.Point(152, 158);
            this.idлікаря.Name = "idлікаря";
            this.idлікаря.Size = new System.Drawing.Size(258, 21);
            this.idлікаря.TabIndex = 12;
            this.idлікаря.Visible = false;
            // 
            // датавідвідування
            // 
            this.датавідвідування.Location = new System.Drawing.Point(152, 186);
            this.датавідвідування.Name = "датавідвідування";
            this.датавідвідування.Size = new System.Drawing.Size(258, 21);
            this.датавідвідування.TabIndex = 13;
            this.датавідвідування.Visible = false;
            // 
            // idпацієнта
            // 
            this.idпацієнта.Location = new System.Drawing.Point(152, 131);
            this.idпацієнта.Name = "idпацієнта";
            this.idпацієнта.Size = new System.Drawing.Size(258, 21);
            this.idпацієнта.TabIndex = 6;
            this.idпацієнта.Visible = false;
            // 
            // прізвищелікарtxtbox
            // 
            this.прізвищелікарtxtbox.Location = new System.Drawing.Point(152, 148);
            this.прізвищелікарtxtbox.Name = "прізвищелікарtxtbox";
            this.прізвищелікарtxtbox.Size = new System.Drawing.Size(258, 21);
            this.прізвищелікарtxtbox.TabIndex = 14;
            this.прізвищелікарtxtbox.Visible = false;
            // 
            // імяtxtbox
            // 
            this.імяtxtbox.Location = new System.Drawing.Point(152, 175);
            this.імяtxtbox.Name = "імяtxtbox";
            this.імяtxtbox.Size = new System.Drawing.Size(258, 21);
            this.імяtxtbox.TabIndex = 14;
            this.імяtxtbox.Visible = false;
            // 
            // спеціалізаціяtxtbox
            // 
            this.спеціалізаціяtxtbox.Location = new System.Drawing.Point(152, 202);
            this.спеціалізаціяtxtbox.Name = "спеціалізаціяtxtbox";
            this.спеціалізаціяtxtbox.Size = new System.Drawing.Size(258, 21);
            this.спеціалізаціяtxtbox.TabIndex = 14;
            this.спеціалізаціяtxtbox.Visible = false;
            // 
            // розкладtxtbox
            // 
            this.розкладtxtbox.Location = new System.Drawing.Point(152, 229);
            this.розкладtxtbox.Name = "розкладtxtbox";
            this.розкладtxtbox.Size = new System.Drawing.Size(258, 21);
            this.розкладtxtbox.TabIndex = 14;
            this.розкладtxtbox.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Прізвище";
            this.label5.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ім\'я";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Спеціалізація";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Розклад прийому";
            this.label9.Visible = false;
            // 
            // лікаріbtn
            // 
            this.лікаріbtn.Location = new System.Drawing.Point(255, 291);
            this.лікаріbtn.Name = "лікаріbtn";
            this.лікаріbtn.Size = new System.Drawing.Size(155, 36);
            this.лікаріbtn.TabIndex = 2;
            this.лікаріbtn.Text = "Заповнити";
            this.лікаріbtn.UseVisualStyleBackColor = true;
            this.лікаріbtn.Visible = false;
            this.лікаріbtn.Click += new System.EventHandler(this.лікаріbtn_Click);
            // 
            // назвапослугиtxtbox
            // 
            this.назвапослугиtxtbox.Location = new System.Drawing.Point(152, 199);
            this.назвапослугиtxtbox.Name = "назвапослугиtxtbox";
            this.назвапослугиtxtbox.Size = new System.Drawing.Size(258, 21);
            this.назвапослугиtxtbox.TabIndex = 14;
            this.назвапослугиtxtbox.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Призначення";
            this.label10.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(62, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "Назва послуги";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "Вартість";
            this.label13.Visible = false;
            // 
            // заповнитипослугиbtn
            // 
            this.заповнитипослугиbtn.Location = new System.Drawing.Point(78, 352);
            this.заповнитипослугиbtn.Name = "заповнитипослугиbtn";
            this.заповнитипослугиbtn.Size = new System.Drawing.Size(155, 36);
            this.заповнитипослугиbtn.TabIndex = 2;
            this.заповнитипослугиbtn.Text = "Заповнити";
            this.заповнитипослугиbtn.UseVisualStyleBackColor = true;
            this.заповнитипослугиbtn.Visible = false;
            this.заповнитипослугиbtn.Click += new System.EventHandler(this.заповнитипослугиbtn_Click);
            // 
            // вартістьtxtbox
            // 
            this.вартістьtxtbox.Location = new System.Drawing.Point(152, 226);
            this.вартістьtxtbox.Name = "вартістьtxtbox";
            this.вартістьtxtbox.Size = new System.Drawing.Size(258, 21);
            this.вартістьtxtbox.TabIndex = 14;
            this.вартістьtxtbox.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 15);
            this.label14.TabIndex = 11;
            this.label14.Text = "Ідентифікатор карти";
            this.label14.Visible = false;
            // 
            // idкартиtxtbox
            // 
            this.idкартиtxtbox.Location = new System.Drawing.Point(152, 105);
            this.idкартиtxtbox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.idкартиtxtbox.Name = "idкартиtxtbox";
            this.idкартиtxtbox.Size = new System.Drawing.Size(258, 21);
            this.idкартиtxtbox.TabIndex = 15;
            this.idкартиtxtbox.Visible = false;
            // 
            // Main_врачи
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1164, 467);
            this.Controls.Add(this.idкартиtxtbox);
            this.Controls.Add(this.вартістьtxtbox);
            this.Controls.Add(this.назвапослугиtxtbox);
            this.Controls.Add(this.розкладtxtbox);
            this.Controls.Add(this.спеціалізаціяtxtbox);
            this.Controls.Add(this.імяtxtbox);
            this.Controls.Add(this.прізвищелікарtxtbox);
            this.Controls.Add(this.датавідвідування);
            this.Controls.Add(this.idлікаря);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.призначення);
            this.Controls.Add(this.idпацієнта);
            this.Controls.Add(this.діагноз);
            this.Controls.Add(this.заповнитипослугиbtn);
            this.Controls.Add(this.лікаріbtn);
            this.Controls.Add(this.картаврачиbtn);
            this.Controls.Add(this.пацієнтиGridView);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_врачи";
            this.Text = "Ветеринарна лікарня";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_врачи_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пацієнтиGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idлікаря)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idкартиtxtbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem картаbtn;
        private ToolStripMenuItem приемbtn;
        private ToolStripMenuItem врачиbtn;
        private ToolStripMenuItem услугиbtn;
        private ToolStripButton clearbtn;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private Button картаврачиbtn;
        private DataGridView пацієнтиGridView;
        private TextBox діагноз;
        private TextBox призначення;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private NumericUpDown idлікаря;
        private DateTimePicker датавідвідування;
        private TextBox idпацієнта;
        private TextBox прізвищелікарtxtbox;
        private TextBox імяtxtbox;
        private TextBox спеціалізаціяtxtbox;
        private TextBox розкладtxtbox;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button лікаріbtn;
        private TextBox назвапослугиtxtbox;
        private Label label10;
        private Label label12;
        private Label label13;
        private Button заповнитипослугиbtn;
        private TextBox вартістьtxtbox;
        private Label label14;
        private NumericUpDown idкартиtxtbox;
    }
}