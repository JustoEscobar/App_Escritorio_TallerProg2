namespace CapaPresentacion
{
    partial class FRM_detalle_compra
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
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_limpiar_buscador = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_doc_detalle = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_buscar_dc = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_nrodocumento = new System.Windows.Forms.TextBox();
            this.txt_razonSocial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_docproveedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvdatacompra = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_totalpagar = new System.Windows.Forms.TextBox();
            this.btn_exportar = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatacompra)).BeginInit();
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
            this.label1.Text = "DETALLE COMPRA";
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
            // txt_busqueda
            // 
            this.txt_busqueda.Location = new System.Drawing.Point(537, 43);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(127, 20);
            this.txt_busqueda.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(472, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "N° Factura:";
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
            this.btn_limpiar_buscador.TabIndex = 33;
            this.btn_limpiar_buscador.Text = "Limpiar";
            this.btn_limpiar_buscador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_limpiar_buscador.UseVisualStyleBackColor = false;
            this.btn_limpiar_buscador.Click += new System.EventHandler(this.btn_limpiar_buscador_Click);
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
            this.groupBox1.Size = new System.Drawing.Size(632, 79);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Compra";
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
            this.btn_buscar_dc.TabIndex = 7;
            this.btn_buscar_dc.Text = "Buscar";
            this.btn_buscar_dc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_buscar_dc.UseVisualStyleBackColor = false;
            this.btn_buscar_dc.Click += new System.EventHandler(this.btn_buscar_dc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txt_nrodocumento);
            this.groupBox2.Controls.Add(this.txt_razonSocial);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_docproveedor);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(198, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(632, 70);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información Proveedor";
            // 
            // txt_nrodocumento
            // 
            this.txt_nrodocumento.Location = new System.Drawing.Point(583, 36);
            this.txt_nrodocumento.Name = "txt_nrodocumento";
            this.txt_nrodocumento.Size = new System.Drawing.Size(43, 21);
            this.txt_nrodocumento.TabIndex = 5;
            this.txt_nrodocumento.Visible = false;
            // 
            // txt_razonSocial
            // 
            this.txt_razonSocial.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_razonSocial.Location = new System.Drawing.Point(174, 36);
            this.txt_razonSocial.Name = "txt_razonSocial";
            this.txt_razonSocial.Size = new System.Drawing.Size(159, 21);
            this.txt_razonSocial.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Razon Social:";
            // 
            // txt_docproveedor
            // 
            this.txt_docproveedor.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_docproveedor.Location = new System.Drawing.Point(6, 36);
            this.txt_docproveedor.Name = "txt_docproveedor";
            this.txt_docproveedor.Size = new System.Drawing.Size(132, 21);
            this.txt_docproveedor.TabIndex = 1;
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
            // dgvdatacompra
            // 
            this.dgvdatacompra.AllowUserToAddRows = false;
            this.dgvdatacompra.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdatacompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdatacompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatacompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.PrecioCompra,
            this.Cantidad,
            this.SubTotal});
            this.dgvdatacompra.Location = new System.Drawing.Point(198, 241);
            this.dgvdatacompra.MultiSelect = false;
            this.dgvdatacompra.Name = "dgvdatacompra";
            this.dgvdatacompra.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdatacompra.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdatacompra.RowTemplate.Height = 28;
            this.dgvdatacompra.Size = new System.Drawing.Size(632, 204);
            this.dgvdatacompra.TabIndex = 36;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 120;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 150;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(201, 452);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 16);
            this.label12.TabIndex = 40;
            this.label12.Text = "Total a Pagar:";
            // 
            // txt_totalpagar
            // 
            this.txt_totalpagar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_totalpagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_totalpagar.Location = new System.Drawing.Point(290, 451);
            this.txt_totalpagar.Name = "txt_totalpagar";
            this.txt_totalpagar.Size = new System.Drawing.Size(88, 20);
            this.txt_totalpagar.TabIndex = 39;
            this.txt_totalpagar.Text = "0";
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
            this.btn_exportar.Location = new System.Drawing.Point(700, 448);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(130, 25);
            this.btn_exportar.TabIndex = 61;
            this.btn_exportar.Text = "Descargar PDF";
            this.btn_exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_exportar.UseVisualStyleBackColor = false;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // FRM_detalle_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 487);
            this.Controls.Add(this.btn_buscar_dc);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_totalpagar);
            this.Controls.Add(this.dgvdatacompra);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_limpiar_buscador);
            this.Controls.Add(this.txt_busqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Name = "FRM_detalle_compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_detalle_compra";
            this.Load += new System.EventHandler(this.FRM_detalle_compra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatacompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btn_limpiar_buscador;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_doc_detalle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_nrodocumento;
        private System.Windows.Forms.TextBox txt_razonSocial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_docproveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvdatacompra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_totalpagar;
        private FontAwesome.Sharp.IconButton btn_exportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private FontAwesome.Sharp.IconButton btn_buscar_dc;
    }
}