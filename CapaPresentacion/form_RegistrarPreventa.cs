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
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class form_RegistrarPreventa : Form
    {
        private static Usuario usuarioActual;
        private static form_Preventa formPreventa;

        //configuración para detectar qué usuario está generando la preventa.
        public form_RegistrarPreventa(Usuario user, form_Preventa form)
        {
            InitializeComponent();

            usuarioActual = user;
            txtIdUsuario.Text = usuarioActual.idUsuario.ToString();

            formPreventa = form;

            dgvArticulosAFiltrar.RowHeadersVisible = false;
            dgvAgregarArticulosPreventa.RowHeadersVisible = false;
        }

        private void form_RegistrarPreventa_Load(object sender, EventArgs e)
        {
            txtFechaPreventa.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            dgvArticulosAFiltrar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAgregarArticulosPreventa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            List<Sucursal> listaSucursal = new CN_Sucursal().listar();

            foreach (Sucursal item in listaSucursal)
            {
                cboSucursalPreventa.Items.Add(new OpcionCombo()
                {
                    Valor = item.id_suc,
                    Texto = item.desc
                });
            }

            cboSucursalPreventa.DisplayMember = "Texto";
            cboSucursalPreventa.ValueMember = "Valor";
            cboSucursalPreventa.SelectedIndex = 0;

            //listar artículos a filtrar
            List<Articulo> listaArticulos = new CN_RegistrarPreventa().listarArticulos();

            foreach (Articulo item in listaArticulos)
            {
                dgvArticulosAFiltrar.Rows.Add(new object[]
                {
                    "",
                    item.idArticulo, //no visible en la tabla
                    item.descripcion,
                    item.marca,
                    item.SKU,
                    item.rubro,
                    item.costo
                });
            }

            //combo box filtro artículos
            foreach (DataGridViewColumn columna in dgvArticulosAFiltrar.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    cboFiltrarArticulos.Items.Add(new OpcionCombo()
                    {
                        Texto = columna.HeaderText,
                        Valor = columna.Name
                    });
                }
            }
            cboFiltrarArticulos.DisplayMember = "Texto";
            cboFiltrarArticulos.ValueMember = "Valor";
            cboFiltrarArticulos.SelectedIndex = 0;
        }
        private void limpiar()
        {
            txtDNICliente.Text ="";
            txtTelefonoCliente.Text = "";
            txtDomicilioCliente.Text = "";
            txtCorreoCliente.Text = "";
        }

        private CN_RegistrarPreventa objcn_registrarPreventa = new CN_RegistrarPreventa();

        //Buscar cliente por DNI
        private void btnBusquedaCliente_Click(object sender, EventArgs e)
        {
            string dni = txtDNICliente.Text.Trim();

            List<Cliente> lista = objcn_registrarPreventa.mostrarDatosCliente(dni);

            if (lista.Count > 0)
            {
                txtIdCliente.Text = lista[0].idCliente.ToString();
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

        //Buscar artículo por SKU
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
                txtIdArticulo.Text = listaArticulo[0].idArticulo.ToString();
            }
            else
            {
                limpiar();
                MessageBox.Show("No se encontró ningún artículo con ese SKU.", "Artículo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private decimal SumarSubtotales()
        {
            decimal sumaTotal = 0;

            foreach (DataGridViewRow filaArticulo in dgvAgregarArticulosPreventa.Rows)
            {
                if (!filaArticulo.IsNewRow)
                {
                    var valorCelda = filaArticulo.Cells["Subtotal"].Value;
                    if (valorCelda != null)
                    {
                        if (decimal.TryParse(valorCelda.ToString(), out decimal subtotal))
                        {
                            sumaTotal += subtotal;
                        }
                    }
                }
            }

            return sumaTotal;
        }

        //Agregar artículos a la preventa
        private void btnAgregarArticulosPreventa_Click_1(object sender, EventArgs e)
        {
            string descripcion = txtDescripcionArticulo.Text;
            string sku = txtSKUBusqueda.Text;
            double costo = 0;
            string idArticulo = txtIdArticulo.Text;

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
            row.Cells[5].Value = idArticulo;
            row.Cells[6].Value = "";

            double valorCosto = Convert.ToDouble(row.Cells[2].Value);

            row.Cells[4].Value = cantidad * valorCosto;

            dgvAgregarArticulosPreventa.Rows.Add(row);

            // Limpiar los campos de texto y resetear el NumericUpDown
            txtSKUBusqueda.Clear();
            txtDescripcionArticulo.Clear();
            txtRubroArticulo.Clear();
            txtMarcaArticulo.Clear();
            txtCostoArticulo.Clear();
            nudCantidadArticulo.Value = 1; // Asumiendo que el valor mínimo es 1

            txtTotalAPagar.Text = SumarSubtotales().ToString("N2");
        }
        
        // CREAR nueva preventa
        private void bntCrearPreventa_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Preventa objregistrarPreventa = new Preventa()
            {
                fecha = Convert.ToDateTime(txtFechaPreventa.Text),
                monto = Convert.ToDouble(txtTotalAPagar.Text),
                osucursal = new Sucursal()
                {
                    id_suc = Convert.ToInt32(txtIdSucursal.Text),
                    desc =  ((OpcionCombo)cboSucursalPreventa.SelectedItem).Texto
                },
                ousuario = new Usuario()
                {
                    idUsuario = Convert.ToInt32(txtIdUsuario.Text),
                    nombreCompleto = usuarioActual.nombreCompleto
                },
                ocliente = new Cliente()
                {
                    idCliente = Convert.ToInt32(txtIdCliente.Text),
                    nombreCompleto = txtNombreCliente.Text
                },
                nroOperacion = Convert.ToInt32(txtNroOperacionPreventa.Text)
            };

            int idPreventaGenerada = new CN_RegistrarPreventa().registrarPreventa(objregistrarPreventa, out mensaje);


            //Artículos
            string msj = string.Empty;

            List<ItemPrevArt> articulosPreventa = new List<ItemPrevArt>();
            foreach (DataGridViewRow row in dgvAgregarArticulosPreventa.Rows)
            {
                if (row.Cells["idArticulo"].Value != null)
                {
                    for (int i = 0; i < Convert.ToInt32(row.Cells["Cantidad"].Value); i++)
                    {
                        ItemPrevArt item = new ItemPrevArt
                        {
                            opreventa = new Preventa
                            {
                                idPreventa = idPreventaGenerada
                            },
                            osucursal = new Sucursal
                            {
                                id_suc = Convert.ToInt32(txtIdSucursal.Text)
                            },
                            oarticulo = new Articulo
                            {
                                idArticulo = Convert.ToInt32(row.Cells["idArticulo"].Value)
                            }
                        };
                        articulosPreventa.Add(item);
                    }
                }
            }

            CN_RegistrarPreventa registrarArticulosPreventa = new CN_RegistrarPreventa();
            registrarArticulosPreventa.EnviarDatos(articulosPreventa, out msj);

            MessageBox.Show("La preventa se ha creado correctamente.");
            formPreventa.MyDataGridView.Rows.Add
                (
                    "",
                    idPreventaGenerada, //no visible en la tabla
                    objregistrarPreventa.fecha,
                    objregistrarPreventa.ocliente.nombreCompleto,
                    objregistrarPreventa.osucursal.desc,
                    objregistrarPreventa.monto,
                    objregistrarPreventa.nroOperacion,
                    objregistrarPreventa.baja,
                    objregistrarPreventa.ousuario.nombreCompleto
                );

            this.Close();
        }

        private void cboSucursalPreventa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdSucursal.Text = ((OpcionCombo)cboSucursalPreventa.SelectedItem).Valor.ToString();
        }

        //Cancelar preventa
        private void btnCancelarPreventa_Click(object sender, EventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(txtNroOperacionPreventa);
            textBoxes.Add(txtDNICliente);
            textBoxes.Add(txtSKUBusqueda);
            textBoxes.Add(txtSKUBusqueda);
            bool contieneTexto = false;

            foreach (TextBox textBox in textBoxes)
            {
                if (!string.IsNullOrEmpty(textBox.Text))
                {
                    contieneTexto = true;
                    break;
                }
            }

            if (contieneTexto)
            {
                DialogResult result = MessageBox.Show("¿Desea cancelar la preventa?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        private void dgvArticulosAFiltrar_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvArticulosAFiltrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvArticulosAFiltrar.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    //hacemos que el valor de la columna id lo pinte en txtId
                    txtIdArticulo.Text = dgvArticulosAFiltrar.Rows[indice].Cells["idArticuloAFiltrar"].Value.ToString();
                    txtDescripcionArticulo.Text = dgvArticulosAFiltrar.Rows[indice].Cells["DescripcionArticulo"].Value.ToString();
                    txtMarcaArticulo.Text = dgvArticulosAFiltrar.Rows[indice].Cells["MarcaArticulo"].Value.ToString();
                    txtSKUBusqueda.Text = dgvArticulosAFiltrar.Rows[indice].Cells["SKUArticulo"].Value.ToString();
                    txtRubroArticulo.Text = dgvArticulosAFiltrar.Rows[indice].Cells["RubroArticulo"].Value.ToString();
                    txtCostoArticulo.Text = dgvArticulosAFiltrar.Rows[indice].Cells["PrecioArticulo"].Value.ToString();
                }
            }
        }

        private void cboFiltrarArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFiltrarArticulos_TextChanged(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cboFiltrarArticulos.SelectedItem).Valor.ToString();

            if (dgvArticulosAFiltrar.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvArticulosAFiltrar.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtFiltrarArticulos.Text.Trim().ToUpper()))
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

        private void dgvAgregarArticulosPreventa_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 6)
            {
                //eventos del método
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                //para que el ícono quede centrado
                var w = Properties.Resources.tabler_trash.Width;
                var h = Properties.Resources.tabler_trash.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.tabler_trash, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvAgregarArticulosPreventa_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAgregarArticulosPreventa.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    dgvAgregarArticulosPreventa.Rows.RemoveAt(e.RowIndex);
                    txtTotalAPagar.Text = SumarSubtotales().ToString("N2");
                }
            }
        }
    }
}
