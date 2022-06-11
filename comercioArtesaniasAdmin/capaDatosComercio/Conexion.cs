using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace capaDatosComercio
{
    public class Conexion
    {
        public static String cn = ConfigurationManager.ConnectionStrings["cadena"].ToString();
    }
}
