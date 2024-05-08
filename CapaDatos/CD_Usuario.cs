using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class CD_Usuario
    {

        public List<Usuario> listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select id_usuario, dni, nombre_completo, correo, contraseña from Usuario";

                    SqlCommand cmd = new SqlCommand(query, oconexion);

                }
                catch(Exception ex)
                {

                }



            }


        }

    }
}
