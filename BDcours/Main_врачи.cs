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
using MySql.Data.MySqlClient;

namespace BDcours
{
    public partial class Main_врачи : Form
    {
        public Main_врачи()
        {
            InitializeComponent();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void картаbtn_Click(object sender, EventArgs e)
        {
            label12.Visible = false;
            label13.Visible = false;
            назвапослугиtxtbox.Visible = false;
            вартістьtxtbox.Visible = false;
            заповнитипослугиbtn.Visible = false;

            label5.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            прізвищелікарtxtbox.Visible = false;
            імяtxtbox.Visible = false;
            спеціалізаціяtxtbox.Visible = false;
            розкладtxtbox.Visible = false;
            лікаріbtn.Visible = false;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label6.Visible = true;
            label14.Visible = true;
            idпацієнта.Visible = true;
            idлікаря.Visible = true;
            датавідвідування.Visible = true;
            діагноз.Visible = true;
            призначення.Visible = true;
            картаврачиbtn.Visible = true;
            idкартиtxtbox.Visible = true;
            


            string connString = "Server=localhost;port=3306;Database=ветеринарная_лечебница;username=montly;password=some_pass";
            string query = "select * from `лікарі`";

            MySqlConnection conn = new MySqlConnection(connString);
            database db = new database();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            adapter.Fill(table);
            dataGridView.DataSource = table;
            conn.Close();
        }

        private void приемbtn_Click(object sender, EventArgs e)
        {
            label12.Visible = false;
            label13.Visible = false;
            назвапослугиtxtbox.Visible = false;
            вартістьtxtbox.Visible = false;
            заповнитипослугиbtn.Visible = false;
            idкартиtxtbox.Visible=false;
            label14.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            idпацієнта.Visible = false;
            idлікаря.Visible = false;
            датавідвідування.Visible = false;
            діагноз.Visible = false;
            призначення.Visible = false;
            картаврачиbtn.Visible = false;

            label5.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            прізвищелікарtxtbox.Visible = false;
            імяtxtbox.Visible = false;
            спеціалізаціяtxtbox.Visible = false;
            розкладtxtbox.Visible = false;
            лікаріbtn.Visible = false;

            string connString = "Server=localhost;port=3306;Database=ветеринарная_лечебница;username=montly;password=some_pass";
            MySqlConnection conn = new MySqlConnection(connString);
            database db = new database();
            DataTable table = new DataTable();

            string query = "select * from `записи пацієнтів на прийом`";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            adapter.Fill(table);
            dataGridView.DataSource = table;
            conn.Close();
        }

        private void врачиbtn_Click(object sender, EventArgs e)
        {
            label12.Visible = false;
            label13.Visible = false;
            назвапослугиtxtbox.Visible = false;
            вартістьtxtbox.Visible = false;
            заповнитипослугиbtn.Visible = false;
            idкартиtxtbox.Visible = false;
            label14.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            idпацієнта.Visible = false;
            idлікаря.Visible = false;
            датавідвідування.Visible = false;
            діагноз.Visible = false;
            призначення.Visible = false;
            картаврачиbtn.Visible = false;

            label5.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            прізвищелікарtxtbox.Visible = true;
            імяtxtbox.Visible = true;
            спеціалізаціяtxtbox.Visible = true;
            розкладtxtbox.Visible = true;
            лікаріbtn.Visible = true;

            string connString = "Server=localhost;port=3306;Database=ветеринарная_лечебница;username=montly;password=some_pass";
            MySqlConnection conn = new MySqlConnection(connString);
            database db = new database();
            DataTable table = new DataTable();

            string query = "select * from `лікарі`";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            adapter.Fill(table);
            dataGridView.DataSource = table;
            conn.Close();
        }

        private void услугиbtn_Click(object sender, EventArgs e)
        {
            label12.Visible = true;
            label13.Visible = true;
            назвапослугиtxtbox.Visible=true;
            вартістьtxtbox.Visible = true;
            заповнитипослугиbtn.Visible = true;

            idкартиtxtbox.Visible = false;
            label14.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            прізвищелікарtxtbox.Visible = false;
            імяtxtbox.Visible = false;
            спеціалізаціяtxtbox.Visible = false;
            розкладtxtbox.Visible = false;
            лікаріbtn.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            idпацієнта.Visible = false;
            idлікаря.Visible = false;
            датавідвідування.Visible = false;
            діагноз.Visible = false;
            призначення.Visible = false;
            картаврачиbtn.Visible = false;

            string connString = "Server=localhost;port=3306;Database=ветеринарная_лечебница;username=montly;password=some_pass";
            MySqlConnection conn = new MySqlConnection(connString);
            database db = new database();
            DataTable table = new DataTable();

            string query = "select * from `послуги`";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            adapter.Fill(table);
            dataGridView.DataSource = table;
            conn.Close();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            idкартиtxtbox.Visible = false;
            label14.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            назвапослугиtxtbox.Visible = false;
            вартістьtxtbox.Visible = false;
            заповнитипослугиbtn.Visible = false;

            label5.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            прізвищелікарtxtbox.Visible = false;
            імяtxtbox.Visible = false;
            спеціалізаціяtxtbox.Visible = false;
            розкладtxtbox.Visible = false;
            лікаріbtn.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            idпацієнта.Visible = false;
            idлікаря.Visible = false;
            датавідвідування.Visible = false;
            діагноз.Visible = false;
            призначення.Visible = false;
            картаврачиbtn.Visible = false;

            dataGridView.DataSource = null;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Main_врачи_Load(object sender, EventArgs e)
        {
            string script = $"select * from пацієнти";
            string connString = "Server=localhost;port=3306;Database=ветеринарная_лечебница;username=montly;password=some_pass";


            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(script, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                пацієнтиGridView.DataSource = table;
                connection.Close();

            }
        }

        private void картаврачиbtn_Click(object sender, EventArgs e)
        {
            датавідвідування.CustomFormat = "dd.MM.yyyy";
            DateTime selectedDate1 = датавідвідування.Value.Date;

            string script = $"insert into `електронні амбулаторні картки` values ({idкартиtxtbox.Text},{idпацієнта.Text},{idлікаря.Text},'{selectedDate1.ToString("dd.MM.yyyy")}','{діагноз.Text}','{призначення.Text}');";
            string connString = "Server=localhost;port=3306;Database=ветеринарная_лечебница;username=montly;password=some_pass";


            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(script, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView.DataSource = table;
                connection.Close();

            }

            string script1 = $"select * from `електронні амбулаторні картки`";
            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(script1, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView.DataSource = table;
                connection.Close();

            }
        }

        private void лікаріbtn_Click(object sender, EventArgs e)
        {
            string script = $"insert into лікарі (`Прізвище`,`Ім'я`,`Спеціалізація`,`Розклад прийомів`) values ('{прізвищелікарtxtbox.Text}','{імяtxtbox.Text}','{спеціалізаціяtxtbox.Text}','{розкладtxtbox.Text}');";
            string connString = "Server=localhost;port=3306;Database=ветеринарная_лечебница;username=montly;password=some_pass";


            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(script, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView.DataSource = table;
                connection.Close();


            }
            string script1 = $"select * from лікарі";
            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(script1, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView.DataSource = table;
                connection.Close();

            }

        }

        private void заповнитипослугиbtn_Click(object sender, EventArgs e)
        {
            string script = $"insert into послуги (`Назва послуги`,`Вартість`) values ('{назвапослугиtxtbox.Text}',{вартістьtxtbox.Text});";
            string connString = "Server=localhost;port=3306;Database=ветеринарная_лечебница;username=montly;password=some_pass";


            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(script, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView.DataSource = table;
                connection.Close();


            }
            string script1 = $"select * from послуги";
            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(script1, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView.DataSource = table;
                connection.Close();

            }
        }

        private void updateкартаtxtbox_Click(object sender, EventArgs e)
        {
            string script = $"insert into послуги (`Назва послуги`,`Вартість`) values ('{назвапослугиtxtbox.Text}',{вартістьtxtbox.Text});";
            string connString = "Server=localhost;port=3306;Database=ветеринарная_лечебница;username=montly;password=some_pass";

            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(script, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView.DataSource = table;
                connection.Close();


            }
        }
    }
}
