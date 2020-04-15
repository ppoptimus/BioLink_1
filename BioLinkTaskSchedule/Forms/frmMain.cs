using MetroFramework.Forms;
using System.IO;
using System.Windows.Forms;

namespace BioLinkTaskSchedule.Forms
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
            UC_ConfigPath configPath = new UC_ConfigPath();
        }

        private void lblCloseForm_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnBrowse_Click(object sender, System.EventArgs e)
        {
            ConfigPath(SavePathFile());
        }

        private string SavePathFile()
        {
            Stream myStream;
            var path = "";
            sdPath.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (sdPath.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = sdPath.FileName;
                path = sdPath.FileName;
                if ((myStream = sdPath.OpenFile()) != null)
                {
                    myStream.Close();
                }
            }
            return path;
        }
       
        private void ConfigPath(string path)
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

        
    }
}
