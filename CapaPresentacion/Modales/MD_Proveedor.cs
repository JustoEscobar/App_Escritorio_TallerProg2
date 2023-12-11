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
    public partial class MD_Proveedor : Form
    {

        public Proveedor _Proveedor {  get; set; }

        public MD_Proveedor()
        {
            InitializeComponent();
        }

        private void MD_Proveedor_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true)
                {
                    cbo_busqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbo_busqueda.DisplayMember = "Texto";
            cbo_busqueda.ValueMember = "Valor";
            cbo_busqueda.SelectedIndex = 0;

            //MOSTRAR TODOS LOS PROVEEDORES     
            List<Proveedor> listaProveedors = new CN_Proveedor().Listar();

            foreach (Proveedor item in listaProveedors)
            {
                dgvdata.Rows.Add(new object[] {item.IdProveedor, item.Documento, item.RazonSocial});
            }
        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if(iRow >= 0 && iColum > 0)
            {
                _Proveedor = new Proveedor()
                {
                    IdProveedor = Convert.ToInt32(dgvdata.Rows[iRow].Cells["Id"].Value.ToString()),
                    Documento = dgvdata.Rows[iRow].Cells["Documento"].Value.ToString(),
                    RazonSocial = dgvdata.Rows[iRow].Cells["RazonSocial"].Value.ToString()
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
