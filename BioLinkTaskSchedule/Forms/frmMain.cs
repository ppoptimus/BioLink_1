using BioLinkTaskSchedule.Commands;
using MetroFramework.Forms;
using System;
using System.IO;
using System.Linq;
using System.Net;
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

        //Comment ไปก่อน
        //#region backgroundWorker 
        //struct FtpSetting
        //{
        //    public string Server { get; set; }
        //    public string Username { get; set; }
        //    public string Password { get; set; }
        //    public string FileName { get; set; }
        //    public string FullName { get; set; }
        //}

        //FtpSetting _inputParameter;
        //private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        //{
        //    string fileName = ((FtpSetting)e.Argument).FileName;
        //    string fullName = ((FtpSetting)e.Argument).FullName;
        //    string userName = ((FtpSetting)e.Argument).Username;
        //    string password = ((FtpSetting)e.Argument).Password;
        //    string server = ((FtpSetting)e.Argument).Server;
        //    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(string.Format("{0}/{1}", server, fileName)));
        //    request.Method = WebRequestMethods.Ftp.UploadFile;
        //    request.Credentials = new NetworkCredential(userName, password);
        //    Stream ftpStream = request.GetRequestStream();
        //    FileStream fs = File.OpenRead(fullName);
        //    byte[] buffer = new byte[1024];
        //    double total = (double)fs.Length;
        //    int byteRead = 0;
        //    double read = 0;
        //    do
        //    {
        //        if (!backgroundWorker.CancellationPending)
        //        {
        //            //Upload file & update process bar
        //            byteRead = fs.Read(buffer, 0, 1024);
        //            ftpStream.Write(buffer, 0, byteRead);
        //            read += (double)byteRead;
        //            double percentage = read / total * 100;
        //            backgroundWorker.ReportProgress((int)percentage);
        //        }
        //    }
        //    while (byteRead != 0);
        //    fs.Close();
        //    ftpStream.Close();
        //}

        //private void backgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        //{
        //    lblStatus.Text = $"Uploaded {e.ProgressPercentage} %";
        //    progressBar.Value = e.ProgressPercentage;
        //    progressBar.Update();
        //}

        //private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        //{
        //    lblStatus.Text = "Upload complete !";
        //}

        //private void RunbackgroundWorker()
        //{
        //    using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "All files|*.*" })
        //    {
        //        if (ofd.ShowDialog() == DialogResult.OK)
        //        {
        //            FileInfo fi = new FileInfo(ofd.FileName);
        //            _inputParameter.Username = txtUserName.Text;
        //            _inputParameter.Password = txtPassword.Text;
        //            _inputParameter.Server = txtServer.Text;
        //            _inputParameter.FileName = fi.Name;
        //            _inputParameter.FullName = fi.FullName;
        //            backgroundWorker.RunWorkerAsync(_inputParameter);
        //        }
        //    }
        //}

        //#endregion backgroundWorker

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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string result = command.FtpUpload(txtSource.Text, txtServer.Text, txtFtpPath.Text, txtPort.Text, txtUserName.Text, txtPassword.Text);
            if(!String.IsNullOrEmpty(result))
            {
                MessageBox.Show(result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion FTP

    }
}
