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
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.id_preventa, p.fecha, p.monto, p.nro_operacion, p.baja, p.cliente_id, p.sucursal_id, p.usuario_id," +
                        "c.id_cliente, c.nombre_completo as nomC, c.dni as dniC, c.correo, c.telefono as telC, c.domicilio, c.fecha_nac," +
                        "s.id_sucursal, s.descripcion, s.telefono as telS," +
                        "u.id_usuario, u.dni as dniU, u.nombre_completo as nomU " +
                        "FROM preventa p");
                    query.AppendLine("INNER JOIN cliente c on c.id_cliente = p.cliente_id");
                    query.AppendLine("INNER JOIN sucursal s on s.id_sucursal = p.sucursal_id");
                    query.AppendLine("INNER JOIN usuario u on u.id_usuario = p.usuario_id");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
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
    }
}
