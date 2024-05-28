
namespace CapaPresentacion
{
    partial class form_Clientes
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ttlClientes = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.usuarioCorreo = new System.Windows.Forms.Label();
            this.usuarioNombreCompleto = new System.Windows.Forms.Label();
            this.usuarioDNI = new System.Windows.Forms.Label();
            this.formUsuarios = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.textNombreCompleto = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEraser = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnBusqueda = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.bntGuardar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
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
            this.DNI,
            this.NombreCompleto,
            this.Correo,
            this.Telefono,
            this.Domicilio,
            this.FechaNacimiento,
            this.EstadoValor,
            this.Estado});
            this.dgvData.Location = new System.Drawing.Point(327, 78);
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
            this.dgvData.TabIndex = 52;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_CellPainting);
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
            // DNI
            // 
            this.DNI.FillWeight = 64.14292F;
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 6;
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 125;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.FillWeight = 169.8403F;
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.MinimumWidth = 6;
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 150;
            // 
            // Correo
            // 
            this.Correo.FillWeight = 85.60435F;
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 140;
            // 
            // Telefono
            // 
            this.Telefono.FillWeight = 100.0715F;
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 125;
            // 
            // Domicilio
            // 
            this.Domicilio.FillWeight = 106.2491F;
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.MinimumWidth = 6;
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.ReadOnly = true;
            this.Domicilio.Width = 125;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.FillWeight = 168.2236F;
            this.FechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.FechaNacimiento.MinimumWidth = 6;
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            this.FechaNacimiento.Width = 150;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.MinimumWidth = 6;
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            this.EstadoValor.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            this.Estado.Width = 125;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.Location = new System.Drawing.Point(858, 43);
            this.txtBusqueda.MinimumSize = new System.Drawing.Size(4, 24);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(197, 22);
            this.txtBusqueda.TabIndex = 57;
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBusqueda.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(858, 13);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(197, 24);
            this.cboBusqueda.TabIndex = 56;
            this.cboBusqueda.SelectedIndexChanged += new System.EventHandler(this.cboBusqueda_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(756, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 55;
            this.label6.Text = "Buscar por:";
            // 
            // ttlClientes
            // 
            this.ttlClientes.AutoSize = true;
            this.ttlClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttlClientes.Location = new System.Drawing.Point(323, 45);
            this.ttlClientes.Margin = new System.Windows.Forms.Padding(0);
            this.ttlClientes.Name = "ttlClientes";
            this.ttlClientes.Size = new System.Drawing.Size(78, 20);
            this.ttlClientes.TabIndex = 54;
            this.ttlClientes.Text = "Clientes";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(234, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(33, 22);
            this.txtId.TabIndex = 53;
            this.txtId.Text = "0";
            this.txtId.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(31, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "Detalle Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(30, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Fecha Nacimiento";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(33, 322);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(233, 22);
            this.txtDomicilio.TabIndex = 43;
            this.txtDomicilio.TextChanged += new System.EventHandler(this.txtDomicilio_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(31, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Domicilio";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(33, 253);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(232, 22);
            this.txtTelefono.TabIndex = 41;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(30, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Teléfono";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(34, 187);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(232, 22);
            this.txtCorreo.TabIndex = 39;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(34, 124);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(232, 22);
            this.txtNombreCompleto.TabIndex = 36;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(34, 63);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(232, 22);
            this.txtDNI.TabIndex = 32;
            this.txtDNI.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // usuarioCorreo
            // 
            this.usuarioCorreo.AutoSize = true;
            this.usuarioCorreo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usuarioCorreo.Location = new System.Drawing.Point(31, 165);
            this.usuarioCorreo.Name = "usuarioCorreo";
            this.usuarioCorreo.Size = new System.Drawing.Size(51, 17);
            this.usuarioCorreo.TabIndex = 30;
            this.usuarioCorreo.Text = "Correo";
            // 
            // usuarioNombreCompleto
            // 
            this.usuarioNombreCompleto.AutoSize = true;
            this.usuarioNombreCompleto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usuarioNombreCompleto.Location = new System.Drawing.Point(31, 102);
            this.usuarioNombreCompleto.Name = "usuarioNombreCompleto";
            this.usuarioNombreCompleto.Size = new System.Drawing.Size(121, 17);
            this.usuarioNombreCompleto.TabIndex = 29;
            this.usuarioNombreCompleto.Text = "Nombre Completo";
            // 
            // usuarioDNI
            // 
            this.usuarioDNI.AutoSize = true;
            this.usuarioDNI.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usuarioDNI.Location = new System.Drawing.Point(31, 41);
            this.usuarioDNI.Name = "usuarioDNI";
            this.usuarioDNI.Size = new System.Drawing.Size(31, 17);
            this.usuarioDNI.TabIndex = 28;
            this.usuarioDNI.Text = "DNI";
            // 
            // formUsuarios
            // 
            this.formUsuarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.formUsuarios.Dock = System.Windows.Forms.DockStyle.Left;
            this.formUsuarios.Location = new System.Drawing.Point(0, 0);
            this.formUsuarios.Name = "formUsuarios";
            this.formUsuarios.Size = new System.Drawing.Size(294, 632);
            this.formUsuarios.TabIndex = 27;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 22);
            this.textBox1.TabIndex = 31;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(34, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 22);
            this.textBox2.TabIndex = 35;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(34, 200);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(172, 22);
            this.textBox3.TabIndex = 38;
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(34, 200);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(172, 22);
            this.textCorreo.TabIndex = 37;
            // 
            // textDNI
            // 
            this.textDNI.Location = new System.Drawing.Point(34, 74);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(172, 22);
            this.textDNI.TabIndex = 33;
            // 
            // textNombreCompleto
            // 
            this.textNombreCompleto.Location = new System.Drawing.Point(34, 138);
            this.textNombreCompleto.Name = "textNombreCompleto";
            this.textNombreCompleto.Size = new System.Drawing.Size(172, 22);
            this.textNombreCompleto.TabIndex = 34;
            // 
            // txtDia
            // 
            this.txtDia.ForeColor = System.Drawing.Color.Gray;
            this.txtDia.Location = new System.Drawing.Point(34, 388);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(60, 22);
            this.txtDia.TabIndex = 60;
            this.txtDia.Text = "dd";
            this.txtDia.TextChanged += new System.EventHandler(this.txtDia_TextChanged);
            this.txtDia.Enter += new System.EventHandler(this.txtDia_Enter);
            this.txtDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDia_KeyPress);
            this.txtDia.Leave += new System.EventHandler(this.txtDia_Leave);
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(195, 12);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(33, 22);
            this.txtIndice.TabIndex = 61;
            this.txtIndice.Text = "-1";
            this.txtIndice.Visible = false;
            // 
            // txtMes
            // 
            this.txtMes.ForeColor = System.Drawing.Color.Gray;
            this.txtMes.Location = new System.Drawing.Point(121, 388);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(60, 22);
            this.txtMes.TabIndex = 62;
            this.txtMes.Text = "mm";
            this.txtMes.TextChanged += new System.EventHandler(this.txtMes_TextChanged);
            this.txtMes.Enter += new System.EventHandler(this.txtMes_Enter);
            this.txtMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMes_KeyPress);
            this.txtMes.Leave += new System.EventHandler(this.txtMes_Leave);
            // 
            // txtAnio
            // 
            this.txtAnio.ForeColor = System.Drawing.Color.Gray;
            this.txtAnio.Location = new System.Drawing.Point(207, 388);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(60, 22);
            this.txtAnio.TabIndex = 63;
            this.txtAnio.Text = "yyyy";
            this.txtAnio.TextChanged += new System.EventHandler(this.txtAnio_TextChanged);
            this.txtAnio.Enter += new System.EventHandler(this.txtAnio_Enter);
            this.txtAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnio_KeyPress);
            this.txtAnio.Leave += new System.EventHandler(this.txtAnio_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(102, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 17);
            this.label1.TabIndex = 64;
            this.label1.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(189, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 17);
            this.label4.TabIndex = 65;
            this.label4.Text = "/";
            // 
            // btnEraser
            // 
            this.btnEraser.BackColor = System.Drawing.SystemColors.Control;
            this.btnEraser.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnEraser.IconColor = System.Drawing.Color.Black;
            this.btnEraser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEraser.IconSize = 20;
            this.btnEraser.Location = new System.Drawing.Point(33, 445);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(114, 42);
            this.btnEraser.TabIndex = 49;
            this.btnEraser.Text = "Limpiar";
            this.btnEraser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEraser.UseVisualStyleBackColor = false;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 20;
            this.btnLimpiar.Location = new System.Drawing.Point(1154, 13);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(62, 54);
            this.btnLimpiar.TabIndex = 59;
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
            this.btnBusqueda.Location = new System.Drawing.Point(1079, 13);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(64, 54);
            this.btnBusqueda.TabIndex = 58;
            this.btnBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 20;
            this.btnEliminar.Location = new System.Drawing.Point(153, 445);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(114, 42);
            this.btnEliminar.TabIndex = 50;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // bntGuardar
            // 
            this.bntGuardar.BackColor = System.Drawing.Color.LightGreen;
            this.bntGuardar.IconChar = FontAwesome.Sharp.IconChar.SadCry;
            this.bntGuardar.IconColor = System.Drawing.Color.Black;
            this.bntGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntGuardar.IconSize = 25;
            this.bntGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntGuardar.Location = new System.Drawing.Point(34, 504);
            this.bntGuardar.Name = "bntGuardar";
            this.bntGuardar.Size = new System.Drawing.Size(233, 46);
            this.bntGuardar.TabIndex = 48;
            this.bntGuardar.Text = "Guardar";
            this.bntGuardar.UseVisualStyleBackColor = false;
            this.bntGuardar.Click += new System.EventHandler(this.bntGuardar_Click);
            // 
            // form_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 632);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.btnEraser);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cboBusqueda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ttlClientes);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bntGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.usuarioCorreo);
            this.Controls.Add(this.usuarioNombreCompleto);
            this.Controls.Add(this.usuarioDNI);
            this.Controls.Add(this.formUsuarios);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.textDNI);
            this.Controls.Add(this.textNombreCompleto);
            this.Name = "form_Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.form_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnEraser;
        private System.Windows.Forms.DataGridView dgvData;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ttlClientes;
        private System.Windows.Forms.TextBox txtId;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton bntGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label usuarioCorreo;
        private System.Windows.Forms.Label usuarioNombreCompleto;
        private System.Windows.Forms.Label usuarioDNI;
        private System.Windows.Forms.Label formUsuarios;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.TextBox textDNI;
        private System.Windows.Forms.TextBox textNombreCompleto;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}