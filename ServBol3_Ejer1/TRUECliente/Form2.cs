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
    public partial class Form2 : Form
    {
        Form1 form1;
        DialogResult res;
        string ip;
        int puerto;
        IPEndPoint ie;
        Socket server;

        public Form2(string ip, int puerto)
        {
            InitializeComponent();
            this.ip = ip;
            this.puerto = puerto;
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

        private void Horabtn_Click(object sender, EventArgs e)
        {
            Connection("Hora");
        }

        private void Fechabtn_Click(object sender, EventArgs e)
        {
            Connection("fecha");
        }

        private void Todobtn_Click(object sender, EventArgs e)
        {
            Connection("todo");
        }

        private void Apagarbtn_Click(object sender, EventArgs e)
        {
            Connection("apagar");
        }

        private void Settingbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form1 = new Form1();
            res = form1.ShowDialog();
        }
    }
}
