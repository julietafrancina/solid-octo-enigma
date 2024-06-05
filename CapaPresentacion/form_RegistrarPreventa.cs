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
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class form_RegistrarPreventa : Form
    {
        public form_RegistrarPreventa()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtDNICliente.Text ="";
            txtTelefonoCliente.Text = "";
            txtDomicilioCliente.Text = "";
            txtCorreoCliente.Text = "";
        }

        private CN_RegistrarPreventa objcn_registrarPreventa = new CN_RegistrarPreventa();
        private void btnBusquedaCliente_Click(object sender, EventArgs e)
        {
            string dni = txtDNICliente.Text.Trim();

            List<Cliente> lista = objcn_registrarPreventa.mostrarDatosCliente(dni);

            if (lista.Count > 0)
            {
                txtNombreCliente.Text = lista[0].nombreCompleto;
                txtTelefonoCliente.Text = lista[0].telefono;
                txtDomicilioCliente.Text = lista[0].domicilio;
                txtCorreoCliente.Text = lista[0].correo;
            }
            else
            {
                limpiar();
                MessageBox.Show("No se encontró ningún cliente con ese DNI.", "Cliente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscarSKU_Click(object sender, EventArgs e)
        {
            string sku = txtSKUBusqueda.Text.Trim();

            List<Articulo> listaArticulo = objcn_registrarPreventa.mostrarDatosArticulo(sku);

            if (listaArticulo.Count > 0)
            {
                txtDescripcionArticulo.Text = listaArticulo[0].descripcion;
                txtRubroArticulo.Text = listaArticulo[0].rubro;
                txtMarcaArticulo.Text = listaArticulo[0].marca;
                txtCostoArticulo.Text = listaArticulo[0].costo.ToString("F2");
            }
            else
            {
                limpiar();
                MessageBox.Show("No se encontró ningún artículo con ese SKU.", "Artículo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregarArticulosPreventa_Click_1(object sender, EventArgs e)
        {
            string descripcion = txtDescripcionArticulo.Text;
            string sku = txtSKUBusqueda.Text;
            double costo = 0;

            // Validar y convertir el costo a double
            if (!double.TryParse(txtCostoArticulo.Text, out costo))
            {
                MessageBox.Show("El costo no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int cantidad = (int)nudCantidadArticulo.Value;

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvAgregarArticulosPreventa);

            row.Cells[0].Value = descripcion;
            row.Cells[1].Value = sku;
            row.Cells[2].Value = costo.ToString("F2");
            row.Cells[3].Value = cantidad;
            row.Cells[4].Value = 0;

            dgvAgregarArticulosPreventa.Rows.Add(row);

            // Limpiar los campos de texto y resetear el NumericUpDown
            txtDescripcionArticulo.Clear();
            txtRubroArticulo.Clear();
            txtMarcaArticulo.Clear();
            txtCostoArticulo.Clear();
            nudCantidadArticulo.Value = 1; // Asumiendo que el valor mínimo es 1
        }

        private void dgvAgregarArticulosPreventa_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvAgregarArticulosPreventa.Columns["Costo"].Index ||
            e.ColumnIndex == dgvAgregarArticulosPreventa.Columns["Cantidad"].Index)
            {
                int rowIndex = e.RowIndex;

                if (rowIndex >= 0 && rowIndex < dgvAgregarArticulosPreventa.Rows.Count)
                {
                    // Obtener el valor de 'Costo' y 'Cantidad' en la fila actual
                    double costo = Convert.ToDouble(dgvAgregarArticulosPreventa.Rows[rowIndex].Cells["Costo"].Value);
                    int cantidad = Convert.ToInt32(dgvAgregarArticulosPreventa.Rows[rowIndex].Cells["Cantidad"].Value);

                    // Calcular el subtotal (costo * cantidad)
                    double subtotal = costo * cantidad;

                    // Actualizar el valor de 'Subtotal' en la misma fila
                    dgvAgregarArticulosPreventa.Rows[rowIndex].Cells["Subtotal"].Value = subtotal.ToString("F2"); // Formatear el subtotal con dos decimales
                }
            }
        }
    }
}
