namespace WindowsFormsApplication1
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.lblMenu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.btnOrden = new System.Windows.Forms.Button();
            this.btnModProd = new System.Windows.Forms.Button();
            this.btnAltaProd = new System.Windows.Forms.Button();
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.btnModCliente = new System.Windows.Forms.Button();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.pnlFacturacion = new System.Windows.Forms.Panel();
            this.btnAltaFact = new System.Windows.Forms.Button();
            this.pnlReportes = new System.Windows.Forms.Panel();
            this.btnRepFecha = new System.Windows.Forms.Button();
            this.btnRepProd = new System.Windows.Forms.Button();
            this.btnRepCliente = new System.Windows.Forms.Button();
            this.imgRic = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlProductos.SuspendLayout();
            this.pnlClientes.SuspendLayout();
            this.pnlFacturacion.SuspendLayout();
            this.pnlReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(293, 19);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(63, 22);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menu";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Controls.Add(this.btnFacturacion);
            this.panel1.Controls.Add(this.btnReportes);
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.btnProductos);
            this.panel1.Location = new System.Drawing.Point(33, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 56);
            this.panel1.TabIndex = 1;
            // 
            // btnClientes
            // 
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnClientes.Location = new System.Drawing.Point(123, -1);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(92, 55);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.btnClientes.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnFacturacion.Location = new System.Drawing.Point(230, -1);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(114, 55);
            this.btnFacturacion.TabIndex = 6;
            this.btnFacturacion.Text = "Facturación";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            // 
            // btnReportes
            // 
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnReportes.Location = new System.Drawing.Point(351, 0);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(92, 54);
            this.btnReportes.TabIndex = 7;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.MouseEnter += new System.EventHandler(this.button5_MouseEnter);
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnInfo.Location = new System.Drawing.Point(449, -1);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(91, 55);
            this.btnInfo.TabIndex = 8;
            this.btnInfo.Text = "info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            this.btnInfo.MouseEnter += new System.EventHandler(this.btnInfo_MouseEnter);
            // 
            // btnProductos
            // 
            this.btnProductos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Location = new System.Drawing.Point(-1, -1);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(109, 55);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Leave += new System.EventHandler(this.button1_Leave);
            this.btnProductos.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.btnProductos.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.btnProductos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // pnlProductos
            // 
            this.pnlProductos.Controls.Add(this.btnOrden);
            this.pnlProductos.Controls.Add(this.btnModProd);
            this.pnlProductos.Controls.Add(this.btnAltaProd);
            this.pnlProductos.Location = new System.Drawing.Point(33, 116);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Size = new System.Drawing.Size(109, 138);
            this.pnlProductos.TabIndex = 2;
            this.pnlProductos.Visible = false;
            // 
            // btnOrden
            // 
            this.btnOrden.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnOrden.Location = new System.Drawing.Point(0, 96);
            this.btnOrden.Name = "btnOrden";
            this.btnOrden.Size = new System.Drawing.Size(109, 42);
            this.btnOrden.TabIndex = 7;
            this.btnOrden.Text = "Orden";
            this.btnOrden.UseVisualStyleBackColor = true;
            this.btnOrden.Click += new System.EventHandler(this.btnOrden_Click);
            // 
            // btnModProd
            // 
            this.btnModProd.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnModProd.Location = new System.Drawing.Point(0, 48);
            this.btnModProd.Name = "btnModProd";
            this.btnModProd.Size = new System.Drawing.Size(109, 42);
            this.btnModProd.TabIndex = 5;
            this.btnModProd.Text = "Modificar";
            this.btnModProd.UseVisualStyleBackColor = true;
            this.btnModProd.Click += new System.EventHandler(this.btnModProd_Click);
            // 
            // btnAltaProd
            // 
            this.btnAltaProd.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAltaProd.Location = new System.Drawing.Point(0, 0);
            this.btnAltaProd.Name = "btnAltaProd";
            this.btnAltaProd.Size = new System.Drawing.Size(109, 42);
            this.btnAltaProd.TabIndex = 0;
            this.btnAltaProd.Text = "Alta";
            this.btnAltaProd.UseVisualStyleBackColor = true;
            this.btnAltaProd.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnlClientes
            // 
            this.pnlClientes.Controls.Add(this.btnModCliente);
            this.pnlClientes.Controls.Add(this.btnAltaCliente);
            this.pnlClientes.Location = new System.Drawing.Point(157, 116);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(92, 90);
            this.pnlClientes.TabIndex = 3;
            this.pnlClientes.Visible = false;
            // 
            // btnModCliente
            // 
            this.btnModCliente.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnModCliente.Location = new System.Drawing.Point(0, 48);
            this.btnModCliente.Name = "btnModCliente";
            this.btnModCliente.Size = new System.Drawing.Size(92, 42);
            this.btnModCliente.TabIndex = 5;
            this.btnModCliente.Text = "Modificar";
            this.btnModCliente.UseVisualStyleBackColor = true;
            this.btnModCliente.Click += new System.EventHandler(this.btnModCliente_Click);
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAltaCliente.Location = new System.Drawing.Point(0, 0);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(92, 42);
            this.btnAltaCliente.TabIndex = 5;
            this.btnAltaCliente.Text = "Alta";
            this.btnAltaCliente.UseVisualStyleBackColor = true;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // pnlFacturacion
            // 
            this.pnlFacturacion.Controls.Add(this.btnAltaFact);
            this.pnlFacturacion.Location = new System.Drawing.Point(264, 116);
            this.pnlFacturacion.Name = "pnlFacturacion";
            this.pnlFacturacion.Size = new System.Drawing.Size(114, 42);
            this.pnlFacturacion.TabIndex = 4;
            this.pnlFacturacion.Visible = false;
            // 
            // btnAltaFact
            // 
            this.btnAltaFact.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAltaFact.Location = new System.Drawing.Point(0, 0);
            this.btnAltaFact.Name = "btnAltaFact";
            this.btnAltaFact.Size = new System.Drawing.Size(114, 42);
            this.btnAltaFact.TabIndex = 5;
            this.btnAltaFact.Text = "Nuevo";
            this.btnAltaFact.UseVisualStyleBackColor = true;
            this.btnAltaFact.Click += new System.EventHandler(this.btnAltaFact_Click);
            // 
            // pnlReportes
            // 
            this.pnlReportes.Controls.Add(this.btnRepFecha);
            this.pnlReportes.Controls.Add(this.btnRepProd);
            this.pnlReportes.Controls.Add(this.btnRepCliente);
            this.pnlReportes.Location = new System.Drawing.Point(385, 116);
            this.pnlReportes.Name = "pnlReportes";
            this.pnlReportes.Size = new System.Drawing.Size(92, 138);
            this.pnlReportes.TabIndex = 3;
            this.pnlReportes.Visible = false;
            // 
            // btnRepFecha
            // 
            this.btnRepFecha.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnRepFecha.Location = new System.Drawing.Point(0, 96);
            this.btnRepFecha.Name = "btnRepFecha";
            this.btnRepFecha.Size = new System.Drawing.Size(92, 42);
            this.btnRepFecha.TabIndex = 7;
            this.btnRepFecha.Text = "Fecha";
            this.btnRepFecha.UseVisualStyleBackColor = true;
            this.btnRepFecha.Click += new System.EventHandler(this.btnRepFecha_Click);
            // 
            // btnRepProd
            // 
            this.btnRepProd.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnRepProd.Location = new System.Drawing.Point(0, 0);
            this.btnRepProd.Name = "btnRepProd";
            this.btnRepProd.Size = new System.Drawing.Size(92, 42);
            this.btnRepProd.TabIndex = 5;
            this.btnRepProd.Text = "producto";
            this.btnRepProd.UseVisualStyleBackColor = true;
            this.btnRepProd.Click += new System.EventHandler(this.btnRepProd_Click);
            // 
            // btnRepCliente
            // 
            this.btnRepCliente.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnRepCliente.Location = new System.Drawing.Point(0, 48);
            this.btnRepCliente.Name = "btnRepCliente";
            this.btnRepCliente.Size = new System.Drawing.Size(92, 42);
            this.btnRepCliente.TabIndex = 5;
            this.btnRepCliente.Text = "Cliente";
            this.btnRepCliente.UseVisualStyleBackColor = true;
            this.btnRepCliente.Click += new System.EventHandler(this.btnRepCliente_Click);
            // 
            // imgRic
            // 
            this.imgRic.Image = ((System.Drawing.Image)(resources.GetObject("imgRic.Image")));
            this.imgRic.Location = new System.Drawing.Point(33, 322);
            this.imgRic.Name = "imgRic";
            this.imgRic.Size = new System.Drawing.Size(350, 81);
            this.imgRic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgRic.TabIndex = 5;
            this.imgRic.TabStop = false;
            this.imgRic.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblInfo.Location = new System.Drawing.Point(260, 406);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(326, 19);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Administración De Bases De Datos Agosto 2014";
            this.lblInfo.Visible = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(608, 434);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.imgRic);
            this.Controls.Add(this.pnlReportes);
            this.Controls.Add(this.pnlFacturacion);
            this.Controls.Add(this.pnlClientes);
            this.Controls.Add(this.pnlProductos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMenu);
            this.Name = "FrmMenu";
            this.Text = "Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenu_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.pnlProductos.ResumeLayout(false);
            this.pnlClientes.ResumeLayout(false);
            this.pnlFacturacion.ResumeLayout(false);
            this.pnlReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgRic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Panel pnlProductos;
        private System.Windows.Forms.Button btnModProd;
        private System.Windows.Forms.Button btnAltaProd;
        private System.Windows.Forms.Panel pnlClientes;
        private System.Windows.Forms.Button btnModCliente;
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.Panel pnlFacturacion;
        private System.Windows.Forms.Button btnAltaFact;
        private System.Windows.Forms.Panel pnlReportes;
        private System.Windows.Forms.Button btnRepFecha;
        private System.Windows.Forms.Button btnRepProd;
        private System.Windows.Forms.Button btnRepCliente;
        private System.Windows.Forms.PictureBox imgRic;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnOrden;
    }
}

