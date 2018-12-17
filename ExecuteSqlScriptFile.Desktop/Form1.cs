using ExecuteSqlScriptFile.Desktop.Entities;
using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExecuteSqlScriptFile.Desktop.Clases;
using ExecuteSqlScriptFile.Desktop.Forms;

namespace ExecuteSqlScriptFile.Desktop
{
    public partial class Form1 : Form
    {
        List<string> archios = null;
        ExecuteScriptSql sql = null;
        Configuracion conf = null;
        public static string FolderNamePerfil { get; set; }
        public string Ecoding { get; set; }
        public string baseconn
        {
            get { return "Data Source={0};Initial Catalog={1};User ID={2};Password={3};Connection Timeout=60; Connection Lifetime=600; Pooling=true; Min Pool Size=0; Max Pool Size=64;"; }
        }
        public string baseconnIntegrada
        {
            get { return "Data Source={0};Initial Catalog={1};Integrated Security=True;"; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtOrigen.Text = folderBrowserDialog1.SelectedPath;
                Util.GetFilesFromOrigen(lstArchivos, txtOrigen.Text, $"*.{Util.TipoArchivoScripts}");
            }
        }

        

        private void CargarConfiguracionDefault()
        {
            CargarConfiguracion(AppDomain.CurrentDomain.BaseDirectory + "Configuracion.json");
            if(!Directory.Exists(Util.FolderPathPerfil))
            {
                Directory.CreateDirectory(Util.FolderPathPerfil);
            }
            Util.GetFilesFromOrigen(tscbPerfiles, Util.FolderPathPerfil, $"*.{Util.TipoArchivoConfiguracion}");
        }
        private void CargarConfiguracionFromFile(string file)
        {
            CargarConfiguracion(file);
            txtNombrePerfil.Text = file.Split(new char[] { '\\' })[file.Split(new char[] { '\\' }).Length - 1].Replace($".{Util.TipoArchivoConfiguracion}", "");
        }
        private void CargarConfiguracion(string file)
        {
            chklstConexiones.Items.Clear();
            conf = new Configuracion();
            JavaScriptSerializer serialize = new JavaScriptSerializer();
            int indice = 0, contUnchechk = 0;
            using (StreamReader r = new StreamReader(file))
            {
                string json = r.ReadToEnd();
                conf = serialize.Deserialize<Configuracion>(json);
            }

            txtOrigen.Text = conf.paths[0];
            this.Ecoding = conf.encoding;

            foreach (Conexion con in conf.conexiones)
            {
                chklstConexiones.Items.Add(con.db);
                chklstConexiones.SetItemChecked(indice, !con.ignore);

                if (chklstConexiones.GetItemChecked(indice))
                {
                    contUnchechk++;
                }

                indice++;
            }

            Util.SetCheckedAll(chklstConexiones, chkSeleccionarTodos);
        }

        private void GuardarConfiguracion(string file)
        {
            conf = new Configuracion();
            Conexion conexion = new Conexion();
            JavaScriptSerializer serialize = new JavaScriptSerializer();
            int indice = 0;
            using (StreamReader r = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "Configuracion.json"))
            {
                string json = r.ReadToEnd();
                conf = serialize.Deserialize<Configuracion>(json);
            }

            conf.paths[0] = txtOrigen.Text;
            conf.encoding = this.Ecoding;

            foreach (string con in chklstConexiones.CheckedItems)
            {
                foreach(Conexion objcon in conf.conexiones)
                {
                    if(objcon.db == con)
                    {
                        objcon.ignore = false;
                    }
                }
            }

            File.WriteAllText(file, serialize.Serialize(conf));
        }

        private void Ejecutar()
        {
            sql = new ExecuteScriptSql(conf.encoding);
            List<string> mensajes = new List<string>();

            try
            {
                WriteLog("Ejecutando...\n");
                WriteLog("Este proceso puede tardar unos minutos...");
                WriteLog("----------------------------------------------------------------------------------------");
                mensajes = sql.ExecuteFilesScript(new List<string>(new[] { txtOrigen.Text }), getConexionesSeleccionadas(conf.conexiones));

                foreach (string msj in mensajes)
                {
                    WriteLog(msj + "\n");
                }

                string text = "con exito";

                if (mensajes.Contains("Error"))
                {
                    text = "con errores";
                }

                WriteLog("----------------------------------------------------------------------------------------");
                WriteLog(string.Format("El proceso de ejecucion termino {0}", text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            } 
        }
        private List<string> buildConexion(List<Conexion> conexiones)
        {
            List<string> res = new List<string>();
            foreach (Conexion con in conexiones)
            {
                if (!con.ignore)
                {
                    if (con.integrada)
                    {
                        res.Add(string.Format(baseconnIntegrada, con.server, con.db));
                    }
                    else
                    {
                        res.Add(string.Format(baseconn, con.server, con.db, con.user, con.psw));
                    }
                }
            }

            return res;
        }

        private List<string> getConexionesSeleccionadas(List<Conexion> conexiones)
        {
            List<Conexion> res = new List<Conexion>();
            Conexion conexion = new Conexion();

            foreach (string con in chklstConexiones.CheckedItems)
            {
                conexion = conexiones.Find(ele => ele.db == con);
                conexion.ignore = false;
                res.Add(conexion);
            }

            return buildConexion(res);
        }

        private void WriteLog(string mesaje)
        {
            lstLog.Items.Add(mesaje);
            lstLog.Update();
        }

        private void lstArchivos_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 46 && lstArchivos.SelectedItems.Count > 0)
            {
                foreach(int item in lstArchivos.SelectedIndices)
                {
                    lstArchivos.Items.RemoveAt(item);
                }
                lstArchivos.Update();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Util.GetFilesFromOrigen(lstArchivos, txtOrigen.Text, $"*.{Util.TipoArchivoScripts}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ejecutar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = $"Text Files (.{Util.TipoArchivoConfiguracion})|*.{Util.TipoArchivoConfiguracion}|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    CargarConfiguracionFromFile(openFileDialog1.FileName);
                    Util.GetFilesFromOrigen(lstArchivos, txtOrigen.Text, $"*.{Util.TipoArchivoScripts}");
                    this.Text = "Ejecutar Scripts Sql Server - " + openFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al cargar configuracion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarConfiguracionDefault();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string ArchivoActual = null;
            if (string.IsNullOrEmpty(txtNombrePerfil.Text))
            {
                MessageBox.Show("Debe colocarle un nombre al perfil", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ArchivoActual = Util.FolderPathPerfil + txtNombrePerfil.Text + $".{Util.TipoArchivoConfiguracion}";
                GuardarConfiguracion(ArchivoActual);
                Util.GetFilesFromOrigen(tscbPerfiles, Util.FolderPathPerfil, $"*.{Util.TipoArchivoConfiguracion}");

                if (File.Exists(ArchivoActual))
                {
                    MessageBox.Show("Archivo Guardado con exito !!!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el archivo, favor verifique", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                /*saveFileDialog1.Filter = "Text Files (.json)|*.json|All Files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    GuardarConfiguracion(saveFileDialog1.FileName);

                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        MessageBox.Show("Archivo Guardado con exito !!!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar el archivo, favor verifique", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }*/
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            CargarConfiguracionDefault();
            lstLog.Items.Clear();
            lstArchivos.Items.Clear();
            txtNombrePerfil.Clear();
            countCheckedIndex();
        }

        private void tscbPerfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string archivopath = ((ComboboxItem)tscbPerfiles.SelectedItem).Value;
            string Archivo = ((ComboboxItem)tscbPerfiles.SelectedItem).Text;
            CargarConfiguracionFromFile(archivopath);
            Util.GetFilesFromOrigen(lstArchivos, txtOrigen.Text, $"*.{Util.TipoArchivoScripts}");
            this.Text = "Ejecutar Scripts Sql Server - " + Archivo;

        }

        private void chkSeleccionarTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeleccionarTodos.CheckState != CheckState.Indeterminate)
            {
                chkSeleccionarTodos.Text = (chkSeleccionarTodos.Checked) ? "Deseleccionar Todos" : "Seleccionar Todos";

                for (int i = 0; i < chklstConexiones.Items.Count; i++)
                {
                    chklstConexiones.SetItemChecked(i, chkSeleccionarTodos.Checked);
                }
            }

            countCheckedIndex();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FrmPerfiles frm = new FrmPerfiles();
            frm.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Util.GetFilesFromOrigen(tscbPerfiles, Util.FolderPathPerfil, $"*.{Util.TipoArchivoConfiguracion}");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lstLog.Items.Clear();
        }

        private void chklstConexiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Util.SetCheckedAll(chklstConexiones, chkSeleccionarTodos);
            countCheckedIndex();
        }

        private void countCheckedIndex()
        {
            lblNumSeleccionados.Text = chklstConexiones.CheckedIndices.Count.ToString();
        }
    }
}
