using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cn.cliente;
using cn.producto;
using cd.venta;
using System.Data;

namespace cn.venta
{
    public class venta
    {
        private int idFactura = 0;
        private cliente.cliente clienteAct = null;
        private List<producto.producto> productos;
        private decimal total = 0;
        private decimal subTotal= 0;
        private decimal totalIva = 0;
        private DateTime fechaCompra;
        private decimal cargo = 0;

        #region Propiedades

        public int IdFactura
        {
            get { return this.idFactura; }
            set { this.idFactura = value; }
        }

        public cliente.cliente Cliente
        {
            get { return this.clienteAct; }
            set { this.clienteAct = value; }
        }

        public List<producto.producto> Productos
        {
            get { return this.productos; }
            set { this.productos = value; }
        }

        public decimal Total
        {
            get { return this.total; }
            set { this.total = value; }
        }

        public decimal SubTotal
        {
            get { return this.subTotal; }
            set { this.subTotal = value; }
        }

        public decimal TotalIva
        {
            get { return this.totalIva; }
            set { this.totalIva = value; }
        }

        public DateTime FechaCompra
        {
            get { return this.fechaCompra; }
            set { this.fechaCompra = value; }
        }

        public decimal Cargo
        {
            get { return this.cargo; }
            set { this.cargo = value; }
        }
        #endregion
        #region constructores
        public venta() //
        {
            clienteAct = new cliente.cliente();
            productos = new List<producto.producto>();
        }
        #endregion

        public void asignaProducto(producto.producto producto)
        {
            this.productos.Add(producto);
        }

        public void realizarVenta()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add( "cve_prod", typeof(string));
            dt.Columns.Add( "cant_prod", typeof(decimal));
            dt.Columns.Add( "precio_prod", typeof(decimal));
            dt.Columns.Add( "iva_prod", typeof(int));
            foreach (producto.producto producto in this.productos)
            {
                try
                {
                    dt.Rows.Add(producto.Clave, producto.Existencia, producto.Precio, producto.Iva);
                }
                catch (FormatException e) { Console.WriteLine (e.Message); }
            }
            
           this.idFactura = cd.venta.venta.realizaVenta(this.clienteAct.Clave,this.total,this.subTotal,this.totalIva,this.cargo,this.fechaCompra,dt);
        }
    }
}
