using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permisos> Listar(int id_usuario) // Devuelve la lista de permisos que tiene un usuario
        {
            List<Permisos> lista = new List<Permisos>(); // instancia una lista de permisos
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)) // crea una conexion a la base de datos
            {
                try
                {
                    StringBuilder query = new StringBuilder();// Se utiliza StringBuilder para armar la consulta de manera eficiente
                    query.AppendLine("select p.id_rol,p.nombre_menu from permisos p"); // Selecciona el id del rol y el nombre del menú desde la tabla permisos
                    query.AppendLine("inner join roles r on r.id_rol = p.id_rol"); // Relaciona la tabla permisos con la tabla roles usando el id_rol
                    query.AppendLine("inner join usuarios u on u.id_rol = r.id_rol"); // Relaciona la tabla roles con la tabla usuarios usando el id_rol
                    query.AppendLine("where u.id_usuario = @id_usuario"); // Filtra los resultados para obtener solo los permisos del usuario especificado

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);// Crea un comando SQL utilizando la consulta armada y la conexión a la base de datos
                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario); // Agrega el parámetro @id_usuario a la consulta, asignándole el valor recibido por el método
                    cmd.CommandType = CommandType.Text; // Especifica que el comando es una consulta de texto y no un procedimiento


                    oconexion.Open(); //abre la conexion a la base de datos

                    using (SqlDataReader dr = cmd.ExecuteReader()) //ejecuta el comando y obtiene un lector de datos
                    {
                        while (dr.Read()) //mientras haya filas para leer en el datareader
                        {
                            lista.Add(new Permisos() //agrega un nuevo objeto Permisos a la lista con los siguientes atributos
                            {
                                id_rol = new Roles() { id_rol = Convert.ToInt32(dr["id_rol"]) }, //convierte el valor de id_rol a entero y lo asigna a la propiedad id_rol del objeto Roles
                                nombre_menu = dr["nombre_menu"].ToString() //convierte el valor leido a cadena y lo asigna a la propiedad "nombre_menu" del objeto Permisos
                            });
                        }
                    }
                }
                catch (Exception) // si ocurre una excepcion
                {
                    lista = new List<Permisos>(); // reinicia la lista a una nueva lista vacia
                }
            }
            //si no hubo excepcion, devuelve la lista de permisos obtenida de la base de datos
            return lista;

        }
    }
}
