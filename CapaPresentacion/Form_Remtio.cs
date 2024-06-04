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
            re.Sucursal_id = textSucursal.Text;
            re.letra = textL.Text;
            re.tipoRemito = ((OpcionCombo)CB_tipo.SelectedItem).Texto.ToString();
            re.Estado_id = textEstado.Text;
            re.numero = Convert.ToInt32(textNro.Text);

            int rem_gen = new CN_Remito().genRemito(re, out Mensaje);

            if (re.nroOperacion != 0)
            {

                tabla_rem.Rows.Add(new object[] {

                //"",
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
              //  "",
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

           /* // Limpiar ComboBox antes de cargar los IDs
            CB_fact.Items.Clear();

            // Agregar los IDs al ComboBox
            foreach (int idFactura in obj_rf)
            {
                CB_fact.Items.Add(idFactura);
            }*/
        }

        private void BtLimpiarRem_Click(object sender, EventArgs e)
        {
            tabla_rem.Rows.Clear();
        }

        private void btEliminarRem_Click(object sender, EventArgs e)
        {
            //damos de baja (estado anulado) el remito 

            // tabla_rem.SelectedRows.
        }

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
                    string query = "SELECT Factura.nro_op, Sucursal.descripcion " +
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
                    }

                    reader.Close();
                }
            }
        }
    }


}
