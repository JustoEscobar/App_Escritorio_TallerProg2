using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using Microsoft.Win32;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;
using SaveFileDialog = System.Windows.Forms.SaveFileDialog;

namespace CapaPresentacion
{
    public partial class FRMbackup : Form
    {
        public FRMbackup()
        {
            InitializeComponent();
        }

        private void FRMbackup_Load(object sender, EventArgs e)
        {

        }

        private void btn_conectarBD_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", oconexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        cbo_base_datos.Items.Add(fila[0].ToString());
                    }

                    cbo_base_datos.SelectedIndex = 0;

                }
            }
        }

        private void btn_abrir_respaldo_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "SQL Backup files|*.bak";
            saveFile.FileName = $"{cbo_base_datos.Text}-{DateTime.Today.ToString("dd-MM-yyyy")}-{DateTime.Now.ToString("h.mm")}.bak";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                txt_abrir_ruta.Text = saveFile.FileName;
            }
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que exista la carpeta, en caso contrario la crea//
                if (!Directory.Exists(@"D:\Backup"))
                {
                    Directory.CreateDirectory(@"D:\Backup");
                }

                System.Diagnostics.Process.Start("cmd", $"/k sqlcmd -S localhost\\SQLEXPRESS -E -Q \"BACKUP DATABASE [{cbo_base_datos.Text}] TO DISK='{txt_abrir_ruta.Text}'\"");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_abrir_restaurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "SQL Backup Files|*.bak";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_abrir_restaurar.Text = openFileDialog1.FileName;
            }
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            string baseName = txt_base_restaurar.Text;
            string rutaRestaurar = txt_abrir_restaurar.Text;

            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = $"/k Sqlcmd -S localhost\\SQLEXPRESS -E -Q \"RESTORE DATABASE [{baseName}] FROM DISK = '{rutaRestaurar}'\"";
            System.Diagnostics.Process.Start(startInfo);
        }
    }
}
