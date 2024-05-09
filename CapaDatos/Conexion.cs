using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CapaDatos
{
    // Esta clase es la que envía a las demás clases la cadena de conexión que tenemos almacenada en App.config. 
    public class Conexion
    {

        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();

    }
}
