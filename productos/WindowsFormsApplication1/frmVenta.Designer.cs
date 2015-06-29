namespace WindowsFormsApplication1
{
    partial class frmVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scPrincipal = new System.Windows.Forms.SplitContainer();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.btnFinalizarVenta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.pbModificar = new System.Windows.Forms.PictureBox();
            this.cbEnvio = new System.Windows.Forms.ComboBox();
            this.lblEnvio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.mcFecha = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.scPrincipal)).BeginInit();
            this.scPrincipal.Panel1.SuspendLayout();
            this.scPrincipal.Panel2.SuspendLayout();
            this.scPrincipal.SuspendLayout();
            this.flpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // scPrincipal
            // 
            this.scPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scPrincipal.Location = new System.Drawing.Point(0, 0);
            this.scPrincipal.Name = "scPrincipal";
            // 
            // scPrincipal.Panel1
            // 
            this.scPrincipal.Panel1.Controls.Add(this.flpMenu);
            // 
            // scPrincipal.Panel2
            // 
            this.scPrincipal.Panel2.Controls.Add(this.pbModificar);
            this.scPrincipal.Panel2.Controls.Add(this.cbEnvio);
            this.scPrincipal.Panel2.Controls.Add(this.lblEnvio);
            this.scPrincipal.Panel2.Controls.Add(this.label1);
            this.scPrincipal.Panel2.Controls.Add(this.lblSubTotal);
            this.scPrincipal.Panel2.Controls.Add(this.lblTotal);
            this.scPrincipal.Panel2.Controls.Add(this.lblFecha);
            this.scPrincipal.Panel2.Controls.Add(this.lblCliente);
            this.scPrincipal.Panel2.Controls.Add(this.dgvProductos);
            this.scPrincipal.Panel2.Controls.Add(this.mcFecha);
            this.scPrincipal.Size = new System.Drawing.Size(876, 461);
            this.scPrincipal.SplitterDistance = 292;
            this.scPrincipal.TabIndex = 0;
            // 
            // flpMenu
            // 
            this.flpMenu.Controls.Add(this.btnAgregarCliente);
            this.flpMenu.Controls.Add(this.btnAddProd);
            this.flpMenu.Controls.Add(this.btnFinalizarVenta);
            this.flpMenu.Controls.Add(this.btnSalir);
            this.flpMenu.Controls.Add(this.btnFactura);
            this.flpMenu.Controls.Add(this.btnNuevaVenta);
            this.flpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMenu.Location = new System.Drawing.Point(0, 0);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(292, 461);
            this.flpMenu.TabIndex = 0;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.Location = new System.Drawing.Point(3, 3);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(282, 56);
            this.btnAgregarCliente.TabIndex = 0;
            this.btnAgregarCliente.Text = "Seleccionar cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddProd
            // 
            this.btnAddProd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProd.Location = new System.Drawing.Point(3, 65);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(282, 56);
            this.btnAddProd.TabIndex = 1;
            this.btnAddProd.Text = "Seleccionar producto";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFinalizarVenta
            // 
            this.btnFinalizarVenta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarVenta.Location = new System.Drawing.Point(3, 127);
            this.btnFinalizarVenta.Name = "btnFinalizarVenta";
            this.btnFinalizarVenta.Size = new System.Drawing.Size(282, 56);
            this.btnFinalizarVenta.TabIndex = 3;
            this.btnFinalizarVenta.Text = "Finalizar Venta";
            this.btnFinalizarVenta.UseVisualStyleBackColor = true;
            this.btnFinalizarVenta.Click += new System.EventHandler(this.btnFinalizarVenta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(3, 189);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(282, 56);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.Enabled = false;
            this.btnFactura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.Location = new System.Drawing.Point(3, 251);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(282, 56);
            this.btnFactura.TabIndex = 4;
            this.btnFactura.Text = "Generar Factura (PDF)";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Enabled = false;
            this.btnNuevaVenta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaVenta.Location = new System.Drawing.Point(3, 313);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(282, 56);
            this.btnNuevaVenta.TabIndex = 6;
            this.btnNuevaVenta.Text = "Nueva Venta";
            this.btnNuevaVenta.UseVisualStyleBackColor = true;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // pbModificar
            // 
            this.pbModificar.Location = new System.Drawing.Point(498, 396);
            this.pbModificar.Name = "pbModificar";
            this.pbModificar.Size = new System.Drawing.Size(64, 33);
            this.pbModificar.TabIndex = 9;
            this.pbModificar.TabStop = false;
            // 
            // cbEnvio
            // 
            this.cbEnvio.FormattingEnabled = true;
            this.cbEnvio.Items.AddRange(new object[] {
            "Nacional - $200",
            "Nacional Urgente - $500",
            "Internacional - $1000",
            "Internacional Urgente - $2000"});
            this.cbEnvio.Location = new System.Drawing.Point(132, 410);
            this.cbEnvio.Name = "cbEnvio";
            this.cbEnvio.Size = new System.Drawing.Size(121, 21);
            this.cbEnvio.TabIndex = 8;
            this.cbEnvio.SelectedIndexChanged += new System.EventHandler(this.cbEnvio_SelectedIndexChanged);
            // 
            // lblEnvio
            // 
            this.lblEnvio.AutoSize = true;
            this.lblEnvio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnvio.Location = new System.Drawing.Point(19, 411);
            this.lblEnvio.Name = "lblEnvio";
            this.lblEnvio.Size = new System.Drawing.Size(107, 20);
            this.lblEnvio.TabIndex = 7;
            this.lblEnvio.Text = "Tipo de envio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Productos";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(33, 87);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(129, 20);
            this.lblSubTotal.TabIndex = 5;
            this.lblSubTotal.Text = "Sub-total: $ 00.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(33, 55);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(98, 20);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total: $ 00.00";
            this.lblTotal.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(429, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(55, 20);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(33, 25);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(199, 20);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente : No seleccionado";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvProductos.Location = new System.Drawing.Point(22, 218);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(550, 173);
            this.dgvProductos.TabIndex = 1;
            // 
            // mcFecha
            // 
            this.mcFecha.Enabled = false;
            this.mcFecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcFecha.Location = new System.Drawing.Point(323, 38);
            this.mcFecha.Name = "mcFecha";
            this.mcFecha.TabIndex = 0;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 461);
            this.Controls.Add(this.scPrincipal);
            this.Name = "frmVenta";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            this.scPrincipal.Panel1.ResumeLayout(false);
            this.scPrincipal.Panel2.ResumeLayout(false);
            this.scPrincipal.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scPrincipal)).EndInit();
            this.scPrincipal.ResumeLayout(false);
            this.flpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scPrincipal;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Button btnFinalizarVenta;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.MonthCalendar mcFecha;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEnvio;
        private System.Windows.Forms.Label lblEnvio;
        private System.Windows.Forms.PictureBox pbModificar;
    }
}