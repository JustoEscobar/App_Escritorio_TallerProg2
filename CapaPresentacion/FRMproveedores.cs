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

namespace CapaPresentacion
{
    public partial class FRMproveedores : Form
    {
        public FRMproveedores()
        {
            InitializeComponent();
        }

        private void FRMproveedores_Load(object sender, EventArgs e)
        {
            cbo_estado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbo_estado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cbo_estado.DisplayMember = "Texto";
            cbo_estado.ValueMember = "Valor";
            cbo_estado.SelectedIndex = 0;


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

            //MOSTRAR TODOS LOS PROVEEDORES     
            List<Proveedor> listaProveedors = new CN_Proveedor().Listar();

            foreach (Proveedor item in listaProveedors)
            {
                dgvdata.Rows.Add(new object[] { "", item.IdProveedor, item.Documento, item.RazonSocial, item.Correo, item.Telefono,

                item.Estado == true ? 1 : 0,
                item.Estado == true ? "Activo" : "No Activo"
                 });
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Proveedor objProveedor = new Proveedor()
            {
                IdProveedor = Convert.ToInt32(txt_id.Text),
                Documento = txt_documento.Text,
                RazonSocial = txt_razonSocial.Text,
                Correo = txt_correo.Text,
                Telefono = txt_telefono.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cbo_estado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objProveedor.IdProveedor == 0)
            {
                int idProveedorgenerado = new CN_Proveedor().Registrar(objProveedor, out mensaje);

                if (idProveedorgenerado != 0)
                {

                    dgvdata.Rows.Add(new object[] { "", idProveedorgenerado, txt_documento.Text, txt_razonSocial.Text, txt_correo.Text, txt_telefono.Text,
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
                bool resultado = new CN_Proveedor().Editar(objProveedor, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txt_indice.Text)];
                    row.Cells["Id"].Value = txt_id.Text;
                    row.Cells["Documento"].Value = txt_documento.Text;
                    row.Cells["RazonSocial"].Value = txt_razonSocial.Text;
                    row.Cells["Correo"].Value = txt_correo.Text;
                    row.Cells["Telefono"].Value = txt_telefono.Text;
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
        private void Limpiar()
        {
            txt_indice.Text = "-1";
            txt_id.Text = "0";
            txt_documento.Text = "";
            txt_razonSocial.Text = "";
            txt_correo.Text = "";
            txt_telefono.Text = "";
            cbo_estado.SelectedIndex = 0;

            txt_documento.Select();
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
                    txt_documento.Text = dgvdata.Rows[indice].Cells["Documento"].Value.ToString();
                    txt_razonSocial.Text = dgvdata.Rows[indice].Cells["RazonSocial"].Value.ToString();
                    txt_correo.Text = dgvdata.Rows[indice].Cells["Correo"].Value.ToString();
                    txt_telefono.Text = dgvdata.Rows[indice].Cells["Telefono"].Value.ToString();

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

        private void btn_eliminar2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_id.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el proveedor", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Proveedor objProveedor = new Proveedor()
                    {
                        IdProveedor = Convert.ToInt32(txt_id.Text)
                    };

                    bool respuesta = new CN_Proveedor().Eliminar(objProveedor, out mensaje);

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

        private void btn_limpiar2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
