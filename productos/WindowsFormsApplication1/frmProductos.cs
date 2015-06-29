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

namespace WindowsFormsApplication1
{
    public partial class frmProductos : Form
    {
        private int tipo = 0;
        private producto productoActual;
        public frmProductos()
        {
            InitializeComponent();
        }

        public frmProductos(int tipo)
        {
            this.tipo = tipo;
            InitializeComponent();
        }

        public frmProductos(int tipo, producto productoActual)
        {
            this.tipo = tipo;
            this.productoActual = productoActual;
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            if (this.tipo == 1)
            {
                btnRegistro.Visible = true;
                btnModificar.Visible = false;
                btnEliminar.Visible = false;
                this.txtClave.Text = producto.obtieneClaveActual();
            }
            else if (this.tipo == 2)
            {
                btnRegistro.Visible = false;
                btnModificar.Visible = true;
                btnEliminar.Visible = true;
                lblFecha.Visible = false;
                dtpProducto.Visible = false;
                numExistencia.Enabled = false;
                txtClave.Text = this.productoActual.Clave;
                txtNombre.Text = productoActual.Nombre;
                txtPrecio.Text = productoActual.Precio.ToString();
                numExistencia.Value = Convert.ToInt32(productoActual.Existencia);
                cbUnMed.SelectedItem = productoActual.UnMed;
                cbIva.SelectedItem = productoActual.Iva.ToString() + "%";
                txtDesc.Text = productoActual.Desc;
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            agregar();
            /*bool result = false;
            string mensaje = string.Empty;
            if (txtNombre.Text != string.Empty && txtPrecio.Text != string.Empty && numExistencia.Value >= 0 && cbUnMed.SelectedItem != null && cbIva.SelectedItem != null)
            {
                if (validacion.validarNombre(txtNombre.Text) == true)
                {
                    if (validacion.validarCantidadDecimal(txtPrecio.Text))
                    {
                        this.productoActual = new producto(txtClave.Text, txtNombre.Text, Convert.ToDecimal(txtPrecio.Text), numExistencia.Value, cbUnMed.SelectedItem.ToString(), Convert.ToInt32(cbIva.SelectedItem.ToString().Trim('%')), dtpProducto.Value.ToString("dd-MM-yy"), txtDesc.Text);
                        result = productoActual.RegistroProducto();
                        if (result == true)
                        {
                            mensaje = "El Producto Se Ha Agregado";
                        }
                        else
                        {
                            mensaje = "El Producto No Se Ha Podido Agregar, Intenta Mas Tarde";
                        }
                    }
                    else
                    {
                        mensaje = "El precio no tiene un formato correcto";
                    }
                }
                else
                {
                    mensaje = "El nombre no tiene un formato valido";
                }
            }
            else
            {
                mensaje = "Llena todos los campos";
            }
            MessageBox.Show(mensaje);
            if (result == true){this.Close();}*/
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Esta seguro que desea eliminar el producto?", "Eliminar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bool op = productoActual.eliminarProducto();
                if (op == true)
                {
                    MessageBox.Show("El producto se ha eliminado");
                }
                else
                {
                    MessageBox.Show("El producto no se ha eliminado, intenta mas tarde");
                }
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            agregar();
        }

        private void agregar()
        {
            bool result = false;
            string mensaje = string.Empty;
            if (txtNombre.Text != string.Empty && txtPrecio.Text != string.Empty && numExistencia.Value >= 0 && cbUnMed.SelectedItem != null && cbIva.SelectedItem != null)
            {
                if (validacion.validarNombre(txtNombre.Text) == true)
                {
                    if (validacion.validarCantidadDecimal(txtPrecio.Text))
                    {
                        if (this.tipo == 1)
                        {
                            this.productoActual = new producto(txtClave.Text, txtNombre.Text, Convert.ToDecimal(txtPrecio.Text), numExistencia.Value, cbUnMed.SelectedItem.ToString(), Convert.ToInt32(cbIva.SelectedItem.ToString().Trim('%')), dtpProducto.Value.ToString("dd-MM-yy"), txtDesc.Text);
                            result = productoActual.RegistroProducto();
                            if (result == true)
                            {
                                mensaje = "El Producto Se Ha Agregado";
                            }
                            else
                            {
                                mensaje = "El Producto No Se Ha Podido Agregar, Intenta Mas Tarde";
                            }
                        }
                        else
                        {
                            this.productoActual = new producto(txtClave.Text, txtNombre.Text, Convert.ToDecimal(txtPrecio.Text), numExistencia.Value, cbUnMed.SelectedItem.ToString(), Convert.ToInt32(cbIva.SelectedItem.ToString().Trim('%')),txtDesc.Text);
                            result = productoActual.modificarProducto();
                            if (result == true)
                            {
                                mensaje = "El Producto Se Ha modificado";
                            }
                            else
                            {
                                mensaje = "El Producto No Se Ha Podido modificar, Intenta Mas Tarde";
                            }
                        }
                    }
                    else
                    {
                        mensaje = "El precio no tiene un formato correcto";
                    }
                }
                else
                {
                    mensaje = "El nombre no tiene un formato valido";
                }
            }
            else
            {
                mensaje = "Llena todos los campos";
            }
            MessageBox.Show(mensaje);
            if (result == true) { this.Close(); }
        }
    }
}
