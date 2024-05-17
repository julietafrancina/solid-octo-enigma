using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        private CD_Cliente objcd_Cliente = new CD_Cliente();

        public List<Cliente> listar()
        {
            return objcd_Cliente.listar();
        }


        public int Registrar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.dni.ToString() == "")
            {
                Mensaje += "Es necesario el documento del Cliente\n";
            }

            if (obj.nombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre completo del Cliente\n";
            }

            if (obj.correo == "")
            {
                Mensaje += "Es necesario el correo del Cliente\n";
            }

            if (obj.telefono == "")
            {
                Mensaje += "Es necesario el telefono del Cliente\n";
            }

            if (obj.domicilio == "")
            {
                Mensaje += "Es necesario el domicilio del Cliente\n";
            }

            if (obj.fechaNacimiento == null)
            {
                Mensaje += "Es necesaria la fecha de nacimiento del Cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Cliente.Registrar(obj, out Mensaje);
            }

        }

        public bool Editar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.dni.ToString() == "")
            {
                Mensaje += "Es necesario el documento del Cliente\n";
            }

            if (obj.nombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre completo del Cliente\n";
            }

            if (obj.correo == "")
            {
                Mensaje += "Es necesario el correo del Cliente\n";
            }

            if (obj.telefono == "")
            {
                Mensaje += "Es necesario el telefono del Cliente\n";
            }

            if (obj.domicilio == "")
            {
                Mensaje += "Es necesario el domicilio del Cliente\n";
            }

            if (obj.fechaNacimiento == null)
            {
                Mensaje += "Es necesaria la fecha de nacimiento del Cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Cliente.Editar(obj, out Mensaje);
            }

        }

        public bool Eliminar(Cliente obj, out string Mensaje)
        {
            return objcd_Cliente.Eliminar(obj, out Mensaje);
        }


    }
}
