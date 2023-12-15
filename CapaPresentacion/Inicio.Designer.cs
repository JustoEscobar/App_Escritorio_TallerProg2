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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
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
            this.submenu_negocio = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ventas = new FontAwesome.Sharp.IconMenuItem();
            this.submenu_registrar_venta = new FontAwesome.Sharp.IconMenuItem();
            this.submenu_verdetalle = new FontAwesome.Sharp.IconMenuItem();
            this.menu_compras = new FontAwesome.Sharp.IconMenuItem();
            this.submenu_registrar_compra = new FontAwesome.Sharp.IconMenuItem();
            this.submenu_ver_detalle_compra = new FontAwesome.Sharp.IconMenuItem();
            this.menu_clientes = new FontAwesome.Sharp.IconMenuItem();
            this.menu_proveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menu_reportes = new FontAwesome.Sharp.IconMenuItem();
            this.submenu_reporteCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_reporteVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_estadisticas = new FontAwesome.Sharp.IconMenuItem();
            this.ventasPorPrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficoBarrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_backup = new FontAwesome.Sharp.IconMenuItem();
            this.menu_acercade = new FontAwesome.Sharp.IconMenuItem();
            this.btn_salir = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contenidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.índiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rehacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.seleccionartodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarcomoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistapreviadeimpresiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_titulo
            // 
            this.menu_titulo.AutoSize = false;
            this.menu_titulo.BackColor = System.Drawing.Color.Orange;
            this.menu_titulo.Location = new System.Drawing.Point(0, 0);
            this.menu_titulo.Name = "menu_titulo";
            this.menu_titulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu_titulo.Size = new System.Drawing.Size(1244, 60);
            this.menu_titulo.TabIndex = 1;
            this.menu_titulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(86, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "SISTEMA DE VENTAS - NUTRICIÓN INTEGRAL";
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.White;
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contenedor.Location = new System.Drawing.Point(0, 131);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1244, 538);
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
            this.menu.GripMargin = new System.Windows.Forms.Padding(2);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_usuario,
            this.menu_mantenedor,
            this.menu_ventas,
            this.menu_compras,
            this.menu_clientes,
            this.menu_proveedores,
            this.menu_reportes,
            this.menu_estadisticas,
            this.menu_backup,
            this.menu_acercade});
            this.menu.Location = new System.Drawing.Point(0, 60);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1244, 71);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menu_usuario
            // 
            this.menu_usuario.AutoSize = false;
            this.menu_usuario.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.menu_usuario.IconColor = System.Drawing.Color.Black;
            this.menu_usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_usuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_usuario.Margin = new System.Windows.Forms.Padding(200, 0, 0, 0);
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
            this.menu_mantenedor.Size = new System.Drawing.Size(80, 67);
            this.menu_mantenedor.Text = "Mantenedor";
            this.menu_mantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenu_categoria
            // 
            this.submenu_categoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenu_categoria.IconColor = System.Drawing.Color.Black;
            this.submenu_categoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenu_categoria.Name = "submenu_categoria";
            this.submenu_categoria.Size = new System.Drawing.Size(125, 22);
            this.submenu_categoria.Text = "Categoria";
            this.submenu_categoria.Click += new System.EventHandler(this.iconMenuItem1_Click);
            // 
            // submenu_producto
            // 
            this.submenu_producto.Name = "submenu_producto";
            this.submenu_producto.Size = new System.Drawing.Size(125, 22);
            this.submenu_producto.Text = "Producto";
            this.submenu_producto.Click += new System.EventHandler(this.submenu_producto_Click);
            // 
            // submenu_negocio
            // 
            this.submenu_negocio.Name = "submenu_negocio";
            this.submenu_negocio.Size = new System.Drawing.Size(125, 22);
            this.submenu_negocio.Text = "Negocio";
            this.submenu_negocio.Click += new System.EventHandler(this.submenu_negocio_Click);
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
            this.menu_ventas.Size = new System.Drawing.Size(80, 67);
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
            this.menu_compras.Size = new System.Drawing.Size(80, 67);
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
            this.menu_proveedores.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
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
            this.menu_reportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_reporteCompras,
            this.submenu_reporteVentas});
            this.menu_reportes.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.menu_reportes.IconColor = System.Drawing.Color.Black;
            this.menu_reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_reportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_reportes.Name = "menu_reportes";
            this.menu_reportes.Size = new System.Drawing.Size(80, 67);
            this.menu_reportes.Text = "Reportes";
            this.menu_reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenu_reporteCompras
            // 
            this.submenu_reporteCompras.Name = "submenu_reporteCompras";
            this.submenu_reporteCompras.Size = new System.Drawing.Size(164, 22);
            this.submenu_reporteCompras.Text = "Reporte compras";
            this.submenu_reporteCompras.Click += new System.EventHandler(this.submenu_reporteCompras_Click);
            // 
            // submenu_reporteVentas
            // 
            this.submenu_reporteVentas.Name = "submenu_reporteVentas";
            this.submenu_reporteVentas.Size = new System.Drawing.Size(164, 22);
            this.submenu_reporteVentas.Text = "Reporte ventas";
            this.submenu_reporteVentas.Click += new System.EventHandler(this.submenu_reporteVentas_Click);
            // 
            // menu_estadisticas
            // 
            this.menu_estadisticas.AutoSize = false;
            this.menu_estadisticas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasPorPrToolStripMenuItem,
            this.graficoBarrasToolStripMenuItem});
            this.menu_estadisticas.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.menu_estadisticas.IconColor = System.Drawing.Color.Black;
            this.menu_estadisticas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_estadisticas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_estadisticas.Name = "menu_estadisticas";
            this.menu_estadisticas.Size = new System.Drawing.Size(122, 67);
            this.menu_estadisticas.Text = "Estadisticas";
            this.menu_estadisticas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_estadisticas.Click += new System.EventHandler(this.menu_estadisticas_Click);
            // 
            // ventasPorPrToolStripMenuItem
            // 
            this.ventasPorPrToolStripMenuItem.Name = "ventasPorPrToolStripMenuItem";
            this.ventasPorPrToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.ventasPorPrToolStripMenuItem.Text = "Grafico de torta";
            // 
            // graficoBarrasToolStripMenuItem
            // 
            this.graficoBarrasToolStripMenuItem.Name = "graficoBarrasToolStripMenuItem";
            this.graficoBarrasToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.graficoBarrasToolStripMenuItem.Text = "Grafico barras";
            // 
            // menu_backup
            // 
            this.menu_backup.AutoSize = false;
            this.menu_backup.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.menu_backup.IconColor = System.Drawing.Color.Black;
            this.menu_backup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menu_backup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_backup.Name = "menu_backup";
            this.menu_backup.Size = new System.Drawing.Size(80, 67);
            this.menu_backup.Text = "BackUp";
            this.menu_backup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu_backup.Click += new System.EventHandler(this.menu_backup_Click);
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
            this.menu_acercade.Click += new System.EventHandler(this.menu_acercade_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Orange;
            this.btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_salir.IconColor = System.Drawing.Color.Black;
            this.btn_salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_salir.IconSize = 45;
            this.btn_salir.Location = new System.Drawing.Point(1175, 2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(62, 55);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Orange;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // contenidoToolStripMenuItem
            // 
            this.contenidoToolStripMenuItem.Name = "contenidoToolStripMenuItem";
            this.contenidoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.contenidoToolStripMenuItem.Text = "&Contenido";
            // 
            // índiceToolStripMenuItem
            // 
            this.índiceToolStripMenuItem.Name = "índiceToolStripMenuItem";
            this.índiceToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.índiceToolStripMenuItem.Text = "Índic&e";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.buscarToolStripMenuItem.Text = "&Buscar";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 6);
            // 
            // acercadeToolStripMenuItem
            // 
            this.acercadeToolStripMenuItem.Name = "acercadeToolStripMenuItem";
            this.acercadeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.acercadeToolStripMenuItem.Text = "&Acerca de...";
            // 
            // personalizarToolStripMenuItem
            // 
            this.personalizarToolStripMenuItem.Name = "personalizarToolStripMenuItem";
            this.personalizarToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.personalizarToolStripMenuItem.Text = "&Personalizar";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.opcionesToolStripMenuItem.Text = "&Opciones";
            // 
            // deshacerToolStripMenuItem
            // 
            this.deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem";
            this.deshacerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.deshacerToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.deshacerToolStripMenuItem.Text = "&Deshacer";
            // 
            // rehacerToolStripMenuItem
            // 
            this.rehacerToolStripMenuItem.Name = "rehacerToolStripMenuItem";
            this.rehacerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.rehacerToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.rehacerToolStripMenuItem.Text = "&Rehacer";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cortarToolStripMenuItem.Image")));
            this.cortarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.cortarToolStripMenuItem.Text = "Cor&tar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripMenuItem.Image")));
            this.copiarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.copiarToolStripMenuItem.Text = "&Copiar";
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pegarToolStripMenuItem.Image")));
            this.pegarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.pegarToolStripMenuItem.Text = "&Pegar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 6);
            // 
            // seleccionartodoToolStripMenuItem
            // 
            this.seleccionartodoToolStripMenuItem.Name = "seleccionartodoToolStripMenuItem";
            this.seleccionartodoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.seleccionartodoToolStripMenuItem.Text = "&Seleccionar todo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.nuevoToolStripMenuItem.Text = "&Nuevo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            this.abrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.abrirToolStripMenuItem.Text = "&Abrir";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 6);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            this.guardarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.guardarToolStripMenuItem.Text = "&Guardar";
            // 
            // guardarcomoToolStripMenuItem
            // 
            this.guardarcomoToolStripMenuItem.Name = "guardarcomoToolStripMenuItem";
            this.guardarcomoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.guardarcomoToolStripMenuItem.Text = "G&uardar como";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripMenuItem.Image")));
            this.imprimirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.imprimirToolStripMenuItem.Text = "&Imprimir";
            // 
            // vistapreviadeimpresiónToolStripMenuItem
            // 
            this.vistapreviadeimpresiónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vistapreviadeimpresiónToolStripMenuItem.Image")));
            this.vistapreviadeimpresiónToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.vistapreviadeimpresiónToolStripMenuItem.Name = "vistapreviadeimpresiónToolStripMenuItem";
            this.vistapreviadeimpresiónToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.vistapreviadeimpresiónToolStripMenuItem.Text = "&Vista previa de impresión";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.salirToolStripMenuItem.Text = "&Salir";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 669);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_salir);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem submenu_registrar_venta;
        private FontAwesome.Sharp.IconMenuItem submenu_verdetalle;
        private FontAwesome.Sharp.IconMenuItem submenu_registrar_compra;
        private FontAwesome.Sharp.IconMenuItem submenu_ver_detalle_compra;
        private System.Windows.Forms.ToolStripMenuItem submenu_negocio;
        private System.Windows.Forms.ToolStripMenuItem submenu_reporteCompras;
        private System.Windows.Forms.ToolStripMenuItem submenu_reporteVentas;
        private FontAwesome.Sharp.IconButton btn_salir;
        private FontAwesome.Sharp.IconMenuItem menu_backup;
        private FontAwesome.Sharp.IconMenuItem menu_estadisticas;
        private FontAwesome.Sharp.IconMenuItem menu_acercade;
        private System.Windows.Forms.ToolStripMenuItem ventasPorPrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficoBarrasToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem contenidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem índiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem acercadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deshacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rehacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem seleccionartodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarcomoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vistapreviadeimpresiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

