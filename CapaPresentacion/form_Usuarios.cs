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
    public partial class form_Usuarios : Form
    {
        public form_Usuarios()
        {
            InitializeComponent();
        }

        private void form_Usuarios_Load(object sender, EventArgs e)
        {
            cboEstado.Items.Add(new OpcionCombo()
            {
                Valor = 1,
                Texto = "Activo"
            });
            cboEstado.Items.Add(new OpcionCombo()
            {
                Valor = 1,
                Texto = "Inactivo"
            });

            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";
            cboEstado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_Rol().listar();

            foreach (Rol item in listaRol)
            {
                cboRol.Items.Add(new OpcionCombo()
                {
                    Valor = item.id_rol,
                    Texto = item.descripcion
                });
            }

            cboRol.DisplayMember = "Texto";
            cboRol.ValueMember = "Valor";
            cboRol.SelectedIndex = 0;

            //Mostrar todos los usuarios en la tabla 
            List<Usuario> listaUsuario = new CN_Usuario().listar();

            foreach (Usuario item in listaUsuario)
            {
                dgvData.Rows.Add(new object[] {
                "",
                item.idUsuario,
                item.dni,
                item.nombreCompleto,
                item.correo,
                item.contraseña,
                item.orol.id_rol,
                item.orol.descripcion
                });
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
                txtClave.Text,
                ((OpcionCombo)cboRol.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cboRol.SelectedItem).Texto.ToString(),
                ((OpcionCombo)cboEstado.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cboEstado.SelectedItem).Texto.ToString()
            });

            limpiar();
        }
        private void limpiar()
        {
            txtId.Text = "0";
            txtDNI.Text = "";
            txtNombreCompleto.Text = "";
            txtCorreo.Text = "";
            txtClave.Text = "";
            txtConfirmarClave.Text = "";
            cboRol.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;
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
                    txtClave.Text = dgvData.Rows[indice].Cells["Contraseña"].Value.ToString();
                    txtConfirmarClave.Text = dgvData.Rows[indice].Cells["ConfirmarClave"].Value.ToString();

                    foreach (OpcionCombo oc in cboRol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["idRol"].Value))
                        {
                            int indice_combo = cboRol.Items.IndexOf(oc);
                            cboRol.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }
    }
}