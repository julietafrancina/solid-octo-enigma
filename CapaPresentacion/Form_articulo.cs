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
                "",
                art.idArticulo,
                art.SKU,
                art.rubro,
                art.marca,
                art.costo,
                art.baja,
                });
            }

            private void label1_Click(object sender, EventArgs e)
            {
                
            };

            private void button1_Click(object sender, EventArgs e)
            {

            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void textSKU_TextChanged(object sender, EventArgs e)
            {

            }
        }

        private void tabla_art_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void byGuardar_Click(object sender, EventArgs e)
        {
            tabla_art.Rows.Add(new object[] {
                "",
                textID.Text,
                textSKU.Text,
                textRubro.Text,
                textMarca.Text,
                textCosto.Text,
             });
            limpiar();
        }
        private void limpiar()
        {
            textID.Text = "0";
            textSKU.Text = "";
            textRubro.Text = "";
            textMarca.Text = "";
            textCosto.Text = "";
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {

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
    }

}
