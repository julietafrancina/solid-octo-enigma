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

                    SqlCommand cmd = new SqlCommand("sp_TraerFacturas", oconexion);
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


        public int Registrar(Factura obj, out string Mensaje)
        {
            int idFacturaGenerada = 0;
            Mensaje = string.Empty;

            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_RegistrarFactura", oconexion);
                    cmd.Parameters.AddWithValue("Sucursal_ID", obj.sucursal_id.id_suc);
                    cmd.Parameters.AddWithValue("Letra", obj.letra);
                    cmd.Parameters.AddWithValue("Numero", obj.nro);
                    cmd.Parameters.AddWithValue("MontoTotal", obj.monto_total);
                    cmd.Parameters.AddWithValue("NumeroOperacion", obj.nro_operacion);
                    cmd.Parameters.AddWithValue("Estado_ID", obj.estado_id.id_estado);
                    cmd.Parameters.AddWithValue("Preventa_ID", obj.preventa_id.idPreventa);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idFacturaGenerada = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {

                idFacturaGenerada = 0;
                Mensaje = ex.Message;

            }


            return idFacturaGenerada;

        }


        public bool Editar(Factura obj, out string Mensaje)
        {

            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("sp_ModificarFactura", oconexion);
                    cmd.Parameters.AddWithValue("IdDeFactura", obj.id_factura);
                    cmd.Parameters.AddWithValue("Numero", obj.nro);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        
        }




    }

}
