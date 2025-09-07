using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Permisos
    {
        public int id_permiso { get; set; }
        public string nombre_menu { get; set; }
        public Roles id_rol { get; set; }
    }
}
