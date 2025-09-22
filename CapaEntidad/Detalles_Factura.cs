using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalles_Factura
    {
        public int id_detalle { get; set; }
        public int cantidad { get; set; }
        public float precio_unitario { get; set; }
        public float subtotal { get; set; }
        public bool activo { get; set; }
        public Facturas id_factura { get; set; }
        public Productos id_producto { get; set; }
    } //Representacion la tabla detalles_factura, con sus respectivos atributos
}
