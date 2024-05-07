using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {

        public int idUsuario { get; set; }
        public Rol Rol_id { get; set; }
        public int dni { get; set; }
        public string nombreCompleto { get; set; }
        public string correo { get; set; }
        public string contraseña { get; set; }
    }

}
