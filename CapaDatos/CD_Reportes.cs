using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Reportes
    {
        public DataTable Recaudacion(DateTime desde, DateTime hasta, int idUsuario, bool incluirNC)
        {
            using (var cn = new SqlConnection(Conexion.cadena))
            using (var cmd = new SqlCommand("SP_REPORTE_RECAUDACION", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", desde.Date);
                cmd.Parameters.AddWithValue("@hasta", hasta.Date);
                cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                cmd.Parameters.AddWithValue("@incluir_nc", incluirNC);

                var dt = new DataTable();
                cn.Open();
                new SqlDataAdapter(cmd).Fill(dt);
                return dt;
            }
        }
        public DataTable ProductosMasVendidos(DateTime desde, DateTime hasta, int idUsuario, bool incluirNC)
        {
            using (var cn = new SqlConnection(Conexion.cadena))
            using (var cmd = new SqlCommand("SP_REPORTE_PRODUCTOS_MAS_VENDIDOS", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", desde.Date);
                cmd.Parameters.AddWithValue("@hasta", hasta.Date);
                cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                cmd.Parameters.AddWithValue("@incluir_nc", incluirNC);

                var dt = new DataTable();
                cn.Open();
                new SqlDataAdapter(cmd).Fill(dt);
                return dt;
            }
        }
        public DataTable TotalVentas(DateTime desde, DateTime hasta, int idUsuario, bool incluirNC)
        {
            using (var cn = new SqlConnection(Conexion.cadena))
            using (var cmd = new SqlCommand("SP_REPORTE_TOTAL_VENTAS", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desde", desde.Date);
                cmd.Parameters.AddWithValue("@hasta", hasta.Date);
                cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                cmd.Parameters.AddWithValue("@incluir_nc", incluirNC);

                var dt = new DataTable();
                cn.Open();
                new SqlDataAdapter(cmd).Fill(dt);
                return dt;
            }
        }
    }
}