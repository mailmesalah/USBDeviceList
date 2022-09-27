using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
namespace ProjectUSBDeviceList
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            listAllUSBDevices();
        }

        private void listAllUSBDevices()
        {
            ManagementObjectCollection collection;
            using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_USBHub"))collection = searcher.Get();

            dataGrid.Rows.Clear();
            foreach (var device in collection)
            {
                string[] row = new string[] { device.GetPropertyValue("DeviceID").ToString(), device.GetPropertyValue("PNPDeviceID").ToString(), device.GetPropertyValue("Description").ToString()};
                dataGrid.Rows.Add(row);                                                
            }
            collection.Dispose();
        }
    }
}
