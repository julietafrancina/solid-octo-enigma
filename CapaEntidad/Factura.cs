using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
   public class Factura{
        public int id_factura { get; set; }
        public string letra { get; set; }
        public int nro { get; set; }
        public Double monto_total { get; set; }
        public int nro_operacion { get; set; }
        public Sucursal sucursal_id { get; set; }
        public Preventa preventa_id { get; set; }
        public Estado estado_id { get; set; }
    }
}
