using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Biolink_Api.Services
{
    public class ConnectionConfig
    {
        private string myCon = System.Configuration.ConfigurationManager.ConnectionStrings["ModelContext"].ConnectionString;
        MySqlConnection conn;
        DataTable dt;

        public ConnectionConfig()
        {
            conn = new MySqlConnection(myCon);
        }

        public void ConnectMySql()
        {
            try
            {
                conn.Open();
                var date = UnixTimeStampToDateTime(1580517767).ToString("yyyyMMdd");
                
            }
            catch (MySqlException ex)
            {
                Console.Write(ex.Message);
            }
        }

        public void ExportText(string sqlQuery)
        {
            try
            {
                sqlQuery = @"select DEVDT, USRID from t_lg202002 
                            where USRID is not null and USRID<> ''
                            and USRGRUID is not null
                            and EVT is not null
                            and IMGLGUID is not null";
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

        public DataTable Getdata(string sqlQuery)
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = new MySqlCommand(sqlQuery, conn);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            return table;
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

    }
}