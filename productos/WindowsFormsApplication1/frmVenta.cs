using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cn.venta;
using cn.producto;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace WindowsFormsApplication1
{
    public partial class frmVenta : Form
    {
        venta ventaActual;
        public frmVenta()
        {
            ventaActual = new venta();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBusqueda fb = new FrmBusqueda(5, ventaActual.Cliente);
            fb.ShowDialog();
            lblCliente.Text = "Cliente: " + ventaActual.Cliente.Nombre;
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            dgvProductos.ColumnCount = 6;
            dgvProductos.Columns[0].Name = "Clave";
            dgvProductos.Columns[1].Name = "Nombre";
            dgvProductos.Columns[2].Name = "Precio";
            dgvProductos.Columns[3].Name = "Precio base";
            dgvProductos.Columns[4].Name = "IVA";
            dgvProductos.Columns[5].Name = "Cantidad";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBusqueda fb = new FrmBusqueda(4,ventaActual.Productos);
            fb.ShowDialog();
            mostrarProductos();

        }

        private void mostrarProductos()
        {
            this.ventaActual.Total = 0;
            this.ventaActual.SubTotal = 0;
            this.ventaActual.TotalIva = 0;
            if (ventaActual.Productos.Count > 0)
            {
                dgvProductos.Rows.Clear();
                foreach (cn.producto.producto prod in ventaActual.Productos)
                {
                    string[] producto = { prod.Clave, prod.Nombre, prod.Precio.ToString(), (prod.Precio - (prod.Precio * (Convert.ToDecimal(prod.Iva)/100))).ToString(), prod.Iva.ToString(), prod.Existencia.ToString() };
                    dgvProductos.Rows.Add(producto);
                    this.ventaActual.Total += prod.Precio * prod.Existencia;
                    this.ventaActual.SubTotal += (prod.Precio - (prod.Precio * (Convert.ToDecimal(prod.Iva) / 100)))*prod.Existencia;
                }
                this.ventaActual.TotalIva = decimal.Round(this.ventaActual.Total - this.ventaActual.SubTotal,2);
                lblTotal.Text = "Total: $ " + decimal.Round(this.ventaActual.Total,2);
                lblSubTotal.Text = "Sub-total: $ " + decimal.Round(this.ventaActual.SubTotal,2);
                dgvProductos.Refresh();
            }
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            if (ventaActual.Cliente != null && ventaActual.Productos.Count > 0 && cbEnvio.SelectedIndex >= 0)
            {
                // realizar venta
                this.ventaActual.FechaCompra = DateTime.Now;
                this.ventaActual.realizarVenta();
                if (this.ventaActual.IdFactura != 0)
                {
                    MessageBox.Show("La venta se ha realizado con exito");
                    this.btnAgregarCliente.Enabled = false;
                    this.btnAddProd.Enabled = false;
                    this.btnFinalizarVenta.Enabled = false;
                    this.btnFactura.Enabled = true;
                    this.btnNuevaVenta.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se ha podido realizar la venta (no hay disponibilidad en almacen)");
                    this.ventaActual.Productos.Clear();
                    this.dgvProductos.Refresh();
                }
            }
            else
            {
                MessageBox.Show("No se puede realizar la venta");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbEnvio_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ventaActual.Total -= this.ventaActual.Cargo;
            if (cbEnvio.SelectedIndex == 0)
            {
                this.ventaActual.Cargo = 200;
                this.ventaActual.Total += 200;
            }
            else if (cbEnvio.SelectedIndex == 1)
            {
                this.ventaActual.Cargo = 500;
                this.ventaActual.Total += 500;
            }
            else if (cbEnvio.SelectedIndex == 2)
            {
                this.ventaActual.Cargo = 1000;
                this.ventaActual.Total += 1000;
            }
            else if (cbEnvio.SelectedIndex == 3)
            {
                this.ventaActual.Cargo = 2000;
                this.ventaActual.Total += 2000;
            }
            lblTotal.Text = "Total: $ " + this.ventaActual.Total;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            try
            {
                Document documento = new Document(PageSize.LETTER);
                PdfWriter escritor = PdfWriter.GetInstance(documento, new FileStream(@"C:\Users\Vic Kenshin\Desktop\Facturas\" + this.ventaActual.IdFactura.ToString() + ".pdf", FileMode.OpenOrCreate));
                documento.AddTitle(this.ventaActual.IdFactura + " " + this.ventaActual.Cliente.Nombre);
                documento.AddCreator("littleWhiteBlueEyes");
                documento.Open();
                
                iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(Path.Combine(Application.StartupPath,@"img\logo.jpg"));
                imagen.BorderWidth = 0;
                imagen.Alignment = Element.ALIGN_CENTER;
                float percentage = 0.0f;
                percentage = 150 / imagen.Width;
                imagen.ScalePercent(percentage * 100);
                documento.Add(imagen);
                iTextSharp.text.Font fuenteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                iTextSharp.text.Font fuenteHead = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                iTextSharp.text.Font fuenteCuerpo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                iTextSharp.text.Font fuenteFooter = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 8, iTextSharp.text.Font.ITALIC, BaseColor.BLACK);
                Paragraph titulo = new Paragraph("Recibo de compra", fuenteTitulo);
                titulo.Alignment = Element.ALIGN_CENTER;
                documento.Add(new Paragraph(titulo));
                documento.Add(Chunk.NEWLINE);
                documento.Add(Chunk.NEWLINE);
                documento.Add(new Paragraph("Factura No: " + this.ventaActual.IdFactura.ToString(), fuenteCuerpo));
                documento.Add(new Paragraph("Total: $" + this.ventaActual.Total.ToString(), fuenteCuerpo));
                documento.Add(new Paragraph("Sub-Total: $" + this.ventaActual.SubTotal.ToString(), fuenteCuerpo));
                documento.Add(new Paragraph("Total Iva: $" + this.ventaActual.TotalIva.ToString(), fuenteCuerpo));
                documento.Add(new Paragraph("Cargo (Envio): $" + this.ventaActual.Cargo.ToString(), fuenteCuerpo));
                documento.Add(new Paragraph("Fecha: " + this.ventaActual.FechaCompra.ToShortDateString(), fuenteCuerpo));
                documento.Add(new Paragraph("Cliente: " + this.ventaActual.Cliente.Nombre, fuenteCuerpo));
                documento.Add(new Paragraph("RFC: " + this.ventaActual.Cliente.Rfc, fuenteCuerpo));
                documento.Add(new Paragraph("Dirección: " + this.ventaActual.Cliente.Dir, fuenteCuerpo));
                documento.Add(Chunk.NEWLINE);
                documento.Add(Chunk.NEWLINE);
                PdfPTable tablaProductos = new PdfPTable(5);
                tablaProductos.WidthPercentage = 80;
                PdfPCell colProducto = new PdfPCell(new Phrase("Producto", fuenteCuerpo));
                colProducto.BorderWidth = 0;
                colProducto.BorderWidthBottom = .75f;
                PdfPCell colPrecio = new PdfPCell(new Phrase("Precio", fuenteCuerpo));
                colProducto.BorderWidth = 0;
                colProducto.BorderWidthBottom = .75f;
                PdfPCell colCantidad = new PdfPCell(new Phrase("Cantidad", fuenteCuerpo));
                colProducto.BorderWidth = 0;
                colProducto.BorderWidthBottom = .75f;
                PdfPCell colIva = new PdfPCell(new Phrase("Iva", fuenteCuerpo));
                colProducto.BorderWidth = 0;
                colProducto.BorderWidthBottom = .75f;
                PdfPCell colTotal = new PdfPCell(new Phrase("Total", fuenteCuerpo));
                colProducto.BorderWidth = 0;
                colProducto.BorderWidthBottom = .75f;

                tablaProductos.AddCell(colProducto);
                tablaProductos.AddCell(colPrecio);
                tablaProductos.AddCell(colCantidad);
                tablaProductos.AddCell(colIva);
                tablaProductos.AddCell(colTotal);
                foreach (producto producto in this.ventaActual.Productos)
                {
                    colProducto = new PdfPCell(new Phrase(producto.Nombre, fuenteCuerpo));
                    colPrecio = new PdfPCell(new Phrase("$" + producto.Precio.ToString(), fuenteCuerpo));
                    colCantidad = new PdfPCell(new Phrase(producto.Existencia.ToString(), fuenteCuerpo));
                    colIva = new PdfPCell(new Phrase(producto.Iva.ToString(), fuenteCuerpo));
                    colTotal = new PdfPCell(new Phrase("$" + (producto.Existencia * producto.Precio).ToString(), fuenteCuerpo));
                    tablaProductos.AddCell(colProducto);
                    tablaProductos.AddCell(colPrecio);
                    tablaProductos.AddCell(colCantidad);
                    tablaProductos.AddCell(colIva);
                    tablaProductos.AddCell(colTotal);
                }
                documento.Add(tablaProductos);
                documento.Add(Chunk.NEWLINE);
                Paragraph footer = new Paragraph("W&B Enterprise México Developed by ViCross", fuenteFooter);
                footer.Alignment = Element.ALIGN_CENTER;
                documento.Add(new Paragraph(footer));
                documento.Close();
                escritor.Close();
                MessageBox.Show("La factura se ha generado con exito");
                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("La factura no se ha generado con exito debido a " + ex.Data);
            }
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            ventaActual = new venta();
            this.lblCliente.Text = "Cliente : No seleccionado";
            this.lblTotal.Text = "Total: $ 00.00";
            this.lblSubTotal.Text = "Sub-total: $ 00.00";
            dgvProductos.RowCount = 0;
            dgvProductos.Refresh();
            this.btnAgregarCliente.Enabled = true;
            this.btnAddProd.Enabled = true;
            this.btnFinalizarVenta.Enabled = true;
            this.btnFactura.Enabled = false;
            this.btnNuevaVenta.Enabled = false;
            this.cbEnvio.SelectedIndex = -1;
        }
    }
}
