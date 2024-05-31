using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;


namespace CapaNegocio
{
    public class CN_Articulo{

        private CD_Articulo objcd_art = new CD_Articulo();

        public List<Articulo> listar()
        {
            return objcd_art.listar();
        }

        public int guardar_bd(Articulo obj, out string Mensaje) {

            Mensaje = string.Empty;
            if (Mensaje != string.Empty){
                return 0;
            }
            else{
                return objcd_art.guardar_bd(obj, out Mensaje);
            }

            


        }

    }
}
