using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class FacturaPrev{

        public int id_factprev { get; set; }
        public Factura fac_id { get; set; }
        public Preventa prev_id { get; set; }
    }
}
