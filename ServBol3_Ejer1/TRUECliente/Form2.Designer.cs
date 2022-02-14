
namespace TRUECliente
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.Serverbtn = new System.Windows.Forms.Button();
            this.Puertotxt = new System.Windows.Forms.TextBox();
            this.IPtxt = new System.Windows.Forms.TextBox();
            this.Puertolbl = new System.Windows.Forms.Label();
            this.Iplbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Serverbtn
            // 
            this.Serverbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Serverbtn.Location = new System.Drawing.Point(23, 99);
            this.Serverbtn.Name = "Serverbtn";
            this.Serverbtn.Size = new System.Drawing.Size(75, 23);
            this.Serverbtn.TabIndex = 15;
            this.Serverbtn.Text = "Apply";
            this.Serverbtn.UseVisualStyleBackColor = true;
            this.Serverbtn.Click += new System.EventHandler(this.Serverbtn_Click);
            // 
            // Puertotxt
            // 
            this.Puertotxt.Location = new System.Drawing.Point(12, 73);
            this.Puertotxt.Name = "Puertotxt";
            this.Puertotxt.Size = new System.Drawing.Size(100, 20);
            this.Puertotxt.TabIndex = 14;
            this.Puertotxt.Text = "10823";
            // 
            // IPtxt
            // 
            this.IPtxt.Location = new System.Drawing.Point(12, 24);
            this.IPtxt.Name = "IPtxt";
            this.IPtxt.Size = new System.Drawing.Size(100, 20);
            this.IPtxt.TabIndex = 13;
            this.IPtxt.Text = "192.168.22.31";
            // 
            // Puertolbl
            // 
            this.Puertolbl.AutoSize = true;
            this.Puertolbl.Location = new System.Drawing.Point(9, 56);
            this.Puertolbl.Name = "Puertolbl";
            this.Puertolbl.Size = new System.Drawing.Size(38, 13);
            this.Puertolbl.TabIndex = 12;
            this.Puertolbl.Text = "Puerto";
            // 
            // Iplbl
            // 
            this.Iplbl.AutoSize = true;
            this.Iplbl.Location = new System.Drawing.Point(9, 8);
            this.Iplbl.Name = "Iplbl";
            this.Iplbl.Size = new System.Drawing.Size(17, 13);
            this.Iplbl.TabIndex = 11;
            this.Iplbl.Text = "IP";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 225);
            this.Controls.Add(this.Serverbtn);
            this.Controls.Add(this.Puertotxt);
            this.Controls.Add(this.IPtxt);
            this.Controls.Add(this.Puertolbl);
            this.Controls.Add(this.Iplbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Serverbtn;
        private System.Windows.Forms.Label Puertolbl;
        private System.Windows.Forms.Label Iplbl;
        public System.Windows.Forms.TextBox Puertotxt;
        public System.Windows.Forms.TextBox IPtxt;
    }
}