using BioLink_1.Models;
using BioLink_1.Stuff;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;

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

        private void btnViewData_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8080/");

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/GetData/GetTextFile").Result;
            if (response.IsSuccessStatusCode)
            {
                var users = response.Content.ReadAsAsync<IEnumerable<t_text_file>>().Result;
                gvViewData.DataSource = users;

            }
        }
    }
}
