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
        private CD_Usuario objcd_Usuario = new CD_Usuario();
        public List<Usuario> Listar()
        {
            return objcd_Usuario.Listar();
        }

        public int Registrar(Usuario obj,out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el Documento del usuario\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del usuario\n";
            }

            if (obj.Contraseña == "")
            {
                Mensaje += "Es necesario la contraseña del usuario\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Usuario.Registrar(obj, out Mensaje);
            }
           
        }

        public bool Editar(Usuario obj,out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el Documento del usuario\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del usuario\n";
            }

            if (obj.Contraseña == "")
            {
                Mensaje += "Es necesario la contraseña del usuario\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Usuario.Editar(obj, out Mensaje);
            }



            
        }

        public bool Eliminar(Usuario obj,out string Mensaje)
        {
            return objcd_Usuario.Eliminar(obj, out Mensaje);
        }
    }
}
