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

        public void genRemito(Remito r)
        {
            GenerarRemito(r);
        }
        public List<Remito> listar()
        {
            return objcd_re.listar();
        }
    }
}
