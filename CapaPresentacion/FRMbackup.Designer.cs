namespace CapaPresentacion
{
    partial class FRMbackup
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
            this.label10 = new System.Windows.Forms.Label();
            this.btn_backup = new FontAwesome.Sharp.IconButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_conectarBD = new FontAwesome.Sharp.IconButton();
            this.cbo_base_datos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_abrir_ruta = new System.Windows.Forms.TextBox();
            this.btn_abrir_respaldo = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_abrir_restaurar = new FontAwesome.Sharp.IconButton();
            this.txt_abrir_restaurar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_restaurar = new FontAwesome.Sharp.IconButton();
            this.txt_base_restaurar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(362, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "RESPALDO Y RESTAURACION DE BASE DE DATOS";
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
            this.label10.TabIndex = 27;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_backup
            // 
            this.btn_backup.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backup.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backup.IconChar = FontAwesome.Sharp.IconChar.SdCard;
            this.btn_backup.IconColor = System.Drawing.Color.Black;
            this.btn_backup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_backup.IconSize = 16;
            this.btn_backup.Location = new System.Drawing.Point(249, 66);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(89, 23);
            this.btn_backup.TabIndex = 29;
            this.btn_backup.Text = "Guardar";
            this.btn_backup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_backup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_backup.UseVisualStyleBackColor = false;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cbo_base_datos);
            this.groupBox3.Controls.Add(this.btn_conectarBD);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(198, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(643, 87);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información de la base de datos";
            // 
            // btn_conectarBD
            // 
            this.btn_conectarBD.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_conectarBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_conectarBD.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conectarBD.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btn_conectarBD.IconColor = System.Drawing.Color.Black;
            this.btn_conectarBD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_conectarBD.IconSize = 16;
            this.btn_conectarBD.Location = new System.Drawing.Point(384, 39);
            this.btn_conectarBD.Name = "btn_conectarBD";
            this.btn_conectarBD.Size = new System.Drawing.Size(89, 24);
            this.btn_conectarBD.TabIndex = 32;
            this.btn_conectarBD.Text = "Conectar";
            this.btn_conectarBD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_conectarBD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_conectarBD.UseVisualStyleBackColor = false;
            this.btn_conectarBD.Click += new System.EventHandler(this.btn_conectarBD_Click);
            // 
            // cbo_base_datos
            // 
            this.cbo_base_datos.FormattingEnabled = true;
            this.cbo_base_datos.Location = new System.Drawing.Point(194, 39);
            this.cbo_base_datos.Name = "cbo_base_datos";
            this.cbo_base_datos.Size = new System.Drawing.Size(175, 24);
            this.cbo_base_datos.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Base de Datos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Ruta a guardar:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btn_abrir_respaldo);
            this.groupBox1.Controls.Add(this.txt_abrir_ruta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_backup);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(198, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 106);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información ruta  de respaldo:";
            // 
            // txt_abrir_ruta
            // 
            this.txt_abrir_ruta.Location = new System.Drawing.Point(184, 39);
            this.txt_abrir_ruta.Name = "txt_abrir_ruta";
            this.txt_abrir_ruta.Size = new System.Drawing.Size(226, 21);
            this.txt_abrir_ruta.TabIndex = 35;
            // 
            // btn_abrir_respaldo
            // 
            this.btn_abrir_respaldo.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_abrir_respaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abrir_respaldo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abrir_respaldo.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btn_abrir_respaldo.IconColor = System.Drawing.Color.Black;
            this.btn_abrir_respaldo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_abrir_respaldo.IconSize = 16;
            this.btn_abrir_respaldo.Location = new System.Drawing.Point(416, 36);
            this.btn_abrir_respaldo.Name = "btn_abrir_respaldo";
            this.btn_abrir_respaldo.Size = new System.Drawing.Size(81, 24);
            this.btn_abrir_respaldo.TabIndex = 34;
            this.btn_abrir_respaldo.Text = "Abrir";
            this.btn_abrir_respaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_abrir_respaldo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_abrir_respaldo.UseVisualStyleBackColor = false;
            this.btn_abrir_respaldo.Click += new System.EventHandler(this.btn_abrir_respaldo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_base_restaurar);
            this.groupBox2.Controls.Add(this.btn_abrir_restaurar);
            this.groupBox2.Controls.Add(this.txt_abrir_restaurar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_restaurar);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(198, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 143);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información de Restauracion:";
            // 
            // btn_abrir_restaurar
            // 
            this.btn_abrir_restaurar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_abrir_restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abrir_restaurar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abrir_restaurar.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btn_abrir_restaurar.IconColor = System.Drawing.Color.Black;
            this.btn_abrir_restaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_abrir_restaurar.IconSize = 16;
            this.btn_abrir_restaurar.Location = new System.Drawing.Point(416, 36);
            this.btn_abrir_restaurar.Name = "btn_abrir_restaurar";
            this.btn_abrir_restaurar.Size = new System.Drawing.Size(81, 24);
            this.btn_abrir_restaurar.TabIndex = 34;
            this.btn_abrir_restaurar.Text = "Abrir";
            this.btn_abrir_restaurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_abrir_restaurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_abrir_restaurar.UseVisualStyleBackColor = false;
            this.btn_abrir_restaurar.Click += new System.EventHandler(this.btn_abrir_restaurar_Click);
            // 
            // txt_abrir_restaurar
            // 
            this.txt_abrir_restaurar.Location = new System.Drawing.Point(184, 39);
            this.txt_abrir_restaurar.Name = "txt_abrir_restaurar";
            this.txt_abrir_restaurar.Size = new System.Drawing.Size(226, 21);
            this.txt_abrir_restaurar.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Ruta Restaurar:";
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restaurar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restaurar.IconChar = FontAwesome.Sharp.IconChar.SdCard;
            this.btn_restaurar.IconColor = System.Drawing.Color.Black;
            this.btn_restaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_restaurar.IconSize = 16;
            this.btn_restaurar.Location = new System.Drawing.Point(249, 110);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(89, 23);
            this.btn_restaurar.TabIndex = 29;
            this.btn_restaurar.Text = "Restaurar";
            this.btn_restaurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_restaurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_restaurar.UseVisualStyleBackColor = false;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click);
            // 
            // txt_base_restaurar
            // 
            this.txt_base_restaurar.Location = new System.Drawing.Point(184, 78);
            this.txt_base_restaurar.Name = "txt_base_restaurar";
            this.txt_base_restaurar.Size = new System.Drawing.Size(226, 21);
            this.txt_base_restaurar.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Base de Datos a restaurar:";
            // 
            // FRMbackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 487);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Name = "FRMbackup";
            this.Text = "FRMbackup";
            this.Load += new System.EventHandler(this.FRMbackup_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btn_backup;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton btn_conectarBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_base_datos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btn_abrir_respaldo;
        private System.Windows.Forms.TextBox txt_abrir_ruta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_base_restaurar;
        private FontAwesome.Sharp.IconButton btn_abrir_restaurar;
        private System.Windows.Forms.TextBox txt_abrir_restaurar;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btn_restaurar;
    }
}