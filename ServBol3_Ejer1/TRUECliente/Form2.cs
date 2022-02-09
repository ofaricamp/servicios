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
    public partial class Form2 : Form
    {
        string ip;
        int puerto;
        IPEndPoint ie;
        Socket socket;
        public Form2(string ip, int puerto)
        {
            InitializeComponent();
            this.ip = ip;
            this.puerto = puerto;
        }

        public void Connection (string comando)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Horabtn_Click(object sender, EventArgs e)
        {

        }

        private void Fechabtn_Click(object sender, EventArgs e)
        {

        }

        private void Todobtn_Click(object sender, EventArgs e)
        {

        }

        private void Apagarbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
