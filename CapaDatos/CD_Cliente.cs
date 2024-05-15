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
    public class CD_Cliente
    {
        public List<Cliente> listar()
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT id_cliente, nombre_completo, dni, correo, telefono, domicilio, fecha_nac FROM Cliente");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            lista.Add(new Cliente()
                            {
                                idCliente = Convert.ToInt32(dr["id_Cliente"]),
                                dni = Convert.ToInt32(dr["dni"]),
                                nombreCompleto = dr["nombre_completo"].ToString(),
                                correo = dr["correo"].ToString(),
                                telefono= dr["telefono"].ToString(),
                                domicilio = dr["domicilio"].ToString(),
                                fechaNacimiento = Convert.ToDateTime(dr["fecha_nac"])
                            });
                        }

                    }
                }
                catch (Exception)
                {
                    lista = new List<Cliente>();
                }



            }


            return lista;


        }
    }
}
