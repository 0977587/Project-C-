using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace DatabaseController
{
        //Install-Package MySql.Data -Version 8.0.18
    public class DBConnection
    {
        public List<List<string>> Send(string queri)
        {
            List<string> Stringlist;
            List<List<string>> Stringlist2 = new List<List<string>>();

            this.DatabaseName = "projectcdb";
            if (this.IsConnect())
            {
                Console.WriteLine(queri);


                var cmd = new MySqlCommand(queri, Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Stringlist = new List<string>();
                    for (int i = 0; i < reader.FieldCount ; i++)
                    {
                        Stringlist.Add(reader[i].ToString());
                    }
                    Stringlist2.Add(Stringlist);


                }
                cmd.Dispose();

                reader.Close();
               
            }

            return Stringlist2;
        }

        private string databaseName = string.Empty;
        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }

        public string Password { get; set; }
        private MySqlConnection connection = null;
        public MySqlConnection Connection
        {
            get { return connection; }
        }


        public bool IsConnect()
        {
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(databaseName))
                    return false;
                string connstring = string.Format("Server=localhost; Port=3306; database={0}; UID=root; password=root", databaseName);
                connection = new MySqlConnection(connstring);
                connection.Open();
            }

            return true;
        }

        public void Close()
        {
            connection.Close();
        }

        public int returnWachtrijLength()
        {
            List<List<string>> returnstatement = new DBConnection().Send("SELECT COUNT(WachtrijId) FROM projectcdb.wachtrij");
            int length = Convert.ToInt32(returnstatement[0][0]);
            return length;
        }
    }
}
