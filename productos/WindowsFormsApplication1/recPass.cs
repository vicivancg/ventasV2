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
    public partial class recPass : Form
    {
        public recPass()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (usuario.recuperarPass(txtUsuario.Text.ToString()) == 1)
            {
                MessageBox.Show("El correo se ha enviado con exito");
            }
            else
            {
                MessageBox.Show("El correo no se ha enviado con exito");
            }

            this.Close();
        }
    }
}
