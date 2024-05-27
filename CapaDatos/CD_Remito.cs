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

        /*public void CargarDatos()
        {
            string connectionString = "Server=your_server;Database=your_database;User Id=your_user_id;Password=your_password;";
            string query = "SELECT ColumnName FROM YourTable WHERE ConditionColumn = SomeValue";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            textNroOp.Text = reader["nro_op"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }*/
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
                            bool valor = (bool)dr["estado_id"];
                            String e;
                            
                            //preg si es true=1 quiere decir que esta confirmado
                            if (valor == true)
                            {
                                e = "";

                            }
                            else
                            {
                                b = "No";
                            }
                            lista.Add(new Remito()
                            {
                                numero = Convert.ToInt32(dr["numero"]),
                                nroOperacion = Convert.ToInt32(dr["nroOperacion"]),
                                letra = dr["letra"].ToString(),
                                tipoRemito = dr["tipo"].ToString(),
                                Estado_id = dr[Estado.descripcion].ToString(),
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
