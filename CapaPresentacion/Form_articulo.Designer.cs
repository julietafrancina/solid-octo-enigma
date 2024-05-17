
namespace CapaPresentacion
{
    partial class Editar
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
            this.label1 = new System.Windows.Forms.Label();
            this.sku = new System.Windows.Forms.Label();
            this.textSKU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textRubro = new System.Windows.Forms.TextBox();
            this.textMarca = new System.Windows.Forms.TextBox();
            this.textCosto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtEditar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.byGuardar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle artículo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sku
            // 
            this.sku.AutoSize = true;
            this.sku.Location = new System.Drawing.Point(42, 82);
            this.sku.Name = "sku";
            this.sku.Size = new System.Drawing.Size(36, 17);
            this.sku.TabIndex = 1;
            this.sku.Text = "SKU";
            // 
            // textSKU
            // 
            this.textSKU.Location = new System.Drawing.Point(45, 102);
            this.textSKU.Name = "textSKU";
            this.textSKU.Size = new System.Drawing.Size(212, 22);
            this.textSKU.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rubro";
            // 
            // textRubro
            // 
            this.textRubro.Location = new System.Drawing.Point(45, 160);
            this.textRubro.Name = "textRubro";
            this.textRubro.Size = new System.Drawing.Size(212, 22);
            this.textRubro.TabIndex = 4;
            // 
            // textMarca
            // 
            this.textMarca.Location = new System.Drawing.Point(45, 220);
            this.textMarca.Name = "textMarca";
            this.textMarca.Size = new System.Drawing.Size(212, 22);
            this.textMarca.TabIndex = 5;
            // 
            // textCosto
            // 
            this.textCosto.Location = new System.Drawing.Point(45, 274);
            this.textCosto.Name = "textCosto";
            this.textCosto.Size = new System.Drawing.Size(212, 22);
            this.textCosto.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Costo";
            // 
            // BtEditar
            // 
            this.BtEditar.Location = new System.Drawing.Point(45, 329);
            this.BtEditar.Name = "BtEditar";
            this.BtEditar.Size = new System.Drawing.Size(97, 42);
            this.BtEditar.TabIndex = 9;
            this.BtEditar.Text = "Editar\r\n";
            this.BtEditar.UseVisualStyleBackColor = true;
            this.BtEditar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(160, 329);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(97, 42);
            this.btEliminar.TabIndex = 10;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            // 
            // byGuardar
            // 
            this.byGuardar.BackColor = System.Drawing.Color.LightGreen;
            this.byGuardar.Location = new System.Drawing.Point(45, 389);
            this.byGuardar.Name = "byGuardar";
            this.byGuardar.Size = new System.Drawing.Size(205, 46);
            this.byGuardar.TabIndex = 11;
            this.byGuardar.Text = "Guardar";
            this.byGuardar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 22);
            this.textBox1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(286, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(888, 527);
            this.dataGridView1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(286, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(888, 71);
            this.label5.TabIndex = 14;
            this.label5.Text = "Lista de artículos";
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 625);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.byGuardar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.BtEditar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textCosto);
            this.Controls.Add(this.textMarca);
            this.Controls.Add(this.textRubro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSKU);
            this.Controls.Add(this.sku);
            this.Controls.Add(this.label1);
            this.Name = "Editar";
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.Form_articulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sku;
        private System.Windows.Forms.TextBox textSKU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textRubro;
        private System.Windows.Forms.TextBox textMarca;
        private System.Windows.Forms.TextBox textCosto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtEditar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button byGuardar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
    }
}