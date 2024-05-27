using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

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

                            numero = Convert.ToInt32(dr["numero"]),
                            nroOperacion = Convert.ToInt32(dr["nroOperacion"]),
                            letra = dr["letra"].ToString(),
                            tipoRemito = dr["tipo"].ToString(),
                            descripcion = dr["descripcion"].ToString(),
                             osto = Convert.ToDouble(dr["costo"]),
                        }
                    }
                }
            }
        }
   }
