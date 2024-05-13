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
                    string query = "select u.id_usuario, u.dni, u.nombre_completo, u.correo, u.contraseña, u.rol_id, r.descripcion from usuario u "
                       + "join rol r on u.rol_id = r.id_rol" ;

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            lista.Add(new Usuario()
                            {
                                idUsuario = Convert.ToInt32(dr["id_usuario"]),
                                dni = Convert.ToInt32(dr["dni"]),
                                nombreCompleto = dr["nombre_completo"].ToString(),
                                correo = dr["correo"].ToString(),
                                contraseña = dr["contraseña"].ToString(),
                                Rol_id = new Rol(Convert.ToInt32(dr["rol_id"]), dr["descripcion"].ToString())
                            }); ;
                        }

                    }
                }
                catch (Exception)
                {
                    lista = new List<Usuario>();
                }



            }


            return lista;



        }

    }
}
