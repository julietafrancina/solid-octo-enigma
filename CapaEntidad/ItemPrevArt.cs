using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ItemPrevArt
    {
        public int idPreventaPorArticulo { get; set; }
        public Preventa opreventa { get; set; }
        public Sucursal osucursal { get; set; }
        public Articulo oarticulo { get; set; }
    }
}
