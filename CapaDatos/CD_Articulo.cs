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
    public class CD_Articulo{

        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)){

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select * from Articulo");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            bool valor= (bool)dr["baja"];
                            String b;
                            //preg si es true=1 quiere decir que esta dado de baja
                            if (valor == true) {
                                b = "Si";
                                
                            }
                            else {
                                b = "No";
                            }
                                        

                                lista.Add(new Articulo()
                            {
                                idArticulo = Convert.ToInt32(dr["id_articulo"]),
                                SKU = Convert.ToInt32(dr["sku"]),
                                rubro = dr["rubro"].ToString(),
                                marca = dr["marca"].ToString(),
                                costo = Convert.ToDouble(dr["costo"]),
                                baja = b,
                                
                            });
                        }

                    }

                }catch (Exception)
                {
                    lista = new List<Articulo>();
                }
            }
            return lista;


            }
        }
}
