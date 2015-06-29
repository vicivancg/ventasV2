using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cd.producto;
using System.Data;

namespace cn.producto
{
    public class producto
    {
        private string clave = string.Empty;
        private string nombre = string.Empty;
        private decimal precio = 0;
        private decimal existencia = 0;
        private string unMed = string.Empty;
        private int iva = 0;
        private string fecha;
        private string desc = string.Empty;

        #region propiedades

        public string Clave { get { return this.clave; } set { this.clave = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public decimal Precio { get { return this.precio; } set { this.precio = value; } }
        public decimal Existencia { get { return this.existencia; } set { this.existencia = value; } }
        public string UnMed { get { return this.unMed; } set { this.unMed = value; } }
        public int Iva { get { return this.iva; } set { this.iva = value; } }
        public string Fecha{ get { return this.fecha; } set { this.fecha = value; } }
        public string Desc { get { return this.desc; } set { this.desc = value; } }

        #endregion

        public producto() { }
        public producto(string clave)
        {
            this.clave = clave;
        }

        public producto(string clave, string nombre, decimal precio, decimal existencia, string unidadMedida, int iva, string fecha, string desc)
        {
            this.clave = clave;
            this.nombre = nombre;
            this.precio = precio;
            this.existencia = existencia;
            this.unMed = unidadMedida;
            this.iva = iva;
            this.fecha = fecha;
            this.desc = desc;
        }

        public producto(string clave, string nombre, decimal precio, decimal existencia, string unidadMedida, int iva, string desc)
        {
            this.clave = clave;
            this.nombre = nombre;
            this.precio = precio;
            this.existencia = existencia;
            this.unMed = unidadMedida;
            this.iva = iva;
            this.desc = desc;
        }

        #region metodos

        public static string obtieneClaveActual()
        {
            return cd.producto.producto.obtenerProdAct();
        }

        public bool RegistroProducto()
        {
            return cd.producto.producto.NuevoProducto(this.clave, this.nombre, this.desc, this.unMed, this.existencia, this.precio, this.iva, this.fecha);
        }

        public static DataTable mostrarProductos(string nomClave)
        {
            return cd.producto.producto.mostrarProducto(nomClave);
        }

        public bool modificarProducto()
        {
            return cd.producto.producto.modificarProducto(this.clave, this.nombre, this.desc, this.unMed, this.existencia, this.precio, this.iva);
        }

        public bool eliminarProducto()
        {
            return cd.producto.producto.eliminarProducto(this.clave);
        }

        public static bool NuevaOrden(string claveProducto, decimal cantidad, DateTime fecha)
        {
            return cd.producto.producto.NuevaOrden(claveProducto, cantidad, fecha);
        }

        #endregion
    }
}
