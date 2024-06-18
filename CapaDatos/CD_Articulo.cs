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
                            bool valor = (bool)dr["activo"];
                            String a;
                            //preg si es true=1 quiere decir que esta activo
                            if (valor == true)
                            {
                                a = "Si";

                            }
                            else
                            {
                                a = "No";
                            }


                            lista.Add(new Articulo()
                            {
                                SKU = Convert.ToInt32(dr["sku"]),
                                rubro = dr["rubro"].ToString(),
                                marca = dr["marca"].ToString(),
                                descripcion = dr["descripcion"].ToString(),
                                costo = Convert.ToDouble(dr["costo"]),
                                activo = a,

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
        public int guardar_bd(Articulo obj, out string Mensaje)
        {
            int id_new_art = 0;
            Mensaje = string.Empty;
            bool a;
            if (obj.activo == "Si")
            {
                a = true;
            }
            else
            {
                a = false;
            }


            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_ingresarArt", oconexion);

                    cmd.Parameters.AddWithValue("sku", obj.SKU);
                    cmd.Parameters.AddWithValue("rubro", obj.rubro);
                    cmd.Parameters.AddWithValue("marca", obj.marca);
                    cmd.Parameters.AddWithValue("descripcion", obj.descripcion);
                    cmd.Parameters.AddWithValue("costo", Convert.ToDecimal(obj.costo));
                    cmd.Parameters.AddWithValue("activo", a);

                    cmd.Parameters.Add("id_artResult", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    id_new_art = Convert.ToInt32(cmd.Parameters["id_artResult"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                id_new_art = 0;
                Mensaje = ex.Message;
            }


            return id_new_art;

        }
    }

        
   
}
