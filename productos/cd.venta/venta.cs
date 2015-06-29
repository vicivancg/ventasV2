using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using cd.comun;

namespace cd.venta
{
    public class venta
    {
        public static int realizaVenta(string cve_cliente, decimal total_fact, decimal subTotal_fact, decimal iva_fact, decimal cargo_fact, DateTime fecha_fact,DataTable productos)
        {
            List<SqlParameter> parametros = new List<SqlParameter> { };
            parametros.Add(new SqlParameter("@idFact",SqlDbType.Int));
            parametros[0].Direction = ParameterDirection.Output;
            parametros.Add(new SqlParameter("@cve_cliente",cve_cliente));
            parametros.Add(new SqlParameter("@total_fact", total_fact));
            parametros.Add(new SqlParameter("@subTotal_fact", subTotal_fact));
            parametros.Add(new SqlParameter("@iva_fact", iva_fact));
            parametros.Add(new SqlParameter("@cargo_fact", cargo_fact));
            parametros.Add(new SqlParameter("@fecha_fact", fecha_fact));
            parametros.Add(new SqlParameter("@productosTable", productos));
            return Convert.ToInt32(conexion.ejecutarQuery("nuevaFactura", CommandType.StoredProcedure, parametros, "@idFact"));
        }
    }
}
