using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Clientes
    {
        public int id_cliente { get; set; }
        public int dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public bool sexo { get; set; }
        public string telefono { get; set; }
        public bool activo { get; set; }
    } //Representacion de la tabla clientes, con sus respectivos atributos
}
