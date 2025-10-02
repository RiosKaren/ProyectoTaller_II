using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Producto
    {
        private CD_Producto objcd_producto = new CD_Producto();

        public List<Productos> Listar()
        {
            return objcd_producto.Listar(); //devuelve la lista de Productos obtenida desde la capa de datos
        }

        public int Registrar(Productos obj, out string Mensaje)
        {
            return objcd_producto.Registrar(obj, out Mensaje); //Devuelve el id del usuario registrado desde la capa de datos
        }

        public bool Editar(Productos obj, out string Mensaje)
        {
            return objcd_producto.Editar(obj, out Mensaje); //Devuelve true o false si se edito el usuario desde la capa de datos
        }

        public bool CambiarEstado(Productos obj, string accion, out string Mensaje)
        {
            return objcd_producto.CambiarEstado(obj, accion, out Mensaje);
        }
    }
}
