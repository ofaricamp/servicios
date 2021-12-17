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
    // TODO stringWriter para el formulario 2, para así guardar lo modificado en el txt
    // mejor visibilidad en la excpciones y errores a la hora de informar al usuario
    public partial class Form1 : Form
    {
        FileInfo SelectedFileInfo;
        public string contenidoTxt = "";
        bool clear = true;
        public Form1()
        {
            InitializeComponent();
        }

        public void Clearcion(bool clearMetod)
        {
            if (clearMetod)
            {
                listBoxFile.Items.Clear();
                ListBoxSubDir.Items.Clear();
            }
        }

        public void RellenaListBox(string subdirectory)
        {
            try
            {
                Clearcion(this.clear);
                DirectoryInfo info;
                string entorno = Environment.ExpandEnvironmentVariables(subdirectory);
                Directory.SetCurrentDirectory(entorno);
                info = new DirectoryInfo(Directory.GetCurrentDirectory());
                ListBoxSubDir.Items.Add("..");
                foreach (DirectoryInfo dirs in info.GetDirectories())
                {
                    ListBoxSubDir.Items.Add(dirs.Name);
                }
                foreach (FileInfo files in info.GetFiles())
                {
                    listBoxFile.Items.Add(files);
                }
                label6.Text = info.FullName;
                this.clear = true;
            }
            catch (UnauthorizedAccessException unautex)
            {
                MessageBox.Show("Acceso NO disponible :'c", "Sorry dude");
                this.clear = false;
            }
            catch (FileNotFoundException filex)
            {
                MessageBox.Show("Fichero No encontrado mira si escribiste bien la ruta ;3", "Sorry dude");
                this.clear = false;
            }
            catch (DirectoryNotFoundException direx)
            {
                MessageBox.Show("Directorio No encontrado mira si escribiste bien la ruta ;3", "Sorry dude");
                this.clear = false;
            }
            catch (ArgumentException argex)
            {
                MessageBox.Show("Necesitas tener algo escrito", "Sorry dude");
                this.clear = false;
            }
        }
        public void KiloMegaGiga(FileInfo file)
        {
            if (file.Length < 1024)
            {
                label2.Text = $"Name: {file.Name}  Size: {((float)file.Length):F2} Bytes";
            }
            else if (file.Length / 1024 < 1024)
            {
                label2.Text = $"Name: {file.Name}  Size: {((float)file.Length / 1024):F2} KB";
            }
            else if (((file.Length / 1024) / 1024) < 1024)
            {
                label2.Text = $"Name: {file.Name}  Size: {((float)((file.Length / 1024) / 1024)):F2} MB";
            }
            else
            {
                label2.Text = $"Name: {file.Name}  Size: {((float)(((file.Length / 1024) / 1024) / 1024)):F2} GB";
            }
        }

        public void TXTIchooseYou(FileInfo file)
        {
            DialogResult dialogResult;
            if (file.Name.EndsWith(".txt"))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(file.Name))
                    {
                        contenidoTxt = reader.ReadToEnd();
                        reader.Close();
                    }
                    //LetsTryTogether.Text = contenidoTxt.ToString();
                    Form2 form2 = new Form2(contenidoTxt, file);
                    dialogResult = form2.ShowDialog();
                }
                catch (FileNotFoundException filex)
                {
                    //errorFileLabel.Text = $"The file was not found: {filex}";
                    MessageBox.Show("Fichero No encontrado", "Sorry dude");
                }
                catch (DirectoryNotFoundException direx)
                {
                    // ErrorDirLabel.Text = $"The directory was not found: {direx}";
                    MessageBox.Show("Directorio No encontrado", "Sorry dude");
                }
                catch (IOException ioex)
                {
                    // errorFileLabel.Text = $"The file couldn´t be opened: {ioex}";
                    MessageBox.Show("El fichero no se pudo abrir :c", "Sorry dude");
                }
            }
        }
        private void DirectoriBtn_Click(object sender, EventArgs e)
        {
            RellenaListBox(textBoxDir.Text.ToString());
        }

        private void ListBoxSubDir_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ListBoxSubDir.SelectedItem != null)
            {
                RellenaListBox(ListBoxSubDir.SelectedItem.ToString());
            }
        }

        private void listBoxFile_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBoxFile.SelectedItem != null)
            {
                SelectedFileInfo = (FileInfo)listBoxFile.SelectedItem;
                KiloMegaGiga(SelectedFileInfo);
                TXTIchooseYou(SelectedFileInfo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo("C:\\DirectorioPadre\\Directorio2\\Txt3.txt");
            using (StreamWriter sw = new StreamWriter(file.FullName))
            {
                do
                {
                    sw.Write("\nsilksong release date is in Febrero\nSorry Alvaro pero es la verdad");
                } while (((file.Length/1024)/1024) < 3);
                sw.Close();
            }
        }
    }
}
