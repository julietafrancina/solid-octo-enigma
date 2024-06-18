using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;


namespace CapaNegocio
{
    public class CN_Preventa
    {
        private CD_Preventa objcd_preventa = new CD_Preventa(); //Instancia de la clase Preventa

        public List<Preventa> listar()
        {
            return objcd_preventa.listar();
        }

        //Llamo al método MostrarArticulosPreventa
        public List<Articulo> listarArticulosPreventa(Preventa obj)
        {
            return objcd_preventa.listarArticulosPreventa(obj);
        }

        public bool bajaPreventa(int id_preventa, out string mensaje)
        {
            mensaje = string.Empty;
            return objcd_preventa.bajaPreventa(id_preventa, out mensaje);
        }

        public List<Preventa> listarPrevsAFacturar()
        {
            return objcd_preventa.listarPrevsAFacturar();
        }
    }

}
