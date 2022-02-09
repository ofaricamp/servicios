
namespace ServBol3_Ejer1Cliente
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
            this.Iplbl = new System.Windows.Forms.Label();
            this.Puertolbl = new System.Windows.Forms.Label();
            this.IPtxt = new System.Windows.Forms.TextBox();
            this.Puertotxt = new System.Windows.Forms.TextBox();
            this.Serverbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Iplbl
            // 
            this.Iplbl.AutoSize = true;
            this.Iplbl.Location = new System.Drawing.Point(13, 13);
            this.Iplbl.Name = "Iplbl";
            this.Iplbl.Size = new System.Drawing.Size(17, 13);
            this.Iplbl.TabIndex = 0;
            this.Iplbl.Text = "IP";
            this.Iplbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Puertolbl
            // 
            this.Puertolbl.AutoSize = true;
            this.Puertolbl.Location = new System.Drawing.Point(13, 61);
            this.Puertolbl.Name = "Puertolbl";
            this.Puertolbl.Size = new System.Drawing.Size(38, 13);
            this.Puertolbl.TabIndex = 1;
            this.Puertolbl.Text = "Puerto";
            this.Puertolbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // IPtxt
            // 
            this.IPtxt.Location = new System.Drawing.Point(16, 29);
            this.IPtxt.Name = "IPtxt";
            this.IPtxt.Size = new System.Drawing.Size(100, 20);
            this.IPtxt.TabIndex = 2;
            this.IPtxt.Text = "192.168.22.31";
            // 
            // Puertotxt
            // 
            this.Puertotxt.Location = new System.Drawing.Point(16, 78);
            this.Puertotxt.Name = "Puertotxt";
            this.Puertotxt.Size = new System.Drawing.Size(100, 20);
            this.Puertotxt.TabIndex = 3;
            this.Puertotxt.Text = "10823";
            // 
            // Serverbtn
            // 
            this.Serverbtn.Location = new System.Drawing.Point(27, 104);
            this.Serverbtn.Name = "Serverbtn";
            this.Serverbtn.Size = new System.Drawing.Size(75, 23);
            this.Serverbtn.TabIndex = 4;
            this.Serverbtn.Text = "button1";
            this.Serverbtn.UseVisualStyleBackColor = true;
            this.Serverbtn.Visible = false;
            this.Serverbtn.Click += new System.EventHandler(this.Serverbtn_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.Serverbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 139);
            this.Controls.Add(this.Serverbtn);
            this.Controls.Add(this.Puertotxt);
            this.Controls.Add(this.IPtxt);
            this.Controls.Add(this.Puertolbl);
            this.Controls.Add(this.Iplbl);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Iplbl;
        private System.Windows.Forms.Label Puertolbl;
        private System.Windows.Forms.TextBox IPtxt;
        private System.Windows.Forms.TextBox Puertotxt;
        private System.Windows.Forms.Button Serverbtn;
    }
}