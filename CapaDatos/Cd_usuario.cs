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
    public class Cd_usuario{

        public List<Usuario> Listar() {

            List<Usuario> lista = new List<Usuario>(),

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try {

                string query = "select idUsuario, dni, nombreCompleto, correo, contraseña from Usuario";
                SqlCommand cmd = new SqlCommand(query, oconexion);
                cmd.CommandType = CommandType.Text;

                oconexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader()) {
                    while (dr.Read())
                    {
                        lista.Add(new Usuario() {

                            idUsuario = Convert.ToInt32(dr["idUsuario"]),
                            dni = dr["dni"].ToString(),
                            nombreCompleto = dr["nombreCompleto"].ToString(),
                            correo = dr["correo"].ToString(),
                            contraseña = dr["contraseña"].ToString(),

                        });
                    }
                }
            } catch (Exception ex) {
                lista = new List<Usuario>();
            }
        }
        return lista;    

        }

        }
    }

