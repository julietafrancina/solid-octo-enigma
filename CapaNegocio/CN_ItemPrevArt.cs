using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_ItemPrevArt
    {
        private CD_ItemPrevArt objcd_itemprevart = new CD_ItemPrevArt(); //Instancia de la clase ItemPrevArt

        public List<ItemPrevArt> listar()
        {
            return objcd_itemprevart.listar();
        }
    }
}
