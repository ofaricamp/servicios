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

namespace ServBol3_Ejer2
{
    public partial class Form1 : Form
    {
        string mensaje = "";
        IPEndPoint ie;
        string comando = "";
        Socket server;
        public Form1()
        {
            InitializeComponent();
        }

        public void Connection(string comando)
        {
            try
            {

                ie = new IPEndPoint(IPAddress.Parse(Iptxt.Text), Convert.ToInt32(Puertotxt.Text));

                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                server.Connect(ie);


                using (NetworkStream ns = new NetworkStream(server))
                using (StreamReader sr = new StreamReader(ns))
                using (StreamWriter sw = new StreamWriter(ns))
                {
                    sw.WriteLine("User " + (Usertxt.Text));
                    sw.Flush();
                    
                    mensaje = sr.ReadLine();
                    sw.WriteLine(comando);
                    sw.Flush();
                    if (comando == "list")
                    {
                        while (sr.ReadLine() != null)
                        {
                            Listtxt.Text += sr.ReadLine() ;
                            Listtxt.Text += Environment.NewLine;
                        }
                    }
                }
            }
            catch (SocketException e)
            {
                MessageBox.Show($"Error al conetar {e.Message}\nError code{(SocketError)e.ErrorCode} {e.ErrorCode}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (FormatException fe)
            {
                MessageBox.Show($"Formato no válido", "Formato no válido",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException are)
            {

            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            comando = "list";
            this.Connection(comando);
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            comando = "add";
            this.Connection(comando);
        }
    }
}
