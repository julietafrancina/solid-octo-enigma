
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
            this.tabla_rem = new System.Windows.Forms.DataGridView();
            this.Nro_operación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Letra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.BtLimpiarRem = new System.Windows.Forms.Button();
            this.btEliminarRem = new System.Windows.Forms.Button();
            this.btGuardarRem = new System.Windows.Forms.Button();
            this.textNro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_tipo = new System.Windows.Forms.ComboBox();
            this.textEstado = new System.Windows.Forms.TextBox();
            this.CB_fact = new System.Windows.Forms.ComboBox();
            this.labelFact = new System.Windows.Forms.Label();
            this.btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_rem)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla_rem
            // 
            this.tabla_rem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_rem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro_operación,
            this.Sucursal,
            this.Letra,
            this.Tipo,
            this.Estado,
            this.nro,
            this.Factura});
            this.tabla_rem.Location = new System.Drawing.Point(297, 82);
            this.tabla_rem.Name = "tabla_rem";
            this.tabla_rem.RowHeadersWidth = 51;
            this.tabla_rem.RowTemplate.Height = 24;
            this.tabla_rem.Size = new System.Drawing.Size(821, 589);
            this.tabla_rem.TabIndex = 0;
            this.tabla_rem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_rem_CellContentClick);
            // 
            // Nro_operación
            // 
            this.Nro_operación.HeaderText = "Nro_operación";
            this.Nro_operación.MinimumWidth = 6;
            this.Nro_operación.Name = "Nro_operación";
            this.Nro_operación.Width = 125;
            // 
            // Sucursal
            // 
            this.Sucursal.HeaderText = "Sucursal";
            this.Sucursal.MinimumWidth = 6;
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Width = 125;
            // 
            // Letra
            // 
            this.Letra.HeaderText = "Letra";
            this.Letra.MinimumWidth = 6;
            this.Letra.Name = "Letra";
            this.Letra.Width = 125;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // nro
            // 
            this.nro.HeaderText = "Nro";
            this.nro.MinimumWidth = 6;
            this.nro.Name = "nro";
            this.nro.Width = 125;
            // 
            // Factura
            // 
            this.Factura.HeaderText = "Nro factura";
            this.Factura.MinimumWidth = 6;
            this.Factura.Name = "Factura";
            this.Factura.Visible = false;
            this.Factura.Width = 125;
            // 
            // label_lista
            // 
            this.label_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lista.Location = new System.Drawing.Point(292, 46);
            this.label_lista.Name = "label_lista";
            this.label_lista.Size = new System.Drawing.Size(200, 33);
            this.label_lista.TabIndex = 15;
            this.label_lista.Text = "Lista de remitos";
            // 
            // text_buscar_nroOp
            // 
            this.text_buscar_nroOp.AutoSize = true;
            this.text_buscar_nroOp.Location = new System.Drawing.Point(610, 57);
            this.text_buscar_nroOp.Name = "text_buscar_nroOp";
            this.text_buscar_nroOp.Size = new System.Drawing.Size(193, 17);
            this.text_buscar_nroOp.TabIndex = 21;
            this.text_buscar_nroOp.Text = "Buscar por nro de operación:";
            // 
            // text_buscar
            // 
            this.text_buscar.Location = new System.Drawing.Point(829, 53);
            this.text_buscar.Name = "text_buscar";
            this.text_buscar.Size = new System.Drawing.Size(176, 22);
            this.text_buscar.TabIndex = 22;
            this.text_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_buscar_KeyPress);
            // 
            // btnBusquedaRemito
            // 
            this.btnBusquedaRemito.BackColor = System.Drawing.SystemColors.Control;
            this.btnBusquedaRemito.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBusquedaRemito.IconColor = System.Drawing.Color.Black;
            this.btnBusquedaRemito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBusquedaRemito.IconSize = 20;
            this.btnBusquedaRemito.Location = new System.Drawing.Point(1011, 49);
            this.btnBusquedaRemito.Name = "btnBusquedaRemito";
            this.btnBusquedaRemito.Size = new System.Drawing.Size(54, 30);
            this.btnBusquedaRemito.TabIndex = 27;
            this.btnBusquedaRemito.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBusquedaRemito.UseVisualStyleBackColor = false;
            this.btnBusquedaRemito.Click += new System.EventHandler(this.btnBusquedaRemito_Click);
            // 
            // textNroOp
            // 
            this.textNroOp.Location = new System.Drawing.Point(24, 120);
            this.textNroOp.Name = "textNroOp";
            this.textNroOp.ReadOnly = true;
            this.textNroOp.Size = new System.Drawing.Size(212, 22);
            this.textNroOp.TabIndex = 28;
            // 
            // nro_op
            // 
            this.nro_op.AutoSize = true;
            this.nro_op.Location = new System.Drawing.Point(21, 100);
            this.nro_op.Name = "nro_op";
            this.nro_op.Size = new System.Drawing.Size(98, 17);
            this.nro_op.TabIndex = 29;
            this.nro_op.Text = "Nro operación";
            // 
            // textSuc
            // 
            this.textSuc.AutoSize = true;
            this.textSuc.Location = new System.Drawing.Point(21, 164);
            this.textSuc.Name = "textSuc";
            this.textSuc.Size = new System.Drawing.Size(63, 17);
            this.textSuc.TabIndex = 30;
            this.textSuc.Text = "Sucursal";
            // 
            // textSucursal
            // 
            this.textSucursal.Location = new System.Drawing.Point(24, 184);
            this.textSucursal.Name = "textSucursal";
            this.textSucursal.ReadOnly = true;
            this.textSucursal.Size = new System.Drawing.Size(212, 22);
            this.textSucursal.TabIndex = 31;
            // 
            // textLetra
            // 
            this.textLetra.AutoSize = true;
            this.textLetra.Location = new System.Drawing.Point(21, 229);
            this.textLetra.Name = "textLetra";
            this.textLetra.Size = new System.Drawing.Size(41, 17);
            this.textLetra.TabIndex = 32;
            this.textLetra.Text = "Letra";
            // 
            // textL
            // 
            this.textL.Location = new System.Drawing.Point(24, 249);
            this.textL.Name = "textL";
            this.textL.ReadOnly = true;
            this.textL.Size = new System.Drawing.Size(212, 22);
            this.textL.TabIndex = 33;
            this.textL.TextChanged += new System.EventHandler(this.textL_TextChanged);
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(21, 354);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(36, 17);
            this.labelTipo.TabIndex = 34;
            this.labelTipo.Text = "Tipo";
            // 
            // labelestado
            // 
            this.labelestado.AutoSize = true;
            this.labelestado.Location = new System.Drawing.Point(19, 413);
            this.labelestado.Name = "labelestado";
            this.labelestado.Size = new System.Drawing.Size(52, 17);
            this.labelestado.TabIndex = 36;
            this.labelestado.Text = "Estado";
            // 
            // detalle_rem
            // 
            this.detalle_rem.AutoSize = true;
            this.detalle_rem.Location = new System.Drawing.Point(21, 57);
            this.detalle_rem.Name = "detalle_rem";
            this.detalle_rem.Size = new System.Drawing.Size(95, 17);
            this.detalle_rem.TabIndex = 38;
            this.detalle_rem.Text = "Detalle remito";
            // 
            // BtLimpiarRem
            // 
            this.BtLimpiarRem.Location = new System.Drawing.Point(22, 536);
            this.BtLimpiarRem.Name = "BtLimpiarRem";
            this.BtLimpiarRem.Size = new System.Drawing.Size(97, 42);
            this.BtLimpiarRem.TabIndex = 39;
            this.BtLimpiarRem.Text = "Limpiar";
            this.BtLimpiarRem.UseVisualStyleBackColor = true;
            this.BtLimpiarRem.Click += new System.EventHandler(this.BtLimpiarRem_Click);
            // 
            // btEliminarRem
            // 
            this.btEliminarRem.Location = new System.Drawing.Point(139, 536);
            this.btEliminarRem.Name = "btEliminarRem";
            this.btEliminarRem.Size = new System.Drawing.Size(97, 42);
            this.btEliminarRem.TabIndex = 40;
            this.btEliminarRem.Text = "Cancelar";
            this.btEliminarRem.UseVisualStyleBackColor = true;
            this.btEliminarRem.Click += new System.EventHandler(this.btEliminarRem_Click);
            // 
            // btGuardarRem
            // 
            this.btGuardarRem.BackColor = System.Drawing.Color.LightGreen;
            this.btGuardarRem.Location = new System.Drawing.Point(22, 584);
            this.btGuardarRem.Name = "btGuardarRem";
            this.btGuardarRem.Size = new System.Drawing.Size(205, 46);
            this.btGuardarRem.TabIndex = 41;
            this.btGuardarRem.Text = "Guardar";
            this.btGuardarRem.UseVisualStyleBackColor = false;
            this.btGuardarRem.Click += new System.EventHandler(this.btGuardarRem_Click);
            // 
            // textNro
            // 
            this.textNro.Location = new System.Drawing.Point(24, 313);
            this.textNro.Name = "textNro";
            this.textNro.Size = new System.Drawing.Size(212, 22);
            this.textNro.TabIndex = 42;
            this.textNro.TextChanged += new System.EventHandler(this.textNro_TextChanged);
            this.textNro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNro_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nro";
            // 
            // CB_tipo
            // 
            this.CB_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_tipo.FormattingEnabled = true;
            this.CB_tipo.Location = new System.Drawing.Point(24, 374);
            this.CB_tipo.Name = "CB_tipo";
            this.CB_tipo.Size = new System.Drawing.Size(212, 24);
            this.CB_tipo.TabIndex = 44;
            this.CB_tipo.SelectedIndexChanged += new System.EventHandler(this.CB_tipo_SelectedIndexChanged);
            // 
            // textEstado
            // 
            this.textEstado.Location = new System.Drawing.Point(24, 442);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(212, 22);
            this.textEstado.TabIndex = 45;
            this.textEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEstado_KeyPress);
            // 
            // CB_fact
            // 
            this.CB_fact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_fact.FormattingEnabled = true;
            this.CB_fact.Location = new System.Drawing.Point(22, 496);
            this.CB_fact.Name = "CB_fact";
            this.CB_fact.Size = new System.Drawing.Size(212, 24);
            this.CB_fact.TabIndex = 46;
            // 
            // labelFact
            // 
            this.labelFact.AutoSize = true;
            this.labelFact.Location = new System.Drawing.Point(21, 476);
            this.labelFact.Name = "labelFact";
            this.labelFact.Size = new System.Drawing.Size(56, 17);
            this.labelFact.TabIndex = 47;
            this.labelFact.Text = "Factura";
            // 
            // btnLimpiarBuscador
            // 
            this.btnLimpiarBuscador.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarBuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarBuscador.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarBuscador.IconSize = 20;
            this.btnLimpiarBuscador.Location = new System.Drawing.Point(1071, 49);
            this.btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            this.btnLimpiarBuscador.Size = new System.Drawing.Size(47, 30);
            this.btnLimpiarBuscador.TabIndex = 48;
            this.btnLimpiarBuscador.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpiarBuscador.UseVisualStyleBackColor = false;
            this.btnLimpiarBuscador.Click += new System.EventHandler(this.btnLimpiarBuscador_Click);
            // 
            // Form_Remito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 728);
            this.Controls.Add(this.btnLimpiarBuscador);
            this.Controls.Add(this.labelFact);
            this.Controls.Add(this.CB_fact);
            this.Controls.Add(this.textEstado);
            this.Controls.Add(this.CB_tipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNro);
            this.Controls.Add(this.btGuardarRem);
            this.Controls.Add(this.btEliminarRem);
            this.Controls.Add(this.BtLimpiarRem);
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
        private System.Windows.Forms.Button BtLimpiarRem;
        private System.Windows.Forms.Button btEliminarRem;
        private System.Windows.Forms.Button btGuardarRem;
        private System.Windows.Forms.TextBox textNro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_operación;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Letra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private System.Windows.Forms.TextBox textEstado;
        private System.Windows.Forms.ComboBox CB_fact;
        private System.Windows.Forms.Label labelFact;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
    }
}