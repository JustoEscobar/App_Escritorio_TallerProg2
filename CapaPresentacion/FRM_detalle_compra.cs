using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using DocumentFormat.OpenXml.Wordprocessing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Document = iTextSharp.text.Document;
using PageSize = iTextSharp.text.PageSize;

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

        private void btn_limpiar_buscador_Click(object sender, EventArgs e)
        {
            txt_fecha.Text = "";
            txt_doc_detalle.Text = "";
            txt_usuario.Text = "";
            txt_docproveedor.Text = "";
            txt_razonSocial.Text = "";
            
            dgvdatacompra.Rows.Clear( );
            txt_totalpagar.Text="0.00";
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            if (txt_doc_detalle.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string Texto_Html = Properties.Resources.PlantillaCompra.ToString();
            Negocio odatos = new CN_Negocio().ObtenerDatos();

            Texto_Html = Texto_Html.Replace("@nombrenegocio",odatos.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio",odatos.RUC);
            Texto_Html = Texto_Html.Replace("@direcnegocio",odatos.Direccion);

            Texto_Html = Texto_Html.Replace("@tipodocumento", txt_doc_detalle.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", txt_nrodocumento.Text);

            Texto_Html = Texto_Html.Replace("@docproveedor", txt_docproveedor.Text);
            Texto_Html = Texto_Html.Replace("@nombreproveedor", txt_razonSocial.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", txt_fecha.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", txt_usuario.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvdatacompra.Rows)
            {
                filas += "<tr>";
                filas += "<td>"+ row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioCompra"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txt_totalpagar.Text);

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = string.Format("Compra_{0}.pdf", txt_nrodocumento.Text);
            saveFile.Filter = "Pdf Files|*.pdf";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4,25,25,25,25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteImage = new CN_Negocio().ObtenerLogo(out obtenido);

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc,sr);
                    }
                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FRM_detalle_compra_Load(object sender, EventArgs e)
        {

        }
    }
}
