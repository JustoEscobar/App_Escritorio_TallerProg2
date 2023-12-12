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

namespace CapaPresentacion
{
    public partial class FRM_detalle_compra : Form
    {
        public FRM_detalle_compra()
        {
            InitializeComponent();
        }

        private void btn_buscar_dc_Click(object sender, EventArgs e)
        {
            Compra oCompra = new CN_Compra().ObtenerCompra(txt_busqueda.Text);

            if (oCompra.IdCompra != 0)
            {
                txt_nrodocumento.Text = oCompra.NroDocumento;
                txt_fecha.Text = oCompra.FechaRegistro;
                txt_doc_detalle.Text = oCompra.TipoDocumento;
                txt_usuario.Text = oCompra.oUsuario.Nombre;
                txt_docproveedor.Text = oCompra.oProveedor.Documento;
                txt_razonSocial.Text = oCompra.oProveedor.RazonSocial;

                dgvdatacompra.Rows.Clear();

                foreach (Detalle_Compra dc in oCompra.oDetalleCompra)
                {
                    dgvdatacompra.Rows.Add(new object[] { dc.oProducto.Descripcion, dc.PrecioCompra, dc.Cantidad, dc.MontoTotal });
                }
                txt_totalpagar.Text = oCompra.MontoTotal.ToString("0.00");

            }
        }
    }
}
