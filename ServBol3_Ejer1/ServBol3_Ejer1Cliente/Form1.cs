using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServBol3_Ejer1Cliente
{
    public partial class Form1 : Form
    {
        Form2 form2;
        DialogResult res;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
            res = form2.ShowDialog();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
