
namespace ServBol3_Ejer2
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
            this.Addbtn = new System.Windows.Forms.Button();
            this.Puertotxt = new System.Windows.Forms.TextBox();
            this.Iptxt = new System.Windows.Forms.TextBox();
            this.Listbtn = new System.Windows.Forms.Button();
            this.Usertxt = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Listtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(510, 43);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(75, 23);
            this.Addbtn.TabIndex = 0;
            this.Addbtn.Text = "ADD";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Puertotxt
            // 
            this.Puertotxt.Location = new System.Drawing.Point(289, 27);
            this.Puertotxt.Name = "Puertotxt";
            this.Puertotxt.Size = new System.Drawing.Size(78, 20);
            this.Puertotxt.TabIndex = 1;
            // 
            // Iptxt
            // 
            this.Iptxt.Location = new System.Drawing.Point(7, 27);
            this.Iptxt.Name = "Iptxt";
            this.Iptxt.Size = new System.Drawing.Size(276, 20);
            this.Iptxt.TabIndex = 2;
            // 
            // Listbtn
            // 
            this.Listbtn.Location = new System.Drawing.Point(417, 43);
            this.Listbtn.Name = "Listbtn";
            this.Listbtn.Size = new System.Drawing.Size(75, 23);
            this.Listbtn.TabIndex = 3;
            this.Listbtn.Text = "LIST";
            this.Listbtn.UseVisualStyleBackColor = true;
            this.Listbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Usertxt
            // 
            this.Usertxt.Location = new System.Drawing.Point(7, 74);
            this.Usertxt.Name = "Usertxt";
            this.Usertxt.Size = new System.Drawing.Size(274, 20);
            this.Usertxt.TabIndex = 4;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(7, 8);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(20, 13);
            this.lblIP.TabIndex = 5;
            this.lblIP.Text = "IP:";
            // 
            // lblPuerto
            // 
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Location = new System.Drawing.Point(290, 8);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(41, 13);
            this.lblPuerto.TabIndex = 6;
            this.lblPuerto.Text = "Puerto:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(7, 53);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Comandos";
            // 
            // Listtxt
            // 
            this.Listtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Listtxt.Location = new System.Drawing.Point(7, 114);
            this.Listtxt.Multiline = true;
            this.Listtxt.Name = "Listtxt";
            this.Listtxt.Size = new System.Drawing.Size(573, 132);
            this.Listtxt.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 266);
            this.Controls.Add(this.Listtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPuerto);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.Usertxt);
            this.Controls.Add(this.Listbtn);
            this.Controls.Add(this.Iptxt);
            this.Controls.Add(this.Puertotxt);
            this.Controls.Add(this.Addbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.TextBox Puertotxt;
        private System.Windows.Forms.TextBox Iptxt;
        private System.Windows.Forms.Button Listbtn;
        private System.Windows.Forms.TextBox Usertxt;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Listtxt;
    }
}

