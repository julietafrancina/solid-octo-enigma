
namespace CapaPresentacion
{
    partial class Form_Remito
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
            this.tabla_rem = new System.Windows.Forms.DataGridView();
            this.boton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Letra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_operación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_lista = new System.Windows.Forms.Label();
            this.text_buscar_nroOp = new System.Windows.Forms.Label();
            this.text_buscar = new System.Windows.Forms.TextBox();
            this.btnBusquedaRemito = new FontAwesome.Sharp.IconButton();
            this.textNroOp = new System.Windows.Forms.TextBox();
            this.nro_op = new System.Windows.Forms.Label();
            this.textSuc = new System.Windows.Forms.Label();
            this.textSucursal = new System.Windows.Forms.TextBox();
            this.textLetra = new System.Windows.Forms.Label();
            this.textL = new System.Windows.Forms.TextBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelestado = new System.Windows.Forms.Label();
            this.detalle_rem = new System.Windows.Forms.Label();
            this.textNro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_tipo = new System.Windows.Forms.ComboBox();
            this.formUsuarios = new System.Windows.Forms.Label();
            this.btnLimpiarDatos = new FontAwesome.Sharp.IconButton();
            this.btnAnular = new FontAwesome.Sharp.IconButton();
            this.bntGuardar = new FontAwesome.Sharp.IconButton();
            this.text_idsuc = new System.Windows.Forms.TextBox();
            this.btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            this.textEstado = new System.Windows.Forms.TextBox();
            this.labelFact = new System.Windows.Forms.Label();
            this.CB_fact = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_rem)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla_rem
            // 
            this.tabla_rem.AllowUserToAddRows = false;
            this.tabla_rem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
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
            this.tabla_rem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_rem.ColumnHeadersHeight = 50;
            this.tabla_rem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boton,
            this.nro,
            this.Sucursal,
            this.Letra,
            this.Tipo,
            this.Estado,
            this.Nro_operación,
            this.Factura});
            this.tabla_rem.Location = new System.Drawing.Point(297, 82);
            this.tabla_rem.Name = "tabla_rem";
            this.tabla_rem.ReadOnly = true;
            this.tabla_rem.RowHeadersWidth = 51;
            this.tabla_rem.RowTemplate.Height = 40;
            this.tabla_rem.Size = new System.Drawing.Size(913, 589);
            this.tabla_rem.TabIndex = 0;
            this.tabla_rem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_rem_CellContentClick);
            this.tabla_rem.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.tabla_rem_CellPainting);
            // 
            // boton
            // 
            this.boton.FillWeight = 5.86F;
            this.boton.HeaderText = "";
            this.boton.MinimumWidth = 6;
            this.boton.Name = "boton";
            this.boton.ReadOnly = true;
            this.boton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.boton.Width = 40;
            // 
            // nro
            // 
            this.nro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nro.HeaderText = "Número";
            this.nro.MinimumWidth = 6;
            this.nro.Name = "nro";
            this.nro.ReadOnly = true;
            // 
            // Sucursal
            // 
            this.Sucursal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sucursal.HeaderText = "Sucursal";
            this.Sucursal.MinimumWidth = 6;
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.ReadOnly = true;
            // 
            // Letra
            // 
            this.Letra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Letra.HeaderText = "Letra";
            this.Letra.MinimumWidth = 6;
            this.Letra.Name = "Letra";
            this.Letra.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Nro_operación
            // 
            this.Nro_operación.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nro_operación.HeaderText = "Número Operación";
            this.Nro_operación.MinimumWidth = 6;
            this.Nro_operación.Name = "Nro_operación";
            this.Nro_operación.ReadOnly = true;
            // 
            // Factura
            // 
            this.Factura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Factura.HeaderText = "Factura";
            this.Factura.MinimumWidth = 6;
            this.Factura.Name = "Factura";
            this.Factura.ReadOnly = true;
            // 
            // label_lista
            // 
            this.label_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lista.Location = new System.Drawing.Point(293, 55);
            this.label_lista.Name = "label_lista";
            this.label_lista.Size = new System.Drawing.Size(200, 19);
            this.label_lista.TabIndex = 15;
            this.label_lista.Text = "Remitos";
            // 
            // text_buscar_nroOp
            // 
            this.text_buscar_nroOp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_buscar_nroOp.AutoSize = true;
            this.text_buscar_nroOp.Location = new System.Drawing.Point(682, 45);
            this.text_buscar_nroOp.Name = "text_buscar_nroOp";
            this.text_buscar_nroOp.Size = new System.Drawing.Size(180, 17);
            this.text_buscar_nroOp.TabIndex = 21;
            this.text_buscar_nroOp.Text = "Buscar por Nro. de Remito:";
            this.text_buscar_nroOp.Click += new System.EventHandler(this.text_buscar_nroOp_Click);
            // 
            // text_buscar
            // 
            this.text_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_buscar.Location = new System.Drawing.Point(894, 43);
            this.text_buscar.Name = "text_buscar";
            this.text_buscar.Size = new System.Drawing.Size(176, 22);
            this.text_buscar.TabIndex = 22;
            this.text_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_buscar_KeyPress);
            // 
            // btnBusquedaRemito
            // 
            this.btnBusquedaRemito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBusquedaRemito.BackColor = System.Drawing.SystemColors.Control;
            this.btnBusquedaRemito.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBusquedaRemito.IconColor = System.Drawing.Color.Black;
            this.btnBusquedaRemito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBusquedaRemito.IconSize = 20;
            this.btnBusquedaRemito.Location = new System.Drawing.Point(1076, 22);
            this.btnBusquedaRemito.Name = "btnBusquedaRemito";
            this.btnBusquedaRemito.Size = new System.Drawing.Size(64, 54);
            this.btnBusquedaRemito.TabIndex = 27;
            this.btnBusquedaRemito.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBusquedaRemito.UseVisualStyleBackColor = false;
            this.btnBusquedaRemito.Click += new System.EventHandler(this.btnBusquedaRemito_Click);
            // 
            // textNroOp
            // 
            this.textNroOp.Location = new System.Drawing.Point(28, 83);
            this.textNroOp.Name = "textNroOp";
            this.textNroOp.ReadOnly = true;
            this.textNroOp.Size = new System.Drawing.Size(212, 22);
            this.textNroOp.TabIndex = 28;
            // 
            // nro_op
            // 
            this.nro_op.AutoSize = true;
            this.nro_op.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nro_op.Location = new System.Drawing.Point(25, 63);
            this.nro_op.Name = "nro_op";
            this.nro_op.Size = new System.Drawing.Size(101, 17);
            this.nro_op.TabIndex = 29;
            this.nro_op.Text = "Nro.Operación";
            // 
            // textSuc
            // 
            this.textSuc.AutoSize = true;
            this.textSuc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textSuc.Location = new System.Drawing.Point(25, 127);
            this.textSuc.Name = "textSuc";
            this.textSuc.Size = new System.Drawing.Size(63, 17);
            this.textSuc.TabIndex = 30;
            this.textSuc.Text = "Sucursal";
            // 
            // textSucursal
            // 
            this.textSucursal.Location = new System.Drawing.Point(28, 147);
            this.textSucursal.Name = "textSucursal";
            this.textSucursal.ReadOnly = true;
            this.textSucursal.Size = new System.Drawing.Size(212, 22);
            this.textSucursal.TabIndex = 31;
            // 
            // textLetra
            // 
            this.textLetra.AutoSize = true;
            this.textLetra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textLetra.Location = new System.Drawing.Point(25, 192);
            this.textLetra.Name = "textLetra";
            this.textLetra.Size = new System.Drawing.Size(41, 17);
            this.textLetra.TabIndex = 32;
            this.textLetra.Text = "Letra";
            // 
            // textL
            // 
            this.textL.Location = new System.Drawing.Point(28, 212);
            this.textL.Name = "textL";
            this.textL.ReadOnly = true;
            this.textL.Size = new System.Drawing.Size(212, 22);
            this.textL.TabIndex = 33;
            this.textL.TextChanged += new System.EventHandler(this.textL_TextChanged);
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelTipo.Location = new System.Drawing.Point(25, 317);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(36, 17);
            this.labelTipo.TabIndex = 34;
            this.labelTipo.Text = "Tipo";
            // 
            // labelestado
            // 
            this.labelestado.AutoSize = true;
            this.labelestado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelestado.Location = new System.Drawing.Point(25, 441);
            this.labelestado.Name = "labelestado";
            this.labelestado.Size = new System.Drawing.Size(52, 17);
            this.labelestado.TabIndex = 36;
            this.labelestado.Text = "Estado";
            // 
            // detalle_rem
            // 
            this.detalle_rem.AutoSize = true;
            this.detalle_rem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.detalle_rem.ForeColor = System.Drawing.Color.DimGray;
            this.detalle_rem.Location = new System.Drawing.Point(25, 20);
            this.detalle_rem.Name = "detalle_rem";
            this.detalle_rem.Size = new System.Drawing.Size(100, 17);
            this.detalle_rem.TabIndex = 38;
            this.detalle_rem.Text = "Detalle Remito";
            // 
            // textNro
            // 
            this.textNro.Location = new System.Drawing.Point(28, 276);
            this.textNro.Name = "textNro";
            this.textNro.Size = new System.Drawing.Size(212, 22);
            this.textNro.TabIndex = 42;
            this.textNro.TextChanged += new System.EventHandler(this.textNro_TextChanged);
            this.textNro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNro_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(25, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Número";
            // 
            // CB_tipo
            // 
            this.CB_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_tipo.FormattingEnabled = true;
            this.CB_tipo.Location = new System.Drawing.Point(28, 337);
            this.CB_tipo.Name = "CB_tipo";
            this.CB_tipo.Size = new System.Drawing.Size(212, 24);
            this.CB_tipo.TabIndex = 44;
            this.CB_tipo.SelectedIndexChanged += new System.EventHandler(this.CB_fact_SelectedIndexChanged);
            // 
            // formUsuarios
            // 
            this.formUsuarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.formUsuarios.Dock = System.Windows.Forms.DockStyle.Left;
            this.formUsuarios.Location = new System.Drawing.Point(0, 0);
            this.formUsuarios.Name = "formUsuarios";
            this.formUsuarios.Size = new System.Drawing.Size(272, 728);
            this.formUsuarios.TabIndex = 67;
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarDatos.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiarDatos.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarDatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarDatos.IconSize = 20;
            this.btnLimpiarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarDatos.Location = new System.Drawing.Point(28, 499);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(104, 42);
            this.btnLimpiarDatos.TabIndex = 86;
            this.btnLimpiarDatos.Text = "Limpiar";
            this.btnLimpiarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpiarDatos.UseVisualStyleBackColor = false;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.BtLimpiarRem_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnAnular.IconColor = System.Drawing.Color.Firebrick;
            this.btnAnular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnular.IconSize = 20;
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.Location = new System.Drawing.Point(136, 499);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(104, 42);
            this.btnAnular.TabIndex = 104;
            this.btnAnular.Text = "Anular";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btEliminarRem_Click);
            // 
            // bntGuardar
            // 
            this.bntGuardar.BackColor = System.Drawing.Color.LightGreen;
            this.bntGuardar.IconChar = FontAwesome.Sharp.IconChar.SadCry;
            this.bntGuardar.IconColor = System.Drawing.Color.Black;
            this.bntGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntGuardar.IconSize = 25;
            this.bntGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntGuardar.Location = new System.Drawing.Point(27, 547);
            this.bntGuardar.Name = "bntGuardar";
            this.bntGuardar.Size = new System.Drawing.Size(213, 46);
            this.bntGuardar.TabIndex = 105;
            this.bntGuardar.Text = "Guardar";
            this.bntGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bntGuardar.UseVisualStyleBackColor = false;
            this.bntGuardar.Click += new System.EventHandler(this.btGuardarRem_Click);
            // 
            // text_idsuc
            // 
            this.text_idsuc.Location = new System.Drawing.Point(203, 175);
            this.text_idsuc.Name = "text_idsuc";
            this.text_idsuc.Size = new System.Drawing.Size(37, 22);
            this.text_idsuc.TabIndex = 49;
            this.text_idsuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text_idsuc.Visible = false;
            // 
            // btnLimpiarBuscador
            // 
            this.btnLimpiarBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarBuscador.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarBuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarBuscador.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarBuscador.IconSize = 20;
            this.btnLimpiarBuscador.Location = new System.Drawing.Point(1148, 22);
            this.btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            this.btnLimpiarBuscador.Size = new System.Drawing.Size(62, 54);
            this.btnLimpiarBuscador.TabIndex = 106;
            this.btnLimpiarBuscador.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpiarBuscador.UseVisualStyleBackColor = false;
            this.btnLimpiarBuscador.Click += new System.EventHandler(this.btnLimpiarBuscador_Click);
            // 
            // textEstado
            // 
            this.textEstado.Location = new System.Drawing.Point(27, 461);
            this.textEstado.Name = "textEstado";
            this.textEstado.ReadOnly = true;
            this.textEstado.Size = new System.Drawing.Size(212, 22);
            this.textEstado.TabIndex = 107;
            // 
            // labelFact
            // 
            this.labelFact.AutoSize = true;
            this.labelFact.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelFact.Location = new System.Drawing.Point(25, 380);
            this.labelFact.Name = "labelFact";
            this.labelFact.Size = new System.Drawing.Size(56, 17);
            this.labelFact.TabIndex = 108;
            this.labelFact.Text = "Factura";
            // 
            // CB_fact
            // 
            this.CB_fact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_fact.FormattingEnabled = true;
            this.CB_fact.Location = new System.Drawing.Point(27, 400);
            this.CB_fact.Name = "CB_fact";
            this.CB_fact.Size = new System.Drawing.Size(212, 24);
            this.CB_fact.TabIndex = 109;
            this.CB_fact.SelectedIndexChanged += new System.EventHandler(this.CB_fact_SelectedIndexChanged);
            // 
            // Form_Remito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 728);
            this.Controls.Add(this.CB_fact);
            this.Controls.Add(this.labelFact);
            this.Controls.Add(this.textEstado);
            this.Controls.Add(this.btnLimpiarBuscador);
            this.Controls.Add(this.bntGuardar);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.text_idsuc);
            this.Controls.Add(this.CB_tipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNro);
            this.Controls.Add(this.detalle_rem);
            this.Controls.Add(this.labelestado);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.textL);
            this.Controls.Add(this.textLetra);
            this.Controls.Add(this.textSucursal);
            this.Controls.Add(this.textSuc);
            this.Controls.Add(this.nro_op);
            this.Controls.Add(this.textNroOp);
            this.Controls.Add(this.btnBusquedaRemito);
            this.Controls.Add(this.text_buscar);
            this.Controls.Add(this.text_buscar_nroOp);
            this.Controls.Add(this.label_lista);
            this.Controls.Add(this.tabla_rem);
            this.Controls.Add(this.formUsuarios);
            this.Name = "Form_Remito";
            this.Text = "Form_Remtio";
            this.Load += new System.EventHandler(this.Form_Remito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_rem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabla_rem;
        private System.Windows.Forms.Label label_lista;
        private System.Windows.Forms.Label text_buscar_nroOp;
        private System.Windows.Forms.TextBox text_buscar;
        private FontAwesome.Sharp.IconButton btnBusquedaRemito;
        private System.Windows.Forms.TextBox textNroOp;
        private System.Windows.Forms.Label nro_op;
        private System.Windows.Forms.Label textSuc;
        private System.Windows.Forms.TextBox textSucursal;
        private System.Windows.Forms.Label textLetra;
        private System.Windows.Forms.TextBox textL;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelestado;
        private System.Windows.Forms.Label detalle_rem;
        private System.Windows.Forms.TextBox textNro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_tipo;
        private System.Windows.Forms.TextBox text_idsuc;
        private System.Windows.Forms.Label formUsuarios;
        private FontAwesome.Sharp.IconButton btnLimpiarDatos;
        private FontAwesome.Sharp.IconButton btnAnular;
        private FontAwesome.Sharp.IconButton bntGuardar;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private System.Windows.Forms.TextBox textEstado;
        private System.Windows.Forms.Label labelFact;
        private System.Windows.Forms.ComboBox CB_fact;
        private System.Windows.Forms.DataGridViewButtonColumn boton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Letra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_operación;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
    }
}