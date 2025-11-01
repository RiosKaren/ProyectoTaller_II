using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;

namespace CapaDatos
{
    public class CD_Venta
    {
        public static DataTable NuevaTablaDetalles()
        {
            var dt = new DataTable();
            dt.Columns.Add("id_talle", typeof(int));
            dt.Columns.Add("cantidad", typeof(int));
            dt.Columns.Add("precio_unitario", typeof(decimal));
            return dt;
        }

        public bool RegistrarVenta(int puntoVenta, int idCliente, int idUsuario, DataTable detalles,
                                   out int idFactura, out string nroFactura, out string mensaje)
        {
            idFactura = 0;
            nroFactura = string.Empty;
            mensaje = string.Empty;

            try
            {
                using (var cn = new SqlConnection(Conexion.cadena))
                using (var cmd = new SqlCommand("SP_REGISTRARVENTA", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@punto_venta", puntoVenta);
                    cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                    cmd.Parameters.AddWithValue("@id_usuario", idUsuario);

                    var pDetalles = cmd.Parameters.AddWithValue("@detalles_factura", detalles);
                    pDetalles.SqlDbType = SqlDbType.Structured;
                    pDetalles.TypeName = "dbo.Edetalles_factura";

                    var pId = new SqlParameter("@IdFacturaResultado", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    var pNro = new SqlParameter("@NroFactura", SqlDbType.VarChar, 15) { Direction = ParameterDirection.Output };
                    var pRes = new SqlParameter("@Resultado", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    var pMsg = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500) { Direction = ParameterDirection.Output };

                    cmd.Parameters.Add(pId);
                    cmd.Parameters.Add(pNro);
                    cmd.Parameters.Add(pRes);
                    cmd.Parameters.Add(pMsg);

                    cn.Open();
                    cmd.ExecuteNonQuery();

                    idFactura = (int)(pId.Value ?? 0);
                    nroFactura = pNro.Value?.ToString() ?? "";
                    var ok = pRes.Value != DBNull.Value && (bool)pRes.Value;
                    mensaje = pMsg.Value?.ToString() ?? "";

                    return ok;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;
            }
        }

        public List<Factura> ListarVentasPorUsuario(int idUsuario, bool incluirDevoluciones = false)
        {
            var lista = new List<Factura>();

            using (var cn = new SqlConnection(Conexion.cadena))
            using (var cmd = new SqlCommand(@"
                SELECT f.id_factura,
                       f.nro_factura,
                       f.id_cliente,
                       c.dni,
                       f.importe_total,
                       f.fecha
                FROM dbo.factura f
                INNER JOIN dbo.clientes c ON c.id_cliente = f.id_cliente
                WHERE f.id_usuario = @id_usuario
                  AND (@incluir = 1 OR f.importe_total >= 0)   -- por defecto: solo ventas, sin NC
                ORDER BY f.id_factura DESC;", cn))
            {
                cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                cmd.Parameters.Add("@incluir", SqlDbType.Bit).Value = incluirDevoluciones ? 1 : 0;

                cn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Factura
                        {
                            id_factura = Convert.ToInt32(dr["id_factura"]),
                            nro_factura = dr["nro_factura"].ToString(),
                            fecha = Convert.ToDateTime(dr["fecha"]),
                            id_cliente = new Clientes
                            {
                                id_cliente = Convert.ToInt32(dr["id_cliente"]),
                                dni = Convert.ToInt32(dr["dni"])
                            },
                            importe_total = Convert.ToDecimal(dr["importe_total"]),
                        });
                    }
                }
            }
            return lista;
        }

        /*
        public List<Factura> ListarVentas()
        {
            var lista = new List<Factura>();

            using (var cn = new SqlConnection(Conexion.cadena))
            using (var cmd = new SqlCommand(@"
                SELECT f.id_factura,
                       f.nro_factura,
                       f.id_cliente,
                       c.dni,
                       f.importe_total,
                       f.fecha
                FROM factura f
                INNER JOIN clientes c ON c.id_cliente = f.id_cliente
                ORDER BY f.id_factura DESC;", cn))
            {
                cn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {

                        lista.Add(new Factura
                        {
                            id_factura = Convert.ToInt32(dr["id_factura"]),
                            nro_factura = dr["nro_factura"].ToString(),
                            fecha = Convert.ToDateTime(dr["fecha"]),
                            id_cliente = new Clientes               // construir el objeto
                            {
                                id_cliente = Convert.ToInt32(dr["id_cliente"]),
                                dni = Convert.ToInt32(dr["dni"])
                                                                 
                            },
                            importe_total = Convert.ToDecimal(dr["importe_total"]),
                            
                        });
                    }
                }
            }
            return lista;
        }
        */

        public DataSet ObtenerVenta(int idFactura)
        {
            using (var cn = new SqlConnection(Conexion.cadena))
            using (var cmd = new SqlCommand("SP_OBTENER_VENTA", cn))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_factura", idFactura);

                var ds = new DataSet();
                cn.Open();
                da.Fill(ds);

                ds.Tables[0].TableName = "Cabecera";
                ds.Tables[1].TableName = "Detalle";
                return ds;
            }
        }

        public bool RegistrarDevolucion(int puntoVenta, int idFacturaOrigen, int idUsuario,
                                out int idFacturaNC, out string nroFacturaNC, out string mensaje)
        {
                idFacturaNC = 0;
                nroFacturaNC = string.Empty;
                mensaje = string.Empty;

            try
            {
                using (var cn = new SqlConnection(Conexion.cadena))
                using (var cmd = new SqlCommand("SP_REGISTRARDEVOLUCION_TOTAL", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@punto_venta", puntoVenta);
                    cmd.Parameters.AddWithValue("@id_factura_origen", idFacturaOrigen);
                    cmd.Parameters.AddWithValue("@id_usuario", idUsuario);

                    var pId = new SqlParameter("@IdFacturaNC", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    var pNro = new SqlParameter("@NroFacturaNC", SqlDbType.VarChar, 16) { Direction = ParameterDirection.Output };
                    var pRes = new SqlParameter("@Resultado", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    var pMsg = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500) { Direction = ParameterDirection.Output };

                    cmd.Parameters.Add(pId);
                    cmd.Parameters.Add(pNro);
                    cmd.Parameters.Add(pRes);
                    cmd.Parameters.Add(pMsg);

                    cn.Open();
                    cmd.ExecuteNonQuery();

                    idFacturaNC = (int)(pId.Value ?? 0);
                    nroFacturaNC = pNro.Value?.ToString() ?? "";
                    mensaje = pMsg.Value?.ToString() ?? "";

                    return (pRes.Value != DBNull.Value) && (bool)pRes.Value;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;
            }
        }



    }
}