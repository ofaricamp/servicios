
namespace ServBol3_Ejer1Cliente
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
            this.Horabtn = new System.Windows.Forms.Button();
            this.Fechabtn = new System.Windows.Forms.Button();
            this.Todobtn = new System.Windows.Forms.Button();
            this.Apagarbtn = new System.Windows.Forms.Button();
            this.Resultlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Horabtn
            // 
            this.Horabtn.Location = new System.Drawing.Point(138, 47);
            this.Horabtn.Name = "Horabtn";
            this.Horabtn.Size = new System.Drawing.Size(75, 23);
            this.Horabtn.TabIndex = 0;
            this.Horabtn.Text = "HORA";
            this.Horabtn.UseVisualStyleBackColor = true;
            this.Horabtn.Click += new System.EventHandler(this.Horabtn_Click);
            // 
            // Fechabtn
            // 
            this.Fechabtn.Location = new System.Drawing.Point(138, 76);
            this.Fechabtn.Name = "Fechabtn";
            this.Fechabtn.Size = new System.Drawing.Size(75, 23);
            this.Fechabtn.TabIndex = 1;
            this.Fechabtn.Text = "FECHA";
            this.Fechabtn.UseVisualStyleBackColor = true;
            this.Fechabtn.Click += new System.EventHandler(this.Fechabtn_Click);
            // 
            // Todobtn
            // 
            this.Todobtn.Location = new System.Drawing.Point(138, 105);
            this.Todobtn.Name = "Todobtn";
            this.Todobtn.Size = new System.Drawing.Size(75, 23);
            this.Todobtn.TabIndex = 2;
            this.Todobtn.Text = "TODO";
            this.Todobtn.UseVisualStyleBackColor = true;
            this.Todobtn.Click += new System.EventHandler(this.Todobtn_Click);
            // 
            // Apagarbtn
            // 
            this.Apagarbtn.Location = new System.Drawing.Point(138, 134);
            this.Apagarbtn.Name = "Apagarbtn";
            this.Apagarbtn.Size = new System.Drawing.Size(75, 23);
            this.Apagarbtn.TabIndex = 3;
            this.Apagarbtn.Text = "APAGAR";
            this.Apagarbtn.UseVisualStyleBackColor = true;
            this.Apagarbtn.Click += new System.EventHandler(this.Apagarbtn_Click);
            // 
            // Resultlbl
            // 
            this.Resultlbl.AutoSize = true;
            this.Resultlbl.Location = new System.Drawing.Point(12, 86);
            this.Resultlbl.Name = "Resultlbl";
            this.Resultlbl.Size = new System.Drawing.Size(73, 13);
            this.Resultlbl.TabIndex = 4;
            this.Resultlbl.Text = "RESULTADO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 194);
            this.Controls.Add(this.Resultlbl);
            this.Controls.Add(this.Apagarbtn);
            this.Controls.Add(this.Todobtn);
            this.Controls.Add(this.Fechabtn);
            this.Controls.Add(this.Horabtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Horabtn;
        private System.Windows.Forms.Button Fechabtn;
        private System.Windows.Forms.Button Todobtn;
        private System.Windows.Forms.Button Apagarbtn;
        private System.Windows.Forms.Label Resultlbl;
    }
}

