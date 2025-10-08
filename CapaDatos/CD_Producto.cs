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
        public List<Productos> Listar()
        {
            List<Productos> lista = new List<Productos>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine(@"
                        SELECT 
                            p.id_producto,
                            p.codigo,
                            p.nombre,
                            p.descripcion,
                            p.precio,
                            p.imagen_url,
                            p.activo,
                            ISNULL(STRING_AGG(CONCAT('[', t.talla, '] - ', t.stock, ' pares'), CHAR(10)), '') AS tallesTexto,
                            ISNULL(SUM(t.stock), 0) AS stock_total
                        FROM productos p
                        LEFT JOIN talle_producto t ON p.id_producto = t.id_producto
                        GROUP BY p.id_producto, p.codigo, p.nombre, p.descripcion, p.precio, p.imagen_url, p.activo
                    ");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Productos()
                            {
                                id_producto = Convert.ToInt32(dr["id_producto"]),
                                codigo = dr["codigo"].ToString(),
                                nombre = dr["nombre"].ToString(),
                                descripcion = dr["descripcion"].ToString(),
                                precio = Convert.ToDecimal(dr["precio"]),
                                imagen_url = dr["imagen_url"].ToString(),
                                activo = Convert.ToBoolean(dr["activo"]),
                                tallesTexto = dr["tallesTexto"].ToString(),
                                stock_total = Convert.ToInt32(dr["stock_total"])
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<Productos>();
                }
            }

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
