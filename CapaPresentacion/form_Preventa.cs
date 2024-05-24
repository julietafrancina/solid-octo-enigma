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
        }

        //botón para abrir formulario de registrar nueva preventa
        private void btnRegistrarPreventa_Click(object sender, EventArgs e)
        {
            form_RegistrarPreventa registrarPreventa = new form_RegistrarPreventa();
            registrarPreventa.Show();
        }

        private void form_Preventa_Load(object sender, EventArgs e)
        {
            //mostrar todas las preventas
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
                    item.baja
                });
            }
        }

        private void dgvPreventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

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
                    item.baja
                });
            }
        }
    }
}
