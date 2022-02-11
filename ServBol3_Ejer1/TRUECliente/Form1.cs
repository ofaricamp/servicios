using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRUECliente
{
    public partial class Form1 : Form
    {
        Form2 form2;
        DialogResult res;
        IPEndPoint ie;
        bool vamosAlServer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Serverbtn_Click(object sender, EventArgs e)
        {
            try
            {
                vamosAlServer = true;

                form2 = new Form2(IPtxt.Text, int.Parse(Puertotxt.Text));
                ie = new IPEndPoint(IPAddress.Parse(IPtxt.Text), int.Parse(Puertotxt.Text));
            }
            catch (FormatException fe)
            {
                vamosAlServer = false;

                MessageBox.Show($"Formato no válido", "Formato no válido ",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (ArgumentOutOfRangeException ae)
            {
                vamosAlServer = false;
                MessageBox.Show($"Argumento no válido", "Argumento no válido ",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException oe)
            {
                vamosAlServer = false;
                MessageBox.Show($"YA BASTAAAAAA", "MY POWER It´s OVERFLOWING",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (vamosAlServer)
                {
                    res = form2.ShowDialog();
                    this.Visible = false;
                }
            }
        }
    }
}
