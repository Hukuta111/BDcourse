using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BDcours
{
    internal class database
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;port=3306;Database=комерційна_стоматологічна_лікарня;username=montly;password=some_pass");

        public void OpenConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed) 
            { 
                conn.Open();
            }
        }

        public void CloseConnection() 
        {
            if (conn.State == System.Data.ConnectionState.Open)
            { 
                conn.Close(); 
            }
        }

        public MySqlConnection GetConnection()
        {
            return conn;
        }
    }
}
