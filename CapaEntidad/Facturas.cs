using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Facturas
    {
        public int id_factura { get; set; }
        public string fecha { get; set; }
        public float importe_total { get; set; }
        public Clientes id_cliente { get; set; }
        public Usuarios id_usuario { get; set; }
    } //definicion de la tabla facturas, con sus respectivos atributos
}
