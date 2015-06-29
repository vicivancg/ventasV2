using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using cd.comun;

namespace cd.reporte
{
    public class reporte
    {
        public static DataTable reporteNombre(string nombreCliente)
        {
            List<SqlParameter> parametros = new List<SqlParameter> { };
            parametros.Add(new SqlParameter("@nombreCliente", nombreCliente));
            try
            {
                return conexion.obtenerDatos("facturasNombre", CommandType.StoredProcedure, parametros);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Data);
                return null;
            }
        }

        public static DataTable reporteProducto(string nombreProducto)
        {
            List<SqlParameter> parametros = new List<SqlParameter> { };
            parametros.Add(new SqlParameter("@nombreProducto", nombreProducto));
            try
            {
                return conexion.obtenerDatos("facturasProducto", CommandType.StoredProcedure, parametros);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Data);
                return null;
            }
        }

        public static DataTable reportePeriodo(DateTime inicio, DateTime fin)
        {
            List<SqlParameter> parametros = new List<SqlParameter> { };
            parametros.Add(new SqlParameter("@inicio", inicio));
            parametros.Add(new SqlParameter("@fin", fin));
            try
            {
                return conexion.obtenerDatos("facturasPeriodo", CommandType.StoredProcedure, parametros);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Data);
                return null;
            }
        }
    }
}
