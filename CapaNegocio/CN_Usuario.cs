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
        private CD_Usuario objcd_usuario = new CD_Usuario();

        public List<Usuarios> Listar()
        {
            return objcd_usuario.Listar(); //devuelve la lista de usuarios obtenida desde la capa de datos
        }

        public int Registrar(Usuarios obj, out string Mensaje)
        {
            return objcd_usuario.Registrar(obj,out Mensaje); //Devuelve el id del usuario registrado desde la capa de datos
        }

        public bool Editar(Usuarios obj, out string Mensaje)
        {
            return objcd_usuario.Editar(obj, out Mensaje); //Devuelve true o false si se edito el usuario desde la capa de datos
        }

        public bool CambiarEstado(Usuarios obj, string accion, out string Mensaje)
        {
            return objcd_usuario.CambiarEstado(obj, accion, out Mensaje);
        }

    }
}