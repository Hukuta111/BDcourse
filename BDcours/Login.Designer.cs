namespace BDcours
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.logintxtbox = new System.Windows.Forms.TextBox();
            this.passtxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.regbtn = new System.Windows.Forms.Button();
            this.logingError = new System.Windows.Forms.ErrorProvider(this.components);
            this.passError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logingError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passError)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(190, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизація користувача";
            // 
            // logintxtbox
            // 
            this.logintxtbox.Location = new System.Drawing.Point(276, 177);
            this.logintxtbox.Name = "logintxtbox";
            this.logintxtbox.Size = new System.Drawing.Size(326, 23);
            this.logintxtbox.TabIndex = 1;
            // 
            // passtxtbox
            // 
            this.passtxtbox.Location = new System.Drawing.Point(276, 220);
            this.passtxtbox.Name = "passtxtbox";
            this.passtxtbox.Size = new System.Drawing.Size(326, 23);
            this.passtxtbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(190, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логін";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(190, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль";
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.LightYellow;
            this.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginbtn.Location = new System.Drawing.Point(461, 286);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(161, 32);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "Авторизуватися";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // regbtn
            // 
            this.regbtn.BackColor = System.Drawing.Color.LightYellow;
            this.regbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.regbtn.Location = new System.Drawing.Point(185, 286);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(161, 32);
            this.regbtn.TabIndex = 6;
            this.regbtn.Text = "Зарегеструватися";
            this.regbtn.UseVisualStyleBackColor = false;
            this.regbtn.Click += new System.EventHandler(this.regbtn_Click);
            // 
            // logingError
            // 
            this.logingError.ContainerControl = this;
            // 
            // passError
            // 
            this.passError.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.exitbtn);
            this.panel1.Location = new System.Drawing.Point(-5, -19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 57);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Khaki;
            this.button1.Location = new System.Drawing.Point(734, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "__";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // exitbtn
            // 
            this.exitbtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.exitbtn.FlatAppearance.BorderSize = 0;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Font = new System.Drawing.Font("Wide Latin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitbtn.ForeColor = System.Drawing.Color.Crimson;
            this.exitbtn.Location = new System.Drawing.Point(767, 21);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(36, 30);
            this.exitbtn.TabIndex = 0;
            this.exitbtn.Text = "X";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.regbtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passtxtbox);
            this.Controls.Add(this.logintxtbox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.Text = "Ветеринарна лікарня";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.logingError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passError)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox logintxtbox;
        private TextBox passtxtbox;
        private Label label2;
        private Label label3;
        private Button loginbtn;
        private Button regbtn;
        private ErrorProvider logingError;
        private ErrorProvider passError;
        private Panel panel1;
        private Button exitbtn;
        private Button button1;
    }
}