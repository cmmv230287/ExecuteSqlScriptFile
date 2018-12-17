namespace ExecuteSqlScriptFile.Desktop
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstArchivos = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbConexiones = new System.Windows.Forms.GroupBox();
            this.chkSeleccionarTodos = new System.Windows.Forms.CheckBox();
            this.chklstConexiones = new System.Windows.Forms.CheckedListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button4 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tscbPerfiles = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombrePerfil = new System.Windows.Forms.TextBox();
            this.gbNombrePerfil = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumSeleccionados = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbConexiones.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gbNombrePerfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(112, 12);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(199, 20);
            this.txtOrigen.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstArchivos);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtOrigen);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 164);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Origen de Archivos:";
            // 
            // lstArchivos
            // 
            this.lstArchivos.FormattingEnabled = true;
            this.lstArchivos.Location = new System.Drawing.Point(9, 44);
            this.lstArchivos.Name = "lstArchivos";
            this.lstArchivos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstArchivos.Size = new System.Drawing.Size(408, 95);
            this.lstArchivos.TabIndex = 4;
            this.lstArchivos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstArchivos_KeyUp);
            // 
            // button1
            // 
            this.button1.Image = global::ExecuteSqlScriptFile.Desktop.Properties.Resources.noun_441253_cc;
            this.button1.Location = new System.Drawing.Point(347, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 20);
            this.button2.TabIndex = 1;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbConexiones
            // 
            this.gbConexiones.Controls.Add(this.lblNumSeleccionados);
            this.gbConexiones.Controls.Add(this.label3);
            this.gbConexiones.Controls.Add(this.chkSeleccionarTodos);
            this.gbConexiones.Controls.Add(this.chklstConexiones);
            this.gbConexiones.Location = new System.Drawing.Point(12, 275);
            this.gbConexiones.Name = "gbConexiones";
            this.gbConexiones.Size = new System.Drawing.Size(427, 164);
            this.gbConexiones.TabIndex = 5;
            this.gbConexiones.TabStop = false;
            this.gbConexiones.Text = "Conexiones";
            // 
            // chkSeleccionarTodos
            // 
            this.chkSeleccionarTodos.AutoSize = true;
            this.chkSeleccionarTodos.Location = new System.Drawing.Point(11, 15);
            this.chkSeleccionarTodos.Name = "chkSeleccionarTodos";
            this.chkSeleccionarTodos.Size = new System.Drawing.Size(115, 17);
            this.chkSeleccionarTodos.TabIndex = 7;
            this.chkSeleccionarTodos.Text = "Seleccionar Todos";
            this.chkSeleccionarTodos.UseVisualStyleBackColor = true;
            this.chkSeleccionarTodos.CheckedChanged += new System.EventHandler(this.chkSeleccionarTodos_CheckedChanged);
            // 
            // chklstConexiones
            // 
            this.chklstConexiones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chklstConexiones.CheckOnClick = true;
            this.chklstConexiones.FormattingEnabled = true;
            this.chklstConexiones.Location = new System.Drawing.Point(9, 34);
            this.chklstConexiones.Name = "chklstConexiones";
            this.chklstConexiones.Size = new System.Drawing.Size(408, 109);
            this.chklstConexiones.TabIndex = 6;
            this.chklstConexiones.SelectedIndexChanged += new System.EventHandler(this.chklstConexiones_SelectedIndexChanged);
            // 
            // lstLog
            // 
            this.lstLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLog.FormattingEnabled = true;
            this.lstLog.HorizontalScrollbar = true;
            this.lstLog.Location = new System.Drawing.Point(6, 19);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(373, 342);
            this.lstLog.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.lstLog);
            this.groupBox2.Location = new System.Drawing.Point(455, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 391);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(7, 372);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Vaciar Log";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(89, 454);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.tscbPerfiles,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(852, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::ExecuteSqlScriptFile.Desktop.Properties.Resources.noun_1509568_cc;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(53, 22);
            this.toolStripButton1.Text = "Abrir";
            this.toolStripButton1.ToolTipText = "Abrir Configuracion";
            this.toolStripButton1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::ExecuteSqlScriptFile.Desktop.Properties.Resources.noun_460746_cc;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(69, 22);
            this.toolStripButton2.Text = "Guardar";
            this.toolStripButton2.ToolTipText = "Guardar Configuracion Actual";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::ExecuteSqlScriptFile.Desktop.Properties.Resources.noun_1759710_cc;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(62, 22);
            this.toolStripButton3.Text = "Nuevo";
            this.toolStripButton3.ToolTipText = "Nueva Configuracion";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // tscbPerfiles
            // 
            this.tscbPerfiles.Name = "tscbPerfiles";
            this.tscbPerfiles.Size = new System.Drawing.Size(121, 25);
            this.tscbPerfiles.SelectedIndexChanged += new System.EventHandler(this.tscbPerfiles_SelectedIndexChanged);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::ExecuteSqlScriptFile.Desktop.Properties.Resources.noun_629832_cc;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(130, 22);
            this.toolStripButton4.Text = "Administrar Perfiles";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre Perfil:";
            // 
            // txtNombrePerfil
            // 
            this.txtNombrePerfil.Location = new System.Drawing.Point(90, 20);
            this.txtNombrePerfil.Name = "txtNombrePerfil";
            this.txtNombrePerfil.Size = new System.Drawing.Size(327, 20);
            this.txtNombrePerfil.TabIndex = 16;
            // 
            // gbNombrePerfil
            // 
            this.gbNombrePerfil.Controls.Add(this.txtNombrePerfil);
            this.gbNombrePerfil.Controls.Add(this.label2);
            this.gbNombrePerfil.Location = new System.Drawing.Point(12, 48);
            this.gbNombrePerfil.Name = "gbNombrePerfil";
            this.gbNombrePerfil.Size = new System.Drawing.Size(427, 52);
            this.gbNombrePerfil.TabIndex = 18;
            this.gbNombrePerfil.TabStop = false;
            // 
            // button3
            // 
            this.button3.Image = global::ExecuteSqlScriptFile.Desktop.Properties.Resources.noun_441253_cc;
            this.button3.Location = new System.Drawing.Point(12, 454);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Ejecutar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Seleccionados :";
            // 
            // lblNumSeleccionados
            // 
            this.lblNumSeleccionados.AutoSize = true;
            this.lblNumSeleccionados.Location = new System.Drawing.Point(228, 16);
            this.lblNumSeleccionados.Name = "lblNumSeleccionados";
            this.lblNumSeleccionados.Size = new System.Drawing.Size(13, 13);
            this.lblNumSeleccionados.TabIndex = 19;
            this.lblNumSeleccionados.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 493);
            this.Controls.Add(this.gbNombrePerfil);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbConexiones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejecutar Scripts Sql Server";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbConexiones.ResumeLayout(false);
            this.gbConexiones.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbNombrePerfil.ResumeLayout(false);
            this.gbNombrePerfil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstArchivos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbConexiones;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckedListBox chklstConexiones;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombrePerfil;
        private System.Windows.Forms.GroupBox gbNombrePerfil;
        private System.Windows.Forms.ToolStripComboBox tscbPerfiles;
        private System.Windows.Forms.CheckBox chkSeleccionarTodos;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblNumSeleccionados;
        private System.Windows.Forms.Label label3;
    }
}

