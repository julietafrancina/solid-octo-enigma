
namespace CapaPresentacion
{
    partial class form_Preventa
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
            this.txtBusquedaPreventa = new System.Windows.Forms.TextBox();
            this.cboBusquedaPreventa = new System.Windows.Forms.ComboBox();
            this.ttlUsuarios = new System.Windows.Forms.Label();
            this.dgvPreventas = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idPreventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioPreventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNroOperacion = new System.Windows.Forms.TextBox();
            this.preventaNroOperacion = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.preventaMonto = new System.Windows.Forms.Label();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.preventaSucursal = new System.Windows.Forms.Label();
            this.preventaNombreCliente = new System.Windows.Forms.Label();
            this.preventaFecha = new System.Windows.Forms.Label();
            this.formDetallePreventa = new System.Windows.Forms.Label();
            this.preventaBaja = new System.Windows.Forms.Label();
            this.dgvArticulosPreventa = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUsuarioPreventa = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.txtBaja = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.grpArticulos = new System.Windows.Forms.GroupBox();
            this.DetallePreventa = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDarDeBaja = new FontAwesome.Sharp.IconButton();
            this.bntGenerarFactura = new FontAwesome.Sharp.IconButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBusquedaPreventa = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnRestablecerBusquedaPreventa = new FontAwesome.Sharp.IconButton();
            this.btnRegistrarPreventa = new FontAwesome.Sharp.IconButton();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.idArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadArticulosPreventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosPreventa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpArticulos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBusquedaPreventa
            // 
            this.txtBusquedaPreventa.Location = new System.Drawing.Point(15, 62);
            this.txtBusquedaPreventa.MinimumSize = new System.Drawing.Size(4, 24);
            this.txtBusquedaPreventa.Name = "txtBusquedaPreventa";
            this.txtBusquedaPreventa.Size = new System.Drawing.Size(176, 22);
            this.txtBusquedaPreventa.TabIndex = 50;
            // 
            // cboBusquedaPreventa
            // 
            this.cboBusquedaPreventa.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cboBusquedaPreventa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusquedaPreventa.FormattingEnabled = true;
            this.cboBusquedaPreventa.Location = new System.Drawing.Point(15, 32);
            this.cboBusquedaPreventa.Name = "cboBusquedaPreventa";
            this.cboBusquedaPreventa.Size = new System.Drawing.Size(176, 24);
            this.cboBusquedaPreventa.TabIndex = 49;
            // 
            // ttlUsuarios
            // 
            this.ttlUsuarios.AutoSize = true;
            this.ttlUsuarios.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ttlUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttlUsuarios.Location = new System.Drawing.Point(24, 469);
            this.ttlUsuarios.Margin = new System.Windows.Forms.Padding(0);
            this.ttlUsuarios.Name = "ttlUsuarios";
            this.ttlUsuarios.Size = new System.Drawing.Size(93, 20);
            this.ttlUsuarios.TabIndex = 47;
            this.ttlUsuarios.Text = "Preventas";
            // 
            // dgvPreventas
            // 
            this.dgvPreventas.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPreventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPreventas.ColumnHeadersHeight = 40;
            this.dgvPreventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.idPreventa,
            this.Fecha,
            this.Cliente,
            this.Sucursal,
            this.Monto,
            this.NroOperacion,
            this.Baja,
            this.UsuarioPreventa});
            this.dgvPreventas.Location = new System.Drawing.Point(42, 505);
            this.dgvPreventas.MultiSelect = false;
            this.dgvPreventas.Name = "dgvPreventas";
            this.dgvPreventas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPreventas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPreventas.RowHeadersWidth = 51;
            this.dgvPreventas.RowTemplate.Height = 40;
            this.dgvPreventas.Size = new System.Drawing.Size(994, 307);
            this.dgvPreventas.TabIndex = 45;
            this.dgvPreventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreventas_CellContentClick);
            this.dgvPreventas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvPreventa_CellPainting);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 6;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 40;
            // 
            // idPreventa
            // 
            this.idPreventa.HeaderText = "idPreventa";
            this.idPreventa.MinimumWidth = 6;
            this.idPreventa.Name = "idPreventa";
            this.idPreventa.ReadOnly = true;
            this.idPreventa.Visible = false;
            this.idPreventa.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Sucursal
            // 
            this.Sucursal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sucursal.HeaderText = "Sucursal";
            this.Sucursal.MinimumWidth = 6;
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Monto.HeaderText = "Monto";
            this.Monto.MinimumWidth = 6;
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // NroOperacion
            // 
            this.NroOperacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NroOperacion.HeaderText = "NroOperacion";
            this.NroOperacion.MinimumWidth = 6;
            this.NroOperacion.Name = "NroOperacion";
            this.NroOperacion.ReadOnly = true;
            // 
            // Baja
            // 
            this.Baja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Baja.HeaderText = "Baja";
            this.Baja.MinimumWidth = 6;
            this.Baja.Name = "Baja";
            this.Baja.ReadOnly = true;
            // 
            // UsuarioPreventa
            // 
            this.UsuarioPreventa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UsuarioPreventa.HeaderText = "Usuario";
            this.UsuarioPreventa.MinimumWidth = 6;
            this.UsuarioPreventa.Name = "UsuarioPreventa";
            this.UsuarioPreventa.ReadOnly = true;
            // 
            // txtNroOperacion
            // 
            this.txtNroOperacion.Enabled = false;
            this.txtNroOperacion.Location = new System.Drawing.Point(354, 46);
            this.txtNroOperacion.Name = "txtNroOperacion";
            this.txtNroOperacion.Size = new System.Drawing.Size(165, 22);
            this.txtNroOperacion.TabIndex = 38;
            // 
            // preventaNroOperacion
            // 
            this.preventaNroOperacion.AutoSize = true;
            this.preventaNroOperacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.preventaNroOperacion.Location = new System.Drawing.Point(352, 24);
            this.preventaNroOperacion.Name = "preventaNroOperacion";
            this.preventaNroOperacion.Size = new System.Drawing.Size(105, 17);
            this.preventaNroOperacion.TabIndex = 37;
            this.preventaNroOperacion.Text = "Nro. Operación";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(14, 51);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(176, 22);
            this.txtMonto.TabIndex = 36;
            // 
            // preventaMonto
            // 
            this.preventaMonto.AutoSize = true;
            this.preventaMonto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.preventaMonto.Location = new System.Drawing.Point(11, 29);
            this.preventaMonto.Name = "preventaMonto";
            this.preventaMonto.Size = new System.Drawing.Size(83, 17);
            this.preventaMonto.TabIndex = 35;
            this.preventaMonto.Text = "Monto Total";
            // 
            // txtSucursal
            // 
            this.txtSucursal.Enabled = false;
            this.txtSucursal.Location = new System.Drawing.Point(524, 46);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(164, 22);
            this.txtSucursal.TabIndex = 34;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(184, 46);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(164, 22);
            this.txtNombreCliente.TabIndex = 33;
            // 
            // txtFecha
            // 
            this.txtFecha.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(14, 46);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(164, 22);
            this.txtFecha.TabIndex = 32;
            // 
            // preventaSucursal
            // 
            this.preventaSucursal.AutoSize = true;
            this.preventaSucursal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.preventaSucursal.Location = new System.Drawing.Point(521, 24);
            this.preventaSucursal.Name = "preventaSucursal";
            this.preventaSucursal.Size = new System.Drawing.Size(63, 17);
            this.preventaSucursal.TabIndex = 31;
            this.preventaSucursal.Text = "Sucursal";
            // 
            // preventaNombreCliente
            // 
            this.preventaNombreCliente.AutoSize = true;
            this.preventaNombreCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.preventaNombreCliente.Location = new System.Drawing.Point(181, 24);
            this.preventaNombreCliente.Name = "preventaNombreCliente";
            this.preventaNombreCliente.Size = new System.Drawing.Size(105, 17);
            this.preventaNombreCliente.TabIndex = 30;
            this.preventaNombreCliente.Text = "Nombre Cliente";
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
            // formDetallePreventa
            // 
            this.formDetallePreventa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.formDetallePreventa.Dock = System.Windows.Forms.DockStyle.Top;
            this.formDetallePreventa.Location = new System.Drawing.Point(0, 0);
            this.formDetallePreventa.Name = "formDetallePreventa";
            this.formDetallePreventa.Size = new System.Drawing.Size(1304, 441);
            this.formDetallePreventa.TabIndex = 28;
            // 
            // preventaBaja
            // 
            this.preventaBaja.AutoSize = true;
            this.preventaBaja.BackColor = System.Drawing.Color.WhiteSmoke;
            this.preventaBaja.Location = new System.Drawing.Point(860, 20);
            this.preventaBaja.Name = "preventaBaja";
            this.preventaBaja.Size = new System.Drawing.Size(36, 17);
            this.preventaBaja.TabIndex = 54;
            this.preventaBaja.Text = "Baja";
            // 
            // dgvArticulosPreventa
            // 
            this.dgvArticulosPreventa.AllowUserToAddRows = false;
            this.dgvArticulosPreventa.ColumnHeadersHeight = 40;
            this.dgvArticulosPreventa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArticulo,
            this.Articulo,
            this.Rubro,
            this.Marca,
            this.SKU,
            this.Costo,
            this.CantidadArticulosPreventa});
            this.dgvArticulosPreventa.Location = new System.Drawing.Point(15, 31);
            this.dgvArticulosPreventa.Name = "dgvArticulosPreventa";
            this.dgvArticulosPreventa.RowHeadersWidth = 51;
            this.dgvArticulosPreventa.RowTemplate.Height = 24;
            this.dgvArticulosPreventa.Size = new System.Drawing.Size(993, 194);
            this.dgvArticulosPreventa.TabIndex = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.txtUsuarioPreventa);
            this.groupBox1.Controls.Add(this.Usuario);
            this.groupBox1.Controls.Add(this.txtBaja);
            this.groupBox1.Controls.Add(this.txtNroOperacion);
            this.groupBox1.Controls.Add(this.preventaNroOperacion);
            this.groupBox1.Controls.Add(this.txtSucursal);
            this.groupBox1.Controls.Add(this.preventaBaja);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.preventaSucursal);
            this.groupBox1.Controls.Add(this.preventaNombreCliente);
            this.groupBox1.Controls.Add(this.preventaFecha);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Location = new System.Drawing.Point(27, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1262, 85);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de la Preventa";
            // 
            // txtUsuarioPreventa
            // 
            this.txtUsuarioPreventa.Enabled = false;
            this.txtUsuarioPreventa.Location = new System.Drawing.Point(694, 46);
            this.txtUsuarioPreventa.Name = "txtUsuarioPreventa";
            this.txtUsuarioPreventa.Size = new System.Drawing.Size(164, 22);
            this.txtUsuarioPreventa.TabIndex = 57;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Usuario.Location = new System.Drawing.Point(691, 20);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(57, 17);
            this.Usuario.TabIndex = 56;
            this.Usuario.Text = "Usuario";
            // 
            // txtBaja
            // 
            this.txtBaja.Enabled = false;
            this.txtBaja.Location = new System.Drawing.Point(863, 46);
            this.txtBaja.Name = "txtBaja";
            this.txtBaja.Size = new System.Drawing.Size(164, 22);
            this.txtBaja.TabIndex = 55;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 20;
            this.btnLimpiar.Location = new System.Drawing.Point(1064, 24);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(176, 44);
            this.btnLimpiar.TabIndex = 42;
            this.btnLimpiar.Text = "Limpiar campos";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // grpArticulos
            // 
            this.grpArticulos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpArticulos.Controls.Add(this.dgvArticulosPreventa);
            this.grpArticulos.Location = new System.Drawing.Point(27, 166);
            this.grpArticulos.Name = "grpArticulos";
            this.grpArticulos.Size = new System.Drawing.Size(1027, 247);
            this.grpArticulos.TabIndex = 58;
            this.grpArticulos.TabStop = false;
            this.grpArticulos.Text = "Artículos de la Preventa";
            // 
            // DetallePreventa
            // 
            this.DetallePreventa.AutoSize = true;
            this.DetallePreventa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DetallePreventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetallePreventa.Location = new System.Drawing.Point(23, 22);
            this.DetallePreventa.Margin = new System.Windows.Forms.Padding(0);
            this.DetallePreventa.Name = "DetallePreventa";
            this.DetallePreventa.Size = new System.Drawing.Size(149, 20);
            this.DetallePreventa.TabIndex = 59;
            this.DetallePreventa.Text = "Detalle Preventa";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.btnDarDeBaja);
            this.groupBox2.Controls.Add(this.bntGenerarFactura);
            this.groupBox2.Controls.Add(this.txtMonto);
            this.groupBox2.Controls.Add(this.preventaMonto);
            this.groupBox2.Location = new System.Drawing.Point(1077, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 247);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            // 
            // btnDarDeBaja
            // 
            this.btnDarDeBaja.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDarDeBaja.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnDarDeBaja.IconColor = System.Drawing.Color.Firebrick;
            this.btnDarDeBaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDarDeBaja.IconSize = 20;
            this.btnDarDeBaja.Location = new System.Drawing.Point(14, 131);
            this.btnDarDeBaja.Name = "btnDarDeBaja";
            this.btnDarDeBaja.Size = new System.Drawing.Size(176, 42);
            this.btnDarDeBaja.TabIndex = 43;
            this.btnDarDeBaja.Text = "Dar de baja";
            this.btnDarDeBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDarDeBaja.UseVisualStyleBackColor = false;
            this.btnDarDeBaja.Click += new System.EventHandler(this.btnDarDeBaja_Click);
            // 
            // bntGenerarFactura
            // 
            this.bntGenerarFactura.BackColor = System.Drawing.SystemColors.Control;
            this.bntGenerarFactura.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.bntGenerarFactura.IconColor = System.Drawing.Color.CadetBlue;
            this.bntGenerarFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntGenerarFactura.IconSize = 25;
            this.bntGenerarFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntGenerarFactura.Location = new System.Drawing.Point(14, 179);
            this.bntGenerarFactura.Name = "bntGenerarFactura";
            this.bntGenerarFactura.Size = new System.Drawing.Size(176, 46);
            this.bntGenerarFactura.TabIndex = 41;
            this.bntGenerarFactura.Text = "Generar factura";
            this.bntGenerarFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bntGenerarFactura.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.btnBusquedaPreventa);
            this.groupBox3.Controls.Add(this.txtBusquedaPreventa);
            this.groupBox3.Controls.Add(this.cboBusquedaPreventa);
            this.groupBox3.Location = new System.Drawing.Point(1064, 505);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 162);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar por";
            // 
            // btnBusquedaPreventa
            // 
            this.btnBusquedaPreventa.BackColor = System.Drawing.SystemColors.Control;
            this.btnBusquedaPreventa.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBusquedaPreventa.IconColor = System.Drawing.Color.Black;
            this.btnBusquedaPreventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBusquedaPreventa.IconSize = 20;
            this.btnBusquedaPreventa.Location = new System.Drawing.Point(15, 102);
            this.btnBusquedaPreventa.Name = "btnBusquedaPreventa";
            this.btnBusquedaPreventa.Size = new System.Drawing.Size(176, 42);
            this.btnBusquedaPreventa.TabIndex = 44;
            this.btnBusquedaPreventa.Text = "Buscar";
            this.btnBusquedaPreventa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBusquedaPreventa.UseVisualStyleBackColor = false;
            this.btnBusquedaPreventa.Click += new System.EventHandler(this.btnBusquedaPreventa_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1304, 753);
            this.label1.TabIndex = 62;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(132, 468);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(41, 22);
            this.txtId.TabIndex = 63;
            // 
            // btnRestablecerBusquedaPreventa
            // 
            this.btnRestablecerBusquedaPreventa.BackColor = System.Drawing.SystemColors.Control;
            this.btnRestablecerBusquedaPreventa.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.btnRestablecerBusquedaPreventa.IconColor = System.Drawing.Color.Black;
            this.btnRestablecerBusquedaPreventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestablecerBusquedaPreventa.IconSize = 20;
            this.btnRestablecerBusquedaPreventa.Location = new System.Drawing.Point(1079, 655);
            this.btnRestablecerBusquedaPreventa.Name = "btnRestablecerBusquedaPreventa";
            this.btnRestablecerBusquedaPreventa.Size = new System.Drawing.Size(176, 44);
            this.btnRestablecerBusquedaPreventa.TabIndex = 58;
            this.btnRestablecerBusquedaPreventa.Text = "Restablecer";
            this.btnRestablecerBusquedaPreventa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRestablecerBusquedaPreventa.UseVisualStyleBackColor = false;
            this.btnRestablecerBusquedaPreventa.Click += new System.EventHandler(this.btnRestablecerBusquedaPreventa_Click);
            // 
            // btnRegistrarPreventa
            // 
            this.btnRegistrarPreventa.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegistrarPreventa.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnRegistrarPreventa.IconColor = System.Drawing.Color.LimeGreen;
            this.btnRegistrarPreventa.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRegistrarPreventa.IconSize = 30;
            this.btnRegistrarPreventa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarPreventa.Location = new System.Drawing.Point(1079, 750);
            this.btnRegistrarPreventa.Name = "btnRegistrarPreventa";
            this.btnRegistrarPreventa.Size = new System.Drawing.Size(176, 62);
            this.btnRegistrarPreventa.TabIndex = 44;
            this.btnRegistrarPreventa.Text = "Registrar nueva\r\npreventa\r\n";
            this.btnRegistrarPreventa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRegistrarPreventa.UseVisualStyleBackColor = false;
            this.btnRegistrarPreventa.Click += new System.EventHandler(this.btnRegistrarPreventa_Click);
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(188, 20);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(41, 22);
            this.txtIndice.TabIndex = 64;
            // 
            // idArticulo
            // 
            this.idArticulo.HeaderText = "idArticulo";
            this.idArticulo.MinimumWidth = 6;
            this.idArticulo.Name = "idArticulo";
            this.idArticulo.Visible = false;
            this.idArticulo.Width = 125;
            // 
            // Articulo
            // 
            this.Articulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Articulo.HeaderText = "Artículo";
            this.Articulo.MinimumWidth = 6;
            this.Articulo.Name = "Articulo";
            // 
            // Rubro
            // 
            this.Rubro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rubro.HeaderText = "Rubro";
            this.Rubro.MinimumWidth = 6;
            this.Rubro.Name = "Rubro";
            // 
            // Marca
            // 
            this.Marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            // 
            // SKU
            // 
            this.SKU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SKU.HeaderText = "SKU";
            this.SKU.MinimumWidth = 6;
            this.SKU.Name = "SKU";
            // 
            // Costo
            // 
            this.Costo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Costo.HeaderText = "Costo";
            this.Costo.MinimumWidth = 6;
            this.Costo.Name = "Costo";
            // 
            // CantidadArticulosPreventa
            // 
            this.CantidadArticulosPreventa.HeaderText = "Cant.";
            this.CantidadArticulosPreventa.MinimumWidth = 6;
            this.CantidadArticulosPreventa.Name = "CantidadArticulosPreventa";
            this.CantidadArticulosPreventa.Width = 125;
            // 
            // form_Preventa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 852);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.btnRestablecerBusquedaPreventa);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnRegistrarPreventa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DetallePreventa);
            this.Controls.Add(this.grpArticulos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ttlUsuarios);
            this.Controls.Add(this.dgvPreventas);
            this.Controls.Add(this.formDetallePreventa);
            this.Controls.Add(this.label1);
            this.Name = "form_Preventa";
            this.Text = "form_Preventa";
            this.Load += new System.EventHandler(this.form_Preventa_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosPreventa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpArticulos.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBusquedaPreventa;
        private System.Windows.Forms.ComboBox cboBusquedaPreventa;
        private System.Windows.Forms.Label ttlUsuarios;
        private System.Windows.Forms.DataGridView dgvPreventas;
        private FontAwesome.Sharp.IconButton btnDarDeBaja;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton bntGenerarFactura;
        private System.Windows.Forms.TextBox txtNroOperacion;
        private System.Windows.Forms.Label preventaNroOperacion;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label preventaMonto;
        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label preventaSucursal;
        private System.Windows.Forms.Label preventaNombreCliente;
        private System.Windows.Forms.Label preventaFecha;
        private System.Windows.Forms.Label formDetallePreventa;
        private System.Windows.Forms.Label preventaBaja;
        private System.Windows.Forms.DataGridView dgvArticulosPreventa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpArticulos;
        private System.Windows.Forms.Label DetallePreventa;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnBusquedaPreventa;
        private System.Windows.Forms.TextBox txtBaja;
        private FontAwesome.Sharp.IconButton btnRegistrarPreventa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtUsuarioPreventa;
        private System.Windows.Forms.Label Usuario;
        private FontAwesome.Sharp.IconButton btnRestablecerBusquedaPreventa;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPreventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baja;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioPreventa;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadArticulosPreventa;
    }
}