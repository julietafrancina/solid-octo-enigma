
namespace SistemaDeVentas
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.menuArtículos = new FontAwesome.Sharp.IconMenuItem();
            this.menuPreventas = new FontAwesome.Sharp.IconMenuItem();
            this.menuFacturas = new FontAwesome.Sharp.IconMenuItem();
            this.menuRemitos = new FontAwesome.Sharp.IconMenuItem();
            this.menuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuAyuda = new FontAwesome.Sharp.IconMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usuario = new System.Windows.Forms.Label();
            this.lblUsuarioName = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuArtículos,
            this.menuPreventas,
            this.menuFacturas,
            this.menuRemitos,
            this.menuClientes,
            this.menuAyuda});
            this.menu.Location = new System.Drawing.Point(0, 72);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1114, 78);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.AutoSize = false;
            this.menuUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            this.menuUsuarios.IconColor = System.Drawing.Color.Black;
            this.menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.menuUsuarios.IconSize = 50;
            this.menuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(95, 74);
            this.menuUsuarios.Text = "Usuarios";
            this.menuUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuUsuarios.Click += new System.EventHandler(this.menuUsuarios_Click);
            // 
            // menuArtículos
            // 
            this.menuArtículos.AutoSize = false;
            this.menuArtículos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuArtículos.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            this.menuArtículos.IconColor = System.Drawing.Color.Black;
            this.menuArtículos.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.menuArtículos.IconSize = 50;
            this.menuArtículos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuArtículos.Name = "menuArtículos";
            this.menuArtículos.Size = new System.Drawing.Size(95, 74);
            this.menuArtículos.Text = "Artículos";
            this.menuArtículos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuArtículos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuArtículos.Click += new System.EventHandler(this.menuArtículos_Click);
            // 
            // menuPreventas
            // 
            this.menuPreventas.AutoSize = false;
            this.menuPreventas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuPreventas.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.menuPreventas.IconColor = System.Drawing.Color.Black;
            this.menuPreventas.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.menuPreventas.IconSize = 50;
            this.menuPreventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuPreventas.Name = "menuPreventas";
            this.menuPreventas.Size = new System.Drawing.Size(95, 74);
            this.menuPreventas.Text = "Preventas";
            this.menuPreventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuPreventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuFacturas
            // 
            this.menuFacturas.AutoSize = false;
            this.menuFacturas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuFacturas.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.menuFacturas.IconColor = System.Drawing.Color.Black;
            this.menuFacturas.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.menuFacturas.IconSize = 50;
            this.menuFacturas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuFacturas.Name = "menuFacturas";
            this.menuFacturas.Size = new System.Drawing.Size(95, 74);
            this.menuFacturas.Text = "Facturas";
            this.menuFacturas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuFacturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuRemitos
            // 
            this.menuRemitos.AutoSize = false;
            this.menuRemitos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuRemitos.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.menuRemitos.IconColor = System.Drawing.Color.Black;
            this.menuRemitos.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.menuRemitos.IconSize = 50;
            this.menuRemitos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuRemitos.Name = "menuRemitos";
            this.menuRemitos.Size = new System.Drawing.Size(95, 74);
            this.menuRemitos.Text = "Remitos";
            this.menuRemitos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuRemitos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuClientes
            // 
            this.menuClientes.AutoSize = false;
            this.menuClientes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuClientes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.menuClientes.IconColor = System.Drawing.Color.Black;
            this.menuClientes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.menuClientes.IconSize = 50;
            this.menuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(95, 74);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuAyuda
            // 
            this.menuAyuda.AutoSize = false;
            this.menuAyuda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuAyuda.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menuAyuda.IconColor = System.Drawing.Color.Black;
            this.menuAyuda.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.menuAyuda.IconSize = 50;
            this.menuAyuda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAyuda.Name = "menuAyuda";
            this.menuAyuda.Size = new System.Drawing.Size(95, 74);
            this.menuAyuda.Text = "Ayuda";
            this.menuAyuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Ventas";
            // 
            // contenedor
            // 
            this.contenedor.AccessibleName = "contenedor";
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 150);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1114, 389);
            this.contenedor.TabIndex = 3;
            this.contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.contenedor_Paint);
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.Firebrick;
            this.menuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1114, 72);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Firebrick;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(938, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 72);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // usuario
            // 
            this.usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usuario.AutoSize = true;
            this.usuario.BackColor = System.Drawing.Color.Firebrick;
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.ForeColor = System.Drawing.Color.White;
            this.usuario.Location = new System.Drawing.Point(699, 44);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(80, 20);
            this.usuario.TabIndex = 6;
            this.usuario.Text = "Usuario:";
            // 
            // lblUsuarioName
            // 
            this.lblUsuarioName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioName.AutoSize = true;
            this.lblUsuarioName.BackColor = System.Drawing.Color.Firebrick;
            this.lblUsuarioName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioName.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioName.Location = new System.Drawing.Point(772, 44);
            this.lblUsuarioName.Name = "lblUsuarioName";
            this.lblUsuarioName.Size = new System.Drawing.Size(142, 20);
            this.lblUsuarioName.TabIndex = 7;
            this.lblUsuarioName.Text = "lblUsuarioName";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 539);
            this.Controls.Add(this.lblUsuarioName);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load_1);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuArtículos;
        private FontAwesome.Sharp.IconMenuItem menuPreventas;
        private FontAwesome.Sharp.IconMenuItem menuFacturas;
        private FontAwesome.Sharp.IconMenuItem menuRemitos;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuAyuda;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label lblUsuarioName;
    }
}

