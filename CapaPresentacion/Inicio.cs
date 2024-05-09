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

namespace SistemaDeVentas
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        public Inicio(Usuario usuario)
        {
            usuarioActual = usuario;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblUsuarioName.Text = usuarioActual.nombreCompleto;
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
    }
}
