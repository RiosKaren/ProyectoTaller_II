using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuarios
    {
        public int id_usuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string usuario { get; set; }
        public int dni { get; set; }
        public string fecha_nacimiento { get; set; }
        public bool sexo { get; set; }
        public string hash_password { get; set; }
        public bool activo { get; set; }
        public Roles id_rol { get; set; }
    }
}
