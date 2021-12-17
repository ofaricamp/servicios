
namespace ArchivosEjercicio1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DirectoriBtn = new System.Windows.Forms.Button();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.ListBoxSubDir = new System.Windows.Forms.ListBox();
            this.listBoxFile = new System.Windows.Forms.ListBox();
            this.ErrorDirLabel = new System.Windows.Forms.Label();
            this.errorFileLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DirectoriBtn
            // 
            this.DirectoriBtn.Location = new System.Drawing.Point(426, 37);
            this.DirectoriBtn.Name = "DirectoriBtn";
            this.DirectoriBtn.Size = new System.Drawing.Size(75, 20);
            this.DirectoriBtn.TabIndex = 0;
            this.DirectoriBtn.Text = "Directory";
            this.DirectoriBtn.UseVisualStyleBackColor = true;
            this.DirectoriBtn.Click += new System.EventHandler(this.DirectoriBtn_Click);
            // 
            // textBoxDir
            // 
            this.textBoxDir.Location = new System.Drawing.Point(126, 37);
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.Size = new System.Drawing.Size(294, 20);
            this.textBoxDir.TabIndex = 1;
            // 
            // ListBoxSubDir
            // 
            this.ListBoxSubDir.FormattingEnabled = true;
            this.ListBoxSubDir.Location = new System.Drawing.Point(57, 63);
            this.ListBoxSubDir.Name = "ListBoxSubDir";
            this.ListBoxSubDir.Size = new System.Drawing.Size(246, 303);
            this.ListBoxSubDir.TabIndex = 2;
            this.ListBoxSubDir.SelectedValueChanged += new System.EventHandler(this.ListBoxSubDir_SelectedValueChanged);
            // 
            // listBoxFile
            // 
            this.listBoxFile.FormattingEnabled = true;
            this.listBoxFile.Location = new System.Drawing.Point(339, 63);
            this.listBoxFile.Name = "listBoxFile";
            this.listBoxFile.Size = new System.Drawing.Size(254, 303);
            this.listBoxFile.TabIndex = 3;
            this.listBoxFile.SelectedValueChanged += new System.EventHandler(this.listBoxFile_SelectedValueChanged);
            // 
            // ErrorDirLabel
            // 
            this.ErrorDirLabel.AutoSize = true;
            this.ErrorDirLabel.Location = new System.Drawing.Point(179, 386);
            this.ErrorDirLabel.Name = "ErrorDirLabel";
            this.ErrorDirLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorDirLabel.TabIndex = 5;
            // 
            // errorFileLabel
            // 
            this.errorFileLabel.AutoSize = true;
            this.errorFileLabel.Location = new System.Drawing.Point(455, 386);
            this.errorFileLabel.Name = "errorFileLabel";
            this.errorFileLabel.Size = new System.Drawing.Size(0, 13);
            this.errorFileLabel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ruta Del Directorio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "SubDirectorios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ficheros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Directorio Actual:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 14;
            this.button1.Text = "Silksong";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.DirectoriBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.errorFileLabel);
            this.Controls.Add(this.ErrorDirLabel);
            this.Controls.Add(this.listBoxFile);
            this.Controls.Add(this.ListBoxSubDir);
            this.Controls.Add(this.textBoxDir);
            this.Controls.Add(this.DirectoriBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ejercicio 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DirectoriBtn;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.ListBox ListBoxSubDir;
        private System.Windows.Forms.ListBox listBoxFile;
        private System.Windows.Forms.Label ErrorDirLabel;
        private System.Windows.Forms.Label errorFileLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

