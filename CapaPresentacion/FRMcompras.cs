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
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class FRMcompras : Form
    {
        private Usuario _Usuario;

        public FRMcompras(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void FRMcompras_Load(object sender, EventArgs e)
        {
            cbo_tipodocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cbo_tipodocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            cbo_tipodocumento.DisplayMember = "Texto";
            cbo_tipodocumento.ValueMember = "Valor";
            cbo_tipodocumento.SelectedIndex = 0;

            txt_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txt_idproducto.Text = "0";
            txt_idproveedor.Text = "0";
        }

        private void btn_buscar_proveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new MD_Proveedor())
            {
                var result = modal.ShowDialog();
                
                if (result == DialogResult.OK)
                {
                    txt_idproveedor.Text = modal._Proveedor.IdProveedor.ToString();
                    txt_docproveedor.Text = modal._Proveedor.Documento;
                    txt_razonSocial.Text = modal._Proveedor.RazonSocial;
                }
                else
                {
                    txt_docproveedor.Select();
                }
            }
        }

        private void btn_buscarproducto_Click(object sender, EventArgs e)
        {
            using (var modal = new MD_Producto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txt_idproducto.Text = modal._Producto.IdProducto.ToString();
                    txt_codproducto.Text = modal._Producto.Codigo;
                    txt_producto.Text = modal._Producto.Descripcion;
                    txt_preciocompra.Select();
                }
                else
                {
                    txt_codproducto.Select();
                }
            }
        }
    }

}
