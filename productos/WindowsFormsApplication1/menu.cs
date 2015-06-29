using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            pnlProductos.Visible = true;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            pnlClientes.Visible = false;
            pnlFacturacion.Visible = false;
            pnlProductos.Visible = true;
            pnlReportes.Visible = false;
            imgRic.Visible = false;
            lblInfo.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMenu_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //pnlProductos.Visible = false;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            pnlClientes.Visible = true;
            pnlFacturacion.Visible = false;
            pnlProductos.Visible = false;
            pnlReportes.Visible = false;
            imgRic.Visible = false;
            lblInfo.Visible = false;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            //pnlClientes.Visible = false;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            //pnlProductos.Visible = false;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            pnlClientes.Visible = false;
            pnlFacturacion.Visible = true;
            pnlProductos.Visible = false;
            pnlReportes.Visible = false;
            imgRic.Visible = false;
            lblInfo.Visible = false;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            pnlClientes.Visible = false;
            pnlFacturacion.Visible = false;
            pnlProductos.Visible = false;
            pnlReportes.Visible = true;
            imgRic.Visible = false;
            lblInfo.Visible = false;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            /*imgRic.Visible = true;
            lblInfo.Visible = true;*/
        }

        private void btnInfo_MouseEnter(object sender, EventArgs e)
        {
            pnlClientes.Visible = false;
            pnlFacturacion.Visible = false;
            pnlProductos.Visible = false;
            pnlReportes.Visible = false;
            imgRic.Visible = true;
            lblInfo.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            frmProductos frmProd = new frmProductos(1);
            frmProd.ShowDialog();
        }

        private void btnModProd_Click(object sender, EventArgs e)
        {
            FrmBusqueda fb = new FrmBusqueda(1);
            fb.ShowDialog();
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            frmCliente frmCA = new frmCliente(1);
            frmCA.ShowDialog();
        }

        private void btnModCliente_Click(object sender, EventArgs e)
        {
            FrmBusqueda fb = new FrmBusqueda(2);
            fb.ShowDialog();
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAltaFact_Click(object sender, EventArgs e)
        {
            frmVenta fv = new frmVenta();
            fv.ShowDialog();
        }

        private void btnRepProd_Click(object sender, EventArgs e)
        {
            reporte rp = new reporte(1);
            rp.ShowDialog();
        }

        private void btnRepCliente_Click(object sender, EventArgs e)
        {
            reporte rp = new reporte(2);
            rp.ShowDialog();
        }

        private void btnRepFecha_Click(object sender, EventArgs e)
        {
            reporte rp = new reporte(3);
            rp.ShowDialog();
        }

        private void btnOrden_Click(object sender, EventArgs e)
        {
            FrmBusqueda fb = new FrmBusqueda(3);
            fb.ShowDialog();
        }
    }
}
