using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRUECliente
{
    public partial class Form1 : Form
    {
        Settings form2 = new Settings();
        DialogResult res;
        string ip = "192.168.22.31";
        int puerto = 10823;
        IPEndPoint ie;
        Socket server;

        public Form1()
        {
            InitializeComponent();
        }

        public void Connection(string comando)
        {
            try
            {
                ie = new IPEndPoint(IPAddress.Parse(this.ip), this.puerto);

                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                server.Connect(ie);

                using (NetworkStream ns = new NetworkStream(server))
                using (StreamReader read = new StreamReader(ns))
                using (StreamWriter writer = new StreamWriter(ns))
                {
                    read.ReadLine();

                    writer.WriteLine(comando);
                    writer.Flush();

                    Resultlbl.Text = read.ReadLine();
                }
            }
            catch (SocketException e)
            {
                MessageBox.Show($"Error al conetar {e.Message}\nError code{(SocketError)e.ErrorCode} {e.ErrorCode}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Connection(((Button)sender).Text.ToUpper());
        }
        private void Settingbtn_Click(object sender, EventArgs e)
        {
            res = form2.ShowDialog();
            if (res == DialogResult.OK)
            {
                try
                {
                    ip = form2.IPtxt.Text;
                    puerto = int.Parse(form2.Puertotxt.Text);
                }
                catch (FormatException fe)
                {
                    MessageBox.Show($"Formato no válido", "Formato no válido ",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (ArgumentOutOfRangeException ae)
                {
                    MessageBox.Show($"Argumento no válido", "Argumento no válido ",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (OverflowException oe)
                {
                    MessageBox.Show($"YA BASTAAAAAA", "MY POWER It´s OVERFLOWING",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
