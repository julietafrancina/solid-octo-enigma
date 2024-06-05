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
    public class CD_RegistrarPreventa
    {
        public List<Cliente> mostrarDatosCliente(string dni)
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_BUSCARCLIENTEPORDNI", oconexion);
                    cmd.Parameters.AddWithValue("@DNI", dni);
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Cliente()
                            {
                                nombreCompleto = dr["nombre_completo"].ToString(),
                                correo = dr["correo"].ToString(),
                                telefono = dr["telefono"].ToString(),
                                domicilio = dr["domicilio"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Ocurrió un error al buscar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return lista;
        }

        public List<Articulo> mostrarDatosArticulo(string sku)
        {
            List<Articulo> listaArticulo = new List<Articulo>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_BUSCARARTICULOPORSKU", oconexion);
                    cmd.Parameters.AddWithValue("@SKU", sku);
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaArticulo.Add(new Articulo()
                            {
                                descripcion = dr["descripcion"].ToString(),
                                rubro = dr["rubro"].ToString(),
                                marca = dr["marca"].ToString(),
                                costo = Convert.ToDouble(dr["costo"])
                        });
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Ocurrió un error al buscar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return listaArticulo;
        }
    }
}
