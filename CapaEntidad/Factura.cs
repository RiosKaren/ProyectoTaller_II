using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Factura
    {
        public int id_factura { get; set; }
        public DateTime fecha { get; set; }
        public decimal importe_total { get; set; }
        public Clientes id_cliente { get; set; }
        public int dni { get; set; }
        public Usuarios id_usuario { get; set; }
    } //Representacion de la tabla facturas, con sus respectivos atributos
}
