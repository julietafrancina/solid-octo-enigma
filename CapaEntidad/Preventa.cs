using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Preventa
    {

        public int idPreventa { get; set; }
        public Sucursal Sucursal_id { get; set; }
        public Usuario Usuario_id { get; set; }
        public Cliente Cliente_id { get; set; }
        public DateTime fecha { get; set; }
        public double monto { get; set; }
        public bool baja { get; set; }
        public int nroOperacion { get; set; }
        public List<Articulo> articulos = new List<Articulo>();

    }
}
