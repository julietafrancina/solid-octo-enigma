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
    public partial class form_Facturas : Form
    {
        public form_Facturas()
        {
            InitializeComponent();
        }

        private void form_Facturas_Load(object sender, EventArgs e)
        {
            List<Factura> listaFactura = new CN_Factura().listar();

            foreach (Factura item in listaFactura)
            {
                dgvData.Rows.Add(new object[] {
                "",
                item.id_factura,
                item.nro,
                item.letra,
                item.monto_total,
                item.nro_operacion,
                item.sucursal_id.id_suc,
                item.sucursal_id.desc,
                item.preventa_id.idPreventa,
                item.estado_id.id_estado,
                item.estado_id.descripcion
                });
            }
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNroOperacion.Text = "Número de preventa";
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    //hacemos que el valor de la columna id lo pinte en txtId
                    txtIndice.Text = indice.ToString();
                    txtId.Text = dgvData.Rows[indice].Cells["id"].Value.ToString();
                    txtNumero.Text = dgvData.Rows[indice].Cells["Numero"].Value.ToString();
                    txtLetra.Text = dgvData.Rows[indice].Cells["Letra"].Value.ToString();
                    txtMontoTotal.Text = dgvData.Rows[indice].Cells["MontoTotal"].Value.ToString();
                    txtNroOperacion.Text = dgvData.Rows[indice].Cells["NroOperacion"].Value.ToString();
                    txtSucursal.Text = dgvData.Rows[indice].Cells["DescripcionSucursal"].Value.ToString();
                    txtSucursal.ForeColor = System.Drawing.Color.Black;
                }
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifico si la tecla presionada es un nro o una tecla de control 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, cancelar el evento
                e.Handled = true;
            }
        }
    }
}
