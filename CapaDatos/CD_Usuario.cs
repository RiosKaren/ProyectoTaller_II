using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuarios> Listar()
        {
            List<Usuarios> lista = new List<Usuarios>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select u.id_usuario, u.nombre, u.apellido, u.email, u.usuario, u.dni, u.fecha_nacimiento, u.sexo, u.hash_password, u.activo, r.id_rol, r.nombre from usuarios u");
                    query.AppendLine("inner join roles r on r.id_rol = u.id_rol");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuarios()
                            {
                                id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                nombre = dr["nombre"].ToString(),
                                apellido = dr["apellido"].ToString(),
                                email = dr["email"].ToString(),
                                usuario = dr["usuario"].ToString(),
                                dni = Convert.ToInt32(dr["dni"]),
                                fecha_nacimiento = dr["fecha_nacimiento"].ToString(),
                                sexo = Convert.ToBoolean(dr["sexo"]),
                                hash_password = dr["hash_password"].ToString(),
                                activo = Convert.ToBoolean(dr["activo"]),
                                id_rol = new Roles() { id_rol = Convert.ToInt32(dr["id_rol"]), 
                                nombre = dr["nombre"].ToString()}
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<Usuarios>();
                }
            }


            return lista;

        }
    }
}