using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;
using System.Drawing;
using System.Data.Common;
using Microsoft.VisualBasic;
using System.ComponentModel.Design.Serialization;

namespace BDcours
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private int GetUserIDFromDatabase(string login)
        {
            int userID = 0;

            using (MySqlConnection connection = new MySqlConnection("Server = localhost; port = 3306; Database = ветеринарная_лечебница; username = montly; password = some_pass"))
            {
                connection.Open();

                string selectQuery = "SELECT `Ідентифікатор користувача` FROM користувачі WHERE Логін = @Логін";

                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Логін", login);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        userID = Convert.ToInt32(result);
                    }
                }
            }

            return userID;
        }


        public int I;
        MySqlConnection con = new MySqlConnection(@"Server=localhost;port=3306;Database=ветеринарная_лечебница;username=montly;password=some_pass");
        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (logintxtbox.Text == "") 
            {
                logingError.SetError(logintxtbox, "Не вказан логін!");
            }
            else if (passtxtbox.Text == "")
            {
                passError.SetError(passtxtbox, "Не вказан логін!");
            }
            else
            {
                logingError.Clear();
                passError.Clear();

                /*Роль (лікар)*/
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from користувачі where `Логін` = '" + logintxtbox.Text + "'and `Пароль`= '" + passtxtbox.Text + "'and `Роль`= 'лікар'";
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(table);
                I = Convert.ToInt32(table.Rows.Count.ToString());
                if (I == 1)
                {
                    this.Hide();
                    Main_врачи main1 = new Main_врачи();
                    main1.Show();
                }

                /*Роль (пацієнт)*/
                int A;
                MySqlCommand cmd1 = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from користувачі where `Логін` = '" + logintxtbox.Text + "'and `Пароль`= '" + passtxtbox.Text + "'and `Роль`= 'пацієнт'";
                DataTable table1 = new DataTable();
                MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd);
                adapter1.Fill(table1);


                MySqlCommand cmd2 = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"select `Ідентифікатор користувача` from користувачі where `Логін` = '{logintxtbox.Text}' and `Пароль` = '{passtxtbox.Text}'";
                DataTable table2 = new DataTable();
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd);
                adapter1.Fill(table2);
                A = Convert.ToInt32(table1.Rows.Count.ToString());
                if (A == 1)
                {
                    this.Hide();
                    Main_пациенты main3 = new Main_пациенты();
                    main3.Show();
                }

                if (I == 0 && A == 0)
                {
                    MessageBox.Show("Такого користувача не існує!");
                }
                con.Close();
            }
        }

        private void regbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            @public.ShowRegForm();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}