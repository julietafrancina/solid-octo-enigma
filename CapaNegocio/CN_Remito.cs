using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Remito
    {
        private CD_Remito objcd_re = new CD_Remito();

        private CD_Remito obj_rf = new CD_Remito();

        public List<int> ObtenerFactura()
        {
            return obj_rf.ObtenerIdsFactura();
        }

        public int genRemito(Remito r, out string Mensaje)
        {
           Mensaje = String.Empty;
           return objcd_re.GenerarRemito(r, out Mensaje);
        }
        public List<Remito> listar()
        {
            return objcd_re.listar();
        }
    }
}
