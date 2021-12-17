using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiciosEjercicio2
{
    public partial class Form1 : Form
    {
        private readonly object l;
        List<FileInfo> archivo = new List<FileInfo>();
        string[] extensiones = { ".txt", ".doc", ".docx", ".docm",".odt",".pdf",".rtf",".csv",".xls",".xlsx",
                                ".xlsm",".ods",".pps",".ppt",".ppsx",".pptx",".ppsm",".pptm",".potx",".odp"};
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("C:\\yamchaMuerto.jpg");
        }

        public void BuscaDirectorio(string contenidoTextBox)
        {
            DirectoryInfo info;
            string directorio = Environment.ExpandEnvironmentVariables(contenidoTextBox);
            //Directory.SetCurrentDirectory(directorio);
            Directory.SetCurrentDirectory("C:\\DirectorioPadre\\Directorio2");
            info = new DirectoryInfo(Directory.GetCurrentDirectory());
            foreach (FileInfo archivos in info.GetFiles())
            {
                for (int i = 0; i < extensiones.Length; i++)
                {
                    if (archivos.Name.EndsWith(extensiones[i]))
                    {
                        archivo.Add(archivos);
                        contador++;
                    }
                }
            }
            label3.Text = contador.ToString();
        }

        public void BuscadorDePalabras(string ruta, string palabra)
        {

            // FileInfo archivo = (FileInfo)file;
            string contenedor = "";
            double numeroDeVeces = 1;
            //while (true)
            //{
            //lock (l)
            //{
            //  if (true)
            // {
            using (StreamReader reader = new StreamReader(ruta))
            {
                while ((contenedor = reader.ReadLine()) != null)
                {
                    label3.Text = numeroDeVeces.ToString();
                   // numeroDeVeces++;
                        System.Diagnostics.Debug.WriteLine(numeroDeVeces);
                    if (contenedor.Contains(palabra))
                    {
                        numeroDeVeces++;

                    }
                }
            }
            // }
            //}
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BuscadorDePalabras("C:\\DirectorioPadre\\Directorio2\\Txt3.txt", "Alvaro");
        }
    }
}
