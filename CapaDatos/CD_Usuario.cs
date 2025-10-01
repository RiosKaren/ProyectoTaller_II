using CapaEntidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos 
{
    public class CD_Usuario 
    {
        public List<Usuarios> Listar() //utiliza el metodo Listar para obtener la lista de usuarios desde la base de datos
        {
            List<Usuarios> lista = new List<Usuarios>(); //crea una lista de usuarios
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)) //crea una conexion a la base de datos
            {
                try
                {
                    StringBuilder query = new StringBuilder(); //construye la consulta SQL
                    query.AppendLine("select u.id_usuario, u.nombre, u.apellido, u.email, u.usuario, u.dni, u.fecha_nacimiento," +
                        " u.sexo, u.hash_password, u.activo, r.id_rol, r.nombre from usuarios u"); //selecciona los campos de la tabla usuarios
                    query.AppendLine("inner join roles r on r.id_rol = u.id_rol"); //selecciona los campos de la tabla roles

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion); //crea un comando SQL
                    cmd.CommandType = CommandType.Text; //indica que el comando es de tipo texto

                    oconexion.Open(); //abre la conexion a la base de datos

                    using (SqlDataReader dr = cmd.ExecuteReader()) //ejecuta el comando y obtiene un lector de datos
                    {
                        while (dr.Read()) //lee los datos del lector
                        {
                            lista.Add(new Usuarios() //agrega un nuevo usuario a la lista
                            {
                                id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                nombre = dr["nombre"].ToString(),
                                apellido = dr["apellido"].ToString(),
                                email = dr["email"].ToString(),
                                usuario = dr["usuario"].ToString(),
                                dni = Convert.ToInt32(dr["dni"]),
                                fecha_nacimiento = Convert.ToDateTime(dr["fecha_nacimiento"]),
                                sexo = Convert.ToBoolean(dr["sexo"]),
                                hash_password = dr["hash_password"].ToString(),
                                activo = Convert.ToBoolean(dr["activo"]),
                                id_rol = new Roles() { id_rol = Convert.ToInt32(dr["id_rol"]), nombre = dr["nombre"].ToString()}
                            });
                        }
                    }
                }
                catch (Exception) //si ocurre un error, devuelve una lista vacia
                {
                    lista = new List<Usuarios>();
                }
            }   //si no ocurre ningun error, devuelve la lista de usuarios
            return lista;
        }


        public int Registrar(Usuarios obj, out string Mensaje) 
        {
            int idusuariogenerado = 0; //variable para almacenar el id del usuario generado
            Mensaje = string.Empty; //variable para almacenar el mensaje de error o exito

            try 
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)) //crea una conexion a la base de datos
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARUSUARIO", oconexion); //crea un comando SQL para ejecutar el procedimiento almacenado SP_REGISTRARUSUARIO
                    cmd.Parameters.AddWithValue("dni", obj.dni); 
                    cmd.Parameters.AddWithValue("nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("apellido", obj.apellido);
                    cmd.Parameters.AddWithValue("usuario", obj.usuario);
                    cmd.Parameters.AddWithValue("hash_password", obj.hash_password);
                    cmd.Parameters.AddWithValue("email", obj.email);
                    cmd.Parameters.AddWithValue("id_rol", obj.id_rol.id_rol);
                    cmd.Parameters.AddWithValue("activo", obj.activo ? 1 : 0);
                    cmd.Parameters.AddWithValue("sexo", obj.sexo ? 1 : 0);
                    cmd.Parameters.AddWithValue("fecha_nacimiento", obj.fecha_nacimiento);
                    cmd.Parameters.Add("IdUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    //se asignan los parametros del procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure; //indica que el comando es de tipo procedimiento almacenado

                    oconexion.Open(); //abre la conexion a la base de datos

                    cmd.ExecuteNonQuery(); //ejecuta el comando

                    idusuariogenerado = Convert.ToInt32(cmd.Parameters["IdUsuarioResultado"].Value); //obtiene el id del usuario generado
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString(); //obtiene el mensaje de error o exito

                }
            }
            catch (Exception ex) //si ocurre un error, devuelve 0 y el mensaje de error
            {
                idusuariogenerado = 0;
                Mensaje = ex.Message;
            }
            //si no ocurre ningun error, devuelve el id del usuario generado
            return idusuariogenerado;
        }


        public bool Editar(Usuarios obj, out string Mensaje) //Edita un usuario existente
        {
            bool respuesta = false; //variable para almacenar la respuesta del procedimiento almacenado
            Mensaje = string.Empty; //variable para almacenar el mensaje de error o exito

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)) //crea una conexion a la base de datos
                {
                    SqlCommand cmd = new SqlCommand("SP_EDITARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("id_usuario", obj.id_usuario);
                    cmd.Parameters.AddWithValue("dni", obj.dni);
                    cmd.Parameters.AddWithValue("nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("apellido", obj.apellido);
                    cmd.Parameters.AddWithValue("usuario", obj.usuario);
                    cmd.Parameters.AddWithValue("hash_password", obj.hash_password);
                    cmd.Parameters.AddWithValue("email", obj.email);
                    cmd.Parameters.AddWithValue("id_rol", obj.id_rol.id_rol);
                    cmd.Parameters.AddWithValue("activo", obj.activo ? 1 : 0);
                    cmd.Parameters.AddWithValue("sexo", obj.sexo ? 1 : 0);
                    cmd.Parameters.AddWithValue("fecha_nacimiento", obj.fecha_nacimiento);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
                    //se asignan los parametros del procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure; //indica que el comando es de tipo procedimiento almacenado

                    oconexion.Open(); //abre la conexion a la base de datos

                    cmd.ExecuteNonQuery(); //ejecuta el comando

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value); //obtiene la respuesta del procedimiento almacenado
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString(); //obtiene el mensaje de error o exito

                }
            }
            catch (Exception ex) //si ocurre un error, devuelve false y el mensaje de error
            {
                respuesta = false; //variable para almacenar la respuesta del procedimiento almacenado
                Mensaje = ex.Message;//variable para almacenar el mensaje de error o exito
            }


            return respuesta;
        }

        public bool CambiarEstado(Usuarios obj, string accion, out string Mensaje)
        {
            bool respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_AltaBajaUsuario", oconexion);
                    cmd.Parameters.AddWithValue("id_usuario", obj.id_usuario);
                    cmd.Parameters.AddWithValue("Accion", accion); // 'BAJA' o 'ALTA'
                    cmd.Parameters.Add("Respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }

            return respuesta;
        }


    }
}