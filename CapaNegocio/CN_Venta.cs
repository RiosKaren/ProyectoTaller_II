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
        private CD_Venta objcd_venta = new CD_Venta();
        private readonly CD_Venta _cd = new CD_Venta();

        public bool RegistrarVenta(int puntoVenta, int idCliente, int idUsuario, DataTable detalles,
                                   out int idFactura, out string nroFactura, out string mensaje)
            => _cd.RegistrarVenta(puntoVenta, idCliente, idUsuario, detalles, out idFactura, out nroFactura, out mensaje);

        public List<Factura> ListarVentas()
        {
            return objcd_venta.ListarVentas();
        }

        public DataSet ObtenerVentaDS(int idFactura) => _cd.ObtenerVenta(idFactura);

        public bool RegistrarDevolucion(
            int puntoVenta,
            int idFacturaOrigen,
            int idUsuario,
            DataTable detallesDevolucion,
            out int idFacturaNC,
            out string nroFacturaNC,
            out string mensaje)
        {
            var cd = new CD_Venta();
            return cd.RegistrarDevolucion(
                puntoVenta, idFacturaOrigen, idUsuario, detallesDevolucion,
                out idFacturaNC, out nroFacturaNC, out mensaje);
        }


    }
}
