using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biolink_Api.Connections
{
    public class ConnectionConfig
    {
        public void ConnectMySql()
        {
            MySqlConnection conn;
            string myConnectionString;

            myConnectionString = "Server=127.0.0.1;Port=3312;Database=biostar2_ac;Uid=root;Pwd=tha1land;";

            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch (MySqlException ex)
            {
                Console.Write(ex.Message);
            }
        }

    }
}