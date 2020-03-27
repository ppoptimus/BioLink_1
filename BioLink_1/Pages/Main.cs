namespace BioLink_1.Pages
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void MainExport_Menu_Click(object sender, System.EventArgs e)
        {
            
        }

        private void ManualExport_SubMenu_Click(object sender, System.EventArgs e)
        {
            this.mt_pl.Controls.Clear();
            var ctrl = new UC_ManualExport();
            mt_pl.Controls.Add(ctrl);
        }
    }
}
