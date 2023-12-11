using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public Inicio(Usuario objusuario)
        {
            usuarioActual = objusuario;

            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);

            foreach (IconMenuItem iconMenu in menu.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.Descripcion == iconMenu.Name);
                if(encontrado == false)
                {
                    iconMenu.Visible = false;
                }
            }

            lblusuario.Text = usuarioActual.Nombre;
        }

        private void Abrir_Formulario(IconMenuItem menu, Form formulario)
        {
            if(MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.Orange;
            contenedor.Controls.Add(formulario);
            formulario.Show();

        }
        private void menu_usuario_Click(object sender, EventArgs e)
        {
            Abrir_Formulario((IconMenuItem)sender, new FRMusuarios());

        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            Abrir_Formulario(menu_mantenedor, new FRMcategoria());
        }

        private void submenu_producto_Click(object sender, EventArgs e)
        {
            Abrir_Formulario(menu_mantenedor, new FRMproducto());
        }

        private void menu_ventas_Click(object sender, EventArgs e)
        {

        }

        private void submenu_registrar_venta_Click(object sender, EventArgs e)
        {
            Abrir_Formulario(menu_ventas, new FRMventas());
        }

        private void submenu_verdetalle_Click(object sender, EventArgs e)
        {
            Abrir_Formulario(menu_ventas, new FRM_detalle_venta());
        }

        private void submenu_registrar_compra_Click(object sender, EventArgs e)
        {
            Abrir_Formulario(menu_compras, new FRMcompras(usuarioActual));
        }

        private void submenu_ver_detalle_compra_Click(object sender, EventArgs e)
        {
            Abrir_Formulario(menu_compras, new FRM_detalle_compra());
        }

        private void menu_clientes_Click(object sender, EventArgs e)
        {
            Abrir_Formulario((IconMenuItem)sender, new FRMclientes());
        }

        private void menu_proveedores_Click(object sender, EventArgs e)
        {
            Abrir_Formulario((IconMenuItem)sender, new FRMproveedores());
        }

        private void menu_reportes_Click(object sender, EventArgs e)
        {
            Abrir_Formulario((IconMenuItem)sender, new FRMreportes());
        }

        private void submenu_negocio_Click(object sender, EventArgs e)
        {
            Abrir_Formulario(menu_mantenedor, new FRM_Negocio());
        }
    }
}
