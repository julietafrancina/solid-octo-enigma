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
    public class CD_ItemPrevArt
    {
        public List<ItemPrevArt> listar()
        {
            List<ItemPrevArt> lista = new List<ItemPrevArt>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT ipa.id_ipa,  FROM ItemPrevArt ipa");
                    query.AppendLine("INNER JOIN preventa p on p.id_preventa = ipa.prev_id, p.sucursal_id = ipa.prevsuc_id");
                    query.AppendLine("INNER JOIN articulo a on a.id_articulo = ipa.art_id");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            lista.Add(new ItemPrevArt()
                            {
                                idPreventaPorArticulo = Convert.ToInt32(dr["id_ipa"]),
                                opreventa = new Preventa()
                                {
                                    idPreventa = Convert.ToInt32(dr["id_preventa"]),
                                    osucursal = new Sucursal()
                                    {
                                        id_suc = Convert.ToInt32(dr["id_sucursal"])
                                    }
                                },
                                oarticulo = new Articulo()
                                {
                                    idArticulo = Convert.ToInt32(dr["id_articulo"]),
                                }

                            });
                        }

                    }
                }

                catch (Exception)
                {
                    lista = new List<ItemPrevArt>();
                }
            }
            return lista;
        }

    }
}
