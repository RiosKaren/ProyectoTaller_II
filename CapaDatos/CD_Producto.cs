using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                            ISNULL(
                            STRING_AGG(CONCAT('[', t.talla, '] - ', t.stock, ' pares'), CHAR(13) + CHAR(10)) 
                            WITHIN GROUP (ORDER BY t.talla),
                            ''
                        ) AS tallesTexto,
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

        public List<Talle_producto> ObtenerTallesPorProducto(int idProducto)
        {
            List<Talle_producto> lista = new List<Talle_producto>();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString()))
                {
                    string query = @"SELECT id_talle, talla, stock
                             FROM talle_producto
                             WHERE id_producto = @id_producto AND stock > 0
                             ORDER BY talla";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id_producto", idProducto);
                    cmd.CommandType = CommandType.Text;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Talle_producto()
                            {
                                id_talle = Convert.ToInt32(dr["id_talle"]),
                                talla = dr["talla"].ToString(),
                                stock = Convert.ToInt32(dr["stock"]),
                                id_producto = new Productos() { id_producto = idProducto }
                            });
                        }
                    }
                }
            }
            catch
            {
                lista = new List<Talle_producto>();
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
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARPRODUCTO", oconexion); //crea un comando SQL para ejecutar el procedimiento almacenado SP_RegistrarProducto
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
                    SqlCommand cmd = new SqlCommand("SP_EDITARPRODUCTO", oconexion); //crea un comando SQL para ejecutar el procedimiento almacenado SP_EditarProducto
                    cmd.Parameters.AddWithValue("@id_producto", obj.id_producto);
                    cmd.Parameters.AddWithValue("codigo", obj.codigo);
                    cmd.Parameters.AddWithValue("nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("descripcion", obj.descripcion);
                    cmd.Parameters.AddWithValue("precio", obj.precio);
                    if (string.IsNullOrEmpty(obj.imagen_url))
                        cmd.Parameters.AddWithValue("@imagen_url", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@imagen_url", obj.imagen_url);
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

        public List<Talle_producto> ObtenerProductosStock()
        {
            List<Talle_producto> lista = new List<Talle_producto>();

            string query = @"
        SELECT 
            tp.id_talle,
            tp.talla,
            tp.stock,
            p.id_producto,
            p.nombre,
            p.codigo,
            p.descripcion,
            p.imagen_url,
            p.activo
        FROM talle_producto tp
        INNER JOIN productos p ON tp.id_producto = p.id_producto
        WHERE tp.stock <= 10
        ORDER BY tp.stock ASC;
    ";

            using (SqlConnection conn = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Talle_producto talleProd = new Talle_producto
                    {
                        id_talle = Convert.ToInt32(reader["id_talle"]),
                        talla = reader["talla"].ToString(),
                        stock = Convert.ToInt32(reader["stock"]),
                        id_producto = new Productos
                        {
                            id_producto = Convert.ToInt32(reader["id_producto"]),
                            nombre = reader["nombre"].ToString(),
                            codigo = reader["codigo"].ToString(),
                            descripcion = reader["descripcion"].ToString(),
                            imagen_url = reader["imagen_url"].ToString(),
                            activo = Convert.ToBoolean(reader["activo"])
                        }
                    };

                    lista.Add(talleProd);
                }

                reader.Close();
            }

            return lista;
        }


    }
}
