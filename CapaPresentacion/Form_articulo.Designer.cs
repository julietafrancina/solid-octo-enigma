
namespace CapaPresentacion
{
    partial class Form_articulo
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
            this.detalle_art = new System.Windows.Forms.Label();
            this.sku = new System.Windows.Forms.Label();
            this.textSKU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textRubro = new System.Windows.Forms.TextBox();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.textCosto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabla_art = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.textBaja = new System.Windows.Forms.Label();
            this.CB_baja = new System.Windows.Forms.ComboBox();
            this.Cb_busqueda = new System.Windows.Forms.ComboBox();
            this.text_buscar_por = new System.Windows.Forms.Label();
            this.text_buscar = new System.Windows.Forms.TextBox();
            this.textDesc = new System.Windows.Forms.TextBox();
            this.Desc = new System.Windows.Forms.Label();
            this.btnBusqueda = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarBuscador = new FontAwesome.Sharp.IconButton();
            this.Boton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_art)).BeginInit();
            this.SuspendLayout();
            // 
            // detalle_art
            // 
            this.detalle_art.AutoSize = true;
            this.detalle_art.BackColor = System.Drawing.Color.WhiteSmoke;
            this.detalle_art.ForeColor = System.Drawing.Color.DimGray;
            this.detalle_art.Location = new System.Drawing.Point(25, 20);
            this.detalle_art.Name = "detalle_art";
            this.detalle_art.Size = new System.Drawing.Size(103, 17);
            this.detalle_art.TabIndex = 0;
            this.detalle_art.Text = "Detalle Artículo";
            // 
            // sku
            // 
            this.sku.AutoSize = true;
            this.sku.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sku.Location = new System.Drawing.Point(25, 62);
            this.sku.Name = "sku";
            this.sku.Size = new System.Drawing.Size(36, 17);
            this.sku.TabIndex = 1;
            this.sku.Text = "SKU";
            // 
            // textSKU
            // 
            this.textSKU.Location = new System.Drawing.Point(28, 82);
            this.textSKU.Name = "textSKU";
            this.textSKU.Size = new System.Drawing.Size(212, 22);
            this.textSKU.TabIndex = 2;
            this.textSKU.TextChanged += new System.EventHandler(this.textSKU_TextChanged);
            this.textSKU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSKU_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(25, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rubro";
            // 
            // textRubro
            // 
            this.textRubro.Location = new System.Drawing.Point(28, 140);
            this.textRubro.Name = "textRubro";
            this.textRubro.Size = new System.Drawing.Size(212, 22);
            this.textRubro.TabIndex = 4;
            this.textRubro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textRubro_KeyPress);
            // 
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(28, 200);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(212, 22);
            this.textMarca.TabIndex = 5;
            this.textMarca.TextChanged += new System.EventHandler(this.textMarca_TextChanged);
            this.textMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMarca_KeyPress);
            // 
            // textCosto
            // 
            this.textCosto.Location = new System.Drawing.Point(28, 327);
            this.textCosto.Name = "textCosto";
            this.textCosto.Size = new System.Drawing.Size(212, 22);
            this.textCosto.TabIndex = 7;
            this.textCosto.TextChanged += new System.EventHandler(this.textCosto_TextChanged);
            this.textCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCosto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(25, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(25, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Costo";
            // 
            // tabla_art
            // 
            this.tabla_art.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabla_art.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_art.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Boton,
            this.Codigo,
            this.Rubro,
            this.Marca,
            this.Descripción,
            this.Costo,
            this.Activo});
            this.tabla_art.Location = new System.Drawing.Point(291, 82);
            this.tabla_art.Name = "tabla_art";
            this.tabla_art.RowHeadersWidth = 51;
            this.tabla_art.RowTemplate.Height = 24;
            this.tabla_art.Size = new System.Drawing.Size(837, 575);
            this.tabla_art.TabIndex = 13;
            this.tabla_art.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_art_CellContentClick);
            this.tabla_art.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.tabla_art_CellPainting);
            // 
            // Código
            // 
            this.Código.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Código.HeaderText = "SKU";
            this.Código.MinimumWidth = 6;
            this.Código.Name = "Código";
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
            // Descripción
            // 
            this.Descripción.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.MinimumWidth = 6;
            this.Descripción.Name = "Descripción";
            // 
            // Costo
            // 
            this.Costo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Costo.HeaderText = "Costo";
            this.Costo.MinimumWidth = 6;
            this.Costo.Name = "Costo";
            // 
            // Activo
            // 
            this.Activo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Activo.HeaderText = "Activo";
            this.Activo.MinimumWidth = 6;
            this.Activo.Name = "Activo";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(287, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Artículos";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBaja
            // 
            this.textBaja.AutoSize = true;
            this.textBaja.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBaja.Location = new System.Drawing.Point(25, 371);
            this.textBaja.Name = "textBaja";
            this.textBaja.Size = new System.Drawing.Size(46, 17);
            this.textBaja.TabIndex = 16;
            this.textBaja.Text = "Activo";
            // 
            // CB_baja
            // 
            this.CB_baja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_baja.FormattingEnabled = true;
            this.CB_baja.Location = new System.Drawing.Point(28, 391);
            this.CB_baja.Name = "CB_baja";
            this.CB_baja.Size = new System.Drawing.Size(212, 24);
            this.CB_baja.TabIndex = 18;
            this.CB_baja.SelectedIndexChanged += new System.EventHandler(this.CB_baja_SelectedIndexChanged);
            // 
            // Cb_busqueda
            // 
            this.Cb_busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cb_busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_busqueda.FormattingEnabled = true;
            this.Cb_busqueda.Location = new System.Drawing.Point(830, 24);
            this.Cb_busqueda.Name = "Cb_busqueda";
            this.Cb_busqueda.Size = new System.Drawing.Size(161, 24);
            this.Cb_busqueda.TabIndex = 19;
            this.Cb_busqueda.SelectedIndexChanged += new System.EventHandler(this.Cb_busqueda_SelectedIndexChanged);
            // 
            // text_buscar_por
            // 
            this.text_buscar_por.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_buscar_por.AutoSize = true;
            this.text_buscar_por.Location = new System.Drawing.Point(727, 40);
            this.text_buscar_por.Name = "text_buscar_por";
            this.text_buscar_por.Size = new System.Drawing.Size(81, 17);
            this.text_buscar_por.TabIndex = 20;
            this.text_buscar_por.Text = "Buscar por:";
            this.text_buscar_por.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_buscar
            // 
            this.text_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_buscar.Location = new System.Drawing.Point(830, 52);
            this.text_buscar.Name = "text_buscar";
            this.text_buscar.Size = new System.Drawing.Size(161, 22);
            this.text_buscar.TabIndex = 21;
            this.text_buscar.TextChanged += new System.EventHandler(this.text_buscar_TextChanged);
            // 
            // textDesc
            // 
            this.textDesc.Location = new System.Drawing.Point(28, 265);
            this.textDesc.Name = "textDesc";
            this.textDesc.Size = new System.Drawing.Size(212, 22);
            this.textDesc.TabIndex = 6;
            this.textDesc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Desc
            // 
            this.Desc.AutoSize = true;
            this.Desc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Desc.Location = new System.Drawing.Point(25, 245);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(82, 17);
            this.Desc.TabIndex = 23;
            this.Desc.Text = "Descripción";
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBusqueda.BackColor = System.Drawing.SystemColors.Control;
            this.btnBusqueda.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBusqueda.IconColor = System.Drawing.Color.Black;
            this.btnBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBusqueda.IconSize = 20;
            this.btnBusqueda.Location = new System.Drawing.Point(997, 22);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(64, 54);
            this.btnBusqueda.TabIndex = 26;
            this.btnBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // btnLimpiarBuscador
            // 
            this.btnLimpiarBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarBuscador.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarBuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarBuscador.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarBuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarBuscador.IconSize = 20;
            this.btnLimpiarBuscador.Location = new System.Drawing.Point(1067, 22);
            this.btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            this.btnLimpiarBuscador.Size = new System.Drawing.Size(64, 54);
            this.btnLimpiarBuscador.TabIndex = 49;
            this.btnLimpiarBuscador.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpiarBuscador.UseVisualStyleBackColor = false;
            this.btnLimpiarBuscador.Click += new System.EventHandler(this.btnLimpiarBuscador_Click);
            // 
            // Boton
            // 
            this.Boton.HeaderText = "";
            this.Boton.MinimumWidth = 6;
            this.Boton.Name = "Boton";
            this.Boton.Width = 40;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "SKU";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // Rubro
            // 
            this.Rubro.HeaderText = "Rubro";
            this.Rubro.MinimumWidth = 6;
            this.Rubro.Name = "Rubro";
            this.Rubro.Width = 125;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.Width = 125;
            // 
            // Descripción
            // 
            this.formUsuarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.formUsuarios.Dock = System.Windows.Forms.DockStyle.Left;
            this.formUsuarios.Location = new System.Drawing.Point(0, 0);
            this.formUsuarios.Name = "formUsuarios";
            this.formUsuarios.Size = new System.Drawing.Size(268, 753);
            this.formUsuarios.TabIndex = 67;
            // 
            // bntGuardar
            // 
            this.bntGuardar.BackColor = System.Drawing.Color.LightGreen;
            this.bntGuardar.IconChar = FontAwesome.Sharp.IconChar.SadCry;
            this.bntGuardar.IconColor = System.Drawing.Color.Black;
            this.bntGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntGuardar.IconSize = 25;
            this.bntGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntGuardar.Location = new System.Drawing.Point(27, 506);
            this.bntGuardar.Name = "bntGuardar";
            this.bntGuardar.Size = new System.Drawing.Size(213, 46);
            this.bntGuardar.TabIndex = 106;
            this.bntGuardar.Text = "Guardar";
            this.bntGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bntGuardar.UseVisualStyleBackColor = false;
            this.bntGuardar.Click += new System.EventHandler(this.byGuardar_Click);
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarDatos.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiarDatos.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarDatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarDatos.IconSize = 20;
            this.btnLimpiarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarDatos.Location = new System.Drawing.Point(28, 454);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(213, 46);
            this.btnLimpiarDatos.TabIndex = 107;
            this.btnLimpiarDatos.Text = "Limpiar";
            this.btnLimpiarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpiarDatos.UseVisualStyleBackColor = false;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.BtEditar_Click);
            // 
            // Form_articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 753);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.bntGuardar);
            this.Controls.Add(this.btnLimpiarBuscador);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.textDesc);
            this.Controls.Add(this.text_buscar);
            this.Controls.Add(this.text_buscar_por);
            this.Controls.Add(this.Cb_busqueda);
            this.Controls.Add(this.CB_baja);
            this.Controls.Add(this.textBaja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabla_art);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textCosto);
            this.Controls.Add(this.textMarca);
            this.Controls.Add(this.textRubro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSKU);
            this.Controls.Add(this.sku);
            this.Controls.Add(this.detalle_art);
            this.Controls.Add(this.formUsuarios);
            this.Name = "Form_articulo";
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.Form_articulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_art)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label detalle_art;
        private System.Windows.Forms.Label sku;
        private System.Windows.Forms.TextBox textSKU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textRubro;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.TextBox textCosto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tabla_art;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label textBaja;
        private System.Windows.Forms.ComboBox CB_baja;
        private System.Windows.Forms.ComboBox Cb_busqueda;
        private System.Windows.Forms.Label text_buscar_por;
        private System.Windows.Forms.TextBox text_buscar;
        private System.Windows.Forms.TextBox textDesc;
        private System.Windows.Forms.Label Desc;
        private FontAwesome.Sharp.IconButton btnBusqueda;
        private FontAwesome.Sharp.IconButton btnLimpiarBuscador;
        private System.Windows.Forms.DataGridViewButtonColumn Boton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.Label formUsuarios;
        private FontAwesome.Sharp.IconButton bntGuardar;
        private FontAwesome.Sharp.IconButton btnLimpiarDatos;
    }
}