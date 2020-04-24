﻿using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Data;

namespace Biolink_Api.Services
{
    public class ConnectionConfig
    {
        private string myCon = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectMariaDB"].ConnectionString;
        MySqlConnection conn;

        public ConnectionConfig()
        {
            conn = new MySqlConnection(myCon);
        }

        public void ConnectMySql()
        {
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                Console.Write(ex.Message);
            }
        }

        public string ExportText()
        {
            string json;
            var getLastMonth = "202002"; //DateTime.Now.AddDays(-1).ToString("yyyyMM");
            var getLastDay = "20200212"; //DateTime.Now.AddDays(-1).ToString("yyyyMMdd");
            try
            {
                var sqlQuery = @"select FROM_UNIXTIME(DEVDT, '%Y%m%d%H%i%S') as DEVDT, USRIDs from t_lg" + getLastMonth +
                            @" where USRID is not null and USRID<> ''
                            and USRGRUID is not null
                            and EVT is not null
                            and IMGLGUID is not null
                            and DATE_FORMAT(SRVDT, '%Y%m%d')  = '"+ getLastDay+"'";
                var dt = Getdata(sqlQuery);
                json = DataTableToJSONWithJSONNet(dt);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return json;
        }

        public DataTable Getdata(string sqlQuery)
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            dataAdapter.SelectCommand = new MySqlCommand(sqlQuery, conn);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            return table;
        }

        public string DataTableToJSONWithJSONNet(DataTable table)
        {
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(table);
            return JSONString;
        }
    }
}