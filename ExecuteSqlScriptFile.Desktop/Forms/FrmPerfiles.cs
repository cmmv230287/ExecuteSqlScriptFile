using ExecuteSqlScriptFile.Desktop.Clases;
using ExecuteSqlScriptFile.Desktop.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExecuteSqlScriptFile.Desktop.Forms
{
    public partial class FrmPerfiles : Form
    {
        
        public FrmPerfiles()
        {
            InitializeComponent();
        }

        private void lstPerfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            linkLabel1.Visible = true;
        }

        private void FrmPerfiles_Load(object sender, EventArgs e)
        {
            Util.GetFilesFromOrigen(lstPerfiles, Util.FolderPathPerfil, $"*.{Util.TipoArchivoConfiguracion}");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void lstPerfiles_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46 && lstPerfiles.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Desea elimiar el perfil ?", "Confirmacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    foreach (int item in lstPerfiles.SelectedIndices)
                    {
                        File.Delete(((ComboboxItem)lstPerfiles.SelectedItems[0]).Value);
                    }
                    Util.GetFilesFromOrigen(lstPerfiles, Util.FolderPathPerfil, $"*.{Util.TipoArchivoConfiguracion}");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Desea elimiar el perfil ?", "Confirmacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                for (int i = 0; i <= lstPerfiles.SelectedItems.Count; i++)
                {
                    File.Delete(((ComboboxItem)lstPerfiles.SelectedItems[0]).Value);
                }

                Util.GetFilesFromOrigen(lstPerfiles, Util.FolderPathPerfil, $"*.{Util.TipoArchivoConfiguracion}");
            }
        }
    }
}
