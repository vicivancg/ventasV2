using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cn.producto;
using cn.cliente;

namespace WindowsFormsApplication1
{
    public partial class FrmBusqueda : Form
    {
        public int tipo = 0;
        private producto productoActual;
        private cliente clienteActual;
        private List<producto> productosActuales;
        public FrmBusqueda(int tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
        }

        public FrmBusqueda(int tipo, cliente cliente)
        {
            clienteActual = new cliente();
            clienteActual = cliente;
            this.tipo = tipo;
            /*if (cliente.Equals(clienteActual))
            {
                clienteActual.Nombre = "you win";
            }*/
            InitializeComponent();
        }

        public FrmBusqueda(int tipo, List<producto> productos)
        {
            productosActuales = new List<producto>();
            productosActuales = productos;
            this.tipo = tipo;
            InitializeComponent();
            this.txtBusqueda.Text = string.Empty;
          
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            if (this.tipo == 1 || this.tipo == 4 || this.tipo == 3)
            {
                if (validacion.validarNombreProducto(txtBusqueda.Text) == true)
                {
                    dgvBusqueda.DataSource = cn.producto.producto.mostrarProductos(txtBusqueda.Text);
                    dgvBusqueda.Refresh();
                }
                else
                {
                    MessageBox.Show("Texto de busqueda no valido");
                }
            }
            else if (tipo == 2 || tipo == 5)
            {
                if (validacion.validarNombre(txtBusqueda.Text) == true || validacion.validarRazon(txtBusqueda.Text) == true)
                {
                    dgvBusqueda.DataSource = cliente.mostrarClientes(txtBusqueda.Text);
                    dgvBusqueda.Refresh();
                }
                else
                {
                    MessageBox.Show("Texto de busqueda no valido");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (this.tipo == 1)// se va a modificar un producto
            {
                asignaProducto();
                frmProductos fp = new frmProductos(2, productoActual);
                fp.ShowDialog();
            }
            else if (this.tipo == 2)//se va a modificar un cliente
            {
                clienteActual = new cliente(dgvBusqueda.CurrentRow.Cells[0].Value.ToString(), dgvBusqueda.CurrentRow.Cells[1].Value.ToString(), dgvBusqueda.CurrentRow.Cells[2].Value.ToString(), dgvBusqueda.CurrentRow.Cells[3].Value.ToString(), dgvBusqueda.CurrentRow.Cells[4].Value.ToString());
                frmCliente fc = new frmCliente(2,clienteActual);
                fc.ShowDialog();
            }
            else if (this.tipo == 3)//se va a agregar una orden
            {
                if (numCantidad.Value > 0)
                {
                    try
                    {
                        if (producto.NuevaOrden(dgvBusqueda.CurrentRow.Cells[0].Value.ToString(),numCantidad.Value, DateTime.Now))
                        {
                            MessageBox.Show("Orden Exitosa");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo realizar orden");
                        }
                    }
                    catch (Exception em)
                    {
                        MessageBox.Show("Selecciona un producto");
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona la cantidad");
                }
            }
            else if (this.tipo == 4) //se van a añadir productos (venta)
            {
                if (numCantidad.Value > 0)
                {
                    if (cantSeleccionada(dgvBusqueda.CurrentRow.Cells[0].Value.ToString()) > 0) // ya existe el producto elegido, por lo tanto solo se añade la cantidad
                    {
                        foreach (producto prod in productosActuales)
                        {
                            if (prod.Clave.Equals(dgvBusqueda.CurrentRow.Cells[0].Value.ToString()))
                            {
                                prod.Existencia += Convert.ToDecimal(numCantidad.Value);
                                break;
                            }
                        }
                    }
                    else //el producto no existe
                    {
                        asignaProducto();
                        productosActuales.Add(productoActual);
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Selecciona la cantidad, sujeto a disponibilidad");
                }
            }
            else if (this.tipo == 5)
            {
                clienteActual.Clave = dgvBusqueda.CurrentRow.Cells[0].Value.ToString();
                clienteActual.Nombre = dgvBusqueda.CurrentRow.Cells[1].Value.ToString();
                clienteActual.Num = dgvBusqueda.CurrentRow.Cells[2].Value.ToString();
                clienteActual.Dir = dgvBusqueda.CurrentRow.Cells[3].Value.ToString();
                clienteActual.Rfc = dgvBusqueda.CurrentRow.Cells[4].Value.ToString();
                clienteActual.TotFact = Convert.ToDecimal(dgvBusqueda.CurrentRow.Cells[5].Value);
                this.Close();

            }
            this.txtBusqueda.Text = string.Empty;
            this.dgvBusqueda.DataSource = null;
            this.dgvBusqueda.Refresh();//accion despues de eliminar o modificar el producto
        }

        private decimal cantSeleccionada(string clave)//deevuelve la cantidad de un producto que ya ha sido seleccionado
        {
            decimal result = 0;
            if (productosActuales.Count > 0)
            {
                foreach (producto prod in productosActuales)
                {
                    if (prod.Clave == clave)
                    {
                        result = prod.Existencia;// la existencia se toma como la cantidad seleccionada 
                        break;
                    }
                }
            }
            return result;
        }

        private void FrmBusqueda_CursorChanged(object sender, EventArgs e)
        {
        }

        private void dgvBusqueda_SelectionChanged(object sender, EventArgs e)
        {
            if (this.tipo == 4)
            {
                lblCantidad.Visible = true;
                numCantidad.Visible = true;
                decimal cantidadOriginal = Convert.ToDecimal(dgvBusqueda.CurrentRow.Cells[5].Value.ToString());
                decimal cantSelec = cantSeleccionada(dgvBusqueda.CurrentRow.Cells[0].Value.ToString());
                numCantidad.Maximum = cantidadOriginal - cantSelec; //Convert.ToDecimal(dgvBusqueda.CurrentRow.Cells[5].Value.ToString()) - cantSeleccionada(dgvBusqueda.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void asignaProducto()
        {
            productoActual = new producto();
            productoActual.Clave = dgvBusqueda.CurrentRow.Cells[0].Value.ToString();
            productoActual.Nombre = dgvBusqueda.CurrentRow.Cells[1].Value.ToString();
            productoActual.Precio = Convert.ToDecimal(dgvBusqueda.CurrentRow.Cells[2].Value);
            productoActual.UnMed = dgvBusqueda.CurrentRow.Cells[6].Value.ToString();
            productoActual.Iva = Convert.ToInt32(dgvBusqueda.CurrentRow.Cells[4].Value);
            productoActual.Desc = dgvBusqueda.CurrentRow.Cells[8].Value.ToString();
            if (this.tipo == 4) //se añade un producto para vender
            {
                productoActual.Existencia = Convert.ToDecimal(numCantidad.Value);
            }
            else{productoActual.Existencia = Convert.ToDecimal(dgvBusqueda.CurrentRow.Cells[5].Value.ToString());}
        }

        private void FrmBusqueda_Load_1(object sender, EventArgs e)
        {
            if (this.tipo == 1) //es un producto
            {
                this.lblHead.Text = "Busqueda de productos";
                this.lblBusc.Text = "Introduce la clave o nombre del producto que deseas modificar";
            }
            else if (this.tipo == 2)//es un cliente
            {
                this.lblHead.Text = "Busqueda de clientes";
                this.lblBusc.Text = "Introduce la clave o nombre del cliente que deseas modificar";
            }
            else if (this.tipo == 3)//nueva orden
            {
                this.lblHead.Text = "Busqueda de productos";
                this.lblBusc.Text = "Introduce la clave o nombre del producto de la orden de compra";
                lblCantidad.Visible = true;
                numCantidad.Visible = true;
            }
            else if (this.tipo == 4) //es un producto(venta)
            {
                this.lblHead.Text = "Busqueda de productos";
                this.lblBusc.Text = "Introduce la clave o nombre del producto (Venta)";
            }
            else if (this.tipo == 5)//es un cliente (venta)
            {
                this.lblHead.Text = "Busqueda de clientes";
                this.lblBusc.Text = "Introduce la clave o nombre del cliente (Venta)";
            }
        }
    }
}
