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

        public bool RegistrarVenta(int idCliente, int idUsuario, DataTable detalles,
                                   out int idFactura, out string mensaje)
        {
            idFactura = 0;
            mensaje = string.Empty;

            try
            {
                using (var cn = new SqlConnection(Conexion.cadena))
                using (var cmd = new SqlCommand("SP_REGISTRARVENTA", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                    cmd.Parameters.AddWithValue("@id_usuario", idUsuario);

                    var pDetalles = cmd.Parameters.AddWithValue("@detalles_factura", detalles);
                    pDetalles.SqlDbType = SqlDbType.Structured;
                    pDetalles.TypeName = "dbo.Edetalles_factura";

                    var pId = new SqlParameter("@IdFacturaResultado", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    var pRes = new SqlParameter("@Resultado", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    var pMsg = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500) { Direction = ParameterDirection.Output };

                    cmd.Parameters.Add(pId);
                    cmd.Parameters.Add(pRes);
                    cmd.Parameters.Add(pMsg);

                    cn.Open();
                    cmd.ExecuteNonQuery();

                    idFactura = (int)(pId.Value ?? 0);
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
    }
}