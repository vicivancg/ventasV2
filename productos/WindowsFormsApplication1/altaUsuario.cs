using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cn.usuario;

namespace WindowsFormsApplication1
{
    public partial class altaUsuario : Form
    {
        public altaUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string aviso = string.Empty;
            bool result = false;
            if (txtNombre.Text != string.Empty && txtApPat.Text != string.Empty && txtApMat.Text != string.Empty && txtUsuario.Text != string.Empty && txtCont.Text != string.Empty && txtCorreo.Text != string.Empty)
            {
                if (validacion.validarNombre(txtNombre.Text) == false || validacion.validarApellido(txtApPat.Text) == false || validacion.validarApellido(txtApMat.Text) == false)
                {
                    aviso = "el nombre y apellidos deben contener solo letras";
                }
                else if (validacion.validarUsuario(txtUsuario.Text) == false)
                {
                    aviso = "el nombre de usuario debe contener solo letras y numeros";
                }
                else if (validacion.validarContrasena(txtCont.Text) == false)
                {
                    aviso = "la contraseña debe cntener solo letras, numeros y simbolos(.,:;-_)";
                }
                else if (validacion.validarCorreo(txtCorreo.Text) == false)
                {
                    aviso = "el correo debe tener un formato valido";
                }
                else
                {
                    usuario usrActual = new usuario(txtNombre.Text, txtApPat.Text, txtApMat.Text, txtUsuario.Text, txtCont.Text, txtCorreo.Text);
                    result = usrActual.guardaUsuario();
                    if (result == true)
                    {
                        aviso = "Usuario Añadido Exitosamente";
                    }
                    else
                    {
                        aviso = "El Usuario Ya Existe";
                    }
                }
            }
            else
            {
                aviso = "debes completar todos los campos";
            }

            MessageBox.Show(aviso);
            if (result == true)
            {
                this.Close();
            }
        }
    }
}
