using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Producto
    {
        public List<Productos> Listar() //utiliza el metodo Listar para obtener la lista de Productos desde la base de datos
        {
            List<Productos> lista = new List<Productos>(); //crea una lista de Productos
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)) //crea una conexion a la base de datos
            {
                try
                {
                    StringBuilder query = new StringBuilder(); //construye la consulta SQL
                    query.AppendLine("select p.id_producto, p.codigo, p.nombre, p.descripcion, u.precio, p.imagen_url, p.activo from Productos p"); //selecciona los campos de la tabla Productos
                    query.AppendLine("inner join talle_producto t on t.id_talle = t.id_talle"); //selecciona los campos de la tabla talles

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion); //crea un comando SQL
                    cmd.CommandType = CommandType.Text; //indica que el comando es de tipo texto

                    oconexion.Open(); //abre la conexion a la base de datos

                    using (SqlDataReader dr = cmd.ExecuteReader()) //ejecuta el comando y obtiene un lector de datos
                    {
                        while (dr.Read()) //lee los datos del lector
                        {
                            lista.Add(new Productos() //agrega un nuevo producto a la lista
                            {
                                id_producto = Convert.ToInt32(dr["id_producto"]),
                                nombre = dr["nombre"].ToString(),
                                descripcion = dr["descripcion"].ToString(),
                                precio = Convert.ToDecimal(dr["precio"].ToString()),
                                imagen_url = dr["imagen_url"].ToString(),
                                activo = Convert.ToBoolean(dr["activo"])
                            });
                        }
                    }
                }
                catch (Exception) //si ocurre un error, devuelve una lista vacia
                {
                    lista = new List<Productos>();
                }
            }   //si no ocurre ningun error, devuelve la lista de Productos
            return lista;
        }


        public int Registrar(Productos obj, out string Mensaje)
        {
            int Resultado = 0; //variable para almacenar el id del producto generado
            Mensaje = string.Empty; //variable para almacenar el mensaje de error o exito

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)) //crea una conexion a la base de datos
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarProducto", oconexion); //crea un comando SQL para ejecutar el procedimiento almacenado SP_RegistrarProducto
                    cmd.Parameters.AddWithValue("codigo", obj.codigo);
                    cmd.Parameters.AddWithValue("nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("descripcion", obj.descripcion);
                    cmd.Parameters.AddWithValue("precio", obj.precio);
                    cmd.Parameters.AddWithValue("imagen_url", obj.imagen_url);
                    cmd.Parameters.AddWithValue("activo", obj.activo ? 1 : 0);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    //se asignan los parametros del procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure; //indica que el comando es de tipo procedimiento almacenado

                    oconexion.Open(); //abre la conexion a la base de datos

                    cmd.ExecuteNonQuery(); //ejecuta el comando

                    Resultado = Convert.ToInt32(cmd.Parameters["Resultado"].Value); //obtiene el id del producto generado
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString(); //obtiene el mensaje de error o exito

                }
            }
            catch (Exception ex) //si ocurre un error, devuelve 0 y el mensaje de error
            {
                Resultado = 0;
                Mensaje = ex.Message;
            }
            //si no ocurre ningun error, devuelve el id del producto generado
            return Resultado;
        }


        public bool Editar(Productos obj, out string Mensaje) //Edita un producto existente
        {
            bool Respuesta = false; //variable para almacenar la respuesta del procedimiento almacenado
            Mensaje = string.Empty; //variable para almacenar el mensaje de error o exito

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)) //crea una conexion a la base de datos
                {
                    SqlCommand cmd = new SqlCommand("SP_EditarProducto", oconexion); //crea un comando SQL para ejecutar el procedimiento almacenado SP_EditarProducto
                    cmd.Parameters.AddWithValue("codigo", obj.codigo);
                    cmd.Parameters.AddWithValue("nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("descripcion", obj.descripcion);
                    cmd.Parameters.AddWithValue("precio", obj.precio);
                    cmd.Parameters.AddWithValue("imagen_url", obj.imagen_url);
                    cmd.Parameters.AddWithValue("activo", obj.activo ? 1 : 0);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    //se asignan los parametros del procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure; //indica que el comando es de tipo procedimiento almacenado

                    oconexion.Open(); //abre la conexion a la base de datos

                    cmd.ExecuteNonQuery(); //ejecuta el comando

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value); //obtiene la respuesta del procedimiento almacenado
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString(); //obtiene el mensaje de error o exito

                }
            }
            catch (Exception ex) //si ocurre un error, devuelve false y el mensaje de error
            {
                Respuesta = false; //variable para almacenar la respuesta del procedimiento almacenado
                Mensaje = ex.Message;//variable para almacenar el mensaje de error o exito
            }


            return Respuesta;
        }

        public bool CambiarEstado(Productos obj, string accion, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_AltaBajaProducto", oconexion);
                    cmd.Parameters.AddWithValue("id_producto", obj.id_producto);
                    cmd.Parameters.AddWithValue("Accion", accion); // 'BAJA' o 'ALTA'
                    cmd.Parameters.Add("Respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }

            return Respuesta;
        }

    }
}
