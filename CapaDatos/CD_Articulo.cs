using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
//using CapaPresentacion;


namespace CapaDatos
{
    public class CD_Articulo
    {

        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

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
                            bool valor = (bool)dr["baja"];
                            String b;
                            //preg si es true=1 quiere decir que esta dado de baja
                            if (valor == true)
                            {
                                b = "Si";

                            }
                            else
                            {
                                b = "No";
                            }


                            lista.Add(new Articulo()
                            {
                                SKU = Convert.ToInt32(dr["sku"]),
                                rubro = dr["rubro"].ToString(),
                                marca = dr["marca"].ToString(),
                                descripcion= dr["descripcion"].ToString(),
                                costo = Convert.ToDouble(dr["costo"]),
                                baja = b,

                            });
                        }

                    }

                }
                catch (Exception)
                {
                    lista = new List<Articulo>();
                }
            }
            return lista;


        }
        /*public int guardar_bd(Articulo obj)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                oconexion.Open();

                foreach (tabla_art row in tabla_art.Rows)
                {
                    // Ignorar las filas nuevas que aún no se han guardado
                    if (row.IsNewRow) continue;

                    // Obtener los valores de las celdas de la fila
                    string column1Value = row.Cells[0].Value?.ToString();
                    string column2Value = row.Cells[1].Value?.ToString();


                }*/






            }

        }
   // }
//}
