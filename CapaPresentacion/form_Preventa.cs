using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class form_Preventa : Form
    {
        public form_Preventa()
        {
            InitializeComponent();
            dgvPreventas.CellFormatting += dgvPreventas_CellFormatting;
            dgvArticulosPreventa.AllowUserToAddRows = false;
        }

        //Mostrar todas las preventas en el DataGridView
        private void form_Preventa_Load_1(object sender, EventArgs e)
        {
            List<Preventa> listaPreventa = new CN_Preventa().listar();

            foreach (Preventa item in listaPreventa)
            {
                dgvPreventas.Rows.Add(new object[]
                {
                    "",
                    item.idPreventa, //no visible en la tabla
                    item.fecha,
                    item.ocliente.nombreCompleto,
                    item.osucursal.desc,
                    item.monto,
                    item.nroOperacion,
                    item.baja,
                    item.ousuario.nombreCompleto
                });
            }

            //para que en el combo de búsqueda me aparezcan los nombres de las columnas visibles
            foreach (DataGridViewColumn columna in dgvPreventas.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    cboBusquedaPreventa.Items.Add(new OpcionCombo()
                    {
                        Texto = columna.HeaderText,
                        Valor = columna.Name
                    });
                }
            }
            cboBusquedaPreventa.DisplayMember = "Texto";
            cboBusquedaPreventa.ValueMember = "Valor";
            cboBusquedaPreventa.SelectedIndex = 0;
        }

        //Para que diga Sí en vez de True
        private void dgvPreventas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPreventas.Columns[e.ColumnIndex].Name == "Baja" && e.Value != null)
            {
                bool value = (bool)e.Value;
                e.Value = value ? "Sí" : "-";
                e.FormattingApplied = true;
            }
        }

        //botón para abrir formulario de registrar nueva preventa
        private void btnRegistrarPreventa_Click(object sender, EventArgs e)
        {
            form_RegistrarPreventa registrarPreventa = new form_RegistrarPreventa();
            registrarPreventa.Show();
        }

        //Limpiar los campos una vez que se completó la operación
        private void limpiar()
        {
            txtId.Text = "-1";
            txtFecha.Text = "";
            txtNombreCliente.Text = "";
            txtNroOperacion.Text = "";
            txtSucursal.Text = "";
            txtUsuarioPreventa.Text = "";
            txtBaja.Text = "";
        }

        private void dgvPreventa_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
                
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

        //Al seleccionar un usuario de la tabla, pasar sus datos a los inputs del detalle.
        private void dgvPreventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPreventas.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    //hacemos que el valor de la columna id lo pinte en txtId
                    txtId.Text = dgvPreventas.Rows[indice].Cells["idPreventa"].Value.ToString();
                    txtFecha.Text = dgvPreventas.Rows[indice].Cells["Fecha"].Value.ToString();
                    txtNombreCliente.Text = dgvPreventas.Rows[indice].Cells["Cliente"].Value.ToString();
                    txtNroOperacion.Text = dgvPreventas.Rows[indice].Cells["NroOperacion"].Value.ToString();
                    txtSucursal.Text = dgvPreventas.Rows[indice].Cells["Sucursal"].Value.ToString();
                    txtBaja.Text = dgvPreventas.Rows[indice].Cells["Baja"].Value.ToString();
                    txtUsuarioPreventa.Text = dgvPreventas.Rows[indice].Cells["UsuarioPreventa"].Value.ToString();

                    List<Articulo> listaArticulosPreventa = new CN_Preventa().listarArticulosPreventa(new Preventa()
                    {
                        idPreventa = Convert.ToInt32(dgvPreventas.Rows[indice].Cells["idPreventa"].Value)
                    });

                    dgvArticulosPreventa.Rows.Clear();

                    foreach (Articulo item in listaArticulosPreventa)
                    {
                        dgvArticulosPreventa.Rows.Add(new object[]
                        {
                            item.idArticulo, //no visible en la tabla
                            item.descripcion,
                            item.rubro,
                            item.marca,
                            item.SKU,
                            item.costo
                        });
                    }
                }  

                decimal sumaTotal = 0;

                foreach (DataGridViewRow row in dgvArticulosPreventa.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var valorCelda = row.Cells["Costo"].Value;
                        if (valorCelda != null)
                        {
                            if (decimal.TryParse(valorCelda.ToString(), out decimal costo))
                            {
                                sumaTotal += costo;
                            }
                        }
                    }
                }

                txtMonto.Text = sumaTotal.ToString("N2");
            }
        }

        //Limpiar los inputs al hacer click en el botón 'Limpiar'.
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnBusquedaPreventa_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cboBusquedaPreventa.SelectedItem).Valor.ToString();

            if (dgvPreventas.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvPreventas.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusquedaPreventa.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void btnRestablecerBusquedaPreventa_Click(object sender, EventArgs e)
        {
            txtBusquedaPreventa.Text = "";
            foreach (DataGridViewRow row in dgvPreventas.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
