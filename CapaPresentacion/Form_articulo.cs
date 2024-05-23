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
                art.baja,
                });
            }
            CB_baja.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Si" });
            CB_baja.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No" });
            CB_baja.DisplayMember = "Texto";
            CB_baja.ValueMember = "Valor";
            CB_baja.SelectedIndex = 1;

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
            CB_baja.SelectedIndex = 1;
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
    }

}
