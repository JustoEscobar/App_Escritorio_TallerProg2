using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class Login
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
            this.Contraseña = new System.Windows.Forms.Label();
            this.btn_ingresar = new FontAwesome.Sharp.IconButton();
            this.btn_cancelar = new FontAwesome.Sharp.IconButton();
            this.logo_principal = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.txt_documento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo_principal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 191);
            this.label1.TabIndex = 0;
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.Location = new System.Drawing.Point(225, 91);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(71, 16);
            this.Contraseña.TabIndex = 6;
            this.Contraseña.Text = "Contraseña";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ingresar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btn_ingresar.IconColor = System.Drawing.Color.Black;
            this.btn_ingresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ingresar.IconSize = 21;
            this.btn_ingresar.Location = new System.Drawing.Point(200, 146);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(99, 25);
            this.btn_ingresar.TabIndex = 7;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ingresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btn_cancelar.IconColor = System.Drawing.Color.Black;
            this.btn_cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cancelar.IconSize = 21;
            this.btn_cancelar.Location = new System.Drawing.Point(305, 146);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(99, 25);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // logo_principal
            // 
            this.logo_principal.BackColor = System.Drawing.Color.Orange;
            this.logo_principal.BackgroundImage = global::CapaPresentacion.Properties.Resources.logo1;
            this.logo_principal.Image = global::CapaPresentacion.Properties.Resources.logo1;
            this.logo_principal.Location = new System.Drawing.Point(12, 26);
            this.logo_principal.Name = "logo_principal";
            this.logo_principal.Size = new System.Drawing.Size(153, 134);
            this.logo_principal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_principal.TabIndex = 9;
            this.logo_principal.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Documento";
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(228, 107);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.PasswordChar = '*';
            this.txt_clave.Size = new System.Drawing.Size(154, 20);
            this.txt_clave.TabIndex = 4;
            // 
            // txt_documento
            // 
            this.txt_documento.Location = new System.Drawing.Point(228, 68);
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(154, 20);
            this.txt_documento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(237, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "INICIAR SESION";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(426, 191);
            this.Controls.Add(this.logo_principal);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.txt_documento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.logo_principal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Contraseña;
        private FontAwesome.Sharp.IconButton btn_ingresar;
        private FontAwesome.Sharp.IconButton btn_cancelar;
        private System.Windows.Forms.PictureBox logo_principal;
        private Label label3;
        private TextBox txt_clave;
        private TextBox txt_documento;
        private Label label2;
    }
}

