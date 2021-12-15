using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivosEjercicio1
{
    public partial class Form2 : Form
    {
        string content;
        public Form2(string content)
        {
            InitializeComponent();
            this.content = content;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = content;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Modified)
            {
                if (MessageBox.Show("Cambiaste algo ¿Pero lo guardaste/quieres cambiarlo?", "Pudi Pudi",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel)
                {
                    try
                    {

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    e.Cancel = true;
                }
            }
            
        }
    }
}
