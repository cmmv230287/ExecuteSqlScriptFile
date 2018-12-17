using ExecuteSqlScriptFile.Desktop.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExecuteSqlScriptFile.Desktop.Clases
{
    public class Util
    {
        public static string FolderPathPerfil
        {
            get { return AppDomain.CurrentDomain.BaseDirectory + $"{NombreFolderPerfiles}\\"; }
        }

        public static string TipoArchivoConfiguracion
        {
            get { return ConfigurationManager.AppSettings["TipoArchivoConfiguracion"]; }
        }
        public static string NombreFolderPerfiles
        {
            get { return ConfigurationManager.AppSettings["NombreFolderPerfiles"]; }
        }
        public static string TipoArchivoScripts
        {
            get { return ConfigurationManager.AppSettings["TipoArchivoScripts"]; }
        }
        public static void GetFilesFromOrigen(ListBox lstArchivos, string path, string fileTypePattern)
        {
            lstArchivos.Items.Clear();
            string[] filename = null;
            string temp = null;
            int indice = 0;

            if (!string.IsNullOrEmpty(path))
            {
                foreach (string file in System.IO.Directory.GetFiles(path, fileTypePattern))
                {
                    filename = file.Split(new char[] { '\\' });
                    temp = filename[filename.Length - 1];
                    ComboboxItem item = new ComboboxItem();
                    item.Text = temp.Replace($".{TipoArchivoConfiguracion}", "");
                    item.Value = file;
                    lstArchivos.Items.Add(item);
                    indice++;
                }
            }
        }
        public static void GetFilesFromOrigen(ToolStripComboBox tscbPerfiles, string path, string fileTypePattern)
        {
            tscbPerfiles.Items.Clear();
            string[] filename = null;
            string temp = null;
            int indice = 0;

            foreach (string file in System.IO.Directory.GetFiles(path, fileTypePattern))
            {
                filename = file.Split(new char[] { '\\' });
                temp = filename[filename.Length - 1];
                ComboboxItem item = new ComboboxItem();
                item.Text = temp.Replace($".{TipoArchivoConfiguracion}", "");
                item.Value = file;
                tscbPerfiles.Items.Add(item);
                indice++;
            }
        }

        public static void SetCheckedAll(CheckedListBox chklstConexiones, CheckBox chkSeleccionarTodos)
        {
            if (Math.Abs(chklstConexiones.Items.Count - chklstConexiones.CheckedItems.Count) != chklstConexiones.Items.Count)
            {
                chkSeleccionarTodos.CheckState = CheckState.Indeterminate;
                if (Math.Abs(chklstConexiones.Items.Count - chklstConexiones.CheckedItems.Count) == 0)
                {
                    chkSeleccionarTodos.CheckState = CheckState.Checked;
                }
            }
            else
            {
                chkSeleccionarTodos.CheckState = CheckState.Unchecked;
            }
        }
    }
}
