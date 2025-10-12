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
        private CD_Cliente objCD_Cliente = new CD_Cliente();

        public List<Clientes> Listar()
        {
            return objCD_Cliente.Listar(); //devuelve la lista de clientes obtenida desde la capa de datos
        }

        public int Registrar(Clientes obj, out string Mensaje)
        {
            return objCD_Cliente.Registrar(obj, out Mensaje); //Devuelve el id del cliente registrado desde la capa de datos
        }

        public bool Editar(Clientes obj, out string Mensaje)
        {
            return objCD_Cliente.Editar(obj, out Mensaje); //Devuelve true o false si se edito el cliente desde la capa de datos
        }

        public bool CambiarEstado(int idCliente, string accion, out string Mensaje)
        {
            return objCD_Cliente.CambiarEstado(idCliente, accion, out Mensaje);
        }


    }
}
