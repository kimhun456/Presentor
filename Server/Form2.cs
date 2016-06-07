using InTheHand.Net.Sockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bluetooth_ServerSide
{
    public partial class Form2 : Form
    {
        BluetoothDeviceInfo[] devices;
        public int a;

        public Form2(BluetoothDeviceInfo[] devices)
        {
            InitializeComponent();

            this.devices = devices;

            foreach (BluetoothDeviceInfo item in devices)
            {
                listView1.Items.Add(new ListViewItem(item.DeviceName));
            }
            listView1.MultiSelect = false;
            listView1.FullRowSelect = true;
        }
        
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            a = listView1.FocusedItem.Index;
            this.Close();
        }
    }
}
