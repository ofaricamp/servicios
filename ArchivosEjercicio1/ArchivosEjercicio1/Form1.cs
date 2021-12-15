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
        public Form1()
        {
            InitializeComponent();
        }

        public void vaciadoDeLabelsInformativos()
        {
            ErrorDirLabel.Text = "";
            errorFileLabel.Text = "";
        }
        public void RellenaListBox(string subdirectory)
        {
            try
            {
                ListBoxSubDir.Items.Clear();
                listBoxFile.Items.Clear();
                vaciadoDeLabelsInformativos();
                DirectoryInfo info;
                string entorno = Environment.ExpandEnvironmentVariables(subdirectory);
                if (Directory.Exists(subdirectory) || Directory.Exists(entorno))
                {
                    Directory.SetCurrentDirectory(entorno);
                }
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
            }
            catch (UnauthorizedAccessException unautex)
            {
                ErrorDirLabel.Text = "Acceso NO disponible";
            }
            catch (FileNotFoundException filex)
            {
                errorFileLabel.Text = $"The file was not found: {filex}";
            }
            catch (DirectoryNotFoundException direx)
            {
                ErrorDirLabel.Text = $"The directory was not found: {direx}";
            }
        }
        public void KiloMegaGiga(FileInfo file)
        {
            if (file.Length / 1024 < 1024)
            {
                label2.Text = $"Name: {file.Name}  Size: {file.Length / 1024} KB";
            }
            else if (((file.Length / 1024) / 1024) < 1024)
            {
                label2.Text = $"Name: {file.Name}  Size: {(file.Length / 1024) / 1024} MB";
            }
            else
            {
                label2.Text = $"Name: {file.Name}  Size: {((file.Length / 1024) / 1024) / 1024} GB";
            }
        }

        public void TXTIchooseYou(FileInfo file)
        {
            vaciadoDeLabelsInformativos();
            DialogResult dialogResult;
            if (file.Name.EndsWith(".txt"))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(file.Name))
                    {
                        contenidoTxt = reader.ReadToEnd();
                    }
                    LetsTryTogether.Text = contenidoTxt.ToString();
                    Form2 form2 = new Form2(contenidoTxt);
                    dialogResult = form2.ShowDialog();
                }
                catch (FileNotFoundException filex)
                {
                    errorFileLabel.Text = $"The file was not found: {filex}";
                }
                catch(DirectoryNotFoundException direx)
                {
                    ErrorDirLabel.Text = $"The directory was not found: {direx}";
                }
                catch(IOException ioex)
                {
                    errorFileLabel.Text = $"The file couldn´t be opened: {ioex}";
                }
                //errorFileLabel.Text = "hago algo no te preocupes";
            }
        }
        private void DirectoriBtn_Click(object sender, EventArgs e)
        {
            vaciadoDeLabelsInformativos();
            RellenaListBox(textBoxDir.Text.ToString());
        }

        private void ListBoxSubDir_SelectedValueChanged(object sender, EventArgs e)
        {
            vaciadoDeLabelsInformativos();
            if (ListBoxSubDir.SelectedItem != null)
            {
                RellenaListBox(ListBoxSubDir.SelectedItem.ToString());
            }
            else
            {
                ErrorDirLabel.Text = "Error Error Error";
            }
        }

        private void listBoxFile_SelectedValueChanged(object sender, EventArgs e)
        {
            vaciadoDeLabelsInformativos();
            if (listBoxFile.SelectedItem != null)
            {
                SelectedFileInfo = (FileInfo)listBoxFile.SelectedItem;
                KiloMegaGiga(SelectedFileInfo);
                TXTIchooseYou(SelectedFileInfo);
            }
            else
            {
                errorFileLabel.Text = "Error Error Error";
            }
        }
    }
}
