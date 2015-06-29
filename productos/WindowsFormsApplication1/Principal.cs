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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(string.Empty) || txtCont.Text.Equals(string.Empty))
            {
                MessageBox.Show("debes introducir tu usuario y contraseña");
            }
            else
            {
                if (validacion.validarUsuario(txtUsuario.Text) == false)
                {
                    MessageBox.Show("El nombre de usuario debe contener solo letras y numeros");
                }
                else
                {
                    if (validacion.validarContrasena(txtCont.Text) == false)
                    {
                        MessageBox.Show("contraseña no valida");
                    }
                    else
                    {
                        usuario usrActual = new usuario(txtUsuario.Text.ToString(), txtCont.Text.ToString());
                        if (usrActual.verificaUsuario())
                        {
                            MessageBox.Show("Bienvenido");
                            FrmMenu fm = new FrmMenu();
                            fm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario y/o Contraseña Incorrectos");
                        }
                    }
                }
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            altaUsuario frmUsr = new altaUsuario();
            frmUsr.ShowDialog();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void lblForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recPass rp = new recPass();
            rp.ShowDialog();
        }
    }
}
