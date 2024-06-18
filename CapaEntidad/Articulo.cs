using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Articulo
    {
        public int idArticulo { get; set; }
        public int SKU { get; set; }
        public string rubro { get; set; }
        public double costo { get; set; }
        public string descripcion { get; set; }
        public string marca { get; set; }
        public string activo { get; set; }
    }
}
