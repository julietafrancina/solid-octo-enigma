using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objcd_usuario = new CD_Usuario(); //Instancia de la clase CD_Usuario

        public List<Usuario> listar()
        {
            return objcd_usuario.listar();
        }

        //Llamo los tres métodos REGISTRAR, EDITAR y ELIMINAR usuario. Le paso un objeto 'Usuario' y una variable 'mensaje'.
        public int Registrar(Usuario obj, out string mensaje)
        {
            //Validaciones
            mensaje = string.Empty;

            if (obj.dni == 0)
            {
                mensaje += "Es necesario el DNI del usuario.\n";
            }

            if (obj.nombreCompleto == "")
            {
                mensaje += "Es necesario el nombre del usuario.\n";
            }

            if (obj.contraseña == "")
            {
                mensaje += "Es necesaria la contraseña del usuario.\n";
            }

            if (mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_usuario.Registrar(obj, out mensaje);
            }
        }

        public bool Editar(Usuario obj, out string mensaje)
        {
            //Validaciones
            mensaje = string.Empty;

            if (obj.dni == 0)
            {
                mensaje += "Es necesario el DNI del usuario.\n";
            }

            if (obj.nombreCompleto == "")
            {
                mensaje += "Es necesario el nombre del usuario.\n";
            }

            if (obj.contraseña == "")
            {
                mensaje += "Es necesaria la contraseña del usuario.\n";
            }

            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_usuario.Editar(obj, out mensaje);
            }
        }

        public bool Eliminar(Usuario obj, out string mensaje)
        {
            //Validaciones
            mensaje = string.Empty;

            if (obj.dni == 0)
            {
                mensaje += "Es necesario el DNI del usuario.\n";
            }

            if (obj.nombreCompleto == "")
            {
                mensaje += "Es necesario el nombre del usuario.\n";
            }

            if (obj.contraseña == "")
            {
                mensaje += "Es necesaria la contraseña del usuario.\n";
            }

            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_usuario.Eliminar(obj, out mensaje);
            }
        }
    }
}
