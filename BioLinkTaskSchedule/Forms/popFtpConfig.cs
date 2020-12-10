using BioLinkTaskSchedule.Commands;
using BioLinkTaskSchedule.Models;
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
            BindTextBox();
        }

        public void BindTextBox()
        {
            string sourceUri = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "bindText.txt");
            FileInfo fi = new FileInfo(sourceUri);
            if (File.Exists(fi.ToString()))
            {
                string configText = File.ReadLines(sourceUri).First();

                string[] str = configText.Split('|');
                txtServer.Text = str[0];
                txtPort.Text = str[1];
                txtFtpPath.Text = str[2];
                txtUserName.Text = str[3];
                txtPassword.Text = str[4];
            }
            
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
            if(!String.IsNullOrEmpty(txtServer.Text) && !String.IsNullOrEmpty(txtPort.Text))
            {
                if (command.CheckFTPConnection(url, txtUserName.Text, txtPassword.Text))
                {
                    MessageBox.Show("Ftp server connected", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ftp server not connect!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnSaveFtpConfig_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string startupPath = @"C:\BioLink\FtpConfig.txt";
            try
            {
                var source = txtSource.Text;
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
                
                DialogResult result = MessageBox.Show("Config FTP Success", "Information", buttons, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    command.WriteTextMapModel(txtServer.Text, txtPort.Text, txtFtpPath.Text, txtUserName.Text, txtPassword.Text);
                    this.Hide();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFtpCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
