
namespace CapaPresentacion
{
    partial class form_Usuarios
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
            this.formUsuarios = new System.Windows.Forms.Label();
            this.usuarioDNI = new System.Windows.Forms.Label();
            this.usuarioNombreCompleto = new System.Windows.Forms.Label();
            this.usuarioCorreo = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.textNombreCompleto = new System.Windows.Forms.TextBox();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId = new System.Windows.Forms.TextBox();
            this.ttlUsuarios = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboBusquedaUsuario = new System.Windows.Forms.ComboBox();
            this.txtBusquedaUsuario = new System.Windows.Forms.TextBox();
            this.btnLimpiarBusquedaUsuario = new FontAwesome.Sharp.IconButton();
            this.btnBusquedaUsuario = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.bntGuardar = new FontAwesome.Sharp.IconButton();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.btnDarBaja = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // formUsuarios
            // 
            this.formUsuarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.formUsuarios.Dock = System.Windows.Forms.DockStyle.Left;
            this.formUsuarios.Location = new System.Drawing.Point(0, 0);
            this.formUsuarios.Name = "formUsuarios";
            this.formUsuarios.Size = new System.Drawing.Size(286, 625);
            this.formUsuarios.TabIndex = 0;
            // 
            // usuarioDNI
            // 
            this.usuarioDNI.AutoSize = true;
            this.usuarioDNI.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usuarioDNI.Location = new System.Drawing.Point(21, 45);
            this.usuarioDNI.Name = "usuarioDNI";
            this.usuarioDNI.Size = new System.Drawing.Size(31, 17);
            this.usuarioDNI.TabIndex = 1;
            this.usuarioDNI.Text = "DNI";
            // 
            // usuarioNombreCompleto
            // 
            this.usuarioNombreCompleto.AutoSize = true;
            this.usuarioNombreCompleto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usuarioNombreCompleto.Location = new System.Drawing.Point(21, 106);
            this.usuarioNombreCompleto.Name = "usuarioNombreCompleto";
            this.usuarioNombreCompleto.Size = new System.Drawing.Size(121, 17);
            this.usuarioNombreCompleto.TabIndex = 2;
            this.usuarioNombreCompleto.Text = "Nombre Completo";
            // 
            // usuarioCorreo
            // 
            this.usuarioCorreo.AutoSize = true;
            this.usuarioCorreo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usuarioCorreo.Location = new System.Drawing.Point(21, 169);
            this.usuarioCorreo.Name = "usuarioCorreo";
            this.usuarioCorreo.Size = new System.Drawing.Size(51, 17);
            this.usuarioCorreo.TabIndex = 3;
            this.usuarioCorreo.Text = "Correo";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(24, 67);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(229, 22);
            this.txtDNI.TabIndex = 4;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(24, 128);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(229, 22);
            this.txtNombreCompleto.TabIndex = 5;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(24, 191);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(229, 22);
            this.txtCorreo.TabIndex = 6;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(23, 257);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(229, 22);
            this.txtClave.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(20, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Contraseña";
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Location = new System.Drawing.Point(23, 326);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.PasswordChar = '*';
            this.txtConfirmarClave.Size = new System.Drawing.Size(230, 22);
            this.txtConfirmarClave.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(21, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Confirmar contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(20, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Rol";
            // 
            // cboRol
            // 
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(24, 390);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(229, 24);
            this.cboRol.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(34, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(34, 200);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(172, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(34, 200);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(172, 22);
            this.textCorreo.TabIndex = 6;
            // 
            // textNombreCompleto
            // 
            this.textNombreCompleto.Location = new System.Drawing.Point(34, 138);
            this.textNombreCompleto.Name = "textNombreCompleto";
            this.textNombreCompleto.Size = new System.Drawing.Size(172, 22);
            this.textNombreCompleto.TabIndex = 5;
            // 
            // textDNI
            // 
            this.textDNI.Location = new System.Drawing.Point(34, 74);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(172, 22);
            this.textDNI.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(21, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Detalle Usuario";
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
            this.Contraseña,
            this.idRol,
            this.Rol,
            this.Activo});
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
            this.dgvData.Size = new System.Drawing.Size(846, 527);
            this.dgvData.TabIndex = 19;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_CellPainting);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 6;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 40;
            // 
            // id
            // 
            this.id.HeaderText = "idUsuario";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // DNI
            // 
            this.DNI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 6;
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.MinimumWidth = 6;
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Contraseña
            // 
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.MinimumWidth = 6;
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.ReadOnly = true;
            this.Contraseña.Visible = false;
            this.Contraseña.Width = 125;
            // 
            // idRol
            // 
            this.idRol.HeaderText = "idRol";
            this.idRol.MinimumWidth = 6;
            this.idRol.Name = "idRol";
            this.idRol.ReadOnly = true;
            this.idRol.Visible = false;
            this.idRol.Width = 125;
            // 
            // Rol
            // 
            this.Rol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rol.HeaderText = "Rol";
            this.Rol.MinimumWidth = 6;
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.MinimumWidth = 6;
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Width = 125;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(220, 16);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(33, 22);
            this.txtId.TabIndex = 20;
            this.txtId.Text = "0";
            this.txtId.Visible = false;
            // 
            // ttlUsuarios
            // 
            this.ttlUsuarios.AutoSize = true;
            this.ttlUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttlUsuarios.Location = new System.Drawing.Point(323, 45);
            this.ttlUsuarios.Margin = new System.Windows.Forms.Padding(0);
            this.ttlUsuarios.Name = "ttlUsuarios";
            this.ttlUsuarios.Size = new System.Drawing.Size(84, 20);
            this.ttlUsuarios.TabIndex = 21;
            this.ttlUsuarios.Text = "Usuarios";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(713, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Buscar por:";
            // 
            // cboBusquedaUsuario
            // 
            this.cboBusquedaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBusquedaUsuario.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cboBusquedaUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusquedaUsuario.FormattingEnabled = true;
            this.cboBusquedaUsuario.Location = new System.Drawing.Point(815, 13);
            this.cboBusquedaUsuario.Name = "cboBusquedaUsuario";
            this.cboBusquedaUsuario.Size = new System.Drawing.Size(197, 24);
            this.cboBusquedaUsuario.TabIndex = 23;
            // 
            // txtBusquedaUsuario
            // 
            this.txtBusquedaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusquedaUsuario.Location = new System.Drawing.Point(815, 43);
            this.txtBusquedaUsuario.MinimumSize = new System.Drawing.Size(4, 24);
            this.txtBusquedaUsuario.Name = "txtBusquedaUsuario";
            this.txtBusquedaUsuario.Size = new System.Drawing.Size(197, 22);
            this.txtBusquedaUsuario.TabIndex = 24;
            // 
            // btnLimpiarBusquedaUsuario
            // 
            this.btnLimpiarBusquedaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarBusquedaUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarBusquedaUsuario.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarBusquedaUsuario.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarBusquedaUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarBusquedaUsuario.IconSize = 20;
            this.btnLimpiarBusquedaUsuario.Location = new System.Drawing.Point(1111, 13);
            this.btnLimpiarBusquedaUsuario.Name = "btnLimpiarBusquedaUsuario";
            this.btnLimpiarBusquedaUsuario.Size = new System.Drawing.Size(62, 54);
            this.btnLimpiarBusquedaUsuario.TabIndex = 26;
            this.btnLimpiarBusquedaUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpiarBusquedaUsuario.UseVisualStyleBackColor = false;
            this.btnLimpiarBusquedaUsuario.Click += new System.EventHandler(this.btnLimpiarBusquedaUsuario_Click);
            // 
            // btnBusquedaUsuario
            // 
            this.btnBusquedaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBusquedaUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.btnBusquedaUsuario.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBusquedaUsuario.IconColor = System.Drawing.Color.Black;
            this.btnBusquedaUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBusquedaUsuario.IconSize = 20;
            this.btnBusquedaUsuario.Location = new System.Drawing.Point(1036, 13);
            this.btnBusquedaUsuario.Name = "btnBusquedaUsuario";
            this.btnBusquedaUsuario.Size = new System.Drawing.Size(64, 54);
            this.btnBusquedaUsuario.TabIndex = 25;
            this.btnBusquedaUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBusquedaUsuario.UseVisualStyleBackColor = false;
            this.btnBusquedaUsuario.Click += new System.EventHandler(this.btnBusquedaUsuario_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 20;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(23, 460);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(113, 42);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // bntGuardar
            // 
            this.bntGuardar.BackColor = System.Drawing.Color.LightGreen;
            this.bntGuardar.IconChar = FontAwesome.Sharp.IconChar.SadCry;
            this.bntGuardar.IconColor = System.Drawing.Color.Black;
            this.bntGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntGuardar.IconSize = 25;
            this.bntGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntGuardar.Location = new System.Drawing.Point(23, 519);
            this.bntGuardar.Name = "bntGuardar";
            this.bntGuardar.Size = new System.Drawing.Size(230, 46);
            this.bntGuardar.TabIndex = 15;
            this.bntGuardar.Text = "Guardar";
            this.bntGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bntGuardar.UseVisualStyleBackColor = false;
            this.bntGuardar.Click += new System.EventHandler(this.bntGuardar_Click);
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(181, 16);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(33, 22);
            this.txtIndice.TabIndex = 27;
            this.txtIndice.Text = "-1";
            this.txtIndice.Visible = false;
            // 
            // btnDarBaja
            // 
            this.btnDarBaja.BackColor = System.Drawing.SystemColors.Control;
            this.btnDarBaja.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnDarBaja.IconColor = System.Drawing.Color.Firebrick;
            this.btnDarBaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDarBaja.IconSize = 20;
            this.btnDarBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDarBaja.Location = new System.Drawing.Point(142, 460);
            this.btnDarBaja.Name = "btnDarBaja";
            this.btnDarBaja.Size = new System.Drawing.Size(111, 42);
            this.btnDarBaja.TabIndex = 17;
            this.btnDarBaja.Text = "Dar Baja";
            this.btnDarBaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDarBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDarBaja.UseVisualStyleBackColor = false;
            this.btnDarBaja.Click += new System.EventHandler(this.btnDarBaja_Click);
            // 
            // form_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1211, 625);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.btnLimpiarBusquedaUsuario);
            this.Controls.Add(this.btnBusquedaUsuario);
            this.Controls.Add(this.txtBusquedaUsuario);
            this.Controls.Add(this.cboBusquedaUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ttlUsuarios);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDarBaja);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.bntGuardar);
            this.Controls.Add(this.cboRol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConfirmarClave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.usuarioCorreo);
            this.Controls.Add(this.usuarioNombreCompleto);
            this.Controls.Add(this.usuarioDNI);
            this.Controls.Add(this.formUsuarios);
            this.Name = "form_Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.form_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formUsuarios;
        private System.Windows.Forms.Label usuarioDNI;
        private System.Windows.Forms.Label usuarioNombreCompleto;
        private System.Windows.Forms.Label usuarioCorreo;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.TextBox textNombreCompleto;
        private System.Windows.Forms.TextBox textDNI;
        private FontAwesome.Sharp.IconButton bntGuardar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label ttlUsuarios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboBusquedaUsuario;
        private System.Windows.Forms.TextBox txtBusquedaUsuario;
        private FontAwesome.Sharp.IconButton btnLimpiarBusquedaUsuario;
        private FontAwesome.Sharp.IconButton btnBusquedaUsuario;
        private System.Windows.Forms.TextBox txtIndice;
        private FontAwesome.Sharp.IconButton btnDarBaja;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
    }
}