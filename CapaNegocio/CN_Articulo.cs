﻿using System;
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
    }
}
