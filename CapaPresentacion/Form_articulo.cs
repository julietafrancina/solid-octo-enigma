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

namespace CapaPresentacion
{
    public partial class Form_articulo : Form
    {
        public Form_articulo()
        {
            InitializeComponent();
        }

        private void Form_articulo_Load(object sender, EventArgs e)
        {
            List<Articulo> lista_art = new CN_Articulo().listar();

            foreach (Articulo art in lista_art) {



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
            Cb_busqueda.Items.Add(new OpcionCombo() { Valor = 0, Texto = "SKU" });
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
            
            
            tabla_art.Rows.Add(new object[] {

                //"",
                textSKU.Text,
                textRubro.Text,
                textMarca.Text,
                textDesc.Text,
                textCosto.Text,
                ((OpcionCombo)CB_baja.SelectedItem).Texto.ToString(),

             }) ;

         //   int idgenerado = new CN_Articulo().guardar_bd(art, out mensaje);
            //guardar_bd();
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
            // Obtener el valor seleccionado del ComboBox
            string valorBusqueda = Cb_busqueda.SelectedItem?.ToString().Trim();

            if (!string.IsNullOrEmpty(valorBusqueda))
            {
                bool encontrado = false;

                string[] columnasParaBuscar = { "codigo_articulo", "Rubro", "Marca" }; 

                foreach (DataGridViewRow row in tabla_art.Rows)
                {
                    bool filaCoincide = false;

                    foreach (string columna in columnasParaBuscar)
                    {
                        if (row.Cells[sku].Value != null &&
                            row.Cells[sku].Value.ToString().Trim() == valorBusqueda)
                        {
                            filaCoincide = true;
                            break;
                        }
                    }

                    if (filaCoincide)
                    {
                        row.Selected = true;
                        row.Visible = true; // Asegurarse de que la fila sea visible
                        encontrado = true;
                    }
                    else
                    {
                        row.Visible = false; // Ocultar las filas que no coinciden
                    }
                }

                if (!encontrado)
                {
                    MessageBox.Show("Valor no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un valor.");
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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cb_busqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        }
    }

}
