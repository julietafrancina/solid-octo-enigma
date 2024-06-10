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

                string act = "";
                if (item.activo)
                {
                    act = "Si";
                }
                else
                {
                    act = "No";
                }

                dgvData.Rows.Add(new object[]
                {
                    "",
                    item.idUsuario,
                    item.dni,
                    item.nombreCompleto,
                    item.correo,
                    item.contraseña,
                    item.orol.id_rol,
                    item.orol.descripcion,
                    act
                });
            }


            //para que en el combo de búsqueda me aparezcan los nombres de las columnas visibles
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    cboBusquedaUsuario.Items.Add(new OpcionCombo()
                    {
                        Texto = columna.HeaderText,
                        Valor = columna.Name
                    });
                }
            }
            cboBusquedaUsuario.DisplayMember = "Texto";
            cboBusquedaUsuario.ValueMember = "Valor";
            cboBusquedaUsuario.SelectedIndex = 0;
        }


        //Registrar un usuario nuevo al hacer click en el botón 'Guardar'.
        private void bntGuardar_Click(object sender, EventArgs e)
        {
            if(txtDNI.Text == "")
            {
                MessageBox.Show("Se requiere el DNI del usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txtClave.Text == txtConfirmarClave.Text)
                {

                    string mensaje = string.Empty;
                    Usuario objusuario = new Usuario()
                    {
                        idUsuario = Convert.ToInt32(txtId.Text),
                        dni = Convert.ToInt32(txtDNI.Text),
                        nombreCompleto = txtNombreCompleto.Text,
                        correo = txtCorreo.Text,
                        contraseña = txtClave.Text,
                        orol = new Rol()
                        {
                            id_rol = Convert.ToInt32(((OpcionCombo)cboRol.SelectedItem).Valor)
                        }
                    };

                    if (objusuario.idUsuario == 0)
                    {
                        int idUsuarioGenerado = new CN_Usuario().Registrar(objusuario, out mensaje);
                        if (idUsuarioGenerado != 0)
                        {
                            dgvData.Rows.Add(new object[]
                            {
                            "",
                            idUsuarioGenerado,
                            txtDNI.Text,
                            txtNombreCompleto.Text,
                            txtCorreo.Text,
                            txtClave.Text,
                            ((OpcionCombo)cboRol.SelectedItem).Valor.ToString(),
                            ((OpcionCombo)cboRol.SelectedItem).Texto.ToString(),
                            "Sí"
                            });

                            limpiar();
                        }
                        else
                        {
                            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        bool resultado = new CN_Usuario().Editar(objusuario, out mensaje);

                        if (resultado)
                        {
                            DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                            row.Cells["Id"].Value = txtId.Text;
                            row.Cells["DNI"].Value = txtDNI.Text;
                            row.Cells["NombreCompleto"].Value = txtNombreCompleto.Text;
                            row.Cells["Correo"].Value = txtCorreo.Text;
                            row.Cells["Rol"].Value = ((OpcionCombo)cboRol.SelectedItem).Texto.ToString();
                            limpiar();
                        }
                        else
                        {
                            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Confirme la contraseña para continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            
            
        }

        //Limpiar los campos una vez que se completó la operación
        private void limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtDNI.Text = "";
            txtNombreCompleto.Text = "";
            txtCorreo.Text = "";
            txtClave.Text = "";
            txtConfirmarClave.Text = "";
            cboRol.SelectedIndex = 0;
        }

        //Mostrar la tabla de usuarios.
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

        //Al seleccionar un usuario de la tabla, pasar sus datos a los inputs de la izquierda.
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
                    txtDNI.Text = dgvData.Rows[indice].Cells["DNI"].Value.ToString();
                    txtNombreCompleto.Text = dgvData.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtCorreo.Text = dgvData.Rows[indice].Cells["Correo"].Value.ToString();
                    txtClave.Text = dgvData.Rows[indice].Cells["Contraseña"].Value.ToString();

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

        //Limpiar los inputs al hacer click en el botón 'Limpiar'.
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnBusquedaUsuario_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cboBusquedaUsuario.SelectedItem).Valor.ToString();

            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusquedaUsuario.Text.Trim().ToUpper()))
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

        private void btnLimpiarBusquedaUsuario_Click(object sender, EventArgs e)
        {
            txtBusquedaUsuario.Text = "";
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "0")
            {
                MessageBox.Show("No se puede dar de baja un usuario que no existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txtDNI.Text != dgvData.Rows[Convert.ToInt32(txtIndice.Text)].Cells["DNI"].Value.ToString())
                {
                    MessageBox.Show("DNI de usuario incorrecto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (txtClave.Text == txtConfirmarClave.Text)
                    {

                        string mensaje = string.Empty;
                        bool activado;

                        if(dgvData.Rows[Convert.ToInt32(txtIndice.Text)].Cells["Activo"].Value.ToString() == "Si")
                        {
                            activado = true;
                        }
                        else
                        {
                            activado = false;
                        }

                        Usuario obj = new Usuario()
                        {
                            idUsuario = Convert.ToInt32(txtId.Text),
                            dni = Convert.ToInt32(txtDNI.Text),
                            activo = activado
                        };


                        bool resultado = new CN_Usuario().cambiarActivo(obj, out mensaje);

                        if (resultado)
                        {
                            if (activado)
                            {
                                DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                                row.Cells["Activo"].Value = "No";
                                limpiar();
                            }
                            else
                            {
                                DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txtIndice.Text)];
                                row.Cells["Activo"].Value = "Si";
                                limpiar();
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Confirme la contraseña para continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }


            }
        }
    }
}