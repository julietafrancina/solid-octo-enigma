using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Remito
    {
        public int idRemito { get; set; }
        public Sucursal Sucursal_id { get; set; }
        public Estado Estado_id { get; set; }
        public string letra { get; set; }
        public string tipoRemito { get; set; }
        public int numero { get; set; }
        public int nroOperacion { get; set; }
    }
}
