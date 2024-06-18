using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private static string idPrev;
        private static string idFact;

        public Inicio(Usuario usuario)
        {
            usuarioActual = usuario;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
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


        private void AbrirFormulario(Form formulario)
        {

            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }



            if (FormularioActivo != null)
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


        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new CapaPresentacion.form_Usuarios());
        }
        private void menuPreventas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new CapaPresentacion.form_Preventa(usuarioActual, this));
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new CapaPresentacion.form_Clientes());
        }

        private void menuArtículos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new CapaPresentacion.Form_articulo());
        }

        private void menuAyuda_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new CapaPresentacion.form_Ayuda());
        }

        private void menuFacturas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new CapaPresentacion.form_Facturas(this));
        }

        private void menuRemitos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new CapaPresentacion.Form_Remito());
        }


        public void abrirFacturas(object sender, EventArgs e)
        {
            AbrirFormulario(new CapaPresentacion.form_Facturas(idPrev, this));
        }

        public void abrirRemitos(object sender, EventArgs e)
        {
            AbrirFormulario(new CapaPresentacion.Form_Remito(idFact));
        }


        public void setIdPrev(string id)
        {
            idPrev = id;
        }

        public void setIdFactura(string id)
        {
            idFact = id;
        }

    }
}
