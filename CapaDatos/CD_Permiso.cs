using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CapaEntidad;
namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permisos> Listar(int id_usuario)
        {
            List<Permisos> lista = new List<Permisos>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.id_rol,p.nombre_menu from permisos p");
                    query.AppendLine("inner join roles r on r.id_rol = p.id_rol");
                    query.AppendLine("inner join usuarios u on u.id_rol = r.id_rol");
                    query.AppendLine("where u.id_usuario = @id_usuario");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Permisos()
                            {
                                id_rol = new Roles() { id_rol = Convert.ToInt32(dr["id_rol"]) },
                                nombre_menu = dr["nombre_menu"].ToString()
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<Permisos>();
                }
            }

            return lista;

        }
    }
}
