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

        
        public List<Remito> listar()
         {
             List<Remito> lista = new List<Remito>();
             using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
             {

                 try
                 {
                     StringBuilder query = new StringBuilder();
                     query.AppendLine("select * from Remito");

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
                                 Estado_id = new Estado() {descripcion = e},
                                 Factura_id = new Factura() {id_factura = Convert.ToInt32(dr["factura_id"])},
                                 Sucursal_id = new Sucursal() { id_suc = Convert.ToInt32(dr["sucursal_id"])}
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
     }
 }
    
