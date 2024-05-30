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
using System.Data.SqlClient;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class Form_Remito : Form
    {
        public Form_Remito()
        {
            InitializeComponent();
            this.Load += new EventHandler(DLoad); 
        }

        private void DLoad(object sender, EventArgs e)
        {
            CargarDatos();
            textL.Text = "R";
        }

        private void CargarDatos()
         {

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
              {

                 try
                 {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select Factura.nrop_op as operacion, Sucursal.descripcion as nombre"+
                    "from Factura inner join Sucursal on Factura.sucursal_id = Sucursal.id_sucursal");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            textNroOp.Text = Convert.ToString(dr["nro_op"]);
                            textSucursal.Text = dr["sucursal_id"].ToString();
                            textL.Text = "R";
                        }
                     }


                 }
                 catch (Exception ex)
                 {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                 }
              }
        }


        private void limpiar()
        {

            textNroOp.Text = "";
            textSucursal.Text = "";
            textL.Text = "R";
            textNro.Text = "";
            CB_tipo.SelectedIndex = 0;
            CB_estado.SelectedIndex = 0;
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void textNro_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CB_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabla_rem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textNro_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifico si la tecla presionada es un nro o una tecla de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, cancelar el evento
                e.Handled = true;
            }
        }

        private void btGuardarRem_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Remito re = new Remito();


            tabla_rem.Rows.Add(new object[] {

                //"",
                textNroOp.Text, 
                textSucursal.Text,
                textL.Text,
                ((OpcionCombo)CB_tipo.SelectedItem).Texto.ToString(),
                ((OpcionCombo)CB_estado.SelectedItem).Texto.ToString(),
                textNro.Text,
             });
            if (tabla_rem.Rows.Count > 0)
            {
                DataGridViewRow lastRow = tabla_rem.Rows[tabla_rem.Rows.Count - 1];
                GenerarRemito(lastRow);
            }
            limpiar();


        }

        private void GenerarRemito(DataGridViewRow lastRow)
        {

            throw new NotImplementedException();
        }

        private void Form_Remito_Load(object sender, EventArgs e)
        {
            List<Remito> lista_remito = new CN_Remito().listar();

            foreach (Remito rem in lista_remito)
            {

                tabla_rem.Rows.Add(new object[] {
              //  "",
                rem.nroOperacion,
                rem.Sucursal_id,
                rem.letra,
                rem.tipoRemito,
                rem.Estado_id,
                rem.numero,
                rem.factura,
                });
            }
            CB_estado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Confirmado" });
            CB_estado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Anulado" });
            CB_estado.DisplayMember = "Texto";
            CB_estado.ValueMember = "Valor";
            CB_estado.SelectedIndex = 0;

            CB_tipo.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Original" });
            CB_tipo.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Duplicado" });
            CB_tipo.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Triplicado" });
            CB_tipo.DisplayMember = "Texto";
            CB_tipo.ValueMember = "Valor";
            CB_tipo.SelectedIndex = 0;
        }

        private void BtLimpiarRem_Click(object sender, EventArgs e)
        {
            tabla_rem.Rows.Clear();
        }

        private void btEliminarRem_Click(object sender, EventArgs e)
        {
            //damos de baja (estado anulado) el remito 

           // tabla_rem.SelectedRows.
        }
    }


    }
