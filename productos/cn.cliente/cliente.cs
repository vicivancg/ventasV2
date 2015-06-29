using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cd.cliente;
using System.Data;

namespace cn.cliente
{
    public class cliente
    {
        #region campos
        //campos
        private string clave = string.Empty;
        private string nombre = string.Empty;
        private string num = string.Empty;
        private string dir = string.Empty;
        private string rfc = string.Empty;
        private decimal total_fact = 0.0m;
        #endregion

        #region propiedades
        //propiedades
        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        public string Nombre
        {
            get { return nombre;}
            set { nombre = value; }
        }
        public string Num
        {
            get { return num;}
            set { num = value; }
        }
        public string Dir
        {
            get { return dir; }
            set { dir = value; }
        }
        public string Rfc
        {
            get { return rfc; }
            set { rfc = value; }
        }
        public decimal TotFact
        {
            get { return total_fact; }
            set { total_fact = value; }
        }
        #endregion

        #region constructores
        //constructores

        public cliente()
        {
        }

        public cliente(string clave, string nombre, string num, string dir, string rfc, decimal totFact)
        {
            this.clave = clave;
            this.nombre = nombre;
            this.num = num;
            this.dir = dir;
            this.rfc = rfc;
            this.total_fact = totFact;
        }

        public cliente(string clave, string nombre, string num, string dir, string rfc)
        {
            this.clave = clave;
            this.nombre = nombre;
            this.num = num;
            this.dir = dir;
            this.rfc = rfc;
            this.total_fact = 0.0m;
        }
        #endregion

        //metodos

        public static string obtieneClaveActual()
        {
            return cd.cliente.cliente.obtenerClienteAct();
        }

        public bool registroCliente()
        {
            return cd.cliente.cliente.NuevoCliente(this.clave, this.nombre, this.num, this.dir, this.rfc);
        }

        public static DataTable mostrarClientes(string nomClave)
        {
            return cd.cliente.cliente.mostrarClientes(nomClave);
        }

        public bool modificarCliente()
        {
            return cd.cliente.cliente.modificarCliente(this.clave, this.nombre, this.num, this.dir, this.rfc);
        }

        public bool eliminarCliente()
        {
            return cd.cliente.cliente.eliminarCliente(this.clave);
        }
    }
}
