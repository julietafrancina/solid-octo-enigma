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
        }

        private void form_RegistrarPreventa_Load(object sender, EventArgs e)
        {
            txtFechaPreventa.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

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

        //Agregar artículos a la preventa
        private void btnAgregarArticulosPreventa_Click_1(object sender, EventArgs e)
        {
            string descripcion = txtDescripcionArticulo.Text;
            string sku = txtSKUBusqueda.Text;
            double costo = 0;
            string idArticulo = txtIdArticulo.Text;

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
            row.Cells[5].Value = idArticulo;

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

            txtTotalAPagar.Text = sumaTotal.ToString("N2");
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
                    id_suc = Convert.ToInt32(txtIdSucursal.Text)
                },
                ousuario = new Usuario()
                {
                    idUsuario = Convert.ToInt32(txtIdUsuario.Text)
                },
                ocliente = new Cliente()
                {
                    idCliente = Convert.ToInt32(txtIdCliente.Text)
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

            CN_RegistrarPreventa registrarArticulosPreventa = new CN_RegistrarPreventa();
            registrarArticulosPreventa.EnviarDatos(articulosPreventa, out msj);

            MessageBox.Show("La preventa se ha creado correctamente.");
            formPreventa.limpiarDgv();
            formPreventa.form_Preventa_Load_1(sender, e);
            this.Close();
            //actualizar form_Preventa
        }

        private void cboSucursalPreventa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdSucursal.Text = ((OpcionCombo)cboSucursalPreventa.SelectedItem).Valor.ToString();
        }
    }
}
