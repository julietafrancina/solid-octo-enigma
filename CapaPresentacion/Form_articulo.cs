using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
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
              //  "",
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
            Cb_busqueda.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Código" });
            Cb_busqueda.SelectedIndex = 0;
            Cb_busqueda.DisplayMember = "Texto";
            Cb_busqueda.ValueMember = "Valor";
        }

        private void tabla_art_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void byGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Articulo art = new Articulo();

            art.SKU = Convert.ToInt32(textSKU.Text);
            art.rubro = textRubro.Text;
            art.marca = textMarca.Text;
            art.descripcion = textDesc.Text;
            art.costo = Convert.ToDouble(textCosto.Text);
            art.activo = ((OpcionCombo)CB_baja.SelectedItem).Texto.ToString();
            int idgenerado = new CN_Articulo().guardar_bd(art, out mensaje);

            if (idgenerado == 0)
            {
                tabla_art.Rows.Add(new object[] {

                //"",
                textSKU.Text,
                textRubro.Text,
                textMarca.Text,
                textDesc.Text,
                textCosto.Text,
                ((OpcionCombo)CB_baja.SelectedItem).Texto.ToString(),
                MessageBox.Show("Datos guardados correctamente"),

            });
            }

            limpiar();

        }
        private void limpiar()
        {

            textSKU.Text = "";
            textRubro.Text = "";
            textMarca.Text = "";
            textCosto.Text = "";
            textDesc.Text = "";
            CB_baja.SelectedIndex = 0;
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
            tabla_art.Rows.Clear();

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

    }
}
