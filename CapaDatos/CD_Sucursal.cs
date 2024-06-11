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
    public class CD_Sucursal
    {
        public List<Sucursal> listar()
        {
            List<Sucursal> lista = new List<Sucursal>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT id_sucursal, descripcion FROM Sucursal");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Sucursal()
                            {
                                id_suc = Convert.ToInt32(dr["id_sucursal"]),
                                desc = dr["descripcion"].ToString(),
                            });
                        }

                    }
                }
                catch (Exception)
                {
                    lista = new List<Sucursal>();
                }
            }

            return lista;
        }
    }
}
