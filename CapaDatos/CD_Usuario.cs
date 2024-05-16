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
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT u.id_usuario, u.dni, u.nombre_completo, u.correo, u.contraseña, r.id_rol, r.descripcion FROM usuario u");
                    query.AppendLine("INNER JOIN rol r on r.id_rol = u.rol_id");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
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
                                orol = new Rol()
                                {
                                    id_rol = Convert.ToInt32(dr["id_rol"]),
                                    descripcion = dr["descripcion"].ToString()
                                }
                            });
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
