using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaPresentacion.Utilidades;
using CapaEntidad;
using CapaNegocio;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Media;

namespace CapaPresentacion
{
    public partial class FRMusuarios : Form
    {
        public FRMusuarios()
        {
            InitializeComponent();
        }

        private void FRMusuarios_Load(object sender, EventArgs e)
        {
            cbo_estado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbo_estado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cbo_estado.DisplayMember = "Texto";
            cbo_estado.ValueMember = "Valor";
            cbo_estado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_Rol().Listar();
            foreach(Rol item in listaRol)
            {
                cbo_rol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });
            }
            cbo_rol.DisplayMember = "Texto";
            cbo_rol.ValueMember = "Valor";
            cbo_rol.SelectedIndex = 0;

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

            //MOSTRAR TODOS LOS USUARIOS 
            List<Usuario> listaUsuarios = new CN_Usuario().Listar();
            
            foreach (Usuario item in listaUsuarios)
            {
                dgvdata.Rows.Add(new object[] { "", item.IdUsuario, item.Documento, item.Nombre, item.Correo, item.Contraseña,

                item.oRol.IdRol,
                item.oRol.Descripcion,
                item.Estado == true ? 1 : 0,
                item.Estado == true ? "Activo" : "No Activo"
                 });
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea registrar el usuario", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string mensaje = string.Empty;

                Usuario objusuario = new Usuario()
                {
                    IdUsuario = Convert.ToInt32(txt_id.Text),
                    Documento = txt_documento.Text,
                    Nombre = txt_nombre.Text,
                    Correo = txt_correo.Text,
                    Contraseña = txt_clave.Text,
                    oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)cbo_rol.SelectedItem).Valor) },
                    Estado = Convert.ToInt32(((OpcionCombo)cbo_estado.SelectedItem).Valor) == 1 ? true : false
                };

                if (objusuario.IdUsuario == 0)
                {
                    int idusuariogenerado = new CN_Usuario().Registrar(objusuario, out mensaje);

                    if (idusuariogenerado != 0)
                    {

                        dgvdata.Rows.Add(new object[] { "", txt_id.Text, txt_documento.Text, txt_nombre.Text, txt_correo.Text, txt_clave.Text,
                ((OpcionCombo)cbo_rol.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cbo_rol.SelectedItem).Texto.ToString(),
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
                        bool resultado = new CN_Usuario().Editar(objusuario, out mensaje);

                        if (resultado)
                        {
                            DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txt_indice.Text)];
                            row.Cells["Id"].Value = txt_id.Text;
                            row.Cells["Documento"].Value = txt_documento.Text;
                            row.Cells["Nombre"].Value = txt_nombre.Text;
                            row.Cells["Correo"].Value = txt_correo.Text;
                            row.Cells["Contraseña"].Value = txt_clave.Text;
                            row.Cells["IdRol"].Value = ((OpcionCombo)cbo_rol.SelectedItem).Valor.ToString();
                            row.Cells["Rol"].Value = ((OpcionCombo)cbo_rol.SelectedItem).Valor.ToString();
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
            txt_documento.Text = "";
            txt_nombre.Text = "";
            txt_correo.Text = "";
            txt_clave.Text = "";
            txt_confirmarclave.Text = "";
            cbo_rol.SelectedIndex = 0;
            cbo_estado.SelectedIndex = 0;

            txt_documento.Select();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    txt_nombre.Text = dgvdata.Rows[indice].Cells["Nombre"].Value.ToString();
                    txt_correo.Text = dgvdata.Rows[indice].Cells["Correo"].Value.ToString();
                    txt_clave.Text = dgvdata.Rows[indice].Cells["Contraseña"].Value.ToString();
                    txt_confirmarclave.Text = dgvdata.Rows[indice].Cells["Contraseña"].Value.ToString();

                    foreach (OpcionCombo oc in cbo_rol.Items)
                    {
                        if (Convert.ToInt32 (oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["IdRol"].Value))
                        {
                            int indice_combo = cbo_rol.Items.IndexOf(oc);
                            cbo_rol.SelectedIndex = indice_combo;
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
            if (Convert.ToInt32(txt_id.Text) != 0) {
                if(MessageBox.Show("¿Desea eliminar el usuario","Mensaje",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    string mensaje = string.Empty;
                    Usuario objusuario = new Usuario()
                    {
                        IdUsuario = Convert.ToInt32(txt_id.Text)
                    };

                    bool respuesta = new CN_Usuario().Eliminar(objusuario, out mensaje);

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txt_indice.Text));
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
            string columnaFiltro = ((OpcionCombo) cbo_busqueda.SelectedItem).Valor.ToString();

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
    }
}
