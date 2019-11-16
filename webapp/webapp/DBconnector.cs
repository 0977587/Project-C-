using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace webapp
{
    class DBconnector
    {
        private MySqlConnection connection;
        private string hostname, portname, databasename, username, password;
        public DBconnector(string hostname, string portname, string databasename, string username, string password)
        {
            this.hostname = hostname;
            this.portname = portname;
            this.databasename = databasename;
            this.username = username;
            this.password = password;
            connection = new MySqlConnection("server=" + hostname + ";user=" + username + ";database=" + databasename + ";port=" + portname + ";password= " + password);
        }

        public void Connect()
        {
            connection.Open();
            string sql = "select * From user";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0] + "-- " + reader[1]);
            }
            reader.Close();

        }
    }
}
