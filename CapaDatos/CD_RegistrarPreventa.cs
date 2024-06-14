using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Windows.Forms;

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
                    MessageBox.Show("Ocurrió un error al buscar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                idArticulo = Convert.ToInt32(dr["id_articulo"]),
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
                    MessageBox.Show("Ocurrió un error al buscar el artículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    cmd.Parameters.AddWithValue("nro_operacion", obj.nroOperacion);

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

        //REGISTRAR artículos por PREVENTA
        public int EjecutarSP(List<ItemPrevArt> articulosPreventa, out string mensaje)
        {
            mensaje = string.Empty;
            int idArticuloPreventaGenerado = 0;

            foreach (ItemPrevArt item in articulosPreventa)
            {
                try
                {
                    using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                    {

                        SqlCommand cmd = new SqlCommand("SP_registrarArticuloPreventa", oconexion);

                        //parámetros de entrada
                        cmd.Parameters.AddWithValue("id_preventa", item.opreventa.idPreventa);
                        cmd.Parameters.AddWithValue("id_sucursal", item.osucursal.id_suc);
                        cmd.Parameters.AddWithValue("id_articulo", item.oarticulo.idArticulo);

                        //parámetros de salida
                        cmd.Parameters.Add("id_articulo_preventa_resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                        cmd.CommandType = CommandType.StoredProcedure;

                        oconexion.Open();
                        cmd.ExecuteNonQuery();

                        idArticuloPreventaGenerado = Convert.ToInt32(cmd.Parameters["id_articulo_preventa_resultado"].Value);
                        mensaje = cmd.Parameters["mensaje"].Value.ToString();

                    }
                }


                catch (Exception ex)
                {
                    idArticuloPreventaGenerado = 0;
                    mensaje = ex.Message;
                }

            }
            return idArticuloPreventaGenerado;
        }

        //Método para LISTAR artículos a filtrar
        public List<Articulo> listarArticulos()
        {
            List<Articulo> listaArticulos = new List<Articulo>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_listarArticulos", oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listaArticulos.Add(new Articulo()
                            {
                                idArticulo = Convert.ToInt32(dr["id_articulo"]),
                                descripcion = dr["descripcion"].ToString(),
                                marca = dr["marca"].ToString(),
                                SKU = Convert.ToInt32(dr["sku"]),
                                rubro = dr["rubro"].ToString(),
                                costo = Convert.ToDouble(dr["costo"])
                            });
                        }
                    }
                }

                catch (Exception)
                {
                    listaArticulos = new List<Articulo>();
                }
            }
            return listaArticulos;
        }
    }
}
