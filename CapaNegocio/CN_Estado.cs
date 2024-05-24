using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Estado
    {
        private CD_Estado objcd_Estado = new CD_Estado();

        public List<Estado> listar()
        {
            return objcd_Estado.listar();
        }
    }
}
