using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BDcours
{
    public partial class Register : Form
    {
        
        public Register()
        {
            InitializeComponent();
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            string codeofseccurity = "42424242";
            
            if (reglogintxtbox.Text == "")
            {
                reglogError.SetError(reglogintxtbox, "Не вказан логін!");
            }
            else if(regpasstxtbox.Text == "")
            {
                regpassError.SetError(regpasstxtbox, "Не вказан пароль!");
            }
            else if (rolecmbbox.Text == "")
            {
                regroleError.SetError(rolecmbbox, "Не вказана роль!");
            }
            else 
            {
                reglogError.Clear();
                regpassError.Clear();
                regroleError.Clear();

                
                string script = $"insert into користувачі (`Логін`,`Пароль`,`Роль`) values('{reglogintxtbox.Text}','{regpasstxtbox.Text}','{rolecmbbox.Text}')";
                string connString = "Server=localhost;port=3306;Database=ветеринарная_лечебница;username=montly;password=some_pass";

                using (MySqlConnection connection = new MySqlConnection(connString))
                {
                    connection.Open();

                    /*Проверка на роль*/
                    if (rolecmbbox.Text == "лікар")
                    {
                        string result = Microsoft.VisualBasic.Interaction.InputBox("Введіть код доступу: ");

                        if (codeofseccurity == result)
                        {
                            @public.SqlConnection(script, connection);

                            MessageBox.Show("Регестрація пройшла успішно!");
                            this.Hide();
                            Login log = new Login();
                            log.Show();
                            connection.Close();
                        }
                        else
                        {
                            MessageBox.Show("Невірний код доступу!");

                        }
                    }
                    if (rolecmbbox.Text == "пацієнт")
                    {
                        @public.SqlConnection(script, connection);
                        MessageBox.Show("Регестрація пройшла успішно!");
                        this.Hide();
                        Login log = new Login();
                        log.Show();
                        connection.Close();
                    }
                    /*/Проверка на роль*/

                    connection.Close();
                }
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            @public.ShowLoginForm();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void exit1btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
