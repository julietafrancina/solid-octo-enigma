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
        public DateTime fecha { get; set; }
        public double monto { get; set; }
        public bool baja { get; set; }
        public int nroOperacion { get; set; }
        public Sucursal osucursal { get; set; }
        public Usuario ousuario { get; set; }
        public Cliente ocliente { get; set; }

        //agregar un atributo que sea una lista de objetos para los artículos

    }
}
