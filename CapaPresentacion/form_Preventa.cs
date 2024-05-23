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
using CapaNegocio;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class form_Preventa : Form
    {
        public form_Preventa()
        {
            InitializeComponent();
        }
        private void btnRegistrarPreventa_Click(object sender, EventArgs e)
        {
            form_RegistrarPreventa registrarPreventa = new form_RegistrarPreventa();
            registrarPreventa.Show();
        }
    }
}
