using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Estado
    {

        public List<Estado> listar()
        {
            List<Estado> lista = new List<Estado>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT id_estado, descripcion FROM Estado");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            lista.Add(new Estado()
                            {
                                id_estado = Convert.ToInt32(dr["id_estado"]),
                                descripcion = dr["descripcion"].ToString()
                            });
                        }

                    }
                }
                catch (Exception)
                {
                    lista = new List<Estado>();
                }



            }

            return lista;

        }

    }
}
