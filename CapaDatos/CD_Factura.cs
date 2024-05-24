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
    public class CD_Factura
    {

        public List<Factura> listar()
        {
            List<Factura> lista = new List<Factura>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT f.id_factura, f.sucursal_id, f.letra, f.nro, f.monto_total, f.nro_op, " +
                                    "f.estado, f.preventa_id, s.descripcion as descS, s.telefono, e.descripcion as descE " +
                                    "FROM Factura f");
                    query.AppendLine("INNER JOIN Sucursal s ON f.sucursal_id = s.id_sucursal");
                    query.AppendLine("INNER JOIN Estado e ON f.estado = e.id_estado");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            lista.Add(new Factura()
                            {
                                id_factura = Convert.ToInt32(dr["id_factura"]),
                                nro = Convert.ToInt32(dr["nro"]),
                                letra = dr["letra"].ToString(),
                                monto_total = Convert.ToDouble(dr["monto_total"]),
                                nro_operacion = Convert.ToInt32(dr["nro_op"]),
                                sucursal_id = new Sucursal(){id_suc = Convert.ToInt32(dr["sucursal_id"]), 
                                                             desc = dr["descS"].ToString(), 
                                                             telefono = dr["telefono"].ToString()},
                                preventa_id = new Preventa(){idPreventa = Convert.ToInt32(dr["preventa_id"])},
                                estado_id = new Estado() {id_estado = Convert.ToInt32(dr["estado"]), descripcion = dr["descE"].ToString()}
                            });
                        }

                    }
                }
                catch (Exception)
                {
                    lista = new List<Factura>();
                }



            }

            return lista;

        }

    }
}
