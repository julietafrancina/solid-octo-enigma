using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
     public class CD_Remito
     {

         public int GenerarRemito(Remito re, out string Mensaje)
      {
            int id_rem_gen = 0;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_generarRemito", oconexion);
                    
                    cmd.Parameters.AddWithValue("nro_op", re.nroOperacion);
                    cmd.Parameters.AddWithValue("letra", re.letra);
                    cmd.Parameters.AddWithValue("tipo", re.tipoRemito);
                    cmd.Parameters.AddWithValue("nro", re.numero);
                    cmd.Parameters.AddWithValue("sucursal", re.Sucursal_id);
                    cmd.Parameters.AddWithValue("factura", re.factura);
                    cmd.Parameters.AddWithValue("estado", re.Estado_id);
                    cmd.Parameters.AddWithValue("id_rem_gen", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("Mensaje", SqlDbType.VarChar).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    id_rem_gen = Convert.ToInt32(cmd.Parameters["id_rem_gen"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch(Exception ex)
            {
                id_rem_gen = 0;
                Mensaje = ex.Message;
            }


            return id_rem_gen;
      }
        public List<Remito> listar()
         {
             List<Remito> lista = new List<Remito>();
             using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
             {

                 try
                 {
                     StringBuilder query = new StringBuilder();
                     query.AppendLine("select *, Sucursal.descripcion as nombre from Remito inner join Sucursal on Remito.sucursal_id = Sucursal.id_sucursal");

                     SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                     cmd.CommandType = CommandType.Text;

                     oconexion.Open();
                     using (SqlDataReader dr = cmd.ExecuteReader())
                     {
                         while (dr.Read())
                         {
                             int valor = Convert.ToInt32(dr["estado_id"]);
                             String e;

                             //preg si es true=1 quiere decir que esta confirmado
                             if (valor == 1)
                             {
                                 e = "Confirmado";

                             }
                             else
                             {
                                 e = "Anulado";
                             }
                             lista.Add(new Remito()
                             {
                                 idRemito = Convert.ToInt32(dr["id_remito"]),
                                 numero = Convert.ToInt32(dr["nro"]),
                                 nroOperacion = Convert.ToInt32(dr["nro_op"]),
                                 letra = dr["letra"].ToString(),
                                 tipoRemito = dr["tipo"].ToString(),
                                 Estado_id = e,
                                 factura = dr["factura_id"].ToString(),
                                 Sucursal_id = dr["nombre"].ToString(),
                             }) ;
                         }
                         

                     }
                 }
                 catch (Exception)
                 {
                     lista = new List<Remito>();
                 }
             }
             return lista;
         }
        public List<int> ObtenerIdsFactura()
        {
            List<int> idsFactura = new List<int>();

            // Conectarse a la base de datos y ejecutar la consulta SQL
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT id_factura, sucursal_id FROM Factura";
                SqlCommand cmd = new SqlCommand(query, oconexion);

                oconexion.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Leer los resultados y agregar los IDs a la lista
                while (reader.Read())
                {
                    idsFactura.Add(reader.GetInt32(0)); // Suponiendo que el ID está en la primera columna (0-index)
                }
            }

            return idsFactura;
        }
    }
}
 
    
