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
            this.progressBarScan.Maximum = EndPort-BeginPort +1;
            progressBarScan.Value = 0;
            listView1.Items.Clear();

            IPAddress addr = new IPAddress(0);
            try
            {
                addr = IPAddress.Parse(this.textBoxIP.Text);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("IP адрес не введён", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат ввода\n\nВведите четыре числа от 0 до 255 (включительно)\nв формате 123.45.6.789 (просто перечислить чила через точку без пробелов)", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            for (int i = BeginPort; i <= EndPort; i++)
            {
                //С оздаем и инициализируем сокет 
                IPEndPoint ер = new IPEndPoint(addr, i);
                Socket soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                // Пытаемся соединиться с сервером
                

                IPEndPoint iPEndPoint=new IPEndPoint(IPAddress.Any, i);
                IAsyncResult asyncResult = soc.BeginConnect(ер,
                new AsyncCallback(ConnectCallback), soc);
                bool closed=false;
                if (!asyncResult.AsyncWaitHandle.WaitOne(30, false))
                {
                    soc.Close();
                    listView1.Items.Add("Порт " + i.ToString());
                    listView1.Items[0].SubItems.Add("");
                    listView1.Items[0].SubItems.Add("закрыт");
                    //listView1.Sort();
                    listView1.Refresh();
                    closed = true;
                }
                if(!closed)
                {
                    soc.Close();
                    listView1.Items.Add("Порт " + i.ToString());
                    listView1.Items[0].SubItems.Add("открыт");
                    //listView1.Sort();
                    listView1.Refresh();
                }
                ++progressBarScan.Value;
            }
            progressBarScan.Value = 0;
            listView1.Sort();
            listView1.Refresh();
            for (int i = 0; i != listView1.Items.Count; ++i)
            {
                if (listView1.Items[i].SubItems.Count!=0)
                listView1.Items[i].SubItems.Add("открыт");
            }
            listView1.Sort();
            listView1.Refresh();
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
