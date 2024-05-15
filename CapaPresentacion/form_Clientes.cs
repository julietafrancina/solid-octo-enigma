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

namespace CapaPresentacion
{
    public partial class form_Clientes : Form
    {
        public form_Clientes()
        {
            InitializeComponent();
        }

        private void form_Clientes_Load(object sender, EventArgs e)
        {
            List<Cliente> listaCliente = new CN_Cliente().listar();

            foreach (Cliente item in listaCliente)
            {
                dgvData.Rows.Add(new object[] {
                "",
                item.idCliente,
                item.dni,
                item.nombreCompleto,
                item.correo,
                item.telefono,
                item.domicilio,
                item.fechaNacimiento
                });
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                //eventos del método
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                //para que el ícono quede centrado
                var w = Properties.Resources.tabler_check.Width;
                var h = Properties.Resources.tabler_check.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.tabler_check, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    //hacemos que el valor de la columna id lo pinte en txtId
                    txtId.Text = dgvData.Rows[indice].Cells["id"].Value.ToString();
                    txtDNI.Text = dgvData.Rows[indice].Cells["DNI"].Value.ToString();
                    txtNombreCompleto.Text = dgvData.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtCorreo.Text = dgvData.Rows[indice].Cells["Correo"].Value.ToString();
                    txtTelefono.Text = dgvData.Rows[indice].Cells["Telefono"].Value.ToString();
                    txtDomicilio.Text = dgvData.Rows[indice].Cells["Domicilio"].Value.ToString();
                    txtFechaNac.Text = dgvData.Rows[indice].Cells["FechaNacimiento"].Value.ToString();
                }
            }
        }

        private void bntGuardar_Click(object sender, EventArgs e)
        {
            dgvData.Rows.Add(new object[] {
                "",
                txtId.Text,
                txtDNI.Text,
                txtNombreCompleto.Text,
                txtCorreo.Text,
                txtTelefono.Text,
                txtDomicilio.Text,
                txtFechaNac.Text,
            });

            limpiar();
        }


        private void limpiar()
        {
            txtId.Text = "0";
            txtDNI.Text = "";
            txtNombreCompleto.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtDomicilio.Text = "";
            txtFechaNac.Text = "";
        }

    }
}
