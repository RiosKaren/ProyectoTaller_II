using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Talle_producto
    {
        public int id_talle { get; set; }
        public string talla { get; set; }
        public int stock { get; set; }
        public Productos id_producto { get; set; }
    }
}
