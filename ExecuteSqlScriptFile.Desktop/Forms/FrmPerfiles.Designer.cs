namespace ExecuteSqlScriptFile.Desktop.Forms
{
    partial class FrmPerfiles
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
            this.lstPerfiles = new System.Windows.Forms.ListBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lstPerfiles
            // 
            this.lstPerfiles.FormattingEnabled = true;
            this.lstPerfiles.Location = new System.Drawing.Point(12, 12);
            this.lstPerfiles.Name = "lstPerfiles";
            this.lstPerfiles.Size = new System.Drawing.Size(155, 121);
            this.lstPerfiles.TabIndex = 0;
            this.lstPerfiles.SelectedIndexChanged += new System.EventHandler(this.lstPerfiles_SelectedIndexChanged);
            this.lstPerfiles.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstPerfiles_KeyUp);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(9, 136);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Elimiar Seleccion";
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FrmPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 169);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lstPerfiles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPerfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Perfiles";
            this.Load += new System.EventHandler(this.FrmPerfiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPerfiles;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}