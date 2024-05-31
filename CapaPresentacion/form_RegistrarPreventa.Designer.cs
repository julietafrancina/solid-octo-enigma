
namespace CapaPresentacion
{
    partial class form_RegistrarPreventa
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelarPreventa = new FontAwesome.Sharp.IconButton();
            this.bntCrearPreventa = new FontAwesome.Sharp.IconButton();
            this.txtTotalAPagar = new System.Windows.Forms.TextBox();
            this.totalAPagar = new System.Windows.Forms.Label();
            this.RegistrarPreventa = new System.Windows.Forms.Label();
            this.grpArticulos = new System.Windows.Forms.GroupBox();
            this.btnAgregarArticulosPreventa = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.bumCantidadArticulo = new System.Windows.Forms.NumericUpDown();
            this.txtCostoArticulo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMarcaArticulo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRubroArticulo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSKUBusqueda = new System.Windows.Forms.TextBox();
            this.txtDescripcionArticulo = new System.Windows.Forms.TextBox();
            this.dgvAgregarArticulosPreventa = new System.Windows.Forms.DataGridView();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarSKU = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSucursalPreventa = new System.Windows.Forms.TextBox();
            this.txtFechaPreventa = new System.Windows.Forms.TextBox();
            this.preventaSucursal = new System.Windows.Forms.Label();
            this.preventaFecha = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.preventaNombreCliente = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDomicilioCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBusquedaCliente = new FontAwesome.Sharp.IconButton();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.grpArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bumCantidadArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarArticulosPreventa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.btnCancelarPreventa);
            this.groupBox2.Controls.Add(this.bntCrearPreventa);
            this.groupBox2.Controls.Add(this.txtTotalAPagar);
            this.groupBox2.Controls.Add(this.totalAPagar);
            this.groupBox2.Location = new System.Drawing.Point(959, 427);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 289);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preventa";
            // 
            // btnCancelarPreventa
            // 
            this.btnCancelarPreventa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelarPreventa.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnCancelarPreventa.IconColor = System.Drawing.Color.Firebrick;
            this.btnCancelarPreventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarPreventa.IconSize = 20;
            this.btnCancelarPreventa.Location = new System.Drawing.Point(14, 170);
            this.btnCancelarPreventa.Name = "btnCancelarPreventa";
            this.btnCancelarPreventa.Size = new System.Drawing.Size(176, 42);
            this.btnCancelarPreventa.TabIndex = 43;
            this.btnCancelarPreventa.Text = "Cancelar";
            this.btnCancelarPreventa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelarPreventa.UseVisualStyleBackColor = false;
            // 
            // bntCrearPreventa
            // 
            this.bntCrearPreventa.BackColor = System.Drawing.Color.LightGreen;
            this.bntCrearPreventa.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.bntCrearPreventa.IconColor = System.Drawing.Color.LightGreen;
            this.bntCrearPreventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCrearPreventa.IconSize = 25;
            this.bntCrearPreventa.Location = new System.Drawing.Point(14, 227);
            this.bntCrearPreventa.Name = "bntCrearPreventa";
            this.bntCrearPreventa.Size = new System.Drawing.Size(176, 46);
            this.bntCrearPreventa.TabIndex = 41;
            this.bntCrearPreventa.Text = "Crear Preventa";
            this.bntCrearPreventa.UseVisualStyleBackColor = false;
            // 
            // txtTotalAPagar
            // 
            this.txtTotalAPagar.Location = new System.Drawing.Point(14, 53);
            this.txtTotalAPagar.MinimumSize = new System.Drawing.Size(4, 32);
            this.txtTotalAPagar.Name = "txtTotalAPagar";
            this.txtTotalAPagar.PasswordChar = '*';
            this.txtTotalAPagar.Size = new System.Drawing.Size(176, 22);
            this.txtTotalAPagar.TabIndex = 36;
            // 
            // totalAPagar
            // 
            this.totalAPagar.AutoSize = true;
            this.totalAPagar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totalAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAPagar.Location = new System.Drawing.Point(11, 31);
            this.totalAPagar.Name = "totalAPagar";
            this.totalAPagar.Size = new System.Drawing.Size(106, 17);
            this.totalAPagar.TabIndex = 35;
            this.totalAPagar.Text = "Total a pagar";
            // 
            // RegistrarPreventa
            // 
            this.RegistrarPreventa.AutoSize = true;
            this.RegistrarPreventa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RegistrarPreventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarPreventa.Location = new System.Drawing.Point(21, 29);
            this.RegistrarPreventa.Margin = new System.Windows.Forms.Padding(0);
            this.RegistrarPreventa.Name = "RegistrarPreventa";
            this.RegistrarPreventa.Size = new System.Drawing.Size(167, 20);
            this.RegistrarPreventa.TabIndex = 65;
            this.RegistrarPreventa.Text = "Registrar Preventa";
            // 
            // grpArticulos
            // 
            this.grpArticulos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpArticulos.Controls.Add(this.btnAgregarArticulosPreventa);
            this.grpArticulos.Controls.Add(this.label9);
            this.grpArticulos.Controls.Add(this.bumCantidadArticulo);
            this.grpArticulos.Controls.Add(this.txtCostoArticulo);
            this.grpArticulos.Controls.Add(this.label8);
            this.grpArticulos.Controls.Add(this.txtMarcaArticulo);
            this.grpArticulos.Controls.Add(this.label10);
            this.grpArticulos.Controls.Add(this.txtRubroArticulo);
            this.grpArticulos.Controls.Add(this.label6);
            this.grpArticulos.Controls.Add(this.txtSKUBusqueda);
            this.grpArticulos.Controls.Add(this.txtDescripcionArticulo);
            this.grpArticulos.Controls.Add(this.dgvAgregarArticulosPreventa);
            this.grpArticulos.Controls.Add(this.label7);
            this.grpArticulos.Controls.Add(this.label5);
            this.grpArticulos.Controls.Add(this.btnBuscarSKU);
            this.grpArticulos.Location = new System.Drawing.Point(25, 259);
            this.grpArticulos.Name = "grpArticulos";
            this.grpArticulos.Size = new System.Drawing.Size(916, 457);
            this.grpArticulos.TabIndex = 64;
            this.grpArticulos.TabStop = false;
            this.grpArticulos.Text = "Agregar artículos";
            // 
            // btnAgregarArticulosPreventa
            // 
            this.btnAgregarArticulosPreventa.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregarArticulosPreventa.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAgregarArticulosPreventa.IconColor = System.Drawing.Color.LimeGreen;
            this.btnAgregarArticulosPreventa.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAgregarArticulosPreventa.IconSize = 30;
            this.btnAgregarArticulosPreventa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarArticulosPreventa.Location = new System.Drawing.Point(789, 55);
            this.btnAgregarArticulosPreventa.Name = "btnAgregarArticulosPreventa";
            this.btnAgregarArticulosPreventa.Size = new System.Drawing.Size(108, 80);
            this.btnAgregarArticulosPreventa.TabIndex = 67;
            this.btnAgregarArticulosPreventa.Text = "Agregar";
            this.btnAgregarArticulosPreventa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregarArticulosPreventa.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(586, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 88;
            this.label9.Text = "Cantidad";
            // 
            // bumCantidadArticulo
            // 
            this.bumCantidadArticulo.Location = new System.Drawing.Point(589, 112);
            this.bumCantidadArticulo.Name = "bumCantidadArticulo";
            this.bumCantidadArticulo.Size = new System.Drawing.Size(164, 22);
            this.bumCantidadArticulo.TabIndex = 87;
            // 
            // txtCostoArticulo
            // 
            this.txtCostoArticulo.Location = new System.Drawing.Point(589, 55);
            this.txtCostoArticulo.Name = "txtCostoArticulo";
            this.txtCostoArticulo.Size = new System.Drawing.Size(164, 22);
            this.txtCostoArticulo.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(586, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 85;
            this.label8.Text = "Costo";
            // 
            // txtMarcaArticulo
            // 
            this.txtMarcaArticulo.Location = new System.Drawing.Point(384, 112);
            this.txtMarcaArticulo.Name = "txtMarcaArticulo";
            this.txtMarcaArticulo.Size = new System.Drawing.Size(164, 22);
            this.txtMarcaArticulo.TabIndex = 84;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(381, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 17);
            this.label10.TabIndex = 83;
            this.label10.Text = "Marca";
            // 
            // txtRubroArticulo
            // 
            this.txtRubroArticulo.Location = new System.Drawing.Point(214, 112);
            this.txtRubroArticulo.Name = "txtRubroArticulo";
            this.txtRubroArticulo.Size = new System.Drawing.Size(164, 22);
            this.txtRubroArticulo.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(211, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 77;
            this.label6.Text = "Rubro";
            // 
            // txtSKUBusqueda
            // 
            this.txtSKUBusqueda.Location = new System.Drawing.Point(14, 55);
            this.txtSKUBusqueda.Name = "txtSKUBusqueda";
            this.txtSKUBusqueda.Size = new System.Drawing.Size(164, 22);
            this.txtSKUBusqueda.TabIndex = 77;
            // 
            // txtDescripcionArticulo
            // 
            this.txtDescripcionArticulo.Location = new System.Drawing.Point(214, 55);
            this.txtDescripcionArticulo.Name = "txtDescripcionArticulo";
            this.txtDescripcionArticulo.Size = new System.Drawing.Size(334, 22);
            this.txtDescripcionArticulo.TabIndex = 76;
            // 
            // dgvAgregarArticulosPreventa
            // 
            this.dgvAgregarArticulosPreventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregarArticulosPreventa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Articulo,
            this.SKU,
            this.Rubro,
            this.Marca,
            this.Costo,
            this.Eliminar});
            this.dgvAgregarArticulosPreventa.Location = new System.Drawing.Point(14, 168);
            this.dgvAgregarArticulosPreventa.Name = "dgvAgregarArticulosPreventa";
            this.dgvAgregarArticulosPreventa.RowHeadersWidth = 51;
            this.dgvAgregarArticulosPreventa.RowTemplate.Height = 24;
            this.dgvAgregarArticulosPreventa.Size = new System.Drawing.Size(883, 273);
            this.dgvAgregarArticulosPreventa.TabIndex = 56;
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Artículo";
            this.Articulo.MinimumWidth = 6;
            this.Articulo.Name = "Articulo";
            this.Articulo.Width = 175;
            // 
            // SKU
            // 
            this.SKU.HeaderText = "SKU";
            this.SKU.MinimumWidth = 6;
            this.SKU.Name = "SKU";
            this.SKU.Width = 125;
            // 
            // Rubro
            // 
            this.Rubro.HeaderText = "Costo";
            this.Rubro.MinimumWidth = 6;
            this.Rubro.Name = "Rubro";
            this.Rubro.Width = 170;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Cantidad";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.Width = 170;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Subtotal";
            this.Costo.MinimumWidth = 6;
            this.Costo.Name = "Costo";
            this.Costo.Width = 150;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(211, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 75;
            this.label7.Text = "Artículo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(11, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 76;
            this.label5.Text = "SKU";
            // 
            // btnBuscarSKU
            // 
            this.btnBuscarSKU.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscarSKU.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarSKU.IconColor = System.Drawing.Color.Black;
            this.btnBuscarSKU.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarSKU.IconSize = 20;
            this.btnBuscarSKU.Location = new System.Drawing.Point(14, 89);
            this.btnBuscarSKU.Name = "btnBuscarSKU";
            this.btnBuscarSKU.Size = new System.Drawing.Size(164, 46);
            this.btnBuscarSKU.TabIndex = 75;
            this.btnBuscarSKU.Text = "Buscar";
            this.btnBuscarSKU.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarSKU.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.txtSucursalPreventa);
            this.groupBox1.Controls.Add(this.txtFechaPreventa);
            this.groupBox1.Controls.Add(this.preventaSucursal);
            this.groupBox1.Controls.Add(this.preventaFecha);
            this.groupBox1.Location = new System.Drawing.Point(25, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 143);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de la Preventa";
            // 
            // txtSucursalPreventa
            // 
            this.txtSucursalPreventa.Location = new System.Drawing.Point(15, 102);
            this.txtSucursalPreventa.Name = "txtSucursalPreventa";
            this.txtSucursalPreventa.Size = new System.Drawing.Size(164, 22);
            this.txtSucursalPreventa.TabIndex = 34;
            // 
            // txtFechaPreventa
            // 
            this.txtFechaPreventa.Location = new System.Drawing.Point(14, 46);
            this.txtFechaPreventa.Name = "txtFechaPreventa";
            this.txtFechaPreventa.Size = new System.Drawing.Size(164, 22);
            this.txtFechaPreventa.TabIndex = 32;
            // 
            // preventaSucursal
            // 
            this.preventaSucursal.AutoSize = true;
            this.preventaSucursal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.preventaSucursal.Location = new System.Drawing.Point(12, 80);
            this.preventaSucursal.Name = "preventaSucursal";
            this.preventaSucursal.Size = new System.Drawing.Size(63, 17);
            this.preventaSucursal.TabIndex = 31;
            this.preventaSucursal.Text = "Sucursal";
            // 
            // preventaFecha
            // 
            this.preventaFecha.AutoSize = true;
            this.preventaFecha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.preventaFecha.Location = new System.Drawing.Point(11, 24);
            this.preventaFecha.Name = "preventaFecha";
            this.preventaFecha.Size = new System.Drawing.Size(47, 17);
            this.preventaFecha.TabIndex = 29;
            this.preventaFecha.Text = "Fecha";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(286, 46);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(164, 22);
            this.txtNombreCliente.TabIndex = 33;
            // 
            // preventaNombreCliente
            // 
            this.preventaNombreCliente.AutoSize = true;
            this.preventaNombreCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.preventaNombreCliente.Location = new System.Drawing.Point(283, 24);
            this.preventaNombreCliente.Name = "preventaNombreCliente";
            this.preventaNombreCliente.Size = new System.Drawing.Size(121, 17);
            this.preventaNombreCliente.TabIndex = 30;
            this.preventaNombreCliente.Text = "Nombre Completo";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.txtDNICliente);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtDomicilioCliente);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnBusquedaCliente);
            this.groupBox3.Controls.Add(this.txtCorreoCliente);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtTelefonoCliente);
            this.groupBox3.Controls.Add(this.txtNombreCliente);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.preventaNombreCliente);
            this.groupBox3.Location = new System.Drawing.Point(260, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(681, 143);
            this.groupBox3.TabIndex = 64;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información del Cliente";
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Location = new System.Drawing.Point(18, 46);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.Size = new System.Drawing.Size(164, 22);
            this.txtDNICliente.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 73;
            this.label1.Text = "DNI";
            // 
            // txtDomicilioCliente
            // 
            this.txtDomicilioCliente.Location = new System.Drawing.Point(286, 102);
            this.txtDomicilioCliente.Name = "txtDomicilioCliente";
            this.txtDomicilioCliente.Size = new System.Drawing.Size(164, 22);
            this.txtDomicilioCliente.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(283, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 71;
            this.label4.Text = "Domicilio";
            // 
            // btnBusquedaCliente
            // 
            this.btnBusquedaCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnBusquedaCliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBusquedaCliente.IconColor = System.Drawing.Color.Black;
            this.btnBusquedaCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBusquedaCliente.IconSize = 20;
            this.btnBusquedaCliente.Location = new System.Drawing.Point(18, 80);
            this.btnBusquedaCliente.Name = "btnBusquedaCliente";
            this.btnBusquedaCliente.Size = new System.Drawing.Size(164, 46);
            this.btnBusquedaCliente.TabIndex = 67;
            this.btnBusquedaCliente.Text = "Buscar";
            this.btnBusquedaCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBusquedaCliente.UseVisualStyleBackColor = false;
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.Location = new System.Drawing.Point(456, 102);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.Size = new System.Drawing.Size(164, 22);
            this.txtCorreoCliente.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(453, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 69;
            this.label3.Text = "Correo";
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Location = new System.Drawing.Point(456, 46);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(164, 22);
            this.txtTelefonoCliente.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(453, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "Teléfono";
            // 
            // form_RegistrarPreventa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1193, 738);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.RegistrarPreventa);
            this.Controls.Add(this.grpArticulos);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_RegistrarPreventa";
            this.Text = "form_RegistrarPreventa";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpArticulos.ResumeLayout(false);
            this.grpArticulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bumCantidadArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarArticulosPreventa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnCancelarPreventa;
        private FontAwesome.Sharp.IconButton bntCrearPreventa;
        private System.Windows.Forms.TextBox txtTotalAPagar;
        private System.Windows.Forms.Label totalAPagar;
        private System.Windows.Forms.Label RegistrarPreventa;
        private System.Windows.Forms.GroupBox grpArticulos;
        private System.Windows.Forms.DataGridView dgvAgregarArticulosPreventa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSucursalPreventa;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtFechaPreventa;
        private System.Windows.Forms.Label preventaSucursal;
        private System.Windows.Forms.Label preventaNombreCliente;
        private System.Windows.Forms.Label preventaFecha;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCorreoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSKUBusqueda;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnBuscarSKU;
        private System.Windows.Forms.TextBox txtDNICliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDomicilioCliente;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnBusquedaCliente;
        private System.Windows.Forms.TextBox txtDescripcionArticulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown bumCantidadArticulo;
        private System.Windows.Forms.TextBox txtCostoArticulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMarcaArticulo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRubroArticulo;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnAgregarArticulosPreventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eliminar;
    }
}