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
        public List<Roles> Listar()
        {
            List<Roles> lista = new List<Roles>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select id_rol,nombre from roles");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Roles()
                            {
                                id_rol = Convert.ToInt32(dr["id_rol"]),
                                nombre = dr["nombre"].ToString()
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<Roles>();
                }
            }

            return lista;

        }
    }
}
