using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioLink_1.Stuff;
using BioLink_1.Models;

namespace BioLink_1.Pages
{
    public partial class UC_ManualExport : UserControl
    {
        public UC_ManualExport()
        {
            InitializeComponent();
            FillComboBox();
        }
        private void FillComboBox()
        {
            DevicesStuff devicesStuffs = new DevicesStuff();
            Devices devices = new Devices();


            ComboboxItem item = new ComboboxItem();
            item.Text = devicesStuffs.GetDevices.DevicesName;
            item.Value = devicesStuffs.GetDevices.DevicesId;
            cbxDevices.Items.Add(item);
            cbxDevices.SelectedIndex = 0;
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
