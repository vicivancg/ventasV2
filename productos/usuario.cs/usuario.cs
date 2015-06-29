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


namespace usuario.cs
{
    class usuario
    {
        //obtener usuario y contraseña
        public static bool autenticacion(string usuario, string contraseña)
        {
            DataTable dt = new DataTable();
            bool result = false;
            dt = cd.comun.conexion.obtenerDatos("SELECT * FROM usuarios WHERE usuario ='" + usuario + "' AND pass ='" + contraseña + "';", CommandType.Text);
            if (dt.Rows.Count > 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        //nuevo usuario
        /*public static bool nuevoUsuario(string usuario, string contraseña)
        {
            //string query = "INSERT INTO usuarios VALUES ('"
        }*/
    }
}
