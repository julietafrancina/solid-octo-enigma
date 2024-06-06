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
                                idCliente = Convert.ToInt32(dr["id_cliente"].ToString()),
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

        //Método para REGISTRAR una nueva preventa
        public int registrarPreventa(Preventa obj, out string mensaje)
        {
            int idPreventaGenerada = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_registrarPreventa", oconexion);
                    //parámetros de entrada
                    cmd.Parameters.AddWithValue("fecha", obj.fecha);
                    cmd.Parameters.AddWithValue("monto", obj.monto);
                    cmd.Parameters.AddWithValue("baja", obj.baja);
                    cmd.Parameters.AddWithValue("sucursal_id", obj.osucursal.id_suc);
                    cmd.Parameters.AddWithValue("usuario_id", obj.ousuario.idUsuario);
                    cmd.Parameters.AddWithValue("cliente_id", obj.ocliente.idCliente);

                    //parámetros de salida
                    cmd.Parameters.Add("id_preventa_resultada", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    idPreventaGenerada = Convert.ToInt32(cmd.Parameters["id_preventa_resultada"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }

            catch (Exception ex)
            {
                idPreventaGenerada = 0;
                mensaje = ex.Message;
            }

            return idPreventaGenerada;
        }
    }
}
