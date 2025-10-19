using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalle_Factura
    {
        public int id_detalle { get; set; }
        public int cantidad { get; set; }
        public decimal precio_unitario { get; set; }
        public decimal subtotal { get; set; }
        public bool activo { get; set; }
        public Factura id_factura { get; set; }
        public Talle_producto id_talle { get; set; }
    } //Representacion la tabla detalles_factura, con sus respectivos atributos
}
