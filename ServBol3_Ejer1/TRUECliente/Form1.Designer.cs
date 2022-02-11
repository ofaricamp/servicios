
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
            this.Serverbtn = new System.Windows.Forms.Button();
            this.Puertotxt = new System.Windows.Forms.TextBox();
            this.IPtxt = new System.Windows.Forms.TextBox();
            this.Puertolbl = new System.Windows.Forms.Label();
            this.Iplbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Serverbtn
            // 
            this.Serverbtn.Location = new System.Drawing.Point(23, 100);
            this.Serverbtn.Name = "Serverbtn";
            this.Serverbtn.Size = new System.Drawing.Size(75, 23);
            this.Serverbtn.TabIndex = 9;
            this.Serverbtn.Text = "Apply";
            this.Serverbtn.UseVisualStyleBackColor = true;
            this.Serverbtn.Click += new System.EventHandler(this.Serverbtn_Click);
            // 
            // Puertotxt
            // 
            this.Puertotxt.Location = new System.Drawing.Point(12, 74);
            this.Puertotxt.Name = "Puertotxt";
            this.Puertotxt.Size = new System.Drawing.Size(100, 20);
            this.Puertotxt.TabIndex = 8;
            this.Puertotxt.Text = "10823";
            // 
            // IPtxt
            // 
            this.IPtxt.Location = new System.Drawing.Point(12, 25);
            this.IPtxt.Name = "IPtxt";
            this.IPtxt.Size = new System.Drawing.Size(100, 20);
            this.IPtxt.TabIndex = 7;
            this.IPtxt.Text = "192.168.22.31";
            // 
            // Puertolbl
            // 
            this.Puertolbl.AutoSize = true;
            this.Puertolbl.Location = new System.Drawing.Point(9, 57);
            this.Puertolbl.Name = "Puertolbl";
            this.Puertolbl.Size = new System.Drawing.Size(38, 13);
            this.Puertolbl.TabIndex = 6;
            this.Puertolbl.Text = "Puerto";
            // 
            // Iplbl
            // 
            this.Iplbl.AutoSize = true;
            this.Iplbl.Location = new System.Drawing.Point(9, 9);
            this.Iplbl.Name = "Iplbl";
            this.Iplbl.Size = new System.Drawing.Size(17, 13);
            this.Iplbl.TabIndex = 5;
            this.Iplbl.Text = "IP";
            // 
            // Form1
            // 
            this.AcceptButton = this.Serverbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 157);
            this.Controls.Add(this.Serverbtn);
            this.Controls.Add(this.Puertotxt);
            this.Controls.Add(this.IPtxt);
            this.Controls.Add(this.Puertolbl);
            this.Controls.Add(this.Iplbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Serverbtn;
        private System.Windows.Forms.TextBox Puertotxt;
        private System.Windows.Forms.TextBox IPtxt;
        private System.Windows.Forms.Label Puertolbl;
        private System.Windows.Forms.Label Iplbl;
    }
}

