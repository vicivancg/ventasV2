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

namespace cd.usuario
{
    public class usuario
    {
        public static bool guardaUsuario(string Nombre, string APat, string AMat, string Usr, string Contrasena, string Correo)
        {
            List<SqlParameter> parametros = new List<SqlParameter> { };
            parametros.Add(new SqlParameter("@nombre", Nombre));
            parametros.Add(new SqlParameter("@aPat", APat));
            parametros.Add(new SqlParameter("@aMat", AMat));
            parametros.Add(new SqlParameter("@usr", Usr));
            parametros.Add(new SqlParameter("@cont", Contrasena));
            parametros.Add(new SqlParameter("@correo",Correo));
            parametros.Add(new SqlParameter("@resultado",SqlDbType.Int));
            parametros[6].Direction = ParameterDirection.Output;
            return Convert.ToBoolean(conexion.ejecutarQuery("registroUsuario", CommandType.StoredProcedure, parametros, "@resultado"));//regresa un true si el numero de usuario es valido y se realizo el registro
        }

        public static bool VerificaUsuario(string usr, string cont)
        {
            List<SqlParameter> parametros = new List<SqlParameter> { };
            parametros.Add(new SqlParameter("@usr", usr));
            parametros.Add(new SqlParameter("@cont", cont));
            parametros.Add(new SqlParameter("@resultado", SqlDbType.Int));
            parametros[2].Direction = ParameterDirection.Output;
            return Convert.ToBoolean(conexion.ejecutarQuery("verificaUsuario",CommandType.StoredProcedure,parametros,"@resultado"));
        }

        public static DataTable obtienePass(string usuario)
        {
            try
            {
                List<SqlParameter> parametros = new List<SqlParameter> { };
                parametros.Add(new SqlParameter("@usr", usuario));
                return conexion.obtenerDatos("obtenerPass", CommandType.StoredProcedure, parametros);
            }
            catch
            {
                return null;
            }
        }
    }
}
