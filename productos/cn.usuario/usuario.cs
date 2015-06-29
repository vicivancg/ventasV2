using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net;
using System.Net.Mail;
using cd.usuario;

namespace cn.usuario
{
    public class usuario
    {
        private string nombre = string.Empty;
        private string aPat = string.Empty;
        private string aMat = string.Empty;
        private string usr = string.Empty;
        private string contrasena = string.Empty;
        private string correo = string.Empty;

        #region propiedades
        public string Nombre
        {
            get {return this.nombre;}
            set { this.nombre = value;}
        }

        public string APat
        {
            get { return aPat; }
            set { aPat = value; }
        }

        public string AMat
        {
            get { return aMat; }
            set { aMat = value; }
        }

        public string Usr
        {
            get { return usr; }
            set { usr = value; }
        }

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        #endregion

        #region constructores

        public usuario(){}

        public usuario(string Usr, string Contrasena)
        {
            this.usr = Usr;
            this.contrasena = Contrasena;
        }

        public usuario(string Nombre, string APat, string AMat, string Usr, string Contrasena, string Correo)
        {
            this.nombre = Nombre;
            this.aPat = APat;
            this.aMat = AMat;
            this.usr = Usr;
            this.contrasena = Contrasena;
            this.correo = Correo;
        }

        #endregion

        public bool guardaUsuario()
        {
            //devuelve true en 
            return cd.usuario.usuario.guardaUsuario(this.nombre, this.aPat, this.aMat, this.usr, this.contrasena, this.correo);
        }

        public bool verificaUsuario()
        {
            return cd.usuario.usuario.VerificaUsuario(this.usr, this.contrasena);
 
        }

        private static int enviarCorreo(string usr, string correo, string pass)//metodo que envia el correo
        {
            int result = 0;
            try
            {
                MailAddress direccionDestino = new MailAddress(correo); // direcciones de origen y destino
                MailAddress direccionOrigen = new MailAddress("vic150cc@gmail.com");
                MailMessage mensaje = new MailMessage(direccionOrigen, direccionDestino); //se crea mensaje
                mensaje.Subject = "Recuperación de contraseña del usuario " + usr;
                mensaje.IsBodyHtml = true;
                mensaje.Body = "Su contraseña es " + pass;
                mensaje.BodyEncoding = Encoding.UTF8; // se asigna la cidificacion
                string smtpHost = "smtp.gmail.com"; //host de gmail
                string usuario = "admbased2015@gmail.com"; //dirección
                string password = "administracion.2015"; //contraseña
                SmtpClient cliente = new SmtpClient(); // se crea objeto SMTP
                cliente.Port = 587;//se le asigna el puerto de gmail
                cliente.EnableSsl = true; // se habilita la seguridad SSL
                cliente.UseDefaultCredentials = false;
                cliente.Credentials = new NetworkCredential(usuario, password); // se crea una nueva credencial para autenticar el mensaje
                cliente.Host = smtpHost; // se le asigna el host SMTP
                cliente.DeliveryMethod = SmtpDeliveryMethod.Network; //se asigna el metodo de entrega
                cliente.Send(mensaje);//se envia el mensaje
                result = 1;
            }
            catch (Exception e)
            {
                result = 0;
            }
            return result;
        }

        public static int recuperarPass(string usuario)
        {
            int result = 0;
            DataTable tablaPass = cd.usuario.usuario.obtienePass(usuario);
            if (tablaPass != null)
            {
                string correo = tablaPass.Rows[0][0].ToString();
                string pass = tablaPass.Rows[0][1].ToString();
                if (enviarCorreo(usuario, correo, pass) == 1)
                {
                    result = 1;
                }
            }
            else
            {
                result = 0;
            }
            return result;
        }

        
    }
}
