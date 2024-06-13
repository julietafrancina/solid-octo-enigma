﻿using System;
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
    public partial class form_Clientes : Form
    {
        public form_Clientes()
        {
            InitializeComponent();
        }

        private void form_Clientes_Load(object sender, EventArgs e)
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
                    DateTime fecha = Convert.ToDateTime(dgvData.Rows[indice].Cells["FechaNacimiento"].Value);

                    //hacemos que el valor de la columna id lo pinte en txtId
                    txtIndice.Text = indice.ToString();
                    txtId.Text = dgvData.Rows[indice].Cells["id"].Value.ToString();
                    txtDNI.Text = dgvData.Rows[indice].Cells["DNI"].Value.ToString();
                    txtNombreCompleto.Text = dgvData.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtCorreo.Text = dgvData.Rows[indice].Cells["Correo"].Value.ToString();
                    txtTelefono.Text = dgvData.Rows[indice].Cells["Telefono"].Value.ToString();
                    txtDomicilio.Text = dgvData.Rows[indice].Cells["Domicilio"].Value.ToString();
                    datePicker.Value = Convert.ToDateTime(dgvData.Rows[indice].Cells["FechaNacimiento"].Value);
                }
            }
        }

        private void bntGuardar_Click(object sender, EventArgs e)
        {

            if (txtDNI.Text == "")
            {
                MessageBox.Show("Es necesario el documento del Cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                string mensaje = string.Empty;

                Cliente obj = new Cliente()
                {
                    idCliente = Convert.ToInt32(txtId.Text),
                    dni = Convert.ToInt32(txtDNI.Text),
                    nombreCompleto = txtNombreCompleto.Text,
                    correo = txtCorreo.Text,
                    telefono = txtTelefono.Text,
                    domicilio = txtDomicilio.Text,
                    fechaNacimiento = datePicker.Value
                };

                if (obj.idCliente == 0)
                {

                    int idgenerado = new CN_Cliente().Registrar(obj, out mensaje);

                    if (idgenerado != 0)
                    {
                        dgvData.Rows.Add(new object[] {
                        "",
                        idgenerado,
                        txtDNI.Text,
                        txtNombreCompleto.Text,
                        txtCorreo.Text,
                        txtTelefono.Text,
                        txtDomicilio.Text,
                        datePicker.Value
                    });
                        MessageBox.Show("El cliente ha sido registrado correctamente.", "Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    bool resultado = new CN_Cliente().Editar(obj, out mensaje);

                    if (resultado)
                    {
                        DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                        row.Cells["Id"].Value = txtId.Text;
                        row.Cells["DNI"].Value = txtDNI.Text;
                        row.Cells["NombreCompleto"].Value = txtNombreCompleto.Text;
                        row.Cells["Correo"].Value = txtCorreo.Text;
                        row.Cells["Telefono"].Value = txtTelefono.Text;
                        row.Cells["Domicilio"].Value = txtDomicilio.Text;
                        row.Cells["FechaNacimiento"].Value = datePicker.Value;
                        MessageBox.Show("El cliente ha sido editado correctamente.", "Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }


            }
            
            
        }


        private void limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtDNI.Text = "";
            txtNombreCompleto.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtDomicilio.Text = "";
            datePicker.Value = DateTime.Today;
        }


        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDomicilio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if(Convert.ToInt32(txtId.Text) != 0)
            {
                if(MessageBox.Show("¿Desea eliminar el cliente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Cliente obj = new Cliente()
                    {
                        idCliente = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new CN_Cliente().Eliminar(obj, out mensaje);

                    if (respuesta)
                    {
                        dgvData.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                        MessageBox.Show("El cliente ha sido eliminado correctamente.", "Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
            else
            {
                MessageBox.Show("No se puede eliminar un cliente que no existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach(DataGridViewRow row in dgvData.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cboBusqueda.SelectedItem).Valor.ToString();

            if(dgvData.Rows.Count > 0)
            {
                foreach(DataGridViewRow row in dgvData.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void cboBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            txtDNI.Text = "";
            txtNombreCompleto.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtDomicilio.Text = "";
            datePicker.Value = DateTime.Today;
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifico si la tecla presionada es un nro o una tecla de control 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, cancelar el evento
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifico si la tecla presionada es un nro o una tecla de control 
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) && e.KeyChar != '+')
            {
                // Si no es un número ni una tecla de control, cancelar el evento
                e.Handled = true;
            }
        }
    }
}
