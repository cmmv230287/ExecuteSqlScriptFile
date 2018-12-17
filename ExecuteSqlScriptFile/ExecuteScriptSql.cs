using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ExecuteSqlScriptFile
{
    public class ExecuteScriptSql
    {
        private Encoding encoding;
        public ExecuteScriptSql(string encoding)
        {
            this.encoding = Encoding.GetEncoding(encoding);
        }
        public ExecuteScriptSql()
        {
            this.encoding = Encoding.Default;
        }
        /// <summary>
        /// Ejecuta los script en archivos .sql que se encuentran en el path especificado
        /// </summary>
        /// <param name="path">directorio donde se encuetran los archivos .sql</param>
        /// <param name="conexion">cadena de conexion donde se correra el script sql</param>
        /// <returns></returns>
        private List<string> Execute(string path, string conexion)
        {
            List<string> result = new List<string>();
            List<string> files = Directory.GetFiles(path, "*.sql").ToList<string>();
            string database_name = Get_DataBaseName(conexion);
            //var sqlqueries = fileContent.Split(new[] { " GO " }, StringSplitOptions.RemoveEmptyEntries);

            SqlConnection con = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandTimeout = 120;//ConfigurationManager .AppSettings["CommandTimeOut"];
            try
            {
                cmd.Connection = con;
                cmd.Connection.Open();
            }
            catch (Exception ex)
            {
                result.Add(string.Format("Error al momento de abrir la conexion: {0}", ex.Message));
                EscribeLog(string.Format("Error al momento de abrir la conexion: {0}", ex.Message), database_name);
            }

            foreach (var file in files)
            {
                string fileContent = File.ReadAllText(file, encoding);

                var sqlqueries = fileContent.Split(new[] { "GO\r\n", "\r\nGO", "\nGO", "GO\n" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var query in sqlqueries)
                {
                    cmd.CommandText = query;
                    try
                    {
                        cmd.Transaction = cmd.Connection.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();
                        result.Add(string.Format("[{2} {3}]-El archivo {0} fue ejecutado con exito en {1}", file, database_name, DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString()));
                        EscribeLog(string.Format("[{2} {3}]-El archivo {0} fue ejecutado con exito en {1}", file, database_name, DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString()), database_name);
                    }
                    catch (Exception ex)
                    {
                        result.Add($"[{DateTime.Now.ToShortDateString()}]-Error al ejecutar {file} en {database_name}: {ex.Message}");
                        EscribeLog($"[{DateTime.Now.ToShortDateString()}]-Error al ejecutar {file} en {database_name}:{ex.Message}", database_name);
                        cmd.Transaction.Rollback();
                    }
                }
            }
            if (con.State != System.Data.ConnectionState.Closed)
            {
                con.Close();
            }
            return result;
        }
        /// <summary>
        /// Ejecuta los script en archivos .sql que se encuentran en uno o varios path especificados
        /// </summary>
        /// <param name="paths">Lista de path donde se encuentran los archivos .sql</param>
        /// <param name="conexion">caneda de conexion a la base de dato donde se ejecutaran los scripts sql</param>
        /// <returns></returns>
        public List<string> ExecuteFilesScript(List<string> paths, string conexion)
        {
            List<string> result = new List<string>();
            foreach(string path in paths)
            {
                result.AddRange(Execute(path, conexion));
            }
            return result;
        }
        /// <summary>
        /// Ejecuta los script en archivos .sql que se encuentran en uno o varios path especificados
        /// </summary>
        /// <param name="paths">Lista de path donde se encuentran los archivos .sql</param>
        /// <param name="conexiones">lista de canedas de conexion a las bases de datos donde se ejecutaran los scripts sql</param>
        /// <returns></returns>
        public List<string> ExecuteFilesScript(List<string> paths, List<string> conexiones)
        {
            List<string> result = new List<string>();

            foreach (string conexion in conexiones)
            {
                result.AddRange(ExecuteFilesScript(paths, conexion));
            }
            return result;
        }

        public void EscribeLog(string msg, string filename)
        {
            //string pathlog = @"C:\Temp\";
            //string pathlog = @"D:\home\site\wwwroot\ErrorLog\"; {DateTime.Now.ToShortDateString()}
            string pathlog = AppDomain.CurrentDomain.BaseDirectory + "/log/";
            if (!Directory.Exists(pathlog))
            {
                Directory.CreateDirectory(pathlog);
            }
            FileStream stream = new FileStream(pathlog + $"logmsg_{filename}_{DateTime.Now.ToShortDateString().Replace("/", "")}.log", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(msg);
            writer.Close();
        }

        private string Get_DataBaseName(string conexion)
        {
           string db = conexion.Split(new char[] { ';' })[1].Split(new char[] { '=' })[1];
            return db;
        }
    }
}
