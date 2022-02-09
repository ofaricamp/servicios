using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRUECliente
{
    public partial class Form1 : Form
    {
        Form2 form2;
        DialogResult res;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Serverbtn_Click(object sender, EventArgs e)
        {
            form2 = new Form2(IPtxt.Text, int.Parse(Puertotxt.Text));
            res = form2.ShowDialog();
        }
    }
}
