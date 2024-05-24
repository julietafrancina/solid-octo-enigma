using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Factura
    {

        private CD_Factura objcd_Factura = new CD_Factura();

        public List<Factura> listar()
        {
            return objcd_Factura.listar();
        }

    }
}
