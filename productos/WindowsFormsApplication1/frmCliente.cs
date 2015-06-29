using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cn.cliente;

namespace WindowsFormsApplication1
{
    public partial class frmCliente : Form
    {
        private int tipo = 0;
        cliente clienteAct;
        public frmCliente()
        {
            InitializeComponent();
        }

        public frmCliente(int tipo)
        {
            this.tipo = tipo;
            InitializeComponent();
        }
        public frmCliente(int tipo, cliente cliente)
        {
            this.tipo = tipo;
            this.clienteAct = cliente;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            agregar();
            /*bool result = false;
            string nombre = txtNombre.Text;
            string num = txtTelefono.Text;
            string direccion = "calle " + txtCalle.Text + " noInt " + txtNoInt.Value.ToString() + " noExt " + txtNoExt.Value.ToString() + " colonia " + txtColonia.Text + " delegacion " + txtDelegacion.Text + " estado " + txtEstado.Text;
            string rfc = txtRfc.Text;

            cliente clienteActual = new cliente(nombre, num, direccion, rfc);
            result = clienteActual.altaCliente();
            if (result == true)
            {
                MessageBox.Show("El cliente se ha agregado");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se ha podido realizar la accion");
                this.Close();
            }*/
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Esta seguro que desea eliminar el cliente?", "Eliminar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (clienteAct.eliminarCliente())
                {
                    MessageBox.Show("El cliente se ha eliminado");
                    this.Close();
                }
                else{MessageBox.Show("El cliente no se ha podido eliminar, intenta mas tarde");}
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            if (this.tipo == 1) //se recibe una alta
            {
                btnRegistro.Visible = true;
                btnModificar.Visible = false;
                btnEliminar.Visible = false;
                this.txtClave.Text = cliente.obtieneClaveActual();
                rbPerFisica.Checked = true;
            }
            else if (this.tipo == 2) //se recibe una modificacion
            {
                btnRegistro.Visible = false;
                btnModificar.Visible = true;
                btnEliminar.Visible = true;
                lblPrincipal.Text = "Modificar Cliente";
                txtClave.Text = this.clienteAct.Clave;
                txtNombre.Text = this.clienteAct.Nombre;
                txtTelefono.Text = this.clienteAct.Num;
                txtRfc.Text = this.clienteAct.Rfc;
                if (validacion.validarRfcFisica(this.clienteAct.Rfc))
                {
                    rbPerFisica.Checked = true;
                    rbPerMoral.Checked = false;
                }
                else
                {
                    rbPerFisica.Checked = false;
                    rbPerMoral.Checked = true;
                }
                int inicio =0,final=0;
                inicio = this.clienteAct.Dir.IndexOf("calle") + "calle".Length + 1;
                final = this.clienteAct.Dir.IndexOf("noInt");
                txtCalle.Text = this.clienteAct.Dir.Substring(inicio, final - inicio-1);
                inicio = this.clienteAct.Dir.IndexOf("colonia") + "colonia".Length+1;
                final = this.clienteAct.Dir.IndexOf("delegacion");
                txtColonia.Text = this.clienteAct.Dir.Substring(inicio, final - inicio - 1);
                inicio = this.clienteAct.Dir.IndexOf("delegacion") + "delegacion".Length + 1;
                final = this.clienteAct.Dir.IndexOf("estado");
                txtDelegacion.Text = this.clienteAct.Dir.Substring(inicio, final - inicio - 1);
                inicio = this.clienteAct.Dir.IndexOf("estado") + "estado".Length + 1;
                final = this.clienteAct.Dir.Length;
                txtEstado.Text = this.clienteAct.Dir.Substring(inicio, final - inicio);
                inicio = this.clienteAct.Dir.IndexOf("noInt") + "noInt".Length + 1;
                final = this.clienteAct.Dir.IndexOf("noExt");
                numNoInt.Value = Convert.ToInt32(this.clienteAct.Dir.Substring(inicio, final - inicio));
                inicio = this.clienteAct.Dir.IndexOf("noExt") + "noExt".Length + 1;
                final = this.clienteAct.Dir.IndexOf("colonia");
                numNoExt.Value = Convert.ToInt32(this.clienteAct.Dir.Substring(inicio, final - inicio));
            }
        }

        private void agregar()
        {
            bool result = false;
            string mensaje = string.Empty;
            if (txtNombre.Text != string.Empty && txtTelefono.Text != string.Empty && txtRfc.Text != string.Empty && txtCalle.Text != string.Empty && txtColonia.Text != string.Empty && txtDelegacion.Text != string.Empty && txtEstado.Text != string.Empty && numNoExt.Value > 0 && numNoInt.Value >= 0)
            {
                if (validacion.validarRazon(txtNombre.Text) || validacion.validarNombre(txtNombre.Text))
                {
                    if (validacion.validarTelefonoLocal(txtTelefono.Text) || validacion.validarTelefonoMob(txtTelefono.Text))
                    {
                        if ((rbPerFisica.Checked == true && validacion.validarRfcFisica(txtRfc.Text) == true) || (rbPerMoral.Checked == true && validacion.validarRfcMoral(txtRfc.Text) == true))
                        {
                            if (validacion.validarNombresAlfa(txtCalle.Text))
                            {
                                if (validacion.validarNombresAlfa(txtColonia.Text))
                                {
                                    if (validacion.validarNombres(txtDelegacion.Text))
                                    {
                                        if (validacion.validarNombres(txtEstado.Text))
                                        {
                                            if (this.tipo == 1) //el producto se va a guardar
                                            {
                                                this.clienteAct = new cliente(txtClave.Text, txtNombre.Text, txtTelefono.Text, "calle " + txtCalle.Text + " noInt " + numNoInt.Value.ToString() + " noExt " + numNoExt.Value.ToString() + " colonia " + txtColonia.Text + " delegacion " + txtDelegacion.Text + " estado " + txtEstado.Text, txtRfc.Text);
                                                result = clienteAct.registroCliente();
                                                if (result == true) {mensaje = "El Cliente Se Ha Agregado";}
                                                else{mensaje = "El Cliente No Se Ha Podido Agregar, Intenta Mas Tarde";}
                                            }
                                            else if (this.tipo == 2) // se va a modificar
                                            {
                                                this.clienteAct = new cliente(txtClave.Text, txtNombre.Text, txtTelefono.Text, "calle " + txtCalle.Text + " noInt " + numNoInt.Value.ToString() + " noExt " + numNoExt.Value.ToString() + " colonia " + txtColonia.Text + " delegacion " + txtDelegacion.Text + " estado " + txtEstado.Text, txtRfc.Text);
                                                result = clienteAct.modificarCliente();
                                                if (result == true){mensaje = "El Cliente Se Ha Modificado";}
                                                else{mensaje = "El Cliente No Se Ha Podido Modificar, Intenta Mas Tarde";}
                                            }
                                        }
                                        else
                                        {
                                            mensaje = " Estado no valido";
                                        }
                                    }
                                    else
                                    {
                                        mensaje = " Colonia no valida";
                                    }
                                }
                                else
                                {
                                    mensaje = " Colonia no valida";
                                }
                            }
                            else
                            {
                                mensaje = " Calle no valida";
                            }
                        }
                        else
                        {
                            mensaje = " RFC no valido";
                        }
                    }
                    else
                    {
                        mensaje = " Telefono no valido";
                    }
                }
                else
                {
                    mensaje = "Nombre no valido";
                }
            }
            else
            {
                mensaje = "Llena todos los campos";
            }
            MessageBox.Show(mensaje);
            if (result == true) { this.Close(); }
        }

        private void rbPerFisica_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            agregar();
        }
    }
}
