using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Productos
    {
        public int id_producto { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public string imagen_url { get; set; }
        public bool activo { get; set; }

        // Propiedades derivadas (para mostrar en el DGV)
        public string tallesTexto { get; set; }
        public int stock_total { get; set; }

    }//Representacion de la tabla productos, con sus respectivos atributos
}
