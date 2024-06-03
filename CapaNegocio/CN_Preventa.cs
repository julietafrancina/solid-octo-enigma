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

        public List<Preventa> listarPrevsAFacturar()
        {
            return objcd_preventa.listarPrevsAFacturar();
        }

    }
}
