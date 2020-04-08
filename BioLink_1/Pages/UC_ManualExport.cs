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
            ComboBox comboBox = new ComboBox();
            comboBox.DataSource = devicesStuffs.Devices;

            foreach(var item in devicesStuffs.Devices.Select(x => x.DevicesName))
            {
                cbxDevices.Items.Add(item);
            }

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbxDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            var test = cbxDevices.SelectedItem;
        }
    }
}
