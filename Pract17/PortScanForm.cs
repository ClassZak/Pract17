using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Pract17
{
    public partial class PortScanForm : Form
    {
        public PortScanForm()
        {
            InitializeComponent();
        }

        public static ManualResetEvent connectDone = new ManualResetEvent(false);

        private void buttonScan_Click(object sender, EventArgs e)
        {
            int BeginPort = Convert.ToInt32(this.numericUpDownPortBegin.Value);
            int EndPort = Convert.ToInt32(numericUpDownPortEnd.Value);
            int i;
            this.progressBarScan.Maximum = EndPort-BeginPort +1;
            progressBarScan.Value = 0;
            listView1.Items.Clear();
            IPAddress addr = IPAddress.Parse(this.textBoxIP.Text);
            for (i = BeginPort; i <= EndPort; i++)
            {
                //С оздаем и инициализируем сокет 
                long ad = IPAddress.Loopback.Address;
                IPEndPoint ер = new IPEndPoint((addr.Address == ad) ? IPAddress.Any : addr, i);
                Socket soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                // Пытаемся соединиться с сервером
                

                IPEndPoint iPEndPoint=new IPEndPoint(IPAddress.Any, i);
                IAsyncResult asyncResult = soc.BeginConnect(ер,
                new AsyncCallback(ConnectCallback), soc);
                if (!asyncResult.AsyncWaitHandle.WaitOne(30, false))
                {
                    soc.Close();
                    this.listView1.Items.Add("Порт " + i.ToString());
                    this.listView1.Items[i - BeginPort].SubItems.Add("");
                    this.listView1.Items[i - BeginPort].SubItems.Add("закрыт");
                    this.listView1.Refresh();
                    progressBarScan.Value += 1;
                }
                else
                {
                    soc.Close();
                    listView1.Items.Add("Порт " + i.ToString());
                    listView1.Items[i - BeginPort].SubItems.Add("открыт");
                    progressBarScan.Value += 1;
                }
            }
            progressBarScan.Value = 0;
        }



        private static void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                Socket client = (Socket)ar.AsyncState;
                client.EndConnect(ar);
                connectDone.Set();
            }
            catch (Exception e)
            {
            }
        }

    }
}
