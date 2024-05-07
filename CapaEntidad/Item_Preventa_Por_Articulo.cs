using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Item_Preventa_Por_Articulo
    {
        public int idPreventaPorArticulo { get; set; }
        public Preventa Preventa_id { get; set; }
        public Articulo Articulo_id { get; set; }

    }
}
