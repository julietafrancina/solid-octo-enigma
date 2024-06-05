using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_RegistrarPreventa
    {
        private CD_RegistrarPreventa objcd_registrarPreventa = new CD_RegistrarPreventa();

        public List<Cliente> mostrarDatosCliente(string dni)
        {
            return objcd_registrarPreventa.mostrarDatosCliente(dni);
        }

        public List<Articulo> mostrarDatosArticulo(string sku)
        {
            return objcd_registrarPreventa.mostrarDatosArticulo(sku);
        }
    }
}
