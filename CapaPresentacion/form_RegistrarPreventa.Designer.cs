
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_RegistrarPreventa));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAgregarArticulosPreventa = new System.Windows.Forms.DataGridView();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancelarPreventa = new FontAwesome.Sharp.IconButton();
            this.bntCrearPreventa = new FontAwesome.Sharp.IconButton();
            this.txtTotalAPagar = new System.Windows.Forms.TextBox();
            this.totalAPagar = new System.Windows.Forms.Label();
            this.txtNroOperacionPreventa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.RegistrarPreventa = new System.Windows.Forms.Label();
            this.grpArticulos = new System.Windows.Forms.GroupBox();
            this.txtIdArticulo = new System.Windows.Forms.TextBox();
            this.btnAgregarArticulosPreventa = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.nudCantidadArticulo = new System.Windows.Forms.NumericUpDown();
            this.txtCostoArticulo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMarcaArticulo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRubroArticulo = new System.Windows.Forms.TextBox();
            this.btnBuscarSKU = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSKUBusqueda = new System.Windows.Forms.TextBox();
            this.txtDescripcionArticulo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboSucursalPreventa = new System.Windows.Forms.ComboBox();
            this.txtIdSucursal = new System.Windows.Forms.TextBox();
            this.txtFechaPreventa = new System.Windows.Forms.TextBox();
            this.preventaSucursal = new System.Windows.Forms.Label();
            this.preventaFecha = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.preventaNombreCliente = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDomicilioCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBusquedaCliente = new FontAwesome.Sharp.IconButton();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.txtFiltrarArticulos = new System.Windows.Forms.TextBox();
            this.dgvArticulosAFiltrar = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idArticuloAFiltrar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKUArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RubroArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboFiltrarArticulos = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarArticulosPreventa)).BeginInit();
            this.grpArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadArticulo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosAFiltrar)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.dgvAgregarArticulosPreventa);
            this.groupBox2.Controls.Add(this.btnCancelarPreventa);
            this.groupBox2.Controls.Add(this.bntCrearPreventa);
            this.groupBox2.Controls.Add(this.txtTotalAPagar);
            this.groupBox2.Controls.Add(this.totalAPagar);
            this.groupBox2.Location = new System.Drawing.Point(517, 469);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1040, 246);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preventa";
            // 
            // dgvAgregarArticulosPreventa
            // 
            this.dgvAgregarArticulosPreventa.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgregarArticulosPreventa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAgregarArticulosPreventa.ColumnHeadersHeight = 40;
            this.dgvAgregarArticulosPreventa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Articulo,
            this.SKU,
            this.Costo,
            this.Cantidad,
            this.Subtotal,
            this.idArticulo,
            this.btnEliminar});
            this.dgvAgregarArticulosPreventa.Location = new System.Drawing.Point(14, 31);
            this.dgvAgregarArticulosPreventa.MultiSelect = false;
            this.dgvAgregarArticulosPreventa.Name = "dgvAgregarArticulosPreventa";
            this.dgvAgregarArticulosPreventa.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgregarArticulosPreventa.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAgregarArticulosPreventa.RowHeadersWidth = 51;
            this.dgvAgregarArticulosPreventa.RowTemplate.Height = 200;
            this.dgvAgregarArticulosPreventa.Size = new System.Drawing.Size(771, 195);
            this.dgvAgregarArticulosPreventa.TabIndex = 79;
            this.dgvAgregarArticulosPreventa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgregarArticulosPreventa_CellContentClick_1);
            this.dgvAgregarArticulosPreventa.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvAgregarArticulosPreventa_CellPainting_1);
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Artículo";
            this.Articulo.MinimumWidth = 6;
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            this.Articulo.Width = 150;
            // 
            // SKU
            // 
            this.SKU.HeaderText = "SKU";
            this.SKU.MinimumWidth = 6;
            this.SKU.Name = "SKU";
            this.SKU.ReadOnly = true;
            this.SKU.Width = 125;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.MinimumWidth = 6;
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cant.";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 150;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 125;
            // 
            // idArticulo
            // 
            this.idArticulo.HeaderText = "idArticulo";
            this.idArticulo.MinimumWidth = 6;
            this.idArticulo.Name = "idArticulo";
            this.idArticulo.ReadOnly = true;
            this.idArticulo.Visible = false;
            this.idArticulo.Width = 125;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btnEliminar.HeaderText = "";
            this.btnEliminar.MinimumWidth = 6;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnEliminar.Width = 40;
            // 
            // btnCancelarPreventa
            // 
            this.btnCancelarPreventa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelarPreventa.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnCancelarPreventa.IconColor = System.Drawing.Color.Firebrick;
            this.btnCancelarPreventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarPreventa.IconSize = 20;
            this.btnCancelarPreventa.Location = new System.Drawing.Point(830, 121);
            this.btnCancelarPreventa.Name = "btnCancelarPreventa";
            this.btnCancelarPreventa.Size = new System.Drawing.Size(196, 42);
            this.btnCancelarPreventa.TabIndex = 43;
            this.btnCancelarPreventa.Text = "Cancelar";
            this.btnCancelarPreventa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelarPreventa.UseVisualStyleBackColor = false;
            this.btnCancelarPreventa.Click += new System.EventHandler(this.btnCancelarPreventa_Click);
            // 
            // bntCrearPreventa
            // 
            this.bntCrearPreventa.BackColor = System.Drawing.Color.LightGreen;
            this.bntCrearPreventa.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.bntCrearPreventa.IconColor = System.Drawing.Color.LightGreen;
            this.bntCrearPreventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntCrearPreventa.IconSize = 25;
            this.bntCrearPreventa.Location = new System.Drawing.Point(830, 180);
            this.bntCrearPreventa.Name = "bntCrearPreventa";
            this.bntCrearPreventa.Size = new System.Drawing.Size(196, 46);
            this.bntCrearPreventa.TabIndex = 41;
            this.bntCrearPreventa.Text = "Crear Preventa";
            this.bntCrearPreventa.UseVisualStyleBackColor = false;
            this.bntCrearPreventa.Click += new System.EventHandler(this.bntCrearPreventa_Click);
            // 
            // txtTotalAPagar
            // 
            this.txtTotalAPagar.Location = new System.Drawing.Point(830, 53);
            this.txtTotalAPagar.MinimumSize = new System.Drawing.Size(4, 32);
            this.txtTotalAPagar.Name = "txtTotalAPagar";
            this.txtTotalAPagar.Size = new System.Drawing.Size(196, 22);
            this.txtTotalAPagar.TabIndex = 36;
            // 
            // totalAPagar
            // 
            this.totalAPagar.AutoSize = true;
            this.totalAPagar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totalAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAPagar.Location = new System.Drawing.Point(827, 31);
            this.totalAPagar.Name = "totalAPagar";
            this.totalAPagar.Size = new System.Drawing.Size(106, 17);
            this.totalAPagar.TabIndex = 35;
            this.totalAPagar.Text = "Total a pagar";
            // 
            // txtNroOperacionPreventa
            // 
            this.txtNroOperacionPreventa.Location = new System.Drawing.Point(231, 63);
            this.txtNroOperacionPreventa.Name = "txtNroOperacionPreventa";
            this.txtNroOperacionPreventa.Size = new System.Drawing.Size(164, 22);
            this.txtNroOperacionPreventa.TabIndex = 76;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(228, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 17);
            this.label11.TabIndex = 75;
            this.label11.Text = "Nro. de Operación";
            // 
            // RegistrarPreventa
            // 
            this.RegistrarPreventa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.grpArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpArticulos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpArticulos.Controls.Add(this.txtIdArticulo);
            this.grpArticulos.Controls.Add(this.btnAgregarArticulosPreventa);
            this.grpArticulos.Controls.Add(this.label9);
            this.grpArticulos.Controls.Add(this.nudCantidadArticulo);
            this.grpArticulos.Controls.Add(this.txtCostoArticulo);
            this.grpArticulos.Controls.Add(this.label8);
            this.grpArticulos.Controls.Add(this.txtMarcaArticulo);
            this.grpArticulos.Controls.Add(this.label10);
            this.grpArticulos.Controls.Add(this.txtRubroArticulo);
            this.grpArticulos.Controls.Add(this.btnBuscarSKU);
            this.grpArticulos.Controls.Add(this.label6);
            this.grpArticulos.Controls.Add(this.txtSKUBusqueda);
            this.grpArticulos.Controls.Add(this.txtDescripcionArticulo);
            this.grpArticulos.Controls.Add(this.label7);
            this.grpArticulos.Controls.Add(this.label5);
            this.grpArticulos.Location = new System.Drawing.Point(517, 283);
            this.grpArticulos.Name = "grpArticulos";
            this.grpArticulos.Size = new System.Drawing.Size(1040, 152);
            this.grpArticulos.TabIndex = 64;
            this.grpArticulos.TabStop = false;
            this.grpArticulos.Text = "Agregar artículos";
            // 
            // txtIdArticulo
            // 
            this.txtIdArticulo.Location = new System.Drawing.Point(184, 51);
            this.txtIdArticulo.Name = "txtIdArticulo";
            this.txtIdArticulo.Size = new System.Drawing.Size(32, 22);
            this.txtIdArticulo.TabIndex = 77;
            // 
            // btnAgregarArticulosPreventa
            // 
            this.btnAgregarArticulosPreventa.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregarArticulosPreventa.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAgregarArticulosPreventa.IconColor = System.Drawing.Color.LimeGreen;
            this.btnAgregarArticulosPreventa.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAgregarArticulosPreventa.IconSize = 30;
            this.btnAgregarArticulosPreventa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarArticulosPreventa.Location = new System.Drawing.Point(830, 51);
            this.btnAgregarArticulosPreventa.Name = "btnAgregarArticulosPreventa";
            this.btnAgregarArticulosPreventa.Size = new System.Drawing.Size(196, 79);
            this.btnAgregarArticulosPreventa.TabIndex = 67;
            this.btnAgregarArticulosPreventa.Text = "Agregar";
            this.btnAgregarArticulosPreventa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAgregarArticulosPreventa.UseVisualStyleBackColor = false;
            this.btnAgregarArticulosPreventa.Click += new System.EventHandler(this.btnAgregarArticulosPreventa_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(618, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 88;
            this.label9.Text = "Cantidad";
            // 
            // nudCantidadArticulo
            // 
            this.nudCantidadArticulo.Location = new System.Drawing.Point(621, 108);
            this.nudCantidadArticulo.Name = "nudCantidadArticulo";
            this.nudCantidadArticulo.Size = new System.Drawing.Size(164, 22);
            this.nudCantidadArticulo.TabIndex = 87;
            this.nudCantidadArticulo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtCostoArticulo
            // 
            this.txtCostoArticulo.Enabled = false;
            this.txtCostoArticulo.Location = new System.Drawing.Point(621, 51);
            this.txtCostoArticulo.Name = "txtCostoArticulo";
            this.txtCostoArticulo.Size = new System.Drawing.Size(164, 22);
            this.txtCostoArticulo.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(618, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 85;
            this.label8.Text = "Costo";
            // 
            // txtMarcaArticulo
            // 
            this.txtMarcaArticulo.Enabled = false;
            this.txtMarcaArticulo.Location = new System.Drawing.Point(404, 108);
            this.txtMarcaArticulo.Name = "txtMarcaArticulo";
            this.txtMarcaArticulo.Size = new System.Drawing.Size(164, 22);
            this.txtMarcaArticulo.TabIndex = 84;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(401, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 17);
            this.label10.TabIndex = 83;
            this.label10.Text = "Marca";
            // 
            // txtRubroArticulo
            // 
            this.txtRubroArticulo.Enabled = false;
            this.txtRubroArticulo.Location = new System.Drawing.Point(234, 108);
            this.txtRubroArticulo.Name = "txtRubroArticulo";
            this.txtRubroArticulo.Size = new System.Drawing.Size(164, 22);
            this.txtRubroArticulo.TabIndex = 78;
            // 
            // btnBuscarSKU
            // 
            this.btnBuscarSKU.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscarSKU.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarSKU.IconColor = System.Drawing.Color.Black;
            this.btnBuscarSKU.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarSKU.IconSize = 20;
            this.btnBuscarSKU.Location = new System.Drawing.Point(13, 84);
            this.btnBuscarSKU.Name = "btnBuscarSKU";
            this.btnBuscarSKU.Size = new System.Drawing.Size(164, 46);
            this.btnBuscarSKU.TabIndex = 75;
            this.btnBuscarSKU.Text = "Buscar";
            this.btnBuscarSKU.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarSKU.UseVisualStyleBackColor = false;
            this.btnBuscarSKU.Click += new System.EventHandler(this.btnBuscarSKU_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(231, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 77;
            this.label6.Text = "Rubro";
            // 
            // txtSKUBusqueda
            // 
            this.txtSKUBusqueda.Location = new System.Drawing.Point(13, 51);
            this.txtSKUBusqueda.Name = "txtSKUBusqueda";
            this.txtSKUBusqueda.Size = new System.Drawing.Size(165, 22);
            this.txtSKUBusqueda.TabIndex = 77;
            // 
            // txtDescripcionArticulo
            // 
            this.txtDescripcionArticulo.Enabled = false;
            this.txtDescripcionArticulo.Location = new System.Drawing.Point(234, 51);
            this.txtDescripcionArticulo.Name = "txtDescripcionArticulo";
            this.txtDescripcionArticulo.Size = new System.Drawing.Size(334, 22);
            this.txtDescripcionArticulo.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(231, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 75;
            this.label7.Text = "Artículo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(10, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 76;
            this.label5.Text = "SKU";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.txtNroOperacionPreventa);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cboSucursalPreventa);
            this.groupBox1.Controls.Add(this.txtIdSucursal);
            this.groupBox1.Controls.Add(this.txtFechaPreventa);
            this.groupBox1.Controls.Add(this.preventaSucursal);
            this.groupBox1.Controls.Add(this.preventaFecha);
            this.groupBox1.Location = new System.Drawing.Point(517, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 161);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de la Preventa";
            // 
            // cboSucursalPreventa
            // 
            this.cboSucursalPreventa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursalPreventa.FormattingEnabled = true;
            this.cboSucursalPreventa.Location = new System.Drawing.Point(13, 119);
            this.cboSucursalPreventa.Name = "cboSucursalPreventa";
            this.cboSucursalPreventa.Size = new System.Drawing.Size(165, 24);
            this.cboSucursalPreventa.TabIndex = 76;
            this.cboSucursalPreventa.SelectedIndexChanged += new System.EventHandler(this.cboSucursalPreventa_SelectedIndexChanged);
            // 
            // txtIdSucursal
            // 
            this.txtIdSucursal.Location = new System.Drawing.Point(183, 120);
            this.txtIdSucursal.Name = "txtIdSucursal";
            this.txtIdSucursal.Size = new System.Drawing.Size(32, 22);
            this.txtIdSucursal.TabIndex = 35;
            // 
            // txtFechaPreventa
            // 
            this.txtFechaPreventa.Enabled = false;
            this.txtFechaPreventa.Location = new System.Drawing.Point(13, 63);
            this.txtFechaPreventa.Name = "txtFechaPreventa";
            this.txtFechaPreventa.Size = new System.Drawing.Size(164, 22);
            this.txtFechaPreventa.TabIndex = 32;
            // 
            // preventaSucursal
            // 
            this.preventaSucursal.AutoSize = true;
            this.preventaSucursal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.preventaSucursal.Location = new System.Drawing.Point(11, 97);
            this.preventaSucursal.Name = "preventaSucursal";
            this.preventaSucursal.Size = new System.Drawing.Size(63, 17);
            this.preventaSucursal.TabIndex = 31;
            this.preventaSucursal.Text = "Sucursal";
            // 
            // preventaFecha
            // 
            this.preventaFecha.AutoSize = true;
            this.preventaFecha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.preventaFecha.Location = new System.Drawing.Point(10, 41);
            this.preventaFecha.Name = "preventaFecha";
            this.preventaFecha.Size = new System.Drawing.Size(47, 17);
            this.preventaFecha.TabIndex = 29;
            this.preventaFecha.Text = "Fecha";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(237, 63);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(164, 22);
            this.txtNombreCliente.TabIndex = 33;
            // 
            // preventaNombreCliente
            // 
            this.preventaNombreCliente.AutoSize = true;
            this.preventaNombreCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.preventaNombreCliente.Location = new System.Drawing.Point(234, 41);
            this.preventaNombreCliente.Name = "preventaNombreCliente";
            this.preventaNombreCliente.Size = new System.Drawing.Size(121, 17);
            this.preventaNombreCliente.TabIndex = 30;
            this.preventaNombreCliente.Text = "Nombre Completo";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.txtIdCliente);
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
            this.groupBox3.Location = new System.Drawing.Point(956, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(601, 161);
            this.groupBox3.TabIndex = 64;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información del Cliente";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(178, 63);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(32, 22);
            this.txtIdCliente.TabIndex = 36;
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Location = new System.Drawing.Point(13, 63);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.Size = new System.Drawing.Size(164, 22);
            this.txtDNICliente.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 73;
            this.label1.Text = "DNI";
            // 
            // txtDomicilioCliente
            // 
            this.txtDomicilioCliente.Location = new System.Drawing.Point(237, 119);
            this.txtDomicilioCliente.Name = "txtDomicilioCliente";
            this.txtDomicilioCliente.Size = new System.Drawing.Size(164, 22);
            this.txtDomicilioCliente.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(234, 97);
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
            this.btnBusquedaCliente.Location = new System.Drawing.Point(13, 97);
            this.btnBusquedaCliente.Name = "btnBusquedaCliente";
            this.btnBusquedaCliente.Size = new System.Drawing.Size(164, 46);
            this.btnBusquedaCliente.TabIndex = 67;
            this.btnBusquedaCliente.Text = "Buscar";
            this.btnBusquedaCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBusquedaCliente.UseVisualStyleBackColor = false;
            this.btnBusquedaCliente.Click += new System.EventHandler(this.btnBusquedaCliente_Click);
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.Location = new System.Drawing.Point(425, 119);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.Size = new System.Drawing.Size(164, 22);
            this.txtCorreoCliente.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(422, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 69;
            this.label3.Text = "Correo";
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Location = new System.Drawing.Point(425, 63);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(164, 22);
            this.txtTelefonoCliente.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(422, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "Teléfono";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdUsuario.Location = new System.Drawing.Point(204, 27);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(32, 22);
            this.txtIdUsuario.TabIndex = 75;
            // 
            // txtFiltrarArticulos
            // 
            this.txtFiltrarArticulos.Location = new System.Drawing.Point(253, 70);
            this.txtFiltrarArticulos.Multiline = true;
            this.txtFiltrarArticulos.Name = "txtFiltrarArticulos";
            this.txtFiltrarArticulos.Size = new System.Drawing.Size(205, 26);
            this.txtFiltrarArticulos.TabIndex = 77;
            this.txtFiltrarArticulos.TextChanged += new System.EventHandler(this.txtFiltrarArticulos_TextChanged);
            // 
            // dgvArticulosAFiltrar
            // 
            this.dgvArticulosAFiltrar.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulosAFiltrar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArticulosAFiltrar.ColumnHeadersHeight = 40;
            this.dgvArticulosAFiltrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.idArticuloAFiltrar,
            this.DescripcionArticulo,
            this.MarcaArticulo,
            this.SKUArticulo,
            this.RubroArticulo,
            this.PrecioArticulo});
            this.dgvArticulosAFiltrar.Location = new System.Drawing.Point(16, 117);
            this.dgvArticulosAFiltrar.MultiSelect = false;
            this.dgvArticulosAFiltrar.Name = "dgvArticulosAFiltrar";
            this.dgvArticulosAFiltrar.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulosAFiltrar.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArticulosAFiltrar.RowHeadersWidth = 51;
            this.dgvArticulosAFiltrar.RowTemplate.Height = 40;
            this.dgvArticulosAFiltrar.Size = new System.Drawing.Size(442, 485);
            this.dgvArticulosAFiltrar.TabIndex = 78;
            this.dgvArticulosAFiltrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulosAFiltrar_CellContentClick);
            this.dgvArticulosAFiltrar.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvArticulosAFiltrar_CellPainting);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 6;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnSeleccionar.Width = 40;
            // 
            // idArticuloAFiltrar
            // 
            this.idArticuloAFiltrar.HeaderText = "idArticulo";
            this.idArticuloAFiltrar.MinimumWidth = 6;
            this.idArticuloAFiltrar.Name = "idArticuloAFiltrar";
            this.idArticuloAFiltrar.ReadOnly = true;
            this.idArticuloAFiltrar.Visible = false;
            this.idArticuloAFiltrar.Width = 125;
            // 
            // DescripcionArticulo
            // 
            this.DescripcionArticulo.HeaderText = "Artículo";
            this.DescripcionArticulo.MinimumWidth = 6;
            this.DescripcionArticulo.Name = "DescripcionArticulo";
            this.DescripcionArticulo.ReadOnly = true;
            this.DescripcionArticulo.Width = 150;
            // 
            // MarcaArticulo
            // 
            this.MarcaArticulo.HeaderText = "Marca";
            this.MarcaArticulo.MinimumWidth = 6;
            this.MarcaArticulo.Name = "MarcaArticulo";
            this.MarcaArticulo.ReadOnly = true;
            this.MarcaArticulo.Width = 150;
            // 
            // SKUArticulo
            // 
            this.SKUArticulo.HeaderText = "SKU";
            this.SKUArticulo.MinimumWidth = 6;
            this.SKUArticulo.Name = "SKUArticulo";
            this.SKUArticulo.ReadOnly = true;
            this.SKUArticulo.Visible = false;
            this.SKUArticulo.Width = 125;
            // 
            // RubroArticulo
            // 
            this.RubroArticulo.HeaderText = "Rubro";
            this.RubroArticulo.MinimumWidth = 6;
            this.RubroArticulo.Name = "RubroArticulo";
            this.RubroArticulo.ReadOnly = true;
            this.RubroArticulo.Visible = false;
            this.RubroArticulo.Width = 125;
            // 
            // PrecioArticulo
            // 
            this.PrecioArticulo.HeaderText = "Costo";
            this.PrecioArticulo.MinimumWidth = 6;
            this.PrecioArticulo.Name = "PrecioArticulo";
            this.PrecioArticulo.ReadOnly = true;
            this.PrecioArticulo.Visible = false;
            this.PrecioArticulo.Width = 125;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.cboFiltrarArticulos);
            this.groupBox4.Controls.Add(this.dgvArticulosAFiltrar);
            this.groupBox4.Controls.Add(this.txtFiltrarArticulos);
            this.groupBox4.Location = new System.Drawing.Point(25, 93);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(475, 622);
            this.groupBox4.TabIndex = 79;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscar artículos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(13, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 77;
            this.label12.Text = "FIltrar por";
            // 
            // cboFiltrarArticulos
            // 
            this.cboFiltrarArticulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltrarArticulos.FormattingEnabled = true;
            this.cboFiltrarArticulos.Location = new System.Drawing.Point(16, 70);
            this.cboFiltrarArticulos.Name = "cboFiltrarArticulos";
            this.cboFiltrarArticulos.Size = new System.Drawing.Size(205, 24);
            this.cboFiltrarArticulos.TabIndex = 77;
            this.cboFiltrarArticulos.SelectedIndexChanged += new System.EventHandler(this.cboFiltrarArticulos_SelectedIndexChanged);
            // 
            // form_RegistrarPreventa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1579, 738);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.RegistrarPreventa);
            this.Controls.Add(this.grpArticulos);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_RegistrarPreventa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Preventas";
            this.Load += new System.EventHandler(this.form_RegistrarPreventa_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarArticulosPreventa)).EndInit();
            this.grpArticulos.ResumeLayout(false);
            this.grpArticulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadArticulo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosAFiltrar)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.NumericUpDown nudCantidadArticulo;
        private System.Windows.Forms.TextBox txtCostoArticulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMarcaArticulo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRubroArticulo;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnAgregarArticulosPreventa;
        private System.Windows.Forms.TextBox txtIdSucursal;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.ComboBox cboSucursalPreventa;
        private System.Windows.Forms.TextBox txtNroOperacionPreventa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIdArticulo;
        private System.Windows.Forms.TextBox txtFiltrarArticulos;
        private System.Windows.Forms.DataGridView dgvArticulosAFiltrar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboFiltrarArticulos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticuloAFiltrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKUArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RubroArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioArticulo;
        private System.Windows.Forms.DataGridView dgvAgregarArticulosPreventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticulo;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}