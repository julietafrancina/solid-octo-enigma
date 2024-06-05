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
    public class CD_Preventa
    {
        public List<Preventa> listar()
        {
            List<Preventa> lista = new List<Preventa>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("SP_LISTARPREVENTAS", oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Preventa()
                            {
                                idPreventa = Convert.ToInt32(dr["id_preventa"]),
                                fecha = Convert.ToDateTime(dr["fecha"]),
                                monto = Convert.ToInt32(dr["monto"]),
                                nroOperacion = Convert.ToInt32(dr["nro_operacion"]),
                                baja = Convert.ToBoolean(dr["baja"]),

                                ocliente = new Cliente()
                                {
                                    idCliente = Convert.ToInt32(dr["cliente_id"]),
                                    nombreCompleto = dr["nomC"].ToString(),
                                    dni = Convert.ToInt32(dr["dniC"]),
                                    correo = dr["correo"].ToString(),
                                    telefono = dr["telC"].ToString(),
                                    domicilio = dr["domicilio"].ToString(),
                                    fechaNacimiento = Convert.ToDateTime(dr["fecha_nac"]),
                                },

                                osucursal = new Sucursal()
                                {
                                    id_suc = Convert.ToInt32(dr["id_sucursal"]),
                                    desc = dr["descripcion"].ToString(),
                                    telefono = dr["telS"].ToString()
                                },

                                ousuario = new Usuario()
                                {
                                    idUsuario = Convert.ToInt32(dr["id_usuario"]),
                                    dni = Convert.ToInt32(dr["dniU"]),
                                    nombreCompleto = dr["nomU"].ToString(),
                                }
                            }); ;
                        }
                    }
                }

                catch (Exception)
                {
                    lista = new List<Preventa>();
                }
            }
            return lista;
        }

        public List<Articulo> listarArticulosPreventa(Preventa obj)
        {
            List<Articulo> lista = new List<Articulo>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("SP_ARTICULOSPREVENTA", oconexion);
                cmd.Parameters.AddWithValue("id_preventa", obj.idPreventa);

                cmd.CommandType = CommandType.StoredProcedure;

                oconexion.Open();
                cmd.ExecuteNonQuery();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Articulo()
                        {
                            idArticulo = Convert.ToInt32(dr["id_articulo"]),
                            SKU = Convert.ToInt32(dr["SKU"]),
                            descripcion = dr["descripcion"].ToString(),
                            rubro = dr["rubro"].ToString(),
                            marca = dr["marca"].ToString(),
                            costo = Convert.ToDouble(dr["costo"])
                        });
                    }

                }
            }
            return lista;
        }
    }
}
