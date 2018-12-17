using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteSqlScriptFile.Desktop.Entities
{
    public class Conexion
    {
        public string server { get; set; }
        public string db { get; set; }
        public string zf { get; set; }
        public string user { get; set; }
        public string psw { get; set; }
        public bool integrada { get; set; }
        public bool ignore { get; set; }
    }
}
