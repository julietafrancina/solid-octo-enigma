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
using CapaPresentacion.Utilidades;

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
           
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {

                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    cboBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }

            }
            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Value";
            cboBusqueda.SelectedIndex = 0;

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

            cargarPreventasCBO();

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

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtNumero.Text = "";
            txtNumero.ReadOnly = false;
            txtLetra.Text = "";
            txtLetra.ReadOnly = false;
            txtMontoTotal.Text = "";
            txtNroOperacion.Text = "";
            txtSucursal.Text = "Sucursal";
            txtSucursal.ForeColor = System.Drawing.Color.Gray;
            cboBoxPreventa.SelectedIndex = -1;
            cboBoxPreventa.Enabled = true;
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
                    txtNumero.ReadOnly = true;
                    txtLetra.Text = dgvData.Rows[indice].Cells["Letra"].Value.ToString();
                    txtLetra.ReadOnly = true;
                    txtMontoTotal.Text = dgvData.Rows[indice].Cells["MontoTotal"].Value.ToString();
                    txtMontoTotal.ReadOnly = true;
                    txtNroOperacion.Text = dgvData.Rows[indice].Cells["NroOperacion"].Value.ToString();
                    txtSucursal.Text = dgvData.Rows[indice].Cells["DescripcionSucursal"].Value.ToString();
                    txtSucursal.ForeColor = System.Drawing.Color.Black;
                    cboBoxPreventa.Enabled = false;

                    foreach (OpcionCombo oc in cboBoxPreventa.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["idPreventa"].Value))
                        {
                            int indice_combo = cboBoxPreventa.Items.IndexOf(oc);
                            cboBoxPreventa.SelectedIndex = indice_combo;
                            break;
                        }
                    }

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

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cboBusqueda.SelectedItem).Valor.ToString();

            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Visible = true;
            }
        }

        private void cboBoxPreventa_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpcionCombo opcionSeleccionada = (OpcionCombo)cboBoxPreventa.SelectedItem;

            if(opcionSeleccionada != null)
            { 
                int valor = Convert.ToInt32(opcionSeleccionada.Valor);

                List<Preventa> listaPreventas = new CN_Preventa().listarPrevsAFacturar();

                foreach (Preventa item in listaPreventas)
                {
                    if (item.idPreventa == valor)
                    {
                        txtNroOperacion.Text = item.nroOperacion.ToString();
                        txtSucursal.Text = item.osucursal.desc;
                        txtSucursal.ForeColor = System.Drawing.Color.Black;
                        txtMontoTotal.Text = item.monto.ToString();
                    }
                }
            }

        }

        private void bntGuardar_Click(object sender, EventArgs e)
        {

            if (txtNumero.Text == "" || txtLetra.Text == "" || txtMontoTotal.Text == "" || cboBoxPreventa.SelectedIndex == -1)
            {
                MessageBox.Show("Rellene los datos de la factura por favor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                string mensaje = string.Empty;
                List<Preventa> listaPreventas = new CN_Preventa().listar();

                int idAuxiliar = 0;
                foreach (Preventa item in listaPreventas)
                {
                    if (item.idPreventa == Convert.ToInt32(((OpcionCombo)cboBoxPreventa.SelectedItem).Valor))
                    {
                        idAuxiliar = item.osucursal.id_suc;
                        break;
                    }
                }

                Factura obj = new Factura()
                {
                    id_factura = Convert.ToInt32(txtId.Text),
                    nro = Convert.ToInt32(txtNumero.Text),
                    nro_operacion = Convert.ToInt32(txtNroOperacion.Text),
                    letra = txtLetra.Text,
                    monto_total = Convert.ToDouble(txtMontoTotal.Text),
                    estado_id = new Estado() { id_estado = 1 },
                    preventa_id = new Preventa() { idPreventa = Convert.ToInt32(((OpcionCombo)cboBoxPreventa.SelectedItem).Valor) },
                    sucursal_id = new Sucursal() { id_suc = idAuxiliar }
                };

                if (obj.id_factura == 0)
                {

                    int idgenerado = new CN_Factura().Registrar(obj, out mensaje);

                    if (idgenerado != 0)
                    {
                        dgvData.Rows.Add(new object[] {
                        "",
                        idgenerado,
                        txtNumero.Text,
                        txtLetra.Text,
                        txtMontoTotal.Text,
                        txtNroOperacion.Text,
                        "",
                        txtSucursal.Text,
                        ((OpcionCombo)cboBoxPreventa.SelectedItem).Valor,
                        1,
                        "Confirmado"
                    });

                        limpiar();
                        cargarPreventasCBO();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Ya se encuentra registrado este número de factura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            
        }


        private void limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtNumero.Text = "";
            txtNumero.ReadOnly = false;
            txtNroOperacion.Text = "";
            txtLetra.Text = "";
            txtLetra.ReadOnly = false;
            txtMontoTotal.Text = "";
            txtSucursal.Text = "Sucursal";
            txtSucursal.ForeColor = System.Drawing.Color.Gray;
            cboBoxPreventa.SelectedIndex = -1;
            cboBoxPreventa.Enabled = true;
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            

            if (txtId.Text == "0")
            {
                MessageBox.Show("No se puede anular una factura que no existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                string mensaje = string.Empty;

                Factura obj = new Factura()
                {
                    id_factura = Convert.ToInt32(txtId.Text),
                    nro = Convert.ToInt32(txtNumero.Text),
                };


                bool resultado = new CN_Factura().Editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["DescEstado"].Value = "Anulado";
                    limpiar();
                    cargarPreventasCBO();
                }
                else
                {
                    MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void txtLetra_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifico si la tecla presionada es una letra o una tecla de control 
            if (e.KeyChar != 'A' && e.KeyChar != 'B' && !char.IsControl(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, cancelar el evento
                e.Handled = true;
            }
        }


        private void cargarPreventasCBO()
        {
            cboBoxPreventa.Items.Clear();

            List<Preventa> listaPreventas = new CN_Preventa().listarPrevsAFacturar();

            foreach (Preventa item in listaPreventas)
            {
                if (item.baja == false)
                {
                    cboBoxPreventa.Items.Add(new OpcionCombo()
                    {
                        Valor = item.idPreventa,
                        Texto = "ID: " + item.idPreventa.ToString() + " -  Nro. Op.: " + item.nroOperacion.ToString()
                    });
                }
            }

            cboBoxPreventa.DisplayMember = "Texto";
            cboBoxPreventa.ValueMember = "Valor";
        }

    }
}
