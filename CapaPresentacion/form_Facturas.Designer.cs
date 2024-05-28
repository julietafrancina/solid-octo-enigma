
namespace CapaPresentacion
{
    partial class form_Facturas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.btnLimpiarDatos = new FontAwesome.Sharp.IconButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnBusqueda = new FontAwesome.Sharp.IconButton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ttlClientes = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bntGuardar = new FontAwesome.Sharp.IconButton();
            this.facturaPreventa = new System.Windows.Forms.Label();
            this.txtNroOperacion = new System.Windows.Forms.TextBox();
            this.facturaNroOp = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.facturaMonto = new System.Windows.Forms.Label();
            this.facturaLetra = new System.Windows.Forms.Label();
            this.facturaNro = new System.Windows.Forms.Label();
            this.formUsuarios = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.textNombreCompleto = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cboBoxPreventa = new System.Windows.Forms.ComboBox();
            this.cboBoxEstado = new System.Windows.Forms.ComboBox();
            this.txtEstado = new System.Windows.Forms.Label();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Letra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPreventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Facturas";
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(191, 12);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(33, 22);
            this.txtIndice.TabIndex = 97;
            this.txtIndice.Text = "-1";
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarDatos.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiarDatos.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarDatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarDatos.IconSize = 20;
            this.btnLimpiarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarDatos.Location = new System.Drawing.Point(29, 466);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(233, 42);
            this.btnLimpiarDatos.TabIndex = 85;
            this.btnLimpiarDatos.Text = "Limpiar";
            this.btnLimpiarDatos.UseVisualStyleBackColor = false;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeight = 40;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.id,
            this.Numero,
            this.Letra,
            this.MontoTotal,
            this.NroOperacion,
            this.IdSucursal,
            this.DescripcionSucursal,
            this.IdPreventa,
            this.IdEstado,
            this.DescEstado});
            this.dgvData.Location = new System.Drawing.Point(329, 78);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 40;
            this.dgvData.Size = new System.Drawing.Size(888, 527);
            this.dgvData.TabIndex = 88;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_CellPainting);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 20;
            this.btnLimpiar.Location = new System.Drawing.Point(1156, 13);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(62, 54);
            this.btnLimpiar.TabIndex = 95;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBusqueda.BackColor = System.Drawing.SystemColors.Control;
            this.btnBusqueda.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBusqueda.IconColor = System.Drawing.Color.Black;
            this.btnBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBusqueda.IconSize = 20;
            this.btnBusqueda.Location = new System.Drawing.Point(1081, 13);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(64, 54);
            this.btnBusqueda.TabIndex = 94;
            this.btnBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.Location = new System.Drawing.Point(860, 43);
            this.txtBusqueda.MinimumSize = new System.Drawing.Size(4, 24);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(197, 22);
            this.txtBusqueda.TabIndex = 93;
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBusqueda.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(860, 13);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(197, 24);
            this.cboBusqueda.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(758, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 91;
            this.label6.Text = "Buscar por:";
            // 
            // ttlClientes
            // 
            this.ttlClientes.AutoSize = true;
            this.ttlClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttlClientes.Location = new System.Drawing.Point(325, 45);
            this.ttlClientes.Margin = new System.Windows.Forms.Padding(0);
            this.ttlClientes.Name = "ttlClientes";
            this.ttlClientes.Size = new System.Drawing.Size(83, 20);
            this.ttlClientes.TabIndex = 90;
            this.ttlClientes.Text = "Facturas";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(230, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(33, 22);
            this.txtId.TabIndex = 89;
            this.txtId.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(27, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 87;
            this.label5.Text = "Detalle Factura";
            // 
            // bntGuardar
            // 
            this.bntGuardar.BackColor = System.Drawing.Color.LightGreen;
            this.bntGuardar.IconChar = FontAwesome.Sharp.IconChar.SadCry;
            this.bntGuardar.IconColor = System.Drawing.Color.Black;
            this.bntGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntGuardar.IconSize = 25;
            this.bntGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntGuardar.Location = new System.Drawing.Point(30, 525);
            this.bntGuardar.Name = "bntGuardar";
            this.bntGuardar.Size = new System.Drawing.Size(233, 46);
            this.bntGuardar.TabIndex = 84;
            this.bntGuardar.Text = "Guardar";
            this.bntGuardar.UseVisualStyleBackColor = false;
            this.bntGuardar.Click += new System.EventHandler(this.bntGuardar_Click);
            // 
            // facturaPreventa
            // 
            this.facturaPreventa.AutoSize = true;
            this.facturaPreventa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.facturaPreventa.Location = new System.Drawing.Point(27, 295);
            this.facturaPreventa.Name = "facturaPreventa";
            this.facturaPreventa.Size = new System.Drawing.Size(65, 17);
            this.facturaPreventa.TabIndex = 83;
            this.facturaPreventa.Text = "Preventa";
            // 
            // txtNroOperacion
            // 
            this.txtNroOperacion.BackColor = System.Drawing.Color.White;
            this.txtNroOperacion.Location = new System.Drawing.Point(30, 252);
            this.txtNroOperacion.Name = "txtNroOperacion";
            this.txtNroOperacion.ReadOnly = true;
            this.txtNroOperacion.Size = new System.Drawing.Size(232, 22);
            this.txtNroOperacion.TabIndex = 80;
            // 
            // facturaNroOp
            // 
            this.facturaNroOp.AutoSize = true;
            this.facturaNroOp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.facturaNroOp.Location = new System.Drawing.Point(27, 230);
            this.facturaNroOp.Name = "facturaNroOp";
            this.facturaNroOp.Size = new System.Drawing.Size(105, 17);
            this.facturaNroOp.TabIndex = 79;
            this.facturaNroOp.Text = "Nro. Operación";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.BackColor = System.Drawing.Color.White;
            this.txtMontoTotal.Location = new System.Drawing.Point(30, 187);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(232, 22);
            this.txtMontoTotal.TabIndex = 78;
            // 
            // txtLetra
            // 
            this.txtLetra.BackColor = System.Drawing.Color.White;
            this.txtLetra.Location = new System.Drawing.Point(30, 124);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(232, 22);
            this.txtLetra.TabIndex = 75;
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.Location = new System.Drawing.Point(30, 63);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(232, 22);
            this.txtNumero.TabIndex = 71;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // facturaMonto
            // 
            this.facturaMonto.AutoSize = true;
            this.facturaMonto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.facturaMonto.Location = new System.Drawing.Point(27, 165);
            this.facturaMonto.Name = "facturaMonto";
            this.facturaMonto.Size = new System.Drawing.Size(83, 17);
            this.facturaMonto.TabIndex = 69;
            this.facturaMonto.Text = "Monto Total";
            // 
            // facturaLetra
            // 
            this.facturaLetra.AutoSize = true;
            this.facturaLetra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.facturaLetra.Location = new System.Drawing.Point(27, 102);
            this.facturaLetra.Name = "facturaLetra";
            this.facturaLetra.Size = new System.Drawing.Size(41, 17);
            this.facturaLetra.TabIndex = 68;
            this.facturaLetra.Text = "Letra";
            // 
            // facturaNro
            // 
            this.facturaNro.AutoSize = true;
            this.facturaNro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.facturaNro.Location = new System.Drawing.Point(27, 41);
            this.facturaNro.Name = "facturaNro";
            this.facturaNro.Size = new System.Drawing.Size(58, 17);
            this.facturaNro.TabIndex = 67;
            this.facturaNro.Text = "Número";
            // 
            // formUsuarios
            // 
            this.formUsuarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.formUsuarios.Dock = System.Windows.Forms.DockStyle.Left;
            this.formUsuarios.Location = new System.Drawing.Point(0, 0);
            this.formUsuarios.Name = "formUsuarios";
            this.formUsuarios.Size = new System.Drawing.Size(294, 632);
            this.formUsuarios.TabIndex = 66;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(48, 200);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(172, 22);
            this.textBox3.TabIndex = 77;
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(48, 200);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(172, 22);
            this.textCorreo.TabIndex = 76;
            // 
            // textDNI
            // 
            this.textDNI.Location = new System.Drawing.Point(48, 74);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(172, 22);
            this.textDNI.TabIndex = 72;
            // 
            // textNombreCompleto
            // 
            this.textNombreCompleto.Location = new System.Drawing.Point(48, 138);
            this.textNombreCompleto.Name = "textNombreCompleto";
            this.textNombreCompleto.Size = new System.Drawing.Size(172, 22);
            this.textNombreCompleto.TabIndex = 73;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 22);
            this.textBox1.TabIndex = 70;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(48, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 22);
            this.textBox2.TabIndex = 74;
            // 
            // cboBoxPreventa
            // 
            this.cboBoxPreventa.BackColor = System.Drawing.Color.White;
            this.cboBoxPreventa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxPreventa.FormattingEnabled = true;
            this.cboBoxPreventa.Location = new System.Drawing.Point(30, 315);
            this.cboBoxPreventa.Name = "cboBoxPreventa";
            this.cboBoxPreventa.Size = new System.Drawing.Size(232, 24);
            this.cboBoxPreventa.TabIndex = 99;
            this.cboBoxPreventa.SelectedIndexChanged += new System.EventHandler(this.cboBoxPreventa_SelectedIndexChanged);
            // 
            // cboBoxEstado
            // 
            this.cboBoxEstado.BackColor = System.Drawing.Color.White;
            this.cboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxEstado.FormattingEnabled = true;
            this.cboBoxEstado.Location = new System.Drawing.Point(30, 378);
            this.cboBoxEstado.Name = "cboBoxEstado";
            this.cboBoxEstado.Size = new System.Drawing.Size(232, 24);
            this.cboBoxEstado.TabIndex = 100;
            // 
            // txtEstado
            // 
            this.txtEstado.AutoSize = true;
            this.txtEstado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEstado.Location = new System.Drawing.Point(27, 358);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(52, 17);
            this.txtEstado.TabIndex = 101;
            this.txtEstado.Text = "Estado";
            // 
            // txtSucursal
            // 
            this.txtSucursal.BackColor = System.Drawing.Color.White;
            this.txtSucursal.ForeColor = System.Drawing.Color.Gray;
            this.txtSucursal.Location = new System.Drawing.Point(31, 421);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.ReadOnly = true;
            this.txtSucursal.Size = new System.Drawing.Size(232, 22);
            this.txtSucursal.TabIndex = 102;
            this.txtSucursal.Text = "Sucursal";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.FillWeight = 5.868263F;
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 6;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 40;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // Numero
            // 
            this.Numero.FillWeight = 64.14292F;
            this.Numero.HeaderText = "Número";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 125;
            // 
            // Letra
            // 
            this.Letra.FillWeight = 169.8403F;
            this.Letra.HeaderText = "Letra";
            this.Letra.MinimumWidth = 6;
            this.Letra.Name = "Letra";
            this.Letra.ReadOnly = true;
            this.Letra.Width = 50;
            // 
            // MontoTotal
            // 
            this.MontoTotal.FillWeight = 85.60435F;
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.MinimumWidth = 6;
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            this.MontoTotal.Width = 140;
            // 
            // NroOperacion
            // 
            this.NroOperacion.FillWeight = 100.0715F;
            this.NroOperacion.HeaderText = "Nro. Operación";
            this.NroOperacion.MinimumWidth = 6;
            this.NroOperacion.Name = "NroOperacion";
            this.NroOperacion.ReadOnly = true;
            this.NroOperacion.Width = 125;
            // 
            // IdSucursal
            // 
            this.IdSucursal.FillWeight = 106.2491F;
            this.IdSucursal.HeaderText = "ID Sucursal";
            this.IdSucursal.MinimumWidth = 6;
            this.IdSucursal.Name = "IdSucursal";
            this.IdSucursal.ReadOnly = true;
            this.IdSucursal.Visible = false;
            this.IdSucursal.Width = 125;
            // 
            // DescripcionSucursal
            // 
            this.DescripcionSucursal.HeaderText = "Descripción Sucursal";
            this.DescripcionSucursal.MinimumWidth = 6;
            this.DescripcionSucursal.Name = "DescripcionSucursal";
            this.DescripcionSucursal.ReadOnly = true;
            this.DescripcionSucursal.Width = 175;
            // 
            // IdPreventa
            // 
            this.IdPreventa.FillWeight = 168.2236F;
            this.IdPreventa.HeaderText = "ID Preventa";
            this.IdPreventa.MinimumWidth = 6;
            this.IdPreventa.Name = "IdPreventa";
            this.IdPreventa.ReadOnly = true;
            this.IdPreventa.Width = 150;
            // 
            // IdEstado
            // 
            this.IdEstado.HeaderText = "ID Estado";
            this.IdEstado.MinimumWidth = 6;
            this.IdEstado.Name = "IdEstado";
            this.IdEstado.ReadOnly = true;
            this.IdEstado.Visible = false;
            this.IdEstado.Width = 125;
            // 
            // DescEstado
            // 
            this.DescEstado.HeaderText = "Estado";
            this.DescEstado.MinimumWidth = 6;
            this.DescEstado.Name = "DescEstado";
            this.DescEstado.ReadOnly = true;
            this.DescEstado.Width = 125;
            // 
            // form_Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 632);
            this.Controls.Add(this.txtSucursal);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.cboBoxEstado);
            this.Controls.Add(this.cboBoxPreventa);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cboBusqueda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ttlClientes);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bntGuardar);
            this.Controls.Add(this.facturaPreventa);
            this.Controls.Add(this.txtNroOperacion);
            this.Controls.Add(this.facturaNroOp);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.txtLetra);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.facturaMonto);
            this.Controls.Add(this.facturaLetra);
            this.Controls.Add(this.facturaNro);
            this.Controls.Add(this.formUsuarios);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.textDNI);
            this.Controls.Add(this.textNombreCompleto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Name = "form_Facturas";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.form_Facturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIndice;
        private FontAwesome.Sharp.IconButton btnLimpiarDatos;
        private System.Windows.Forms.DataGridView dgvData;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ttlClientes;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton bntGuardar;
        private System.Windows.Forms.Label facturaPreventa;
        private System.Windows.Forms.TextBox txtNroOperacion;
        private System.Windows.Forms.Label facturaNroOp;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label facturaMonto;
        private System.Windows.Forms.Label facturaLetra;
        private System.Windows.Forms.Label facturaNro;
        private System.Windows.Forms.Label formUsuarios;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.TextBox textDNI;
        private System.Windows.Forms.TextBox textNombreCompleto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cboBoxPreventa;
        private System.Windows.Forms.ComboBox cboBoxEstado;
        private System.Windows.Forms.Label txtEstado;
        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Letra;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPreventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescEstado;
    }
}