
namespace TRUECliente
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
            this.Settingbtn = new System.Windows.Forms.Button();
            this.Resultlbl = new System.Windows.Forms.Label();
            this.Apagarbtn = new System.Windows.Forms.Button();
            this.Todobtn = new System.Windows.Forms.Button();
            this.Fechabtn = new System.Windows.Forms.Button();
            this.Horabtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Settingbtn
            // 
            this.Settingbtn.Location = new System.Drawing.Point(49, 114);
            this.Settingbtn.Name = "Settingbtn";
            this.Settingbtn.Size = new System.Drawing.Size(75, 23);
            this.Settingbtn.TabIndex = 16;
            this.Settingbtn.Text = "Settings";
            this.Settingbtn.UseVisualStyleBackColor = true;
            this.Settingbtn.Click += new System.EventHandler(this.Settingbtn_Click);
            // 
            // Resultlbl
            // 
            this.Resultlbl.AutoSize = true;
            this.Resultlbl.Location = new System.Drawing.Point(4, 43);
            this.Resultlbl.Name = "Resultlbl";
            this.Resultlbl.Size = new System.Drawing.Size(73, 13);
            this.Resultlbl.TabIndex = 15;
            this.Resultlbl.Text = "RESULTADO";
            // 
            // Apagarbtn
            // 
            this.Apagarbtn.Location = new System.Drawing.Point(130, 91);
            this.Apagarbtn.Name = "Apagarbtn";
            this.Apagarbtn.Size = new System.Drawing.Size(75, 23);
            this.Apagarbtn.TabIndex = 14;
            this.Apagarbtn.Text = "APAGAR";
            this.Apagarbtn.UseVisualStyleBackColor = true;
            this.Apagarbtn.Click += new System.EventHandler(this.Button_Click);
            // 
            // Todobtn
            // 
            this.Todobtn.Location = new System.Drawing.Point(130, 62);
            this.Todobtn.Name = "Todobtn";
            this.Todobtn.Size = new System.Drawing.Size(75, 23);
            this.Todobtn.TabIndex = 13;
            this.Todobtn.Text = "TODO";
            this.Todobtn.UseVisualStyleBackColor = true;
            this.Todobtn.Click += new System.EventHandler(this.Button_Click);
            // 
            // Fechabtn
            // 
            this.Fechabtn.Location = new System.Drawing.Point(130, 33);
            this.Fechabtn.Name = "Fechabtn";
            this.Fechabtn.Size = new System.Drawing.Size(75, 23);
            this.Fechabtn.TabIndex = 12;
            this.Fechabtn.Text = "FECHA";
            this.Fechabtn.UseVisualStyleBackColor = true;
            this.Fechabtn.Click += new System.EventHandler(this.Button_Click);
            // 
            // Horabtn
            // 
            this.Horabtn.Location = new System.Drawing.Point(130, 4);
            this.Horabtn.Name = "Horabtn";
            this.Horabtn.Size = new System.Drawing.Size(75, 23);
            this.Horabtn.TabIndex = 11;
            this.Horabtn.Text = "HORA";
            this.Horabtn.UseVisualStyleBackColor = true;
            this.Horabtn.Click += new System.EventHandler(this.Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 169);
            this.Controls.Add(this.Settingbtn);
            this.Controls.Add(this.Resultlbl);
            this.Controls.Add(this.Apagarbtn);
            this.Controls.Add(this.Todobtn);
            this.Controls.Add(this.Fechabtn);
            this.Controls.Add(this.Horabtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comandos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Settingbtn;
        private System.Windows.Forms.Label Resultlbl;
        private System.Windows.Forms.Button Apagarbtn;
        private System.Windows.Forms.Button Todobtn;
        private System.Windows.Forms.Button Fechabtn;
        private System.Windows.Forms.Button Horabtn;
    }
}

