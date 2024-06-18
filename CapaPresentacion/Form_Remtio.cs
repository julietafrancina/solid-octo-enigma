﻿using System;
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
        string idFactura;
        public Form_Remito()
        {
            InitializeComponent();
            this.Load += new EventHandler(DLoad);
            CargarComboBoxFactura();
            CB_fact.SelectedIndexChanged += new EventHandler(CB_fact_SelectedIndexChanged);

        }

        public Form_Remito(string id)
        {
            InitializeComponent();
            this.Load += new EventHandler(DLoad);
            CargarComboBoxFactura();
            CB_fact.SelectedIndexChanged += new EventHandler(CB_fact_SelectedIndexChanged);
            idFactura = id;
            
        }

        private void DLoad(object sender, EventArgs e)
        {
            CargarDatos();
            textL.Text = "R";
            textEstado.Text = "Confirmado";
            CB_fact.Text = "Seleccione:";

            cargarCboFact();
            foreach (OpcionCombo oc in CB_fact.Items)
            {
                if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(idFactura))
                {
                    int indice_combo = CB_fact.Items.IndexOf(oc);
                    CB_fact.SelectedIndex = indice_combo;
                    break;
                }
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
                    //MessageBox.Show("Error al cargar los datos: " + ex.Message);
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
            CB_fact.SelectedIndex = -1;
            CB_tipo.Enabled = true;
            CB_fact.Enabled = true;
            textNro.ReadOnly = false;
            btnAnular.Enabled = true;

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
                    CB_fact.Enabled = false;

                    foreach (OpcionCombo oc in CB_tipo.Items)
                    {
                        if (oc.Texto.ToString() == tabla_rem.Rows[indice].Cells["Tipo"].Value.ToString()) 
                        {
                            int indice_combo = CB_tipo.Items.IndexOf(oc);
                            CB_tipo.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    if (tabla_rem.Rows[indice].Cells["Estado"].Value.ToString() == "Anulado")
                    {
                        btnAnular.Enabled = false;
                    }
                    else
                    {
                        btnAnular.Enabled = true;
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
            if(CB_fact.SelectedIndex == -1 || textNro.Text == string.Empty)
            {
                MessageBox.Show("Ingrese los datos del remito por favor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string Mensaje = string.Empty;
                Remito re = new Remito();
                re.numero = Convert.ToInt32(textNro.Text);
                re.Sucursal_id = text_idsuc.Text;
                re.letra = textL.Text;
                re.tipoRemito = ((OpcionCombo)CB_tipo.SelectedItem).Texto.ToString();
                re.Estado_id = "1";
                re.nroOperacion = Convert.ToInt32(textNroOp.Text);
                re.factura = ((OpcionCombo)CB_fact.SelectedItem).Valor.ToString();

                int rem_gen = new CN_Remito().genRemito(re, out Mensaje);

                if (rem_gen != 0)
                {
                    tabla_rem.Rows.Add(new object[] {
                        "",
                        textNro.Text,
                        textSucursal.Text,
                        textL.Text,
                        ((OpcionCombo)CB_tipo.SelectedItem).Texto.ToString(),
                        textEstado.Text,
                        textNroOp.Text,
                        ((OpcionCombo)CB_fact.SelectedItem).Valor.ToString()
                     });

                    MessageBox.Show("El remito se ha registrado correctamente.", "Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    cargarCboFact();
                }
                else
                {
                    MessageBox.Show(Mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }


        private void Form_Remito_Load(object sender, EventArgs e)
        {
            List<Remito> lista_remito = new CN_Remito().listar();

            foreach (Remito rem in lista_remito)
            {

                tabla_rem.Rows.Add(new object[] {
                 "",
                rem.numero,
                rem.Sucursal_id,
                rem.letra,
                rem.tipoRemito,
                rem.Estado_id,
                rem.nroOperacion,
                rem.factura,
                });
            }

            CB_tipo.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Original" });
            CB_tipo.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Duplicado" });
            CB_tipo.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Triplicado" });
            CB_tipo.DisplayMember = "Texto";
            CB_tipo.ValueMember = "Valor";
            CB_tipo.SelectedIndex = 0;

            

        }
        private void CargarComboBoxFactura()
        {

            List<int> obj_rf = new CN_Remito().ObtenerFactura();

        }

        private void BtLimpiarRem_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btEliminarRem_Click(object sender, EventArgs e)
        {
            //damos de baja (estado anulado) el remito 
            int numero;
            if (int.TryParse(textNro.Text, out numero) && textNroOp.Text != string.Empty)
            {
                AnularRemito(numero);
                // Actualizar el DataGridView para reflejar los cambios
                ActualizarTabla(numero);
                //CargarDatos();
                limpiar();
                cargarCboFact();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un remito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void AnularRemito(int num)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                string query = "sp_AnularRemito";
                SqlCommand command = new SqlCommand(query, oconexion);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@numero", num);
                command.Parameters.AddWithValue("@nuevo_estado_id", 3); //le asigno el 3 que es el id del estado anulado

                try
                {
                    oconexion.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("El remito ha sido anulado correctamente.", "Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al anular el remito: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
        }

        private void ActualizarTabla(int nro)
        {
            foreach (DataGridViewRow row in tabla_rem.Rows)
            {
                if (Convert.ToInt32(row.Cells["nro"].Value) == nro)
                {
                    row.Cells["Nro_operación"].Value = textNroOp.Text; 
                    row.Cells["Sucursal"].Value = textSucursal.Text;
                    row.Cells["Letra"].Value = textL.Text;
                    row.Cells["nro"].Value = Convert.ToString(textNro.Text);
                    row.Cells["Estado"].Value = "Anulado";
                    row.Cells["Tipo"].Value = CB_tipo.SelectedItem;
                }
            }
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
                    if (row.Cells["nro"].Value != null &&
                        row.Cells["nro"].Value.ToString().Trim().Contains(textoBusqueda))
                    {
                       // row.Selected = true;
                        row.Visible = true; // Asegurarse de que la fila sea visible
                        encontrado = true;
                        //break;  Detener la búsqueda después de encontrar la primera coincidencia
                    }
                    else
                    {
                        row.Visible = false; // Ocultar las filas que no coinciden
                        // MessageBox.Show("Número no encontrado.");
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

        private void btnLimpiarBuscador_Click_1(object sender, EventArgs e)
        {
            text_buscar.Text = "";

            foreach (DataGridViewRow row in tabla_rem.Rows)
            {
                row.Visible = true;
                row.Selected = false;
            } 

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

        private void text_buscar_nroOp_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            text_buscar.Text = "";
            foreach (DataGridViewRow row in tabla_rem.Rows)
            {
                row.Visible = true;
            }
        }


        private void cargarCboFact()
        {

            CB_fact.Items.Clear();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                string query = "sp_TraerFacturasARemitar";
                SqlCommand command = new SqlCommand(query, oconexion);
                command.CommandType = CommandType.StoredProcedure;

                oconexion.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    CB_fact.Items.Add(new OpcionCombo()
                    {
                        Valor = Convert.ToInt32(reader["id_factura"]),
                        Texto = "ID: " + reader["id_factura"].ToString() + " Número: " + reader["nro"].ToString()
                    });
                }

                reader.Close();
            }
        }


    }


}
