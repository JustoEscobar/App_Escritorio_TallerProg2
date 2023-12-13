namespace CapaPresentacion
{
    partial class FRMventas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_tipodocumento = new System.Windows.Forms.ComboBox();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_buscar_cliente = new FontAwesome.Sharp.IconButton();
            this.txt_nombre_cliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_doc_cliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numeric_cantidad = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.btn_buscarproducto = new FontAwesome.Sharp.IconButton();
            this.txt_idproducto = new System.Windows.Forms.TextBox();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_codproducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_agregar = new FontAwesome.Sharp.IconButton();
            this.dgvdataventa = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_totalpagar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_pago = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_cambio = new System.Windows.Forms.TextBox();
            this.btn_registrarventa = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataventa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(194, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "REGISTRAR VENTA";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(175, 9);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.label10.Size = new System.Drawing.Size(694, 469);
            this.label10.TabIndex = 26;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbo_tipodocumento);
            this.groupBox1.Controls.Add(this.txt_fecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(198, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 87);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo Documento:";
            // 
            // cbo_tipodocumento
            // 
            this.cbo_tipodocumento.FormattingEnabled = true;
            this.cbo_tipodocumento.Location = new System.Drawing.Point(138, 36);
            this.cbo_tipodocumento.Name = "cbo_tipodocumento";
            this.cbo_tipodocumento.Size = new System.Drawing.Size(140, 24);
            this.cbo_tipodocumento.TabIndex = 2;
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(6, 39);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(121, 21);
            this.txt_fecha.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btn_buscar_cliente);
            this.groupBox2.Controls.Add(this.txt_nombre_cliente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_doc_cliente);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(504, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 87);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Cliente";
            // 
            // btn_buscar_cliente
            // 
            this.btn_buscar_cliente.BackColor = System.Drawing.Color.White;
            this.btn_buscar_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar_cliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_buscar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_cliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_cliente.ForeColor = System.Drawing.Color.White;
            this.btn_buscar_cliente.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btn_buscar_cliente.IconColor = System.Drawing.Color.Black;
            this.btn_buscar_cliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_buscar_cliente.IconSize = 16;
            this.btn_buscar_cliente.Location = new System.Drawing.Point(149, 36);
            this.btn_buscar_cliente.Name = "btn_buscar_cliente";
            this.btn_buscar_cliente.Size = new System.Drawing.Size(30, 21);
            this.btn_buscar_cliente.TabIndex = 29;
            this.btn_buscar_cliente.UseVisualStyleBackColor = false;
            this.btn_buscar_cliente.Click += new System.EventHandler(this.btn_buscar_cliente_Click);
            // 
            // txt_nombre_cliente
            // 
            this.txt_nombre_cliente.Location = new System.Drawing.Point(188, 36);
            this.txt_nombre_cliente.Name = "txt_nombre_cliente";
            this.txt_nombre_cliente.Size = new System.Drawing.Size(136, 21);
            this.txt_nombre_cliente.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre completo:";
            // 
            // txt_doc_cliente
            // 
            this.txt_doc_cliente.Location = new System.Drawing.Point(6, 36);
            this.txt_doc_cliente.Name = "txt_doc_cliente";
            this.txt_doc_cliente.Size = new System.Drawing.Size(136, 21);
            this.txt_doc_cliente.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nro Documento:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.numeric_cantidad);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_stock);
            this.groupBox3.Controls.Add(this.txt_precio);
            this.groupBox3.Controls.Add(this.btn_buscarproducto);
            this.groupBox3.Controls.Add(this.txt_idproducto);
            this.groupBox3.Controls.Add(this.txt_producto);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_codproducto);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(198, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(647, 87);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información de Producto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(553, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Cantidad:";
            // 
            // numeric_cantidad
            // 
            this.numeric_cantidad.Location = new System.Drawing.Point(556, 52);
            this.numeric_cantidad.Name = "numeric_cantidad";
            this.numeric_cantidad.Size = new System.Drawing.Size(81, 21);
            this.numeric_cantidad.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(461, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Stock:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Precio:";
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(462, 52);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(88, 21);
            this.txt_stock.TabIndex = 32;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(367, 53);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(88, 21);
            this.txt_precio.TabIndex = 31;
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_KeyPress);
            // 
            // btn_buscarproducto
            // 
            this.btn_buscarproducto.BackColor = System.Drawing.Color.White;
            this.btn_buscarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscarproducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_buscarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscarproducto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarproducto.ForeColor = System.Drawing.Color.White;
            this.btn_buscarproducto.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btn_buscarproducto.IconColor = System.Drawing.Color.Black;
            this.btn_buscarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_buscarproducto.IconSize = 16;
            this.btn_buscarproducto.Location = new System.Drawing.Point(152, 53);
            this.btn_buscarproducto.Name = "btn_buscarproducto";
            this.btn_buscarproducto.Size = new System.Drawing.Size(30, 21);
            this.btn_buscarproducto.TabIndex = 30;
            this.btn_buscarproducto.UseVisualStyleBackColor = false;
            this.btn_buscarproducto.Click += new System.EventHandler(this.btn_buscarproducto_Click);
            // 
            // txt_idproducto
            // 
            this.txt_idproducto.Location = new System.Drawing.Point(115, 29);
            this.txt_idproducto.Name = "txt_idproducto";
            this.txt_idproducto.Size = new System.Drawing.Size(27, 21);
            this.txt_idproducto.TabIndex = 5;
            this.txt_idproducto.Visible = false;
            // 
            // txt_producto
            // 
            this.txt_producto.Location = new System.Drawing.Point(188, 53);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(173, 21);
            this.txt_producto.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Producto:";
            // 
            // txt_codproducto
            // 
            this.txt_codproducto.Location = new System.Drawing.Point(6, 53);
            this.txt_codproducto.Name = "txt_codproducto";
            this.txt_codproducto.Size = new System.Drawing.Size(136, 21);
            this.txt_codproducto.TabIndex = 1;
            this.txt_codproducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_codproducto_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cod. Producto:";
            // 
            // btn_agregar
            // 
            this.btn_agregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btn_agregar.IconColor = System.Drawing.Color.ForestGreen;
            this.btn_agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_agregar.IconSize = 40;
            this.btn_agregar.Location = new System.Drawing.Point(757, 243);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(88, 56);
            this.btn_agregar.TabIndex = 35;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dgvdataventa
            // 
            this.dgvdataventa.AllowUserToAddRows = false;
            this.dgvdataventa.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdataventa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdataventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdataventa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.SubTotal,
            this.btn_eliminar});
            this.dgvdataventa.Location = new System.Drawing.Point(198, 243);
            this.dgvdataventa.MultiSelect = false;
            this.dgvdataventa.Name = "dgvdataventa";
            this.dgvdataventa.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdataventa.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdataventa.RowTemplate.Height = 28;
            this.dgvdataventa.Size = new System.Drawing.Size(550, 219);
            this.dgvdataventa.TabIndex = 34;
            this.dgvdataventa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdataventa_CellContentClick);
            this.dgvdataventa.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdataventa_CellPainting);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 120;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.HeaderText = "";
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.ReadOnly = true;
            this.btn_eliminar.Width = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(754, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 16);
            this.label12.TabIndex = 40;
            this.label12.Text = "Total a Pagar:";
            // 
            // txt_totalpagar
            // 
            this.txt_totalpagar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_totalpagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_totalpagar.Location = new System.Drawing.Point(759, 321);
            this.txt_totalpagar.Name = "txt_totalpagar";
            this.txt_totalpagar.Size = new System.Drawing.Size(88, 20);
            this.txt_totalpagar.TabIndex = 39;
            this.txt_totalpagar.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(756, 344);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 38;
            this.label13.Text = "Paga con:";
            // 
            // txt_pago
            // 
            this.txt_pago.Location = new System.Drawing.Point(757, 362);
            this.txt_pago.Name = "txt_pago";
            this.txt_pago.Size = new System.Drawing.Size(88, 20);
            this.txt_pago.TabIndex = 37;
            this.txt_pago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pago_KeyDown);
            this.txt_pago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pago_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(756, 385);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 16);
            this.label14.TabIndex = 42;
            this.label14.Text = "Cambio:";
            // 
            // txt_cambio
            // 
            this.txt_cambio.Location = new System.Drawing.Point(757, 403);
            this.txt_cambio.Name = "txt_cambio";
            this.txt_cambio.Size = new System.Drawing.Size(88, 20);
            this.txt_cambio.TabIndex = 41;
            // 
            // btn_registrarventa
            // 
            this.btn_registrarventa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrarventa.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.btn_registrarventa.IconColor = System.Drawing.Color.DodgerBlue;
            this.btn_registrarventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_registrarventa.IconSize = 22;
            this.btn_registrarventa.Location = new System.Drawing.Point(757, 431);
            this.btn_registrarventa.Name = "btn_registrarventa";
            this.btn_registrarventa.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btn_registrarventa.Size = new System.Drawing.Size(88, 31);
            this.btn_registrarventa.TabIndex = 43;
            this.btn_registrarventa.Text = "Venta";
            this.btn_registrarventa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_registrarventa.UseVisualStyleBackColor = true;
            this.btn_registrarventa.Click += new System.EventHandler(this.btn_registrarventa_Click);
            // 
            // FRMventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 487);
            this.Controls.Add(this.btn_registrarventa);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_cambio);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_pago);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_totalpagar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.dgvdataventa);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Name = "FRMventas";
            this.Text = "FRMventas";
            this.Load += new System.EventHandler(this.FRMventas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataventa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_tipodocumento;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btn_buscar_cliente;
        private System.Windows.Forms.TextBox txt_nombre_cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_doc_cliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numeric_cantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_precio;
        private FontAwesome.Sharp.IconButton btn_buscarproducto;
        private System.Windows.Forms.TextBox txt_idproducto;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_codproducto;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btn_agregar;
        private System.Windows.Forms.DataGridView dgvdataventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btn_eliminar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_totalpagar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_pago;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_cambio;
        private FontAwesome.Sharp.IconButton btn_registrarventa;
    }
}