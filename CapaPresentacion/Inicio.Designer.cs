namespace CapaPresentacion
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
            this.menu_titulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menu_usuario = new FontAwesome.Sharp.IconMenuItem();
            this.menu_mantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.submenu_categoria = new FontAwesome.Sharp.IconMenuItem();
            this.submenu_producto = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ventas = new FontAwesome.Sharp.IconMenuItem();
            this.submenu_registrar_venta = new FontAwesome.Sharp.IconMenuItem();
            this.submenu_verdetalle = new FontAwesome.Sharp.IconMenuItem();
            this.menu_compras = new FontAwesome.Sharp.IconMenuItem();
            this.submenu_registrar_compra = new FontAwesome.Sharp.IconMenuItem();
            this.submenu_ver_detalle_compra = new FontAwesome.Sharp.IconMenuItem();
            this.menu_clientes = new FontAwesome.Sharp.IconMenuItem();
            this.menu_proveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menu_reportes = new FontAwesome.Sharp.IconMenuItem();
            this.menu_acercade = new FontAwesome.Sharp.IconMenuItem();
            this.submenu_negocio = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_titulo
            // 
            this.menu_titulo.AutoSize = false;
            this.menu_titulo.BackColor = System.Drawing.Color.Orange;
            this.menu_titulo.Location = new System.Drawing.Point(0, 0);
            this.menu_titulo.Name = "menu_titulo";
            this.menu_titulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu_titulo.Size = new System.Drawing.Size(1244, 45);
            this.menu_titulo.TabIndex = 1;
            this.menu_titulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "NUTRICIÓN INTEGRAL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contenedor.Location = new System.Drawing.Point(0, 116);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1244, 553);
            this.contenedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1032, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "USUARIO:";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Orange;
            this.lblusuario.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(1081, 18);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(57, 13);
            this.lblusuario.TabIndex = 5;
            this.lblusuario.Text = "lblusuario";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_usuario,
            this.menu_mantenedor,
            this.menu_ventas,
            this.menu_compras,
            this.menu_clientes,
            this.menu_proveedores,
            this.menu_reportes,
            this.menu_acercade});
            this.menu.Location = new System.Drawing.Point(0, 45);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1244, 71);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menu_usuario
            // 
            this.menu_usuario.AutoSize = false;
            this.menu_usuario.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.menu_usuario.IconColor = System.Drawing.Color.Black;
            this.menu_usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_usuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_usuario.Name = "menu_usuario";
            this.menu_usuario.Size = new System.Drawing.Size(80, 67);
            this.menu_usuario.Text = "Usuarios";
            this.menu_usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_usuario.Click += new System.EventHandler(this.menu_usuario_Click);
            // 
            // menu_mantenedor
            // 
            this.menu_mantenedor.AutoSize = false;
            this.menu_mantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_categoria,
            this.submenu_producto,
            this.submenu_negocio});
            this.menu_mantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.menu_mantenedor.IconColor = System.Drawing.Color.Black;
            this.menu_mantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_mantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_mantenedor.Name = "menu_mantenedor";
            this.menu_mantenedor.Size = new System.Drawing.Size(122, 67);
            this.menu_mantenedor.Text = "Mantenedor";
            this.menu_mantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_mantenedor.Click += new System.EventHandler(this.iconMenuItem4_Click);
            // 
            // submenu_categoria
            // 
            this.submenu_categoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenu_categoria.IconColor = System.Drawing.Color.Black;
            this.submenu_categoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenu_categoria.Name = "submenu_categoria";
            this.submenu_categoria.Size = new System.Drawing.Size(180, 22);
            this.submenu_categoria.Text = "Categoria";
            this.submenu_categoria.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // submenu_producto
            // 
            this.submenu_producto.Name = "submenu_producto";
            this.submenu_producto.Size = new System.Drawing.Size(180, 22);
            this.submenu_producto.Text = "Producto";
            this.submenu_producto.Click += new System.EventHandler(this.submenu_producto_Click);
            // 
            // menu_ventas
            // 
            this.menu_ventas.AutoSize = false;
            this.menu_ventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_registrar_venta,
            this.submenu_verdetalle});
            this.menu_ventas.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.menu_ventas.IconColor = System.Drawing.Color.Black;
            this.menu_ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_ventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_ventas.Name = "menu_ventas";
            this.menu_ventas.Size = new System.Drawing.Size(122, 67);
            this.menu_ventas.Text = "Ventas";
            this.menu_ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_ventas.Click += new System.EventHandler(this.menu_ventas_Click);
            // 
            // submenu_registrar_venta
            // 
            this.submenu_registrar_venta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenu_registrar_venta.IconColor = System.Drawing.Color.Black;
            this.submenu_registrar_venta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenu_registrar_venta.Name = "submenu_registrar_venta";
            this.submenu_registrar_venta.Size = new System.Drawing.Size(128, 22);
            this.submenu_registrar_venta.Text = "Registrar";
            this.submenu_registrar_venta.Click += new System.EventHandler(this.submenu_registrar_venta_Click);
            // 
            // submenu_verdetalle
            // 
            this.submenu_verdetalle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenu_verdetalle.IconColor = System.Drawing.Color.Black;
            this.submenu_verdetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenu_verdetalle.Name = "submenu_verdetalle";
            this.submenu_verdetalle.Size = new System.Drawing.Size(128, 22);
            this.submenu_verdetalle.Text = "Ver detalle";
            this.submenu_verdetalle.Click += new System.EventHandler(this.submenu_verdetalle_Click);
            // 
            // menu_compras
            // 
            this.menu_compras.AutoSize = false;
            this.menu_compras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_registrar_compra,
            this.submenu_ver_detalle_compra});
            this.menu_compras.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.menu_compras.IconColor = System.Drawing.Color.Black;
            this.menu_compras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_compras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_compras.Name = "menu_compras";
            this.menu_compras.Size = new System.Drawing.Size(122, 67);
            this.menu_compras.Text = "Compras";
            this.menu_compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenu_registrar_compra
            // 
            this.submenu_registrar_compra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenu_registrar_compra.IconColor = System.Drawing.Color.Black;
            this.submenu_registrar_compra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenu_registrar_compra.Name = "submenu_registrar_compra";
            this.submenu_registrar_compra.Size = new System.Drawing.Size(128, 22);
            this.submenu_registrar_compra.Text = "Registrar";
            this.submenu_registrar_compra.Click += new System.EventHandler(this.submenu_registrar_compra_Click);
            // 
            // submenu_ver_detalle_compra
            // 
            this.submenu_ver_detalle_compra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenu_ver_detalle_compra.IconColor = System.Drawing.Color.Black;
            this.submenu_ver_detalle_compra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenu_ver_detalle_compra.Name = "submenu_ver_detalle_compra";
            this.submenu_ver_detalle_compra.Size = new System.Drawing.Size(128, 22);
            this.submenu_ver_detalle_compra.Text = "Ver detalle";
            this.submenu_ver_detalle_compra.Click += new System.EventHandler(this.submenu_ver_detalle_compra_Click);
            // 
            // menu_clientes
            // 
            this.menu_clientes.AutoSize = false;
            this.menu_clientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.menu_clientes.IconColor = System.Drawing.Color.Black;
            this.menu_clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_clientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_clientes.Name = "menu_clientes";
            this.menu_clientes.Size = new System.Drawing.Size(80, 67);
            this.menu_clientes.Text = "Clientes";
            this.menu_clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_clientes.Click += new System.EventHandler(this.menu_clientes_Click);
            // 
            // menu_proveedores
            // 
            this.menu_proveedores.AutoSize = false;
            this.menu_proveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menu_proveedores.IconColor = System.Drawing.Color.Black;
            this.menu_proveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_proveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_proveedores.Name = "menu_proveedores";
            this.menu_proveedores.Size = new System.Drawing.Size(80, 67);
            this.menu_proveedores.Text = "Proveedores";
            this.menu_proveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_proveedores.Click += new System.EventHandler(this.menu_proveedores_Click);
            // 
            // menu_reportes
            // 
            this.menu_reportes.AutoSize = false;
            this.menu_reportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.menu_reportes.IconColor = System.Drawing.Color.Black;
            this.menu_reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_reportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_reportes.Name = "menu_reportes";
            this.menu_reportes.Size = new System.Drawing.Size(80, 67);
            this.menu_reportes.Text = "Reportes";
            this.menu_reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_reportes.Click += new System.EventHandler(this.menu_reportes_Click);
            // 
            // menu_acercade
            // 
            this.menu_acercade.AutoSize = false;
            this.menu_acercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menu_acercade.IconColor = System.Drawing.Color.Black;
            this.menu_acercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_acercade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_acercade.Name = "menu_acercade";
            this.menu_acercade.Size = new System.Drawing.Size(80, 67);
            this.menu_acercade.Text = "Acerca de";
            this.menu_acercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenu_negocio
            // 
            this.submenu_negocio.Name = "submenu_negocio";
            this.submenu_negocio.Size = new System.Drawing.Size(180, 22);
            this.submenu_negocio.Text = "Negocio";
            this.submenu_negocio.Click += new System.EventHandler(this.submenu_negocio_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 669);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menu_titulo);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu_titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblusuario;
        private FontAwesome.Sharp.IconMenuItem menu_usuario;
        private FontAwesome.Sharp.IconMenuItem menu_mantenedor;
        private FontAwesome.Sharp.IconMenuItem submenu_categoria;
        private System.Windows.Forms.ToolStripMenuItem submenu_producto;
        private FontAwesome.Sharp.IconMenuItem menu_ventas;
        private FontAwesome.Sharp.IconMenuItem menu_compras;
        private FontAwesome.Sharp.IconMenuItem menu_clientes;
        private FontAwesome.Sharp.IconMenuItem menu_proveedores;
        private FontAwesome.Sharp.IconMenuItem menu_reportes;
        private FontAwesome.Sharp.IconMenuItem menu_acercade;
        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem submenu_registrar_venta;
        private FontAwesome.Sharp.IconMenuItem submenu_verdetalle;
        private FontAwesome.Sharp.IconMenuItem submenu_registrar_compra;
        private FontAwesome.Sharp.IconMenuItem submenu_ver_detalle_compra;
        private System.Windows.Forms.ToolStripMenuItem submenu_negocio;
    }
}

