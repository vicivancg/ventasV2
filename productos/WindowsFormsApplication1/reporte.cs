using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cn.reporte;

namespace WindowsFormsApplication1
{
    public partial class reporte : Form
    {
        public int tipo = 0;
        public reporte()
        {
            InitializeComponent();
        }

        public reporte(int tipo)
        {
            this.tipo = tipo;
            InitializeComponent();
        }

        private void reporte_Load(object sender, EventArgs e)
        {
            if (this.tipo == 1)
            {
                lblReporte.Text = "Producto";
                lblInicio.Visible = false;
                lblFin.Visible = false;
                dtpInicio.Visible = false;
                dtpFin.Visible = false;
            }
            else if (this.tipo == 2)
            {
                lblReporte.Text = "Cliente";
                lblInicio.Visible = false;
                lblFin.Visible = false;
                dtpInicio.Visible = false;
                dtpFin.Visible = false;
            }
            else if (this.tipo == 3)
            {
                lblReporte.Visible = false;
                txtReporte.Visible = false;
                lblInicio.Visible = true;
                lblFin.Visible = true;
                dtpInicio.Visible = true;
                dtpFin.Visible = true;
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            reporteVentas rv = new reporteVentas();
            if (this.tipo == 1)
            {
                if (validacion.validarNombres(this.txtReporte.Text) && !this.txtReporte.Text.Equals(string.Empty))
                {
                    rv.SetDataSource(cn.reporte.reporte.reporteVentasProducto(this.txtReporte.Text));
                }
            }
            else if (this.tipo == 2)
            {
                if (validacion.validarNombreProducto(this.txtReporte.Text) && !this.txtReporte.Text.Equals(string.Empty))
                {
                    rv.SetDataSource(cn.reporte.reporte.reporteVentasNombre(this.txtReporte.Text));
                }
            }
            else if (this.tipo == 3)
            {
                rv.SetDataSource(cn.reporte.reporte.reporteVentasPeriodo(dtpInicio.Value,dtpFin.Value));
            }

            this.crystalReportViewer1.ReportSource = rv;
        }
    }
}
