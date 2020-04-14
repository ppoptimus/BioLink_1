using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Biolink_Api.Connections
{
    public class ConnectionConfig
    {
        private string myCon = @"Server=127.0.0.1;Port=3312;Database=biostar2_ac;Uid=root;Pwd=tha1land;";
       
        public void ConnectMySql()
        {
            MySqlConnection conn = new MySqlConnection(myCon);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                Console.Write(ex.Message);
            }
        }

        public void ExportText(string sqlQuery, MySqlConnection conn)
        {
            try
            {
                sqlQuery = "select * from t_ad_column";
                var cmd = new MySqlCommand(sqlQuery, conn);

                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + " -- " + rdr[1]);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Getdata(string sqlQuery, MySqlConnection conn)
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = new MySqlCommand(sqlQuery, conn);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            return table;
        }

    }
}