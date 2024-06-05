using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;
using CapaEntidad;
using CapaNegocio;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class Form_Remito : Form
    {
        public Form_Remito()
        {
            InitializeComponent();
            this.Load += new EventHandler(DLoad);
            CargarComboBoxFactura();
            CB_fact.SelectedIndexChanged += new EventHandler(CB_fact_SelectedIndexChanged);

        }

        private void DLoad(object sender, EventArgs e)
        {
            CargarDatos();
            textL.Text = "R";
            textEstado.Text = "Confirmado";
            CB_fact.Text = "Seleccione:";

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT id_factura FROM Factura";
                SqlCommand command = new SqlCommand(query, oconexion);

                oconexion.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    CB_fact.Items.Add(new OpcionCombo()
                    {
                        Valor = Convert.ToInt32(reader["id_factura"]),
                        Texto = reader["id_factura"].ToString()
                    });
                }

                reader.Close();
            }
        }

        private void CargarDatos()
        {

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select Factura.nro_op as operacion, Sucursal.descripcion as nombre" +
                    "from Factura inner join Sucursal on Factura.sucursal_id = Sucursal.id_sucursal");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            textNroOp.Text = Convert.ToString(dr["operacion"]);
                            textSucursal.Text = dr["nombre"].ToString();
                            textL.Text = "R";
                            textEstado.Text = "Confirmado";
                        }
                    }


                }
                catch (Exception ex)
                {
                   // MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }


        private void limpiar()
        {

            textNroOp.Text = "";
            textSucursal.Text = "";
            textL.Text = "R";
            textNro.Text = "";
            CB_tipo.SelectedIndex = 0;
            textEstado.Text = "Confirmado";   
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void textNro_TextChanged(object sender, EventArgs e)
        {

        }

        private void CB_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabla_rem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabla_rem.Columns[e.ColumnIndex].Name == "boton")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    //hacemos que el valor de la columna id lo pinte en txtId

                    textNroOp.Text = tabla_rem.Rows[indice].Cells["Nro_operación"].Value.ToString();
                    textSucursal.Text = tabla_rem.Rows[indice].Cells["Sucursal"].Value.ToString();
                    textL.Text = tabla_rem.Rows[indice].Cells["Letra"].Value.ToString();
                    textNro.Text = tabla_rem.Rows[indice].Cells["nro"].Value.ToString();
                    textNro.ReadOnly = true;
                    textEstado.Text = tabla_rem.Rows[indice].Cells["Estado"].Value.ToString();
                   
                    CB_tipo.Enabled = false;

                    foreach (OpcionCombo oc in CB_tipo.Items)
                    {
                        if (oc.Texto.ToString() == tabla_rem.Rows[indice].Cells["Tipo"].Value.ToString()) 
                        {
                            int indice_combo = CB_tipo.Items.IndexOf(oc);
                            CB_tipo.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                }
            }
        }

        private void textNro_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifico si la tecla presionada es un nro o una tecla de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, cancelar el evento
                e.Handled = true;
            }
        }

        private void btGuardarRem_Click(object sender, EventArgs e)
        {

            string Mensaje = string.Empty;
            Remito re = new Remito();
            re.nroOperacion = Convert.ToInt32(textNroOp.Text);
            re.Sucursal_id = text_idsuc.Text;
            re.letra = textL.Text;
            re.tipoRemito = ((OpcionCombo)CB_tipo.SelectedItem).Texto.ToString();
            re.Estado_id = "1";
            re.numero = Convert.ToInt32(textNro.Text);
            re.factura= ((OpcionCombo)CB_fact.SelectedItem).Texto.ToString();

            int rem_gen = new CN_Remito().genRemito(re, out Mensaje);

            if (re.nroOperacion != 0)
            {

                tabla_rem.Rows.Add(new object[] {

                "",
                textNroOp.Text,
                textSucursal.Text,
                textL.Text,
                ((OpcionCombo)CB_tipo.SelectedItem).Texto.ToString(),
                textEstado.Text,
                textNro.Text,
             });
            }
            limpiar();


        }


        private void Form_Remito_Load(object sender, EventArgs e)
        {
            List<Remito> lista_remito = new CN_Remito().listar();

            foreach (Remito rem in lista_remito)
            {

                tabla_rem.Rows.Add(new object[] {
                 "",
                rem.nroOperacion,
                rem.Sucursal_id,
                rem.letra,
                rem.tipoRemito,
                rem.Estado_id,
                rem.numero,
                rem.factura,
                });
            }

            CB_tipo.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Original" });
            CB_tipo.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Duplicado" });
            CB_tipo.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Triplicado" });
            CB_tipo.DisplayMember = "Texto";
            CB_tipo.ValueMember = "Valor";
            CB_tipo.SelectedIndex = 0;

            //string connectionString = "your_connection_string_here";

          /*  using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT id_factura, nro_op FROM Factura";
                SqlCommand command = new SqlCommand(query, oconexion);

                oconexion.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    CB_fact.Items.Add(new OpcionCombo()
                    {
                        Valor = reader["nro_op"],
                        Texto = reader["id_factura"].ToString()
                    }); 
                }

                reader.Close();
            }*/
        }
        private void CargarComboBoxFactura()
        {

            List<int> obj_rf = new CN_Remito().ObtenerFactura();

        }

        private void BtLimpiarRem_Click(object sender, EventArgs e)
        {
            tabla_rem.Rows.Clear();
        }

        private void btEliminarRem_Click(object sender, EventArgs e)
        {
            //damos de baja (estado anulado) el remito 

            // Verifica que haya filas en el DataGridView
            if (tabla_rem.Rows.Count > 0)
            {
                // Selecciona la última fila (recién agregada)
                DataGridViewRow ultimaFila = tabla_rem.Rows[tabla_rem.Rows.Count - 1];

                // Obtén el ID de la última fila  
                int id = Convert.ToInt32(ultimaFila.Cells["Estado"].Value); // Cambia "id" por el nombre de la columna que almacena el ID

                // Llama al método para cambiar el estado en la base de datos
                Anular_bd(id, nuevoEstado);

                // Actualiza el DataGridView para reflejar el cambio
                ultimaFila.Cells["Estado"].Value = nuevoEstado; // Cambia "estado_id" por el nombre de la columna de estado
                ultimaFila.Cells["Estado"].Value = "Anulado"; //ia "estado" por el nombre de la columna que muestra el estado
            }
                                               

            // tabla_rem.SelectedRows.
            /* using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
             {
                 string query = "UPDATE Remito SET estado_id  = 3 where id_remito = @id_remito
                 SqlCommand command = new SqlCommand(query, oconexion);

                 command.Parameters.AddWithValue("@id_remito", selectedValue.Valor);

                 oconexion.Open();
                 SqlDataReader reader = command.ExecuteReader();
                 
                if (reader.Reader()){

                    
            }
      
             */
        }
        private void Anular_bd(int id, int nuevoEstado)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                string query = "sp_CambiarEstado";
                SqlCommand command = new SqlCommand(query, oconexion);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nuevo_estado", nuevoEstado);

                oconexion.Open();
                command.ExecuteNonQuery();
                oconexion.Close();
            }
        }

        private const int nuevoEstado = 3;

        private void textL_TextChanged(object sender, EventArgs e)                                                                                                                                                                                                                                 
        {

        }

        private void textEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifico si la tecla presionada es una letra o una tecla de control 
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                // Si no es una letra ni una tecla de control, cancelar el evento
                e.Handled = true;
            }
        }

       

        private void btnBusquedaRemito_Click(object sender, EventArgs e)
        {
            BuscarRemito();

        }
        private void BuscarRemito()
        {
            string textoBusqueda = text_buscar.Text.Trim();

            if (!string.IsNullOrEmpty(textoBusqueda))
            {
                bool encontrado = false;

                foreach (DataGridViewRow row in tabla_rem.Rows)
                {
                    // Verificar si la celda de la columna específica contiene el texto de búsqueda
                    if (row.Cells["Nro_operación"].Value != null &&
                        row.Cells["Nro_operación"].Value.ToString().Trim() == textoBusqueda)
                    {
                        row.Selected = true;
                        row.Visible = true; // Asegurarse de que la fila sea visible
                        encontrado = true;
                        break; // Detener la búsqueda después de encontrar la primera coincidencia
                    }
                    else
                    {
                        row.Visible = false; // Ocultar las filas que no coinciden
                    }
                }

                if (!encontrado)
                {
                    MessageBox.Show("Número no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número.");
            }
        }
        private void text_buscar_TextChanged(object sender, KeyPressEventArgs e)
        {
           
        }

        private void text_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifico si la tecla presionada es un nro o una tecla de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, cancelar el evento
                e.Handled = true;
            }
        }

        private void btnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            text_buscar.Text = "";
            tabla_rem.Rows.Clear();
        }

        private void CB_fact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_fact.SelectedItem != null && CB_fact.SelectedItem is OpcionCombo selectedValue)
            {
                
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    string query = "SELECT Factura.nro_op, Sucursal.descripcion, Factura.sucursal_id " +
                                   "FROM Factura " +
                                   "INNER JOIN Sucursal ON Factura.sucursal_id = Sucursal.id_sucursal " +
                                   "WHERE Factura.id_factura = @id_factura";
                    SqlCommand command = new SqlCommand(query, oconexion);
                    command.Parameters.AddWithValue("@id_factura", selectedValue.Valor);

                    oconexion.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        textNroOp.Text = reader["nro_op"].ToString();
                        textSucursal.Text = reader["descripcion"].ToString();
                        text_idsuc.Text = reader["sucursal_id"].ToString();
                    }

                    reader.Close();
                }
            }
        }

        private void tabla_rem_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //boton seleccionar en tabla:
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                //eventos del método
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                //para que el ícono quede centrado
                var w = Properties.Resources.tabler_check.Width;
                var h = Properties.Resources.tabler_check.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.tabler_check, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
    
    }


}
