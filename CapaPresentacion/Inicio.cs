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

        public Inicio(Usuario usuario = null)
        {
            // solución momentánea para no tener que loguearme cada vez que abro el sistema.
            if (usuario == null) usuarioActual = new Usuario()
            {
                nombreCompleto = "Admin", idUsuario = 1
            };
            else
            { 
                usuarioActual = usuario;
            }
            InitializeComponent();
        }

        private void Inicio_Load_1(object sender, EventArgs e)
        {
            lblUsuarioName.Text = usuarioActual.nombreCompleto;
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
            formulario.BackColor = Color.Firebrick;

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

    }
}
