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

        //llamo al método para listar artículos a filtrar
        public List<Articulo> listarArticulos()
        {
            return objcd_registrarPreventa.listarArticulos();
        }

        //llamo el método para REGISTRAR nueva preventa
        public int registrarPreventa(Preventa obj, out string mensaje)
        {
            //Validaciones
            mensaje = string.Empty;

            if (obj.fecha == null)
            {
                mensaje += "Es necesaria la fecha de la preventa.\n";
            }

            if (obj.osucursal == null)
            {
                mensaje += "Es necesario indicar la sucursal.\n";
            }

            if (obj.ocliente == null)
            {
                mensaje += "Es necesario llenar los datos del cliente.\n";
            }

            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_registrarPreventa.registrarPreventa(obj, out mensaje);
            }
        }

        public int EnviarDatos(List<ItemPrevArt> articulosPreventa, out string mensaje)
        {
            mensaje = string.Empty;
            CD_RegistrarPreventa datos = new CD_RegistrarPreventa();
            return datos.EjecutarSP(articulosPreventa, out mensaje);
        }
    }
}
