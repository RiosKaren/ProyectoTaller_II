using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Rol
    {
        public List<Roles> Listar() // Devuelve la lista de roles
        {
            List<Roles> lista = new List<Roles>(); // instancia una lista de roles
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)) // crea una conexion a la base de datos
            {
                try
                {
                    StringBuilder query = new StringBuilder(); // instancia un objeto StringBuilder para construir la consulta SQL
                    query.AppendLine("select id_rol,nombre from roles"); // agrega la consulta SQL para seleccionar los roles

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion); // crea un comando SQL con la consulta y la conexion
                    cmd.CommandType = CommandType.Text; // especifica que el comando es de tipo texto

                    oconexion.Open(); //abre la conexion a la base de datos

                    using (SqlDataReader dr = cmd.ExecuteReader()) // ejecuta el comando y obtiene un lector de datos
                    {
                        while (dr.Read()) //mientras haya filas para leer en el dr
                        {
                            lista.Add(new Roles() // agrega un nuevo objeto Roles a la lista
                            {
                                id_rol = Convert.ToInt32(dr["id_rol"]), // convierte el valor de id_rol a entero y lo asigna a la propiedad id_rol del objeto Roles
                                nombre = dr["nombre"].ToString() //convierte el valor leido a cadena y lo asigna a la propiedad "nombre" del objeto Roles
                            }); 
                        }
                    }
                }
                catch (Exception) // si ocurre una excepcion
                {
                    lista = new List<Roles>(); // reinicia la lista a una nueva lista vacia
                }
            }
            //si no hubo excepcion, devuelve la lista de roles obtenida de la base de datos
            return lista;
        }
    }
}
