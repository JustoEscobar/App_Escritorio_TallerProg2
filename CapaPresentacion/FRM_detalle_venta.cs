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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace CapaPresentacion
{
    public partial class FRM_detalle_venta : Form
    {
        public FRM_detalle_venta()
        {
            InitializeComponent();
        }

        private void FRM_detalle_venta_Load(object sender, EventArgs e)
        {
            txt_busqueda.Select();
        }

        private void btn_buscar_dc_Click(object sender, EventArgs e)
        {
            Venta oVenta = new CN_Venta().ObtenerVenta(txt_busqueda.Text);

            if (oVenta.IdVenta != 0)
            {
                txt_nrodocumento.Text = oVenta.NumeroDocumento;
                txt_fecha.Text = oVenta.FechaRegistro;
                txt_doc_detalle.Text = oVenta.TipoDocumento;
                txt_usuario.Text = oVenta.oUsuario.Nombre;
                txt_doc_cliente.Text = oVenta.DocumentoCliente;
                txt_nombre_cliente.Text = oVenta.NombreCliente;

                dgvdataventa.Rows.Clear();

                foreach (Detalle_Venta dv in oVenta.oDetalleVenta)
                {
                    dgvdataventa.Rows.Add(new object[] { dv.oProducto.Descripcion, dv.PrecioVenta, dv.Cantidad, dv.SubTotal });
                }
                txt_totalpagar.Text = oVenta.MontoTotal.ToString("0.00");
                txt_monto_pago.Text = oVenta.MontoPago.ToString("0.00");
                txt_cambio.Text = oVenta.MontoCambio.ToString("0.00");

            }
        }

        private void btn_limpiar_buscador_Click(object sender, EventArgs e)
        {
            txt_fecha.Text = "";
            txt_doc_detalle.Text = "";
            txt_usuario.Text = "";
            txt_doc_cliente.Text = "";
            txt_nombre_cliente.Text = "";

            dgvdataventa.Rows.Clear();
            txt_totalpagar.Text = "0.00";
            txt_monto_pago.Text = "0.00";
            txt_cambio.Text = "0.00";
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            if (txt_doc_detalle.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string Texto_Html = Properties.Resources.PlantillaVenta.ToString();
            Negocio odatos = new CN_Negocio().ObtenerDatos();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.RUC);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);

            Texto_Html = Texto_Html.Replace("@tipodocumento", txt_doc_detalle.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", txt_nrodocumento.Text);

            Texto_Html = Texto_Html.Replace("@doccliente", txt_doc_cliente.Text);
            Texto_Html = Texto_Html.Replace("@nombrecliente", txt_nombre_cliente.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", txt_fecha.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", txt_usuario.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvdataventa.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txt_totalpagar.Text);
            Texto_Html = Texto_Html.Replace("@pagocon", txt_monto_pago.Text);
            Texto_Html = Texto_Html.Replace("@cambio", txt_cambio.Text);


            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = string.Format("Venta_{0}.pdf", txt_nrodocumento.Text);
            saveFile.Filter = "Pdf Files|*.pdf";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

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
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }
                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
