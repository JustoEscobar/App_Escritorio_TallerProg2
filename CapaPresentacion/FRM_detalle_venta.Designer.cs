namespace CapaPresentacion
{
    partial class FRM_detalle_venta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_buscar_dc = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_doc_detalle = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_limpiar_buscador = new FontAwesome.Sharp.IconButton();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_nrodocumento = new System.Windows.Forms.TextBox();
            this.txt_nombre_cliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_doc_cliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_totalpagar = new System.Windows.Forms.TextBox();
            this.dgvdataventa = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_monto_pago = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_cambio = new System.Windows.Forms.TextBox();
            this.btn_exportar = new FontAwesome.Sharp.IconButton();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataventa)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_buscar_dc
            // 
            this.btn_buscar_dc.BackColor = System.Drawing.Color.Silver;
            this.btn_buscar_dc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_dc.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_dc.ForeColor = System.Drawing.Color.Black;
            this.btn_buscar_dc.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.btn_buscar_dc.IconColor = System.Drawing.Color.Black;
            this.btn_buscar_dc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_buscar_dc.IconSize = 20;
            this.btn_buscar_dc.Location = new System.Drawing.Point(672, 40);
            this.btn_buscar_dc.Name = "btn_buscar_dc";
            this.btn_buscar_dc.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar_dc.TabIndex = 35;
            this.btn_buscar_dc.Text = "Buscar";
            this.btn_buscar_dc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscar_dc.UseVisualStyleBackColor = false;
            this.btn_buscar_dc.Click += new System.EventHandler(this.btn_buscar_dc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txt_doc_detalle);
            this.groupBox1.Controls.Add(this.txt_usuario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_fecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(198, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 79);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Venta";
            // 
            // txt_doc_detalle
            // 
            this.txt_doc_detalle.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_doc_detalle.Location = new System.Drawing.Point(174, 39);
            this.txt_doc_detalle.Name = "txt_doc_detalle";
            this.txt_doc_detalle.Size = new System.Drawing.Size(159, 21);
            this.txt_doc_detalle.TabIndex = 6;
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_usuario.Location = new System.Drawing.Point(368, 39);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(159, 21);
            this.txt_usuario.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo Documento:";
            // 
            // txt_fecha
            // 
            this.txt_fecha.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_fecha.Location = new System.Drawing.Point(6, 39);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(132, 21);
            this.txt_fecha.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha:";
            // 
            // btn_limpiar_buscador
            // 
            this.btn_limpiar_buscador.BackColor = System.Drawing.Color.Silver;
            this.btn_limpiar_buscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiar_buscador.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_limpiar_buscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar_buscador.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar_buscador.ForeColor = System.Drawing.Color.Black;
            this.btn_limpiar_buscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btn_limpiar_buscador.IconColor = System.Drawing.Color.Black;
            this.btn_limpiar_buscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_limpiar_buscador.IconSize = 16;
            this.btn_limpiar_buscador.Location = new System.Drawing.Point(753, 40);
            this.btn_limpiar_buscador.Name = "btn_limpiar_buscador";
            this.btn_limpiar_buscador.Size = new System.Drawing.Size(77, 23);
            this.btn_limpiar_buscador.TabIndex = 40;
            this.btn_limpiar_buscador.Text = "Limpiar";
            this.btn_limpiar_buscador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_limpiar_buscador.UseVisualStyleBackColor = false;
            this.btn_limpiar_buscador.Click += new System.EventHandler(this.btn_limpiar_buscador_Click);
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Location = new System.Drawing.Point(537, 43);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(127, 20);
            this.txt_busqueda.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(472, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "N° Factura:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(194, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "DETALLE VENTA";
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
            this.label10.TabIndex = 36;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txt_nrodocumento);
            this.groupBox2.Controls.Add(this.txt_nombre_cliente);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_doc_cliente);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(198, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 70);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Cliente";
            // 
            // txt_nrodocumento
            // 
            this.txt_nrodocumento.Location = new System.Drawing.Point(583, 36);
            this.txt_nrodocumento.Name = "txt_nrodocumento";
            this.txt_nrodocumento.Size = new System.Drawing.Size(43, 21);
            this.txt_nrodocumento.TabIndex = 5;
            this.txt_nrodocumento.Visible = false;
            // 
            // txt_nombre_cliente
            // 
            this.txt_nombre_cliente.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_nombre_cliente.Location = new System.Drawing.Point(174, 36);
            this.txt_nombre_cliente.Name = "txt_nombre_cliente";
            this.txt_nombre_cliente.Size = new System.Drawing.Size(159, 21);
            this.txt_nombre_cliente.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nombre Cliente";
            // 
            // txt_doc_cliente
            // 
            this.txt_doc_cliente.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_doc_cliente.Location = new System.Drawing.Point(6, 36);
            this.txt_doc_cliente.Name = "txt_doc_cliente";
            this.txt_doc_cliente.Size = new System.Drawing.Size(132, 21);
            this.txt_doc_cliente.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nro Documento:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(201, 452);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 16);
            this.label12.TabIndex = 45;
            this.label12.Text = "Monto Total:";
            // 
            // txt_totalpagar
            // 
            this.txt_totalpagar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_totalpagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_totalpagar.Location = new System.Drawing.Point(282, 452);
            this.txt_totalpagar.Name = "txt_totalpagar";
            this.txt_totalpagar.Size = new System.Drawing.Size(61, 20);
            this.txt_totalpagar.TabIndex = 44;
            this.txt_totalpagar.Text = "0";
            // 
            // dgvdataventa
            // 
            this.dgvdataventa.AllowUserToAddRows = false;
            this.dgvdataventa.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdataventa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvdataventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdataventa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.SubTotal});
            this.dgvdataventa.Location = new System.Drawing.Point(198, 241);
            this.dgvdataventa.MultiSelect = false;
            this.dgvdataventa.Name = "dgvdataventa";
            this.dgvdataventa.ReadOnly = true;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdataventa.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvdataventa.RowTemplate.Height = 28;
            this.dgvdataventa.Size = new System.Drawing.Size(648, 204);
            this.dgvdataventa.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(357, 452);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "Monto Pago:";
            // 
            // txt_monto_pago
            // 
            this.txt_monto_pago.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_monto_pago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_monto_pago.Location = new System.Drawing.Point(441, 451);
            this.txt_monto_pago.Name = "txt_monto_pago";
            this.txt_monto_pago.Size = new System.Drawing.Size(61, 20);
            this.txt_monto_pago.TabIndex = 46;
            this.txt_monto_pago.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(508, 453);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 49;
            this.label9.Text = "Monto Cambio:";
            // 
            // txt_cambio
            // 
            this.txt_cambio.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_cambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cambio.Location = new System.Drawing.Point(603, 451);
            this.txt_cambio.Name = "txt_cambio";
            this.txt_cambio.Size = new System.Drawing.Size(61, 20);
            this.txt_cambio.TabIndex = 48;
            this.txt_cambio.Text = "0";
            // 
            // btn_exportar
            // 
            this.btn_exportar.BackColor = System.Drawing.Color.White;
            this.btn_exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportar.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btn_exportar.IconColor = System.Drawing.Color.Black;
            this.btn_exportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_exportar.IconSize = 17;
            this.btn_exportar.Location = new System.Drawing.Point(716, 450);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(130, 25);
            this.btn_exportar.TabIndex = 62;
            this.btn_exportar.Text = "Descargar PDF";
            this.btn_exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_exportar.UseVisualStyleBackColor = false;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
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
            // FRM_detalle_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 487);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_cambio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_monto_pago);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_totalpagar);
            this.Controls.Add(this.dgvdataventa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_buscar_dc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_limpiar_buscador);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Name = "FRM_detalle_venta";
            this.Text = "FRM_detalle_venta";
            this.Load += new System.EventHandler(this.FRM_detalle_venta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataventa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_buscar_dc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_doc_detalle;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btn_limpiar_buscador;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_nrodocumento;
        private System.Windows.Forms.TextBox txt_nombre_cliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_doc_cliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_totalpagar;
        private System.Windows.Forms.DataGridView dgvdataventa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_monto_pago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_cambio;
        private FontAwesome.Sharp.IconButton btn_exportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}