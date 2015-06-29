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

namespace cd.producto
{
    public class producto
    {
        public static string obtenerProdAct()
        {
            List<SqlParameter> parametros = new List<SqlParameter> { };
            parametros.Add(new SqlParameter("@claveAct", SqlDbType.NVarChar,20));
            parametros[0].Direction = ParameterDirection.Output;
            parametros[0].Size = 20;
            return conexion.ejecutarQuery("ProdAct", CommandType.StoredProcedure, parametros, "@claveAct").ToString(); ;//regresa la cadena del usr act
        }

        public static bool NuevoProducto(string clave, string nombre, string desc, string unMed, decimal exist, decimal precTot,decimal iva, string fecha_registro)
        {
            bool result = false;
            List<SqlParameter> parametros = new List<SqlParameter> { };
            parametros.Add(new SqlParameter("@cve_prod",clave));
            parametros.Add(new SqlParameter("@nombre_prod",nombre));
            parametros.Add(new SqlParameter("@desc_prod",desc));
            parametros.Add(new SqlParameter("@um_prod",unMed));
            parametros.Add(new SqlParameter("@exist_prod",exist));
            parametros.Add(new SqlParameter("@prec_tot",precTot));
            parametros.Add(new SqlParameter("@iva_prod",iva));
            parametros.Add(new SqlParameter("@fecha_registro", fecha_registro));
            try
            {
                conexion.ejecutarQuery("NuevoProducto", CommandType.StoredProcedure, parametros);
                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public static DataTable mostrarProducto(string nomClave)
        {
            List<SqlParameter> parametros = new List<SqlParameter> { };
            parametros.Add(new SqlParameter("@nomClave",nomClave));
            try
            {
                return conexion.obtenerDatos("mostrarProductos", CommandType.StoredProcedure,parametros);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Data);
                return null;
            }
        }

        public static bool modificarProducto(string clave, string nombre, string desc, string unMed, decimal exist, decimal precTot, decimal iva)
        {
            bool result = false;
            List<SqlParameter> parametros = new List<SqlParameter> { };
            parametros.Add(new SqlParameter("@cve_prod", clave));
            parametros.Add(new SqlParameter("@nombre_prod", nombre));
            parametros.Add(new SqlParameter("@desc_prod", desc));
            parametros.Add(new SqlParameter("@um_prod", unMed));
            parametros.Add(new SqlParameter("@exist_prod", exist));
            parametros.Add(new SqlParameter("@prec_tot", precTot));
            parametros.Add(new SqlParameter("@iva_prod", iva));
            try
            {
                conexion.ejecutarQuery("modificaProducto", CommandType.StoredProcedure, parametros);
                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public static bool eliminarProducto(string clave)
        {
            bool result = false;
            List<SqlParameter> parametros = new List<SqlParameter> { };
            parametros.Add(new SqlParameter("@cve_prod", clave));
            try
            {
                conexion.ejecutarQuery("eliminaProducto", CommandType.StoredProcedure, parametros);
                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public static bool NuevaOrden(string claveProducto, decimal cantidad, DateTime fecha)
        {
            bool result = false;
            List<SqlParameter> parametros = new List<SqlParameter> { };
            parametros.Add(new SqlParameter("@cveProducto", claveProducto));
            parametros.Add(new SqlParameter("@cantidad",cantidad));
            parametros.Add(new SqlParameter("@fechaRegistro", fecha));
            try
            {
                conexion.ejecutarQuery("ordenCompra", CommandType.StoredProcedure, parametros);
                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
        }
    }
}
