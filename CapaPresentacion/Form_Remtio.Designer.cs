
namespace CapaPresentacion
{
    partial class Form_Remtio
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_lista = new System.Windows.Forms.Label();
            this.text_buscar_nroOp = new System.Windows.Forms.Label();
            this.text_buscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(297, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(863, 589);
            this.dataGridView1.TabIndex = 0;
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
            this.text_buscar_nroOp.Location = new System.Drawing.Point(683, 57);
            this.text_buscar_nroOp.Name = "text_buscar_nroOp";
            this.text_buscar_nroOp.Size = new System.Drawing.Size(193, 17);
            this.text_buscar_nroOp.TabIndex = 21;
            this.text_buscar_nroOp.Text = "Buscar por nro de operación:";
            // 
            // text_buscar
            // 
            this.text_buscar.Location = new System.Drawing.Point(882, 52);
            this.text_buscar.Name = "text_buscar";
            this.text_buscar.Size = new System.Drawing.Size(176, 22);
            this.text_buscar.TabIndex = 22;
            // 
            // Form_Remtio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 728);
            this.Controls.Add(this.text_buscar);
            this.Controls.Add(this.text_buscar_nroOp);
            this.Controls.Add(this.label_lista);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_Remtio";
            this.Text = "Form_Remtio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_lista;
        private System.Windows.Forms.Label text_buscar_nroOp;
        private System.Windows.Forms.TextBox text_buscar;
    }
}