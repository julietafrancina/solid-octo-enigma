using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form_articulo : Form
    {
        public Form_articulo()
        {
            InitializeComponent();
            text_buscar.TextChanged += new EventHandler(this.text_buscar_TextChanged);
            Cb_busqueda.SelectedIndexChanged += new EventHandler(this.Cb_busqueda_SelectedIndexChanged);
        }

        private void Form_articulo_Load(object sender, EventArgs e)
        {
            List<Articulo> lista_art = new CN_Articulo().listar();

            foreach (Articulo art in lista_art)
            {



                tabla_art.Rows.Add(new object[] {
                "",
                art.SKU,
                art.rubro,
                art.marca,
                art.descripcion,
                art.costo,
                art.activo,
                });
            }
            CB_baja.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Si" });
            CB_baja.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No" });
            CB_baja.DisplayMember = "Texto";
            CB_baja.ValueMember = "Valor";
            CB_baja.SelectedIndex = 0;

            Cb_busqueda.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Rubro" });
            Cb_busqueda.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Marca" });
            Cb_busqueda.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Codigo" });
            Cb_busqueda.SelectedIndex = 0;
            Cb_busqueda.DisplayMember = "Texto";
            Cb_busqueda.ValueMember = "Valor";
        }

        private void tabla_art_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabla_art.Columns[e.ColumnIndex].Name == "Boton")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    //hacemos que el valor de la columna id lo pinte en txtId

                    textSKU.Text = tabla_art.Rows[indice].Cells["Codigo"].Value.ToString();
                    textRubro.Text = tabla_art.Rows[indice].Cells["Rubro"].Value.ToString();
                    textSKU.ReadOnly = true;
                    textMarca.Text = tabla_art.Rows[indice].Cells["Marca"].Value.ToString();
                    textDesc.Text = tabla_art.Rows[indice].Cells["Descripción"].Value.ToString();
                    textCosto.Text = tabla_art.Rows[indice].Cells["Costo"].Value.ToString();                   
                    

                    foreach (OpcionCombo oc in CB_baja.Items)
                    {
                        if (oc.Texto.ToString() == tabla_art.Rows[indice].Cells["Activo"].Value.ToString())
                        {
                            int indice_combo = CB_baja.Items.IndexOf(oc);
                            CB_baja.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                }
            }
        }

        private void byGuardar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textSKU.Text, out int numeroIngresado))
            {
                foreach (DataGridViewRow row in tabla_art.Rows)
                {
                    while (row.Cells["Codigo"].Value != null && Convert.ToInt32(row.Cells["Codigo"].Value) == numeroIngresado)
                    {
                        if (Convert.ToString(textDesc.Text)!= Convert.ToString(row.Cells["Descripción"].Value) || Convert.ToString(textCosto.Text)!= Convert.ToString(row.Cells["Costo"].Value)
                            || Convert.ToString(textRubro.Text) != Convert.ToString(row.Cells["Rubro"].Value) || Convert.ToString(textMarca.Text) != Convert.ToString(row.Cells["Marca"].Value))
                        {
                            EditarArt(numeroIngresado);
                            break;
                        }
                        else if (((OpcionCombo)CB_baja.SelectedItem).Texto.ToString() == "No")
                        {
                            int s = Convert.ToInt32(textSKU.Text);
                            BajaArt(s);
                            break;
                        }
                        else if (((OpcionCombo)CB_baja.SelectedItem).Texto.ToString() == "Si")
                        {
                            int s = Convert.ToInt32(textSKU.Text);
                            AltaArt(s);
                            break;
                        }

                    }
                }
            }
                
            string mensaje = string.Empty;
            Articulo art = new Articulo();

            art.SKU = Convert.ToInt32(textSKU.Text);
            art.rubro = textRubro.Text;
            art.marca = textMarca.Text;
            art.descripcion = textDesc.Text;
            art.costo = Convert.ToDecimal(textCosto.Text);
            art.activo = ((OpcionCombo)CB_baja.SelectedItem).Texto.ToString();

            int idgenerado = new CN_Articulo().guardar_bd(art, out mensaje);

            if (idgenerado != 0)
            {
                tabla_art.Rows.Add(new object[] {

                "",
                textSKU.Text,
                textRubro.Text,
                textMarca.Text,
                textDesc.Text,
                textCosto.Text,
                ((OpcionCombo)CB_baja.SelectedItem).Texto.ToString(),

            });
            }

            limpiar();

        }
        private void BajaArt(int s)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                string query = "sp_DarDeBajaArt";
                SqlCommand command = new SqlCommand(query, oconexion);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@sku", s);
                command.Parameters.AddWithValue("@activo", 0); //le asigno el 0 que significa que no esta acitvo

                try
                {
                    oconexion.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("El articulo ha sido dado de baja.");
                    ActualizarTabla(s);
                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al dar de baja: " + ex.Message);
                }

            }
        }

        private void AltaArt(int s)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {   
                string query = "sp_DarDeAltaArt";
                SqlCommand command = new SqlCommand(query, oconexion);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@sku", s);
                command.Parameters.AddWithValue("@activo", 1); //le asigno el 1 que significa que está activo

                try
                {
                    oconexion.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("El articulo ha sido activado nuevamente.");
                    ActualizarTabla(s);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al dar de alta: " + ex.Message);
                }

            }
        }
        private void EditarArt(int s)
        {

            int a=0;

            if (((OpcionCombo)CB_baja.SelectedItem).Texto.ToString() == "No")
            {
                a = 0;
            }
            else if (((OpcionCombo)CB_baja.SelectedItem).Texto.ToString() == "Si")
            {
                a = 1;
            }
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                string query = "sp_EditarArt";
                SqlCommand command = new SqlCommand(query, oconexion);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@sku", s);
                command.Parameters.AddWithValue("@activo", a);
                command.Parameters.AddWithValue("@costo", Convert.ToDecimal(textCosto.Text));
                command.Parameters.AddWithValue("@descripcion", textDesc.Text);
                command.Parameters.AddWithValue("@rubro", textRubro.Text);
                command.Parameters.AddWithValue("@marca", textMarca.Text);

                try
                {
                    oconexion.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Cambios guardados correctamente.");
                    ActualizarTabla(s);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar: " + ex.Message);
                }

            }
        }
        private void ActualizarTabla(int s)
        {
            foreach (DataGridViewRow row in tabla_art.Rows)
            {
                if (Convert.ToInt32(row.Cells["Codigo"].Value) == s) 
                {
                    row.Cells["Activo"].Value =CB_baja.SelectedItem;
                    row.Cells["Rubro"].Value = textRubro.Text;
                    row.Cells["Marca"].Value = textMarca.Text;
                    row.Cells["Costo"].Value = Convert.ToString(textCosto.Text); 
                    row.Cells["Descripción"].Value = textDesc.Text;
                }
            }
        }

        private void limpiar()
        {

            textSKU.Text = "";
            textRubro.Text = "";
            textMarca.Text = "";
            textCosto.Text = "";
            textDesc.Text = "";
            CB_baja.SelectedIndex = 0;
            textSKU.ReadOnly = false;
        }
        private void BuscarArticulo()
        {
            //Cb_busqueda; "codigo_articulo", "Rubro", "Marca"
            // Obtener el valor del ComboBox y el TextBox
            // Obtén el nombre de la columna seleccionada en el ComboBox
            string columnaFiltro = ((OpcionCombo)Cb_busqueda.SelectedItem)?.Texto;


            if (string.IsNullOrEmpty(columnaFiltro))
            {
                MessageBox.Show("Por favor, seleccione una columna para buscar.");
                return;
            }

            // Obtén el texto de búsqueda ingresado en el TextBox
            string textoBusqueda = text_buscar.Text.Trim().ToUpper();

            // Verifica si hay filas en el DataGridView
            if (tabla_art.Rows.Count > 0)
            {
                // Itera sobre las filas del DataGridView
                foreach (DataGridViewRow row in tabla_art.Rows)
                {
                    // Verifica que la celda no sea nula y que contenga el texto de búsqueda
                    if (row.Cells[columnaFiltro].Value != null )
                    {
                        string valorCelda = row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper();
                        row.Visible = valorCelda.Contains(textoBusqueda);
                    }
                    else
                    {
                        row.Visible = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay filas en el DataGridView.");
            }
        }

 



        private void BtEditar_Click(object sender, EventArgs e)
        {
            limpiar();

        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CB_baja_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textSKU_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifico si la tecla presionada es un nro o una tecla de control 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, cancelar el evento
                e.Handled = true;
            }
        }

        private void textCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifico si la tecla presionada es un nro o una tecla de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, cancelar el evento
                e.Handled = true;
            }
        }

        private void textRubro_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifico si la tecla presionada es una letra o una tecla de control 
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                // Si no es una letra ni una tecla de control, cancelar el evento
                e.Handled = true;
            }
        }

        private void textMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifico si la tecla presionada es una letra o una tecla de control 
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                // Si no es una letra ni una tecla de control, cancelar el evento
                e.Handled = true;
            }
        }

        private void text_buscar_TextChanged(object sender, EventArgs e)
        {
            BuscarArticulo();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cb_busqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarArticulo();
        }

        private void textSKU_TextChanged(object sender, EventArgs e)
        {

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            text_buscar.Text = "";
            Cb_busqueda.SelectedIndex = 0;
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            BuscarArticulo();
            /*string columnaFiltro = ((OpcionCombo)Cb_busqueda.SelectedItem).Texto.ToString();

            if (tabla_art.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in tabla_art.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(text_buscar.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                        
                    else
                        row.Visible = false;

                }
            }*/

        }

        private void tabla_art_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            textSKU.Text = "";
            textRubro.Text = "";
            textMarca.Text = "";
            textCosto.Text = "";
            textDesc.Text = "";
            CB_baja.SelectedIndex = 0;
            textSKU.ReadOnly = false;
        }
    }
}
