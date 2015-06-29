namespace WindowsFormsApplication1
{
    partial class frmCliente
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
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtDelegacion = new System.Windows.Forms.TextBox();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblNoExt = new System.Windows.Forms.Label();
            this.lblNoInt = new System.Windows.Forms.Label();
            this.lblColonia = new System.Windows.Forms.Label();
            this.numNoExt = new System.Windows.Forms.NumericUpDown();
            this.lblDelegacion = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.numNoInt = new System.Windows.Forms.NumericUpDown();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblRfc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtRfc = new System.Windows.Forms.TextBox();
            this.rbPerMoral = new System.Windows.Forms.RadioButton();
            this.rbPerFisica = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numNoExt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNoInt)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.Location = new System.Drawing.Point(283, 9);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(122, 21);
            this.lblPrincipal.TabIndex = 0;
            this.lblPrincipal.Text = "Nuevo Cliente";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(121, 11);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(145, 20);
            this.txtCalle.TabIndex = 5;
            // 
            // txtDelegacion
            // 
            this.txtDelegacion.Location = new System.Drawing.Point(447, 11);
            this.txtDelegacion.Name = "txtDelegacion";
            this.txtDelegacion.Size = new System.Drawing.Size(145, 20);
            this.txtDelegacion.TabIndex = 6;
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(121, 47);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(145, 20);
            this.txtColonia.TabIndex = 7;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblCalle.Location = new System.Drawing.Point(6, 11);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(47, 20);
            this.lblCalle.TabIndex = 11;
            this.lblCalle.Text = "Calle";
            // 
            // lblNoExt
            // 
            this.lblNoExt.AutoSize = true;
            this.lblNoExt.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblNoExt.Location = new System.Drawing.Point(6, 80);
            this.lblNoExt.Name = "lblNoExt";
            this.lblNoExt.Size = new System.Drawing.Size(58, 20);
            this.lblNoExt.TabIndex = 12;
            this.lblNoExt.Text = "No. Ext";
            // 
            // lblNoInt
            // 
            this.lblNoInt.AutoSize = true;
            this.lblNoInt.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblNoInt.Location = new System.Drawing.Point(332, 80);
            this.lblNoInt.Name = "lblNoInt";
            this.lblNoInt.Size = new System.Drawing.Size(90, 20);
            this.lblNoInt.TabIndex = 13;
            this.lblNoInt.Text = "No. Interior";
            // 
            // lblColonia
            // 
            this.lblColonia.AutoSize = true;
            this.lblColonia.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblColonia.Location = new System.Drawing.Point(6, 45);
            this.lblColonia.Name = "lblColonia";
            this.lblColonia.Size = new System.Drawing.Size(66, 20);
            this.lblColonia.TabIndex = 14;
            this.lblColonia.Text = "Colonia";
            // 
            // numNoExt
            // 
            this.numNoExt.Location = new System.Drawing.Point(121, 83);
            this.numNoExt.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numNoExt.Name = "numNoExt";
            this.numNoExt.Size = new System.Drawing.Size(120, 20);
            this.numNoExt.TabIndex = 15;
            // 
            // lblDelegacion
            // 
            this.lblDelegacion.AutoSize = true;
            this.lblDelegacion.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblDelegacion.Location = new System.Drawing.Point(332, 11);
            this.lblDelegacion.Name = "lblDelegacion";
            this.lblDelegacion.Size = new System.Drawing.Size(95, 20);
            this.lblDelegacion.TabIndex = 16;
            this.lblDelegacion.Text = "Delegacion";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblEstado.Location = new System.Drawing.Point(332, 45);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(58, 20);
            this.lblEstado.TabIndex = 18;
            this.lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(447, 45);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(145, 20);
            this.txtEstado.TabIndex = 17;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnRegistro.Location = new System.Drawing.Point(609, 331);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(75, 38);
            this.btnRegistro.TabIndex = 19;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.button1_Click);
            // 
            // numNoInt
            // 
            this.numNoInt.Location = new System.Drawing.Point(447, 80);
            this.numNoInt.Name = "numNoInt";
            this.numNoInt.Size = new System.Drawing.Size(120, 20);
            this.numNoInt.TabIndex = 20;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnModificar.Location = new System.Drawing.Point(520, 331);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(83, 38);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnEliminar.Location = new System.Drawing.Point(439, 331);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 38);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCancelar.Location = new System.Drawing.Point(12, 331);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 38);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(121, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(184, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblNombre.Location = new System.Drawing.Point(6, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblTelefono.Location = new System.Drawing.Point(6, 69);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(71, 20);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblRfc
            // 
            this.lblRfc.AutoSize = true;
            this.lblRfc.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblRfc.Location = new System.Drawing.Point(332, 8);
            this.lblRfc.Name = "lblRfc";
            this.lblRfc.Size = new System.Drawing.Size(37, 20);
            this.lblRfc.TabIndex = 21;
            this.lblRfc.Text = "RFC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Clave";
            // 
            // txtClave
            // 
            this.txtClave.Enabled = false;
            this.txtClave.Location = new System.Drawing.Point(121, 10);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 34;
            // 
            // pnlDatos
            // 
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatos.Controls.Add(this.txtTelefono);
            this.pnlDatos.Controls.Add(this.txtRfc);
            this.pnlDatos.Controls.Add(this.rbPerMoral);
            this.pnlDatos.Controls.Add(this.rbPerFisica);
            this.pnlDatos.Controls.Add(this.txtClave);
            this.pnlDatos.Controls.Add(this.label1);
            this.pnlDatos.Controls.Add(this.lblRfc);
            this.pnlDatos.Controls.Add(this.lblTelefono);
            this.pnlDatos.Controls.Add(this.lblNombre);
            this.pnlDatos.Controls.Add(this.txtNombre);
            this.pnlDatos.Location = new System.Drawing.Point(44, 55);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(601, 102);
            this.pnlDatos.TabIndex = 36;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(121, 68);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 38;
            // 
            // txtRfc
            // 
            this.txtRfc.Location = new System.Drawing.Point(447, 8);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(120, 20);
            this.txtRfc.TabIndex = 37;
            // 
            // rbPerMoral
            // 
            this.rbPerMoral.AutoSize = true;
            this.rbPerMoral.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPerMoral.Location = new System.Drawing.Point(447, 65);
            this.rbPerMoral.Name = "rbPerMoral";
            this.rbPerMoral.Size = new System.Drawing.Size(133, 24);
            this.rbPerMoral.TabIndex = 36;
            this.rbPerMoral.TabStop = true;
            this.rbPerMoral.Text = "Persona Moral";
            this.rbPerMoral.UseVisualStyleBackColor = true;
            // 
            // rbPerFisica
            // 
            this.rbPerFisica.AutoSize = true;
            this.rbPerFisica.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPerFisica.Location = new System.Drawing.Point(447, 41);
            this.rbPerFisica.Name = "rbPerFisica";
            this.rbPerFisica.Size = new System.Drawing.Size(127, 24);
            this.rbPerFisica.TabIndex = 35;
            this.rbPerFisica.TabStop = true;
            this.rbPerFisica.Text = "Persona fisica";
            this.rbPerFisica.UseVisualStyleBackColor = true;
            this.rbPerFisica.CheckedChanged += new System.EventHandler(this.rbPerFisica_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numNoInt);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.txtEstado);
            this.panel1.Controls.Add(this.lblDelegacion);
            this.panel1.Controls.Add(this.numNoExt);
            this.panel1.Controls.Add(this.lblColonia);
            this.panel1.Controls.Add(this.lblNoInt);
            this.panel1.Controls.Add(this.lblNoExt);
            this.panel1.Controls.Add(this.lblCalle);
            this.panel1.Controls.Add(this.txtColonia);
            this.panel1.Controls.Add(this.txtDelegacion);
            this.panel1.Controls.Add(this.txtCalle);
            this.panel1.Location = new System.Drawing.Point(44, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 123);
            this.panel1.TabIndex = 35;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 381);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.lblPrincipal);
            this.Name = "frmCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNoExt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNoInt)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtDelegacion;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblNoExt;
        private System.Windows.Forms.Label lblNoInt;
        private System.Windows.Forms.Label lblColonia;
        private System.Windows.Forms.NumericUpDown numNoExt;
        private System.Windows.Forms.Label lblDelegacion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.NumericUpDown numNoInt;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblRfc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbPerMoral;
        private System.Windows.Forms.RadioButton rbPerFisica;
        private System.Windows.Forms.TextBox txtRfc;
        private System.Windows.Forms.TextBox txtTelefono;
    }
}