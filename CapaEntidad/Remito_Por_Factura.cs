using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Remito_Por_Factura
    {
        public int idRemitoPorFactura { get; set; }
        public Factura Factura_id { get; set; }
        public Remito Remito_id { get; set; }
    }
}
