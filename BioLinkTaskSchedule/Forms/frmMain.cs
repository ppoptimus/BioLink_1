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
        public int fileNameType;
        public string ftpFileName;

        public frmMain()
        {
            InitializeComponent();
            lblCurrentPath.Text = CuurentPath();
            rdoNew.Checked = true;
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


        #region Tab Ftp
        private void btnConfigFtp_Click(object sender, EventArgs e)
        {
            fileNameType = (rdoNew.Checked == true) ? 1 : 2;
            ftpFileName = (!String.IsNullOrEmpty(txtNewFileName.Text)) ? txtNewFileName.Text : txtReplaceFileName.Text;

            popFtpConfig popFtp = new popFtpConfig(fileNameType, ftpFileName);
            popFtp.ShowDialog();
        }
        private void rdoNew_CheckedChanged(object sender, EventArgs e)
        {
            txtNewFileName.Enabled = true;
            txtReplaceFileName.Enabled = false;
        }

        private void rdoReplace_CheckedChanged(object sender, EventArgs e)
        {
            txtNewFileName.Enabled = false;
            txtReplaceFileName.Enabled = true;
        }


        #endregion Tab Ftp

    }
}
