using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Crypto.Generators;
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
    
    public partial class Main_пациенты : Form
    {

        public Main_пациенты()
        {
            InitializeComponent();
        }


        private void Main_пациенты_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void записатсяbtn_Click(object sender, EventArgs e)
        {
            namelbl.Visible = true;
            typelbl.Visible = true;
            breedlbl.Visible = true;
            datelbl.Visible = true;
            nameanimaltxtbox.Visible = true;
            typeanimaltxtbox.Visible = true;
            breedanimaltxtbox.Visible = true;
            birthtxtbox.Visible = true;
            recordanimalbtn.Visible = true;

            карткаdataGriedView.Visible = false;
            карткаdataGriedView.Visible = false;
            labelкарти.Visible = false;
            idкарткиtxtbox.Visible = false;
            searchкарткиbtn.Visible = false;
            nameanimallbl.Visible = false;
            nametxtbox.Visible = false;

        }

        

        private void recorbtn_Click(object sender, EventArgs e)
        {
            if (nameanimaltxtbox.Text == "")
            {
                errorProvider1.SetError(nameanimaltxtbox, "Не заповнене поле!");
            }
            else if (typeanimaltxtbox.Text == "")
            {
                errorProvider2.SetError(typeanimaltxtbox, "Не заповнене поле!");
            }
            else if (breedanimaltxtbox.Text == "")
            {
                errorProvider3.SetError(breedanimaltxtbox, "Не заповнене поле!");
            }
            else
            {
                

                

                string script1 = "select * from лікарі";
                string script2 = "select * from послуги";
                    


                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();

                namelbl.Visible = false;
                typelbl.Visible = false;
                breedlbl.Visible = false;
                datelbl.Visible = false;
                nameanimaltxtbox.Visible = false;
                typeanimaltxtbox.Visible = false;
                breedanimaltxtbox.Visible = false;
                birthtxtbox.Visible = false;
                recordanimalbtn.Visible = false;
                nameanimallbl.Visible = false;
                nametxtbox.Visible = false;

                doctorDataGridView.Visible = true;
                serviceDataGriedView.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                iddoctortxtbox.Visible = true;
                idservicetxtbox.Visible = true;
                daterecord.Visible = true;
                timetxtbox.Visible = true;
                recordbtn.Visible = true;
               
                string connString = "Server=localhost;port=3306;Database=ветеринарная_лечебница;username=montly;password=some_pass";
                using (MySqlConnection connection = new MySqlConnection(connString))
                {
                    connection.Open();
                    MySqlCommand command1 = new MySqlCommand(script1, connection);
                    MySqlDataAdapter adapter1 = new MySqlDataAdapter(command1);
                    DataTable table1 = new DataTable();
                    adapter1.Fill(table1);
                    doctorDataGridView.DataSource = table1;

                }

                
                using (MySqlConnection connection = new MySqlConnection(connString))
                {
                    connection.Open();
                    MySqlCommand command2 = new MySqlCommand(script2, connection);
                    MySqlDataAdapter adapter2 = new MySqlDataAdapter(command2);
                    DataTable table2 = new DataTable();
                    adapter2.Fill(table2);
                    serviceDataGriedView.DataSource = table2;
                }

                
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            namelbl.Visible = false;
            typelbl.Visible = false;
            breedlbl.Visible = false;
            datelbl.Visible = false;
            nameanimaltxtbox.Visible = false;
            typeanimaltxtbox.Visible = false;
            breedanimaltxtbox.Visible = false;
            birthtxtbox.Visible = false;
            recordanimalbtn.Visible = false;

            карткаdataGriedView.Visible = true;
            labelкарти.Visible = true;
            idкарткиtxtbox.Visible = true;
            searchкарткиbtn.Visible = true;
            nameanimallbl.Visible = true;
            nametxtbox.Visible=true;

            doctorDataGridView.Visible = false;
            serviceDataGriedView.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            iddoctortxtbox.Visible = false;
            idservicetxtbox.Visible = false;
            daterecord.Visible = false;
            timetxtbox.Visible = false;
            recordbtn.Visible = false;

            
        }

        private void searchкарткиbtn_Click(object sender, EventArgs e)
        {
            int I = 0;
            int idкартки = Int32.Parse(idкарткиtxtbox.Text);

            MySqlConnection connection = new MySqlConnection(@"Server=localhost;port=3306;Database=ветеринарная_лечебница;username=montly;password=some_pass");

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText =$"select  `електронні амбулаторні картки`.`Ідентифікатор карти`, `пацієнти`.`Ім'я` as 'Ім`я тварини', `пацієнти`.`Вид тварини`,`пацієнти`.`Порода`, `пацієнти`.`Дата нарождения`,`лікарі`.`Прізвище` as `Прізвище лікаря`,`електронні амбулаторні картки`.`Діагноз`,`електронні амбулаторні картки`.`Дата відвідування`,`електронні амбулаторні картки`.`Призначеня`from `електронні амбулаторні картки`,`пацієнти`,`лікарі`where `пацієнти`.`Ідентифікатор пацієнта` = `електронні амбулаторні картки`.`Ідентифікатор пацієнта` and `електронні амбулаторні картки`.`Ідентифікатор карти` = {idкартки} and `пацієнти`.`Ім'я` =  '{nametxtbox.Text}';";

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(table);
            I = Convert.ToInt32(table.Rows.Count.ToString());
            
            if (I == 1)
            {
                карткаdataGriedView.DataSource = table;
            }
            else
            {
                карткаdataGriedView.DataSource = null;
                MessageBox.Show("Користувача с такою амбулаторною картою не існує!");
            }
            connection.Close();
        }

        private void labelкарти_Click(object sender, EventArgs e)
        {

        }

        private void idкарткиtxtbox_TextChanged(object sender, EventArgs e)
        {

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

        private void recordbtn_Click(object sender, EventArgs e)
        {
            Random randomid = new Random();
            int randomid2 = Convert.ToInt32(randomid.Next(1, 100000));

            daterecord.CustomFormat = "dd.mm.yyyy";
            DateTime selectedDate2 = daterecord.Value.Date;

            birthtxtbox.CustomFormat = "dd.mm.yyyy";
            DateTime selectedDate1 = birthtxtbox.Value.Date;

            timetxtbox.Minimum= 0;
            timetxtbox.Maximum= 24;
            string script = $"insert into пацієнти values({randomid2},{iddoctortxtbox.Text},'{nameanimaltxtbox.Text}','{typeanimaltxtbox.Text}','{breedanimaltxtbox.Text}','{selectedDate1.ToString("dd.MM.yyyy")}')";
            string script3 = $"insert into `записи пацієнтів на прийом` (`Ідентифікатор тварини`,`Ідентифікатор лікаря`,`Ідентифікатор послуги`,`Дата`,`Година`) values ({randomid2},'{iddoctortxtbox.Text}','{idservicetxtbox.Text}','{selectedDate2.ToString("dd.MM.yyyy")}',{timetxtbox.Text})";
            string connString = "Server=localhost;port=3306;Database=ветеринарная_лечебница;username=montly;password=some_pass";


            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(script, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                connection.Close();
            }

            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(script3, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                connection.Close();
            }
            MessageBox.Show($"Ви записались на прийом на {selectedDate1.ToString("dd.MM.yyyy")} число {timetxtbox.Text} годину");
        }
    }
}
