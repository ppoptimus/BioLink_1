using BioLinkTaskSchedule.Commands;
using MetroFramework.Forms;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BioLinkTaskSchedule.Forms
{
    public partial class frmMain : MetroForm
    {
        CommandHelper command = new CommandHelper();
        public frmMain()
        {
            InitializeComponent();
            lblCurrentPath.Text = CuurentPath();
        }

        #region Tab Config path
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
                    lblCurrentPath.Text = txtPath.Text;
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

            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    path = fbd.SelectedPath;
                }
            }
            txtPath.Text = path;
            return path;
        }

        /// <summary>
        /// Write textPathFile into PathConfig.txt
        /// </summary>
        /// <param name="path"></param>
        private void ConfigPath(string textWrite)
        {
            string startupPath = @"C:\BioLink\PathToWriteFile.txt";
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

        private string CuurentPath()
        {
            string cuurentPath = string.Empty;

            string startupPath = @"C:\BioLink\PathToWriteFile.txt";
            cuurentPath = File.ReadLines(startupPath).First();

            return cuurentPath;
        }

        #endregion Config path

        #region Tab FTP
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

        private void btnSaveFtpConfig_Click(object sender, EventArgs e)
        {
            FileInfo sourceFile = new FileInfo(txtSource.Text);
            var source = sourceFile.Name;
            var server = txtServer.Text;
            var ftpPath = txtFtpPath.Text;
            var port = txtPort.Text;
            var userName = txtUserName.Text;
            var passWord = txtPassword.Text;
            string textWrite = $"{source},{server},{ftpPath},{port},{userName},{passWord}";

            string startupPath = @"C:\BioLink\FtpConfig.txt";
            try
            {
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
            //string result = command.FtpUpload(txtSource.Text, txtServer.Text, txtFtpPath.Text, txtPort.Text, txtUserName.Text, txtPassword.Text);
            //if(!String.IsNullOrEmpty(result))
            //{
            //    MessageBox.Show(result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
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

        #endregion FTP

    }
}
