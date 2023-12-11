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

namespace CapaPresentacion.Modales
{
    public partial class MD_Producto : Form
    {
        public Producto _Producto { get; set; }

        public MD_Producto()
        {
            InitializeComponent();
        }

        private void MD_Producto_Load(object sender, EventArgs e)
        {

            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible)
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
                dgvdata.Rows.Add(new object[] {item.IdProducto, item.Codigo, item.Descripcion,
                item.oCategoria.Descripcion,
                item.Stock,
                item.PrecioCompra,
                item.PrecioVenta
                 });
            }
        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {
                _Producto = new Producto()
                {
                    IdProducto = Convert.ToInt32(dgvdata.Rows[iRow].Cells["Id"].Value.ToString()),
                    Codigo = dgvdata.Rows[iRow].Cells["Codigo"].Value.ToString(),
                    Descripcion = dgvdata.Rows[iRow].Cells["Descripcion"].Value.ToString(),
                    Stock = Convert.ToInt32(dgvdata.Rows[iRow].Cells["Stock"].Value.ToString()),
                    PrecioCompra = Convert.ToDecimal(dgvdata.Rows[iRow].Cells["PrecioCompra"].Value.ToString()),
                    PrecioVenta = Convert.ToDecimal(dgvdata.Rows[iRow].Cells["PrecioVenta"].Value.ToString()),
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
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
        }

        private void btn_limpiar_buscador_Click(object sender, EventArgs e)
        {
            {
                txt_busqueda.Text = "";

                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    row.Visible = true;
                }
            }
        }
    }
}
