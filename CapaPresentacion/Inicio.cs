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
using CapaPresentacion;
using FontAwesome.Sharp;


namespace SistemaDeVentas
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public Inicio(Usuario usuario)
        {
            usuarioActual = usuario;
            //solución momentánea para no tener que loguearme cada vez que abro el sistema.
            //if (usuario == null) usuarioActual = new Usuario()
            //{
            //    nombreCompleto = "Admin", idUsuario = 1
            //};
            //else
            //{ 
            //    usuarioActual = usuario;
            //}
            InitializeComponent();
        }

        private void Inicio_Load_1(object sender, EventArgs e)
        {
            lblUsuarioName.Text = usuarioActual.nombreCompleto;

            if (usuarioActual.orol.descripcion == "user")
            {
                menuUsuarios.Visible = false;
            }

        }


        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {

            if(MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if(FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.LightGray;

            contenedor.Controls.Add(formulario);
            formulario.Show();

        }
        

        private void menuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new CapaPresentacion.form_Clientes());
        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new CapaPresentacion.form_Usuarios());
        }

        private void menuArtículos_Click(object sender, EventArgs e)
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

        private void sub_remito_ver_Click(object sender, EventArgs e)
        {
            Abrir_formulario(menuremito)sender, new Form_Remito());
        }

        private void sub_clientes_ver_Click(object sender, EventArgs e)
        {
            Abrir_formulario(menuclientes)sender, new Form_Clientes());
        }
    }
}
