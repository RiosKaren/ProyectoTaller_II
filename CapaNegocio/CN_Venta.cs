using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Venta
    {
        private readonly CD_Venta _cd = new CD_Venta();

        public bool RegistrarVenta(int idCliente, int idUsuario, DataTable detalles,
                                   out int idFactura, out string mensaje)
            => _cd.RegistrarVenta(idCliente, idUsuario, detalles, out idFactura, out mensaje);
    }
}
