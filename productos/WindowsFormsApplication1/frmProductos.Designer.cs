namespace WindowsFormsApplication1
{
    partial class frmProductos
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtUnidadMedida = new System.Windows.Forms.Label();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.numExistencia = new System.Windows.Forms.NumericUpDown();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbUnMed = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblIva = new System.Windows.Forms.Label();
            this.cbIva = new System.Windows.Forms.ComboBox();
            this.dtpProducto = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numExistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblNombre.Location = new System.Drawing.Point(56, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblDesc.Location = new System.Drawing.Point(56, 156);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(96, 20);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Descripción";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblPrecio.Location = new System.Drawing.Point(56, 88);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(56, 20);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio";
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.AutoSize = true;
            this.txtUnidadMedida.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtUnidadMedida.Location = new System.Drawing.Point(256, 54);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(124, 20);
            this.txtUnidadMedida.TabIndex = 3;
            this.txtUnidadMedida.Text = "Unidad Medida";
            // 
            // lblExistencia
            // 
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblExistencia.Location = new System.Drawing.Point(256, 21);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(80, 20);
            this.lblExistencia.TabIndex = 4;
            this.lblExistencia.Text = "Existencia";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(130, 90);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 6;
            // 
            // numExistencia
            // 
            this.numExistencia.Location = new System.Drawing.Point(398, 21);
            this.numExistencia.Name = "numExistencia";
            this.numExistencia.Size = new System.Drawing.Size(120, 20);
            this.numExistencia.TabIndex = 7;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(60, 179);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(463, 96);
            this.txtDesc.TabIndex = 9;
            this.txtDesc.Text = "";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnEliminar.Location = new System.Drawing.Point(354, 293);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 38);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnModificar.Location = new System.Drawing.Point(435, 293);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(83, 38);
            this.btnModificar.TabIndex = 27;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnRegistro.Location = new System.Drawing.Point(524, 293);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(75, 38);
            this.btnRegistro.TabIndex = 26;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCancelar.Location = new System.Drawing.Point(27, 293);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 38);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbUnMed
            // 
            this.cbUnMed.FormattingEnabled = true;
            this.cbUnMed.Items.AddRange(new object[] {
            "KG-kilogramos",
            "G-gramos",
            "L-litros",
            "ML-mililitros",
            "P-piezas",
            "C-Caja"});
            this.cbUnMed.Location = new System.Drawing.Point(397, 55);
            this.cbUnMed.Name = "cbUnMed";
            this.cbUnMed.Size = new System.Drawing.Size(121, 21);
            this.cbUnMed.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label1.Location = new System.Drawing.Point(56, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Clave";
            // 
            // txtClave
            // 
            this.txtClave.Enabled = false;
            this.txtClave.Location = new System.Drawing.Point(130, 23);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 32;
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblIva.Location = new System.Drawing.Point(256, 90);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(36, 20);
            this.lblIva.TabIndex = 35;
            this.lblIva.Text = "IVA";
            // 
            // cbIva
            // 
            this.cbIva.FormattingEnabled = true;
            this.cbIva.Items.AddRange(new object[] {
            "16%",
            "11%",
            "0%"});
            this.cbIva.Location = new System.Drawing.Point(397, 87);
            this.cbIva.Name = "cbIva";
            this.cbIva.Size = new System.Drawing.Size(121, 21);
            this.cbIva.TabIndex = 36;
            // 
            // dtpProducto
            // 
            this.dtpProducto.Enabled = false;
            this.dtpProducto.Location = new System.Drawing.Point(130, 124);
            this.dtpProducto.Name = "dtpProducto";
            this.dtpProducto.Size = new System.Drawing.Size(200, 20);
            this.dtpProducto.TabIndex = 37;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblFecha.Location = new System.Drawing.Point(56, 124);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(55, 20);
            this.lblFecha.TabIndex = 38;
            this.lblFecha.Text = "Fecha";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 354);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpProducto);
            this.Controls.Add(this.cbIva);
            this.Controls.Add(this.lblIva);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbUnMed);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.numExistencia);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblExistencia);
            this.Controls.Add(this.txtUnidadMedida);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numExistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label txtUnidadMedida;
        private System.Windows.Forms.Label lblExistencia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.NumericUpDown numExistencia;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbUnMed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.ComboBox cbIva;
        private System.Windows.Forms.DateTimePicker dtpProducto;
        private System.Windows.Forms.Label lblFecha;
    }
}