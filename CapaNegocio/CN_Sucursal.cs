using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Sucursal
    {
        private CD_Sucursal objcd_sucursal = new CD_Sucursal();

        public List<Sucursal> listar()
        {
            return objcd_sucursal.listar();
        }
    }
}
