using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
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

        private void txt_codproducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo == txt_codproducto.Text && p.Estado == true).FirstOrDefault();
                
                if (oProducto != null)
                {
                    txt_codproducto.BackColor = Color.Honeydew;
                    txt_idproducto.Text = oProducto.IdProducto.ToString();
                    txt_producto.Text = oProducto.Descripcion;
                    txt_preciocompra.Select();
                }
                else
                {
                    txt_codproducto.BackColor = Color.MistyRose;
                    txt_idproducto.Text = "0";
                    txt_producto.Text = "";
                }
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            decimal preciocompra = 0;
            decimal precioventa = 0;
            bool producto_existe = false;

            if (int.Parse(txt_idproducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txt_preciocompra.Text, out preciocompra))
            {
                MessageBox.Show("Precio compra - Formate moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_preciocompra.Select() ;
                return;
            }

            if (!decimal.TryParse(txt_precioventa.Text, out precioventa))
            {
                MessageBox.Show("Precio Venta - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_precioventa.Select();
                return;
            }

            foreach(DataGridViewRow fila in dgvdatacompra.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txt_idproducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }
            if (!producto_existe)
            {
                dgvdatacompra.Rows.Add(new object[]
                {
                    txt_idproducto.Text,
                    txt_producto.Text,
                    preciocompra.ToString("0.00"),
                    precioventa.ToString("0.00"),
                    numeric_cantidad.Value.ToString(),
                    (numeric_cantidad.Value * preciocompra).ToString("0.00")
                });

                calcularTotal();
                limpiarProducto();
                txt_codproducto.Select();
            }
        }

        private void limpiarProducto()
        {
            txt_idproducto.Text = "0";
            txt_codproducto.Text = "";
            txt_producto.BackColor = Color.White;
            txt_producto.Text = "";
            txt_preciocompra.Text = "";
            txt_precioventa.Text = "";
            numeric_cantidad.Value = 1;
        }

        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvdatacompra.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdatacompra.Rows)
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
            }
            txt_totalpagar.Text = total.ToString("0.00");
        }

        private void dgvdatacompra_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.trash_icon.Width;
                var h = Properties.Resources.trash_icon.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.trash_icon, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvdatacompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdatacompra.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    dgvdatacompra.Rows.RemoveAt(indice);
                    calcularTotal();
                }
            }
        }

        private void txt_preciocompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txt_preciocompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if(Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled=true;
                    }
                }
            }
        }

        private void txt_precioventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txt_precioventa.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void btn_registrarcompra_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_idproveedor.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvdatacompra.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            DataTable detalle_compra =new DataTable();

            detalle_compra.Columns.Add("IdProducto", typeof(int));
            detalle_compra.Columns.Add("PrecioCompra", typeof(decimal));
            detalle_compra.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_compra.Columns.Add("Cantidad", typeof(int));
            detalle_compra.Columns.Add("MontoTotal", typeof(decimal));

            foreach (DataGridViewRow row in dgvdatacompra.Rows)
            {
                detalle_compra.Rows.Add(new object[] {
                        Convert.ToInt32(row.Cells["IdProducto"].Value.ToString()),
                        row.Cells["PrecioCompra"].Value.ToString(),
                        row.Cells["PrecioVenta"].Value.ToString(),
                        row.Cells["Cantidad"].Value.ToString(),
                        row.Cells["SubTotal"].Value.ToString()
                 });
            }

            int idcorrelativo = new CN_Compra().obtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idcorrelativo);

            Compra oCompra = new Compra()
            {
                oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                oProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(txt_idproveedor.Text) },
                TipoDocumento = ((OpcionCombo)cbo_tipodocumento.SelectedItem).Texto,
                NroDocumento = numeroDocumento,
                MontoTotal=Convert.ToDecimal(txt_totalpagar.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Compra().Registrar(oCompra, detalle_compra,out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de compra generada:\n" + numeroDocumento + "\n\n ¿Desea copiar al portapapeles?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                
                    Clipboard.SetText(numeroDocumento);

                txt_idproveedor.Text = "0";
                txt_docproveedor.Text = "";
                txt_razonSocial.Text = "";
                dgvdatacompra.Rows.Clear();
                calcularTotal();
            }
        }
    }
}
