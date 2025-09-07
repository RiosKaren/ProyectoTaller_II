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
                    string query = "select id_usuario, nombre, apellido, email, usuario, dni, fecha_nacimiento, sexo, hash_password, activo from usuarios";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
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
                                activo = Convert.ToBoolean(dr["activo"])
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