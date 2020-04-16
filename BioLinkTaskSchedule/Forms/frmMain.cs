using BioLinkTaskSchedule.Models;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace BioLinkTaskSchedule.Forms
{
    public partial class frmMain : MetroForm
    {
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
            SetPathFile();
            txtPath.Enabled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPath.Text))
            {
                string message = "Are you sure that you would like save file to this path?";
                string title = "Confirmation";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    ConfigPath(txtPath.Text);
                    MessageBox.Show("Set path successful", "Message", MessageBoxButtons.OK);
                    txtPath.Clear();
                    txtPath.Enabled = false;
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Path name shouldn't emty", "Warning!", MessageBoxButtons.OK);
                txtPath.Focus();
            }
            
        }

        /// <summary>
        /// Open windows dialog to choose path for save file
        /// </summary>
        /// <returns>Path FileName</returns>
        private string SetPathFile()
        {
            var path = "";
            sdPath.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (sdPath.ShowDialog() == DialogResult.OK)
            {
                path = sdPath.FileName;
            }
            txtPath.Text = path;
            return path;
        }
       
        /// <summary>
        /// Write text file 
        /// </summary>
        /// <param name="path"></param>
        private void ConfigPath(string textWrite)
        {
            string startupPath = @"C:\BioLink\PathConfig.txt";
            try
            {
                //FilePath//
                FileInfo fi = new FileInfo(startupPath);
                fi.Delete();
                if (!File.Exists(startupPath))
                {
                    using (StreamWriter sw = File.CreateText(startupPath))
                    {
                        sw.WriteLine(textWrite);
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

       

        //private void cbxTaskStart_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    switch (cbxTaskStart.SelectedItem.ToString())
        //    {
        //        case "Daily":
        //            GetUC_Daily();
        //            break;
        //        case "Weekly":
        //            GetUC_Weekly();
        //            break;
        //        case "Monthly":

        //            break;
        //        case "OneTime":

        //            break;
        //        default:
        //            break;
        //    }


        //}

        //private void GetUC_Daily()
        //{
        //    if (!pnl.Controls.Contains(UC_Daily.instance))
        //    {
        //        pnl.Controls.Add(UC_Daily.instance);
        //        UC_Daily.instance.Dock = DockStyle.Fill;
        //        UC_Daily.instance.BringToFront();
        //    }
        //    else
        //    {
        //        UC_Daily.instance.BringToFront();
        //    }
        //}

        //private void GetUC_Weekly()
        //{
        //    if (!pnl.Controls.Contains(UC_Weekly.instance))
        //    {
        //        pnl.Controls.Add(UC_Weekly.instance);
        //        UC_Weekly.instance.Dock = DockStyle.Fill;
        //        UC_Weekly.instance.BringToFront();
        //    }
        //    else
        //    {
        //        UC_Weekly.instance.BringToFront();
        //    }
        //}
    }
}
