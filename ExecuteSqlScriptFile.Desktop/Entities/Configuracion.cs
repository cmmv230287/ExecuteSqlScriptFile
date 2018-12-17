using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteSqlScriptFile.Desktop.Entities
{
    public class Configuracion
    {
        public List<string> paths { get; set; }
        public string encoding { get; set; }
        public List<Conexion> conexiones { get; set; }
    }
}
