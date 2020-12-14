using BioLinkTaskSchedule.Commands;
using System;
using System.IO;
using System.Linq;
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
            //string sourceUri = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "bindText.txt");
            string directory = Directory.GetCurrentDirectory() + "\\TextFile";
            string logFileName = directory + "\\bindText.txt";

            FileInfo fi = new FileInfo(logFileName);

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            if (File.Exists(fi.ToString()))
            {
                string configText = File.ReadLines(logFileName).First();

                string[] str = configText.Split('|');
                txtSource.Text = str[0];
                txtServer.Text = str[1];
                txtPort.Text = str[2];
                txtFtpPath.Text = str[3];
                txtUserName.Text = str[4];
                txtPassword.Text = str[5];
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
                    command.WriteTextMapModel(txtSource.Text, txtServer.Text, txtPort.Text, txtFtpPath.Text, txtUserName.Text, txtPassword.Text);
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
