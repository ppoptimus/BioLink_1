using BioLinkTaskSchedule.Models;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace BioLinkTaskSchedule.Forms
{
    public partial class frmMain : MetroForm
    {
        private List<t_text_file> T_Text_File;
        public frmMain()
        {
            InitializeComponent();
        }

        private void lblCloseForm_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnBrowse_Click(object sender, System.EventArgs e)
        {
            ConfigPath(SavePathFile());
            T_Text_File = text_File();
        }

        /// <summary>
        /// Open windows dialog for choose path save file
        /// </summary>
        /// <returns>Path FileName</returns>
        private string SavePathFile()
        {
            Stream myStream;
            var path = "";
            sdPath.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (sdPath.ShowDialog() == DialogResult.OK)
            {
                path = sdPath.FileName;
                if ((myStream = sdPath.OpenFile()) != null)
                {
                    myStream.Close();
                }
            }
            txtPath.Text = path;
            return path;
        }
       
        /// <summary>
        /// Write text file 
        /// </summary>
        /// <param name="path"></param>
        private void ConfigPath(string path)
        {
            try
            {
                FileInfo fi = new FileInfo(path);
                fi.Delete();
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("Hello");
                        sw.WriteLine("And");
                        sw.WriteLine("Welcome");
                    }
                }
            }
            catch (System.Exception)
            {

                return;
            }
            
        }

        private List<t_text_file> text_File()
        {
            List<t_text_file> T_Text_File;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080/");
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/GetData/GetTextFile").Result;
            if (response.IsSuccessStatusCode)
            {
                T_Text_File = response.Content.ReadAsAsync<List<t_text_file>>().Result;
                return T_Text_File;
            }
            else
            {
                return null;
            }
        }

        private void cbxTaskStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxTaskStart.SelectedItem.ToString())
            {
                case "Daily":
                    GetUC_Daily();
                    break;
                case "Weekly":
                    GetUC_Weekly();
                    break;
                case "Monthly":

                    break;
                case "OneTime":

                    break;
                default:
                    break;
            }
            
            
        }

        private void GetUC_Daily()
        {
            if (!pnl.Controls.Contains(UC_Daily.instance))
            {
                pnl.Controls.Add(UC_Daily.instance);
                UC_Daily.instance.Dock = DockStyle.Fill;
                UC_Daily.instance.BringToFront();
            }
            else
            {
                UC_Daily.instance.BringToFront();
            }
        }

        private void GetUC_Weekly()
        {
            if (!pnl.Controls.Contains(UC_Weekly.instance))
            {
                pnl.Controls.Add(UC_Weekly.instance);
                UC_Weekly.instance.Dock = DockStyle.Fill;
                UC_Weekly.instance.BringToFront();
            }
            else
            {
                UC_Weekly.instance.BringToFront();
            }
        }
    }
}
