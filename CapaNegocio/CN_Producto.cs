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

        public List<Productos> ListarActivosConStock()
        {
            List<Productos> lista = new CD_Producto().Listar();
            return lista
                .Where(p => p.activo == true && p.stock_total > 0)
                .ToList(); // devuelve solo los productos activos con stock
        }

        public List<Talle_producto> ObtenerProductosStock()
        {
            return objcd_producto.ObtenerProductosStock(); //devuelve la lista de Productos obtenida desde la capa de datos
        }


        public List<Talle_producto> ObtenerTallesPorProducto(int idProducto)
        {
            return objcd_producto.ObtenerTallesPorProducto(idProducto);
        }

        public int Registrar(Productos obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (string.IsNullOrEmpty(obj.nombre))
            {
                Mensaje = "El nombre del producto no puede estar vacío.";
                return 0;
            }
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
