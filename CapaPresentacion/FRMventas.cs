﻿using System;
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
using CapaPresentacion.Modales;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class FRMventas : Form
    {

        private Usuario _Usuario;

        public FRMventas(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void FRMventas_Load(object sender, EventArgs e)
        {
            cbo_tipodocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cbo_tipodocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            cbo_tipodocumento.DisplayMember = "Texto";
            cbo_tipodocumento.ValueMember = "Valor";
            cbo_tipodocumento.SelectedIndex = 0;

            txt_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txt_idproducto.Text = "0";
            txt_pago.Text = "";
            txt_cambio.Text = "";
            txt_totalpagar.Text = "0";

        }

        private void btn_buscar_cliente_Click(object sender, EventArgs e)
        {
            using (var modal = new MD_Cliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txt_doc_cliente.Text = modal._Cliente.Documento;
                    txt_nombre_cliente.Text = modal._Cliente.Nombre;
                }
                else
                {
                    txt_doc_cliente.Select();
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
                    txt_precio.Text = modal._Producto.PrecioVenta.ToString("0.00");
                    txt_stock.Text = modal._Producto.Stock.ToString();
                    numeric_cantidad.Select();
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
                    txt_precio.Text = oProducto.PrecioVenta.ToString("0.00");
                    txt_stock.Text = oProducto.Stock.ToString();
                    numeric_cantidad.Select();
                }
                else
                {
                    txt_codproducto.BackColor = Color.MistyRose;
                    txt_idproducto.Text = "0";
                    txt_producto.Text = "";
                    txt_precio.Text = "";
                    txt_stock.Text="";
                    numeric_cantidad.Value = 1;
                }
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool producto_existe = false;

            if (int.Parse(txt_idproducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txt_precio.Text, out precio))
            {
                MessageBox.Show("Precio- Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_precio.Select();
                return;
            }

            if (Convert.ToInt32(txt_stock.Text) < Convert.ToInt32(numeric_cantidad.Value.ToString()))
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow fila in dgvdataventa.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txt_idproducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }
            if (!producto_existe)
            {
                dgvdataventa.Rows.Add(new object[]
                {
                    txt_idproducto.Text,
                    txt_producto.Text,
                    precio.ToString("0.00"),
                    numeric_cantidad.Value.ToString(),
                    (numeric_cantidad.Value * precio).ToString("0.00")
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
            txt_precio.Text = "";
            txt_stock.Text = "";
            numeric_cantidad.Value = 1;
        }

        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvdataventa.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdataventa.Rows)
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
            }
            txt_totalpagar.Text = total.ToString("0.00");
        }

        private void dgvdataventa_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 5)
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

        private void dgvdataventa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdataventa.Columns[e.ColumnIndex].Name == "btn_eliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    dgvdataventa.Rows.RemoveAt(indice);
                    calcularTotal();
                }
            }
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txt_precio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void txt_pago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txt_pago.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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
        private void calcularCambio()
        {
            if (txt_totalpagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            decimal pagacon;
            decimal total = Convert.ToDecimal(txt_totalpagar.Text);

            if (txt_pago.Text.Trim() == "")
            {
                txt_pago.Text = "0";
            }
            if (decimal.TryParse(txt_pago.Text.Trim(), out pagacon))
            {
                if (pagacon < total)
                {
                    txt_cambio.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    txt_cambio.Text = cambio.ToString("0.00");
                }
            }
        }

        private void txt_pago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularCambio();
            }
        }
    }
}
