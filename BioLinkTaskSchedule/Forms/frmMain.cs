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
        public int fileTypeChecked = 0;

        public frmMain()
        {
            InitializeComponent();
            lblCurrentPath.Text = CuurentPath();
            BindTextBox();
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
        //-------------------------------------------------------------------------------------------------------------

        #region Tab Ftp   
        private void rdoNew_CheckedChanged_1(object sender, EventArgs e)
        {
            txtNewFileName.Enabled = true;
            txtReplaceFileName.Enabled = false;
            txtReplaceFileName.Text = string.Empty;
            fileTypeChecked = 1;
        }

        private void rdoReplace_CheckedChanged_1(object sender, EventArgs e)
        {
            txtNewFileName.Enabled = false;
            txtReplaceFileName.Enabled = true;
            txtNewFileName.Text = string.Empty;
            fileTypeChecked = 2;
        }

        private void btnOpenConfig_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtNewFileName.Text) || !String.IsNullOrEmpty(txtReplaceFileName.Text))
            {
                if(rdoNew.Checked == true) { fileNameType = 1; }
                else if (rdoReplace.Checked == true) { fileNameType = 2; }
                else { fileNameType = 0; }
                ftpFileName = (!String.IsNullOrEmpty(txtNewFileName.Text)) ? txtNewFileName.Text : txtReplaceFileName.Text;

                var popFtp = new popFtpConfig(fileNameType, ftpFileName);
                popFtp.ShowDialog();
            }
            
        }

        private void btnSaveTabFtp_Click(object sender, EventArgs e)
        {
            try
            {
                ftpFileName = (!String.IsNullOrEmpty(txtNewFileName.Text)) ? txtNewFileName.Text : txtReplaceFileName.Text;
                string textWrite = $"{fileTypeChecked}|{ftpFileName}";
                var fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "bindTabFtpConfig.txt");
                FileInfo fi = new FileInfo(fileName);

                fi.Delete();
                if (!File.Exists(fi.ToString()))
                {
                    using (StreamWriter sw = File.CreateText(fi.ToString()))
                    {
                        sw.WriteLine(textWrite);
                    }
                }
                MessageBox.Show("Save Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void BindTextBox()
        {
            string sourceUri = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "bindTabFtpConfig.txt");
            FileInfo fi = new FileInfo(sourceUri);
            if (File.Exists(fi.ToString()))
            {
                string configText = File.ReadLines(sourceUri).First();

                string[] str = configText.Split('|');
                if(str[0] == "1")
                {
                    rdoNew.Checked = true;
                    txtNewFileName.Text = str[1];
                }
                else if (str[0] == "2")
                {
                    rdoReplace.Checked = true;
                    txtReplaceFileName.Text = str[1];
                }
                else
                {
                    rdoReplace.Checked = false;
                    rdoNew.Checked = false;
                }

            }
        }
        #endregion Tab Ftp
        //-------------------------------------------------------------------------------------------------------------
    }
}
