using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using FontAwesome.Sharp;

namespace SistemaDeVentas
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioact;
        private static IconMenuItem menu_activo = null;
        private static Form formulario_activo = null;
        public Inicio()
        {
            InitializeComponent();
        }
        private void Abrir_formulario(IconMenuItem menu, Form formulario )
        {
            if(menuactivo != null)
            {
                menu_activo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            menu_activo = menu;
            if (formulario_activo != null)
            {
                formulario_activo.Close();
            }
            formulario_activo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;
            contenedor.Controls.Add(formulario);
            formulario.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {
            Abrir_formulario(menumantenedor)sender, new Form_Producto());
        }
        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            Abrir_formulario(IconMenuItem)sender, new Form_Usuario());
        }

        private void sub_cat_Click(object sender, EventArgs e)
        {
            Abrir_formulario(menumantenedor)sender, new Form_Categoria());
        }

        private void sub_detalle_Click(object sender, EventArgs e)
        {
            Abrir_formulario(menuprevta)sender, new Form_Prevta());
        }

        private void sub_fact_detalle_Click(object sender, EventArgs e)
        {

        }

        private void sub_fact_detalle_Click_1(object sender, EventArgs e)
        {
            Abrir_formulario(menufactura)sender, new Form_Factura());

        }
    }
}
