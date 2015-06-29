using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

namespace cd.comun
{
    public class conexion
    {
        private static SqlConnection nuevaConexion()
        {
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["productos"].ConnectionString);
            //conexion.ConnectionString = ConfigurationManager.ConnectionStrings["productos"].ConnectionString;

            //new SqlConnection(@"Data Source =VICKENSHIN; initial catalog = ventasV2; integrated security = true");
            return conexion;
        }

        private static SqlCommand NuevoComando(string consulta, CommandType tipoComando)
        {
            SqlCommand comando = new SqlCommand(consulta, nuevaConexion());
            comando.CommandType = tipoComando;
            return comando;
        }

        public static DataTable obtenerDatos(string consulta, CommandType tipoComando)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter(NuevoComando(consulta, tipoComando));
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;
        }
        
        public static DataTable obtenerDatos(string consulta, CommandType tipoComando, List<SqlParameter> parametros)//metodo que obtiene datos de un procedimiento aalmacenado
        {
            SqlCommand comando = NuevoComando(consulta, tipoComando);
            foreach (SqlParameter parametro in parametros)
            {
                comando.Parameters.Add(parametro);
            }
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;
        }
        public static void ejecutarQuery(string consulta, CommandType tipoComando)
        {
            SqlCommand comando = NuevoComando(consulta, tipoComando);
            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();

        }

        public static void ejecutarQuery(string consulta, CommandType tipoComando, List<SqlParameter> parametros)
        {
            SqlCommand comando = NuevoComando(consulta, tipoComando);
            comando.Connection.Open();
            foreach (SqlParameter parametro in parametros)
            {
                comando.Parameters.Add(parametro);
            }
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Data);
            }
            comando.Connection.Close();

        }

        public static object ejecutarQuery(string consulta, CommandType tipoComando, List<SqlParameter> parametros, string paramSalida)
        {
            SqlCommand comando = NuevoComando(consulta, tipoComando);
            comando.Connection.Open();
            foreach (SqlParameter parametro in parametros)
            {
                comando.Parameters.Add(parametro);
            }
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Data);
            }
            comando.Connection.Close();
            return comando.Parameters[paramSalida].Value;

        }
    }
}
