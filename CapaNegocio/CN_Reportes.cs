using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;


namespace CapaNegocio
{
    public class CN_Reportes
    {
        private readonly CD_Reportes _cd = new CD_Reportes();

        public DataTable ObtenerRecaudacion(DateTime desde, DateTime hasta, int idUsuario = 0, bool incluirNC = true)
        {
            return _cd.Recaudacion(desde, hasta, idUsuario, incluirNC);
        }

        public DataTable ObtenerProductosMasVendidos(DateTime desde, DateTime hasta, int idUsuario = 0, bool incluirNC = false)
        {
            return _cd.ProductosMasVendidos(desde, hasta, idUsuario, incluirNC);
        }
        public DataTable ObtenerTotalVentas(DateTime desde, DateTime hasta, int idUsuario = 0, bool incluirNC = false)
        {
            return _cd.TotalVentas(desde, hasta, idUsuario, incluirNC);
        }
    }
}