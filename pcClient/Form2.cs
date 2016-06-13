using InTheHand.Net.Sockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;

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

            listView1.BeginUpdate();

            listView1.View = View.LargeIcon;

            ListViewItem[] listItems = new ListViewItem[devices.Length];

            ImageList imageListLarge = new ImageList();
            ImageList imageListSmall = new ImageList();
            
            listView1.LargeImageList = imageListLarge;
            listView1.SmallImageList = imageListSmall;

            imageListLarge.ImageSize = new Size(64, 64);

            ResourceManager rm = new ResourceManager(this.GetType());

            Image img = (Image)rm.GetObject("device_watch");

            imageListLarge.Images.Add(img);



            int i = 0;

            
            foreach (BluetoothDeviceInfo info in devices)
            {
                ListViewItem item = new ListViewItem(info.DeviceName + Environment.NewLine
                    + info.ClassOfDevice.Device, 0);
                item.SubItems.Add(info.ClassOfDevice.ToString());
                listItems[i] = item;
                i++;
                
            }
            listView1.Items.AddRange(listItems);



            listView1.MultiSelect = false;
            listView1.FullRowSelect = true;

            listView1.EndUpdate();

        }
        
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            a = listView1.FocusedItem.Index;
            this.Close();
        }
    }
}
