using BioLinkTaskSchedule.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioLinkTaskSchedule.Forms
{
    public partial class popFtpConfig : Form
    {
        CommandHelper command = new CommandHelper();

        protected int _fileNameType;
        protected string _ftpFileName;

        public popFtpConfig(int fileNameType, string ftpFileName)
        {
            InitializeComponent();
            _fileNameType = fileNameType;
            _ftpFileName = ftpFileName;
        }

        private void btnBrows_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "All files|*.*" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(ofd.FileName);
                    txtSource.Text = fi.FullName;
                    btnSaveFtpConfig.Enabled = true;
                }
            }
        }

        private void btnCheckFtp_Click(object sender, EventArgs e)
        {
            string url = "ftp://" + txtServer.Text + ":" + txtPort.Text;
            if (command.CheckFTPConnection(url, txtUserName.Text, txtPassword.Text))
            {
                MessageBox.Show("Ftp server connected", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ftp server not connect!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveFtpConfig_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string startupPath = @"C:\BioLink\FtpConfig.txt";
            try
            {
                FileInfo sourceFile = new FileInfo(txtSource.Text);
                var source = sourceFile.Name;
                var server = txtServer.Text;
                var ftpPath = txtFtpPath.Text;
                var port = txtPort.Text;
                var userName = txtUserName.Text;
                var passWord = txtPassword.Text;
                string textWrite = $"{source}|{server}|{ftpPath}|{port}|{userName}|{passWord}|{_fileNameType}|{_ftpFileName}";

                FileInfo fi = new FileInfo(startupPath);
                fi.Delete();
                if (!File.Exists(startupPath))
                {
                    using (StreamWriter sw = File.CreateText(startupPath))
                    {
                        sw.WriteLine(textWrite);
                    }
                }
                
                DialogResult result = MessageBox.Show("Config FTP Success", "Information", buttons);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //string result = command.FtpUpload(txtSource.Text, txtServer.Text, txtFtpPath.Text, txtPort.Text, txtUserName.Text, txtPassword.Text);
            //if(!String.IsNullOrEmpty(result))
            //{
            //    MessageBox.Show(result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void btnFtpCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
