using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivosEjercicio1
{
    public partial class Form2 : Form
    {
        string content;
        FileInfo file;
        public Form2(string content, FileInfo txt)
        {
            InitializeComponent();
            this.content = content;
            this.file = txt;
        }
        // TODO: probar haciendo lo de guardar el dialog result de MessageBox en un variable
        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = content;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Modified)
            {
                if (MessageBox.Show("Cambiaste algo ¿Pero lo guardaste/quieres cambiarlo? \n se guardará en " + file.FullName, "Pudi Pudi",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(this.file.FullName))
                        {
                            sw.Write(textBox1.Text);
                            sw.Close();
                        }
                    }
                    catch (FileNotFoundException )
                    {
                        MessageBox.Show("Fichero No encontrado", "Sorry dude");
                    }
                    catch (DirectoryNotFoundException )
                    {
                        MessageBox.Show("Directorio No encontrado", "Sorry dude");
                    }
                    catch (IOException )
                    {
                        MessageBox.Show("El fichero no se pudo abrir :c", "Sorry dude");
                    }
                    //  e.Cancel = false; No es necesario ponerlo porque esta a FALSE prederteminadamente 
                    
                }
            }

        }
    }
}
