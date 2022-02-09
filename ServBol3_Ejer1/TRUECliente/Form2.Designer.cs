
namespace TRUECliente
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Resultlbl = new System.Windows.Forms.Label();
            this.Apagarbtn = new System.Windows.Forms.Button();
            this.Todobtn = new System.Windows.Forms.Button();
            this.Fechabtn = new System.Windows.Forms.Button();
            this.Horabtn = new System.Windows.Forms.Button();
            this.Settingbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Resultlbl
            // 
            this.Resultlbl.AutoSize = true;
            this.Resultlbl.Location = new System.Drawing.Point(7, 47);
            this.Resultlbl.Name = "Resultlbl";
            this.Resultlbl.Size = new System.Drawing.Size(73, 13);
            this.Resultlbl.TabIndex = 9;
            this.Resultlbl.Text = "RESULTADO";
            // 
            // Apagarbtn
            // 
            this.Apagarbtn.Location = new System.Drawing.Point(133, 95);
            this.Apagarbtn.Name = "Apagarbtn";
            this.Apagarbtn.Size = new System.Drawing.Size(75, 23);
            this.Apagarbtn.TabIndex = 8;
            this.Apagarbtn.Text = "APAGAR";
            this.Apagarbtn.UseVisualStyleBackColor = true;
            this.Apagarbtn.Click += new System.EventHandler(this.Apagarbtn_Click);
            // 
            // Todobtn
            // 
            this.Todobtn.Location = new System.Drawing.Point(133, 66);
            this.Todobtn.Name = "Todobtn";
            this.Todobtn.Size = new System.Drawing.Size(75, 23);
            this.Todobtn.TabIndex = 7;
            this.Todobtn.Text = "TODO";
            this.Todobtn.UseVisualStyleBackColor = true;
            this.Todobtn.Click += new System.EventHandler(this.Todobtn_Click);
            // 
            // Fechabtn
            // 
            this.Fechabtn.Location = new System.Drawing.Point(133, 37);
            this.Fechabtn.Name = "Fechabtn";
            this.Fechabtn.Size = new System.Drawing.Size(75, 23);
            this.Fechabtn.TabIndex = 6;
            this.Fechabtn.Text = "FECHA";
            this.Fechabtn.UseVisualStyleBackColor = true;
            this.Fechabtn.Click += new System.EventHandler(this.Fechabtn_Click);
            // 
            // Horabtn
            // 
            this.Horabtn.Location = new System.Drawing.Point(133, 8);
            this.Horabtn.Name = "Horabtn";
            this.Horabtn.Size = new System.Drawing.Size(75, 23);
            this.Horabtn.TabIndex = 5;
            this.Horabtn.Text = "HORA";
            this.Horabtn.UseVisualStyleBackColor = true;
            this.Horabtn.Click += new System.EventHandler(this.Horabtn_Click);
            // 
            // Settingbtn
            // 
            this.Settingbtn.Location = new System.Drawing.Point(52, 118);
            this.Settingbtn.Name = "Settingbtn";
            this.Settingbtn.Size = new System.Drawing.Size(75, 23);
            this.Settingbtn.TabIndex = 10;
            this.Settingbtn.Text = "Settings";
            this.Settingbtn.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 156);
            this.Controls.Add(this.Settingbtn);
            this.Controls.Add(this.Resultlbl);
            this.Controls.Add(this.Apagarbtn);
            this.Controls.Add(this.Todobtn);
            this.Controls.Add(this.Fechabtn);
            this.Controls.Add(this.Horabtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Resultlbl;
        private System.Windows.Forms.Button Apagarbtn;
        private System.Windows.Forms.Button Todobtn;
        private System.Windows.Forms.Button Fechabtn;
        private System.Windows.Forms.Button Horabtn;
        private System.Windows.Forms.Button Settingbtn;
    }
}