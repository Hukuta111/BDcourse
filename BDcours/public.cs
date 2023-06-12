using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BDcours
{
    internal class @public
    {
        public static void ShowRegForm()
        {
            Register reg = new Register();
            reg.Show();
        }

        public static void ShowLoginForm()
        {
            Login log = new Login();
            log.Show();
        }

        public static void SqlConnection(string script, MySqlConnection connection)
        {
            MySqlCommand command = new MySqlCommand(script, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
        }
    }
}
