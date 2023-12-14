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
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;

namespace CapaPresentacion
{
    public partial class FRMproducto : Form
    {
        public FRMproducto()
        {
            InitializeComponent();
        }

        private void FRMproducto_Load(object sender, EventArgs e)
        {
            cbo_estado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbo_estado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cbo_estado.DisplayMember = "Texto";
            cbo_estado.ValueMember = "Valor";
            cbo_estado.SelectedIndex = 0;

            List<Categoria> listaCategoria = new CN_Categoria().Listar();
            foreach (Categoria item in listaCategoria)
            {
                cbo_categoria.Items.Add(new OpcionCombo() { Valor = item.IdCategoria, Texto = item.Descripcion });
            }
            cbo_categoria.DisplayMember = "Texto";
            cbo_categoria.ValueMember = "Valor";
            //cbo_categoria.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "btn_seleccionar")
                {
                    cbo_busqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbo_busqueda.DisplayMember = "Texto";
            cbo_busqueda.ValueMember = "Valor";
            cbo_busqueda.SelectedIndex = 0;

            //MOSTRAR TODOS LOS PRODUCTOS 
            List<Producto> listaProductos = new CN_Producto().Listar();

            foreach (Producto item in listaProductos)
            {
                dgvdata.Rows.Add(new object[] { "", item.IdProducto, item.Codigo, item.Descripcion,

                item.oCategoria.IdCategoria,
                item.oCategoria.Descripcion,
                item.Stock,
                item.PrecioCompra,
                item.PrecioVenta,
                item.Estado == true ? 1 : 0,
                item.Estado == true ? "Activo" : "No Activo"
                 });
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea registrar el producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string mensaje = string.Empty;

                Producto objProducto = new Producto()
                {
                    IdProducto = Convert.ToInt32(txt_id.Text),
                    Codigo = txt_codigo.Text,
                    Descripcion = txt_descripcion.Text,
                    oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)cbo_categoria.SelectedItem).Valor) },
                    Estado = Convert.ToInt32(((OpcionCombo)cbo_estado.SelectedItem).Valor) == 1 ? true : false
                };

                if (objProducto.IdProducto == 0)
                {
                    int idProductogenerado = new CN_Producto().Registrar(objProducto, out mensaje);

                    if (idProductogenerado != 0)
                    {

                        dgvdata.Rows.Add(new object[] {
                        "",
                     idProductogenerado,
                     txt_codigo.Text,
                     txt_descripcion.Text,
                    ((OpcionCombo)cbo_categoria.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)cbo_categoria.SelectedItem).Texto.ToString(),
                    "0",
                    "0.00",
                    "0.00",
                    ((OpcionCombo)cbo_estado.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)cbo_estado.SelectedItem).Texto.ToString()
                    });

                        Limpiar();
                    }

                    else
                    {
                        MessageBox.Show(mensaje);
                    }

                }
                else
                {
                    bool resultado = new CN_Producto().Editar(objProducto, out mensaje);

                    if (resultado)
                    {
                        DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txt_indice.Text)];
                        row.Cells["Id"].Value = txt_id.Text;
                        row.Cells["Codigo"].Value = txt_codigo.Text;
                        row.Cells["Descripcion"].Value = txt_descripcion.Text;
                        row.Cells["IdCategoria"].Value = ((OpcionCombo)cbo_categoria.SelectedItem).Valor.ToString();
                        row.Cells["Categoria"].Value = ((OpcionCombo)cbo_categoria.SelectedItem).Valor.ToString();
                        row.Cells["EstadoValor"].Value = ((OpcionCombo)cbo_estado.SelectedItem).Valor.ToString();
                        row.Cells["Estado"].Value = ((OpcionCombo)cbo_estado.SelectedItem).Valor.ToString();

                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                }
            }
        }

        private void Limpiar()
        {
            txt_indice.Text = "-1";
            txt_id.Text = "0";
            txt_codigo.Text = "";
            txt_descripcion.Text = "";
            cbo_categoria.SelectedIndex = 0;
            cbo_estado.SelectedIndex = 0;

            txt_codigo.Select();
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check_icon.Width;
                var h = Properties.Resources.check_icon.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check_icon, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btn_seleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txt_indice.Text = indice.ToString();
                    txt_id.Text = dgvdata.Rows[indice].Cells["Id"].Value.ToString();
                    txt_codigo.Text = dgvdata.Rows[indice].Cells["Codigo"].Value.ToString();
                    txt_descripcion.Text = dgvdata.Rows[indice].Cells["Descripcion"].Value.ToString();


                    foreach (OpcionCombo oc in cbo_categoria.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["IdCategoria"].Value))
                        {
                            int indice_combo = cbo_categoria.Items.IndexOf(oc);
                            cbo_categoria.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    foreach (OpcionCombo oc in cbo_estado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cbo_estado.Items.IndexOf(oc);
                            cbo_estado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_id.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el producto", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Producto objProducto = new Producto()
                    {
                        IdProducto = Convert.ToInt32(txt_id.Text)
                    };

                    bool respuesta = new CN_Producto().Eliminar(objProducto, out mensaje);

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txt_indice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbo_busqueda.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txt_busqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btn_limpiar_buscador_Click(object sender, EventArgs e)
        {
            txt_busqueda.Text = "";

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach(DataGridViewColumn columna in dgvdata.Columns)
                {
                    if (columna.HeaderText != "" && columna.Visible)
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                }
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if(row.Visible)
                        dt.Rows.Add(new object[]
                        {
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[10].Value.ToString(),
                        });

                }

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("ReporteProducto_{0}.xlsx", DateTime.Now.ToString("ddMMyyyy"));
                saveFile.Filter = "Excel Files | *.xlsx";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(saveFile.FileName);
                        MessageBox.Show("Reporte generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
    }
}
