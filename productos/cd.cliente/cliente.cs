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

namespace cd.cliente
{
    public class cliente
    {
        public static string obtenerClienteAct()
        {
            List<SqlParameter> parametros = new List<SqlParameter> { };
            parametros.Add(new SqlParameter("@claveAct", SqlDbType.NVarChar, 20));
            parametros[0].Direction = ParameterDirection.Output;
            parametros[0].Size = 20;
            return conexion.ejecutarQuery("obtieneClave", CommandType.StoredProcedure, parametros, "@claveAct").ToString(); ;//regresa la cadena del usr act
        }

        public static bool NuevoCliente(string clave, string nombre, string tel, string dir, string rfc)
        {
            bool result = false;
            List<SqlParameter> parametros = new List<SqlParameter> { };
            parametros.Add(new SqlParameter("@cve_cliente", clave));
            parametros.Add(new SqlParameter("@nom_cliente", nombre));
            parametros.Add(new SqlParameter("@tel", tel));
            parametros.Add(new SqlParameter("@dir", dir));
            parametros.Add(new SqlParameter("@rfc", rfc));
            try
            {
                conexion.ejecutarQuery("registrarCliente", CommandType.StoredProcedure, parametros);
                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public static DataTable mostrarClientes(string nomClave)
        {
            List<SqlParameter> parametros = new List<SqlParameter> { };
            parametros.Add(new SqlParameter("@nomClave", nomClave));
            try
            {
                return conexion.obtenerDatos("mostrarClientes", CommandType.StoredProcedure, parametros);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Data);
                return null;
            }
        }

        public static bool modificarCliente(string clave, string nombre, string tel, string dir, string rfc)
        {
            bool result = false;
            List<SqlParameter> parametros = new List<SqlParameter> { };
            parametros.Add(new SqlParameter("@cve_cliente", clave));
            parametros.Add(new SqlParameter("@nom_cliente", nombre));
            parametros.Add(new SqlParameter("@tel", tel));
            parametros.Add(new SqlParameter("@dir", dir));
            parametros.Add(new SqlParameter("@rfc", rfc));
            try
            {
                conexion.ejecutarQuery("modificaCliente", CommandType.StoredProcedure, parametros);
                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public static bool eliminarCliente(string clave)
        {
            bool result = false;
            List<SqlParameter> parametros = new List<SqlParameter> { };
            parametros.Add(new SqlParameter("@cve_cliente", clave));
            try
            {
                conexion.ejecutarQuery("eliminaCliente", CommandType.StoredProcedure, parametros);
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
