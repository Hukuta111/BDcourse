namespace BDcours
{
    partial class Register
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
            this.reg_btn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.regpasstxtbox = new System.Windows.Forms.TextBox();
            this.reglogintxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reglogError = new System.Windows.Forms.ErrorProvider(this.components);
            this.regpassError = new System.Windows.Forms.ErrorProvider(this.components);
            this.regroleError = new System.Windows.Forms.ErrorProvider(this.components);
            this.rolecmbbox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.exit1btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.reglogError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regpassError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regroleError)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reg_btn
            // 
            this.reg_btn.BackColor = System.Drawing.Color.LightYellow;
            this.reg_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reg_btn.Location = new System.Drawing.Point(461, 300);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(161, 32);
            this.reg_btn.TabIndex = 13;
            this.reg_btn.Text = "Зарегеструватися";
            this.reg_btn.UseVisualStyleBackColor = false;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.LightYellow;
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closebtn.Location = new System.Drawing.Point(190, 300);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(161, 32);
            this.closebtn.TabIndex = 12;
            this.closebtn.Text = "Вихід";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(195, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(195, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Логін";
            // 
            // regpasstxtbox
            // 
            this.regpasstxtbox.Location = new System.Drawing.Point(281, 197);
            this.regpasstxtbox.Name = "regpasstxtbox";
            this.regpasstxtbox.Size = new System.Drawing.Size(326, 21);
            this.regpasstxtbox.TabIndex = 9;
            // 
            // reglogintxtbox
            // 
            this.reglogintxtbox.Location = new System.Drawing.Point(281, 159);
            this.reglogintxtbox.Name = "reglogintxtbox";
            this.reglogintxtbox.Size = new System.Drawing.Size(326, 21);
            this.reglogintxtbox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(207, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Реєстрація користувача";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(195, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Роль";
            // 
            // reglogError
            // 
            this.reglogError.ContainerControl = this;
            // 
            // regpassError
            // 
            this.regpassError.ContainerControl = this;
            // 
            // regroleError
            // 
            this.regroleError.ContainerControl = this;
            // 
            // rolecmbbox
            // 
            this.rolecmbbox.FormattingEnabled = true;
            this.rolecmbbox.Items.AddRange(new object[] {
            "лікар",
            "пацієнт"});
            this.rolecmbbox.Location = new System.Drawing.Point(281, 236);
            this.rolecmbbox.Name = "rolecmbbox";
            this.rolecmbbox.Size = new System.Drawing.Size(326, 23);
            this.rolecmbbox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Khaki;
            this.button1.Location = new System.Drawing.Point(732, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "__";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit1btn
            // 
            this.exit1btn.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.exit1btn.FlatAppearance.BorderSize = 0;
            this.exit1btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit1btn.Font = new System.Drawing.Font("Wide Latin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit1btn.ForeColor = System.Drawing.Color.Crimson;
            this.exit1btn.Location = new System.Drawing.Point(765, 23);
            this.exit1btn.Name = "exit1btn";
            this.exit1btn.Size = new System.Drawing.Size(36, 30);
            this.exit1btn.TabIndex = 0;
            this.exit1btn.Text = "X";
            this.exit1btn.UseVisualStyleBackColor = true;
            this.exit1btn.Click += new System.EventHandler(this.exit1btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.exit1btn);
            this.panel1.Location = new System.Drawing.Point(-3, -20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 57);
            this.panel1.TabIndex = 19;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rolecmbbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.regpasstxtbox);
            this.Controls.Add(this.reglogintxtbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Ветеринарна лікарня";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.reglogError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regpassError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regroleError)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button reg_btn;
        private Button closebtn;
        private Label label3;
        private Label label2;
        private TextBox regpasstxtbox;
        private TextBox reglogintxtbox;
        private Label label1;
        private Label label5;
        private ErrorProvider reglogError;
        private ErrorProvider regpassError;
        private ErrorProvider regroleError;
        private ComboBox rolecmbbox;
        private Panel panel1;
        private Button button1;
        private Button exit1btn;
    }
}