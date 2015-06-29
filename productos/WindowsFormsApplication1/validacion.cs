using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public static class validacion
    {
        static string patron;
        static System.Text.RegularExpressions.Regex auto;

        public static bool validarUsuario(string cadenaUsuario)
        {
            patron = @"^[a-zA-Z0-9ñÑ]+$";
            auto = new System.Text.RegularExpressions.Regex(patron);
            return auto.IsMatch(cadenaUsuario);
        }
        public static bool validarContrasena(string cadenaUsuario)
        {
            patron = @"^[a-zA-Z0-9ñÑ\.,;:\-_]+$";
            auto = new System.Text.RegularExpressions.Regex(patron);
            return auto.IsMatch(cadenaUsuario);
        }
        public static bool validarNombre(string cadenaUsuario)
        {
            patron = @"^[a-zA-ZáéíóúAÉÍÓÚñÑ\s]+$";
            auto = new System.Text.RegularExpressions.Regex(patron);
            return auto.IsMatch(cadenaUsuario);
        }
        public static bool validarApellido(string cadenaUsuario)
        {
            patron = @"^[a-zA-ZáéíóúAÉÍÓÚñÑ\s]+$";
            auto = new System.Text.RegularExpressions.Regex(patron);
            return auto.IsMatch(cadenaUsuario);
        }
        public static bool validarCorreo(string cadenaUsuario)
        {
            bool val = true;
            bool result = false;
            foreach (char c in cadenaUsuario)
            {
                if (c == '"')
                {
                    val = false;
                    break;
                }
            }

            if (val == true)
            {
                patron = @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
                auto = new System.Text.RegularExpressions.Regex(patron);
                result = auto.IsMatch(cadenaUsuario);
            }
            else
            {
                result = false;
            }

            return result;
        }
        //validar precio y existencia
        public static bool validarCantidadDecimal(string cadenaUsuario)//checar
        {
            patron = "^[0-9]+(.[0-9]{1,2})?$";
            auto = new System.Text.RegularExpressions.Regex(patron);
            return auto.IsMatch(cadenaUsuario);
        }
        //validar descripcion
        /*public static bool validarDescripcion(string cadenaUsuario)
        {
            patron = @"^[a-zA-Z0-9ñÑ.\]+$";
            auto = new System.Text.RegularExpressions.Regex(patron);
            return auto.IsMatch(cadenaUsuario);
        }*/

        //validar nombre del producto
        public static bool validarNombreProducto(string cadenaUsuario)
        {
            patron = @"^[a-zA-Z0-9áéíóúAÉÍÓÚñÑ\s]+$";
            auto = new System.Text.RegularExpressions.Regex(patron);
            return auto.IsMatch(cadenaUsuario);
        }

        //validar razon social
        public static bool validarRazon(string cadenaUsuario)
        {
            patron = @"^[a-zA-Z0-9áéíóúAÉÍÓÚñÑ\s\w\.]+$";
            auto = new System.Text.RegularExpressions.Regex(patron);
            return auto.IsMatch(cadenaUsuario);
        }

        //validar telefono

        public static bool validarTelefonoLocal(string cadenaUsuario)
        {
            patron = @"^[0-9]{8}$";
            auto = new System.Text.RegularExpressions.Regex(patron);
            return auto.IsMatch(cadenaUsuario);
        }

        public static bool validarTelefonoMob(string cadenaUsuario)
        {
            patron = @"^[0-9]{10}$";
            auto = new System.Text.RegularExpressions.Regex(patron);
            return auto.IsMatch(cadenaUsuario);
        }

        //validar rfc

        public static bool validarRfcFisica(string cadenaUsuario)
        {
            patron = @"^[A-Z]{4}[0-9]{6}[A-Z0-9]{3}$";
            auto = new System.Text.RegularExpressions.Regex(patron);
            return auto.IsMatch(cadenaUsuario);
        }
        public static bool validarRfcMoral(string cadenaUsuario)
        {
            patron = @"^[A-Z]{3}[0-9]{6}[A-Z0-9]+$";
            auto = new System.Text.RegularExpressions.Regex(patron);
            return auto.IsMatch(cadenaUsuario);
        }

        //valida calle y colonia

        public static bool validarNombresAlfa(string cadenaUsuario)
        {
            patron = @"^[a-zA-Z0-9áéíóúAÉÍÓÚñÑ\s\.]+$";
            auto = new System.Text.RegularExpressions.Regex(patron);
            return auto.IsMatch(cadenaUsuario);
        }

        //colonia y delegacion

        public static bool validarNombres(string cadenaUsuario)
        {
            patron = @"^[a-zA-ZáéíóúAÉÍÓÚñÑ\s\.]+$";
            auto = new System.Text.RegularExpressions.Regex(patron);
            return auto.IsMatch(cadenaUsuario);
        }

    }
}
