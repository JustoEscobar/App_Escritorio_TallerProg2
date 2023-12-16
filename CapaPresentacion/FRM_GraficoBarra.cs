using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class FRM_GraficoBarra : Form
    {
        public FRM_GraficoBarra()
        {
            InitializeComponent();
        }

        private void FRM_GraficoTorta_Load(object sender, EventArgs e)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                StringBuilder query = new StringBuilder();
                query.AppendLine("SELECT c.IdCategoria,c.Descripcion, SUM(dv.Cantidad) as 'Cantidad_Vendida' FROM DETALLE_VENTA dv");
                query.AppendLine("INNER JOIN PRODUCTO p ON p.IdProducto = dv.IdProducto");
                query.AppendLine("INNER JOIN CATEGORIA c ON c.IdCategoria = p.IdCategoria");
                query.AppendLine("GROUP BY c.IdCategoria, c.Descripcion");
                query.AppendLine("ORDER BY[Cantidad_Vendida] DESC");
                SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                cmd.CommandType = CommandType.Text;

                oconexion.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                Chart_categorias_mas_vendidas.Series[0].Points.Clear();
                //chartServicios.Series.Clear();
                while (dr.Read())
                {
                    string nombreCategoria = dr["Descripcion"].ToString();
                    int cantidad = Convert.ToInt32(dr["Cantidad_Vendida"]);

                    Chart_categorias_mas_vendidas.Series[0].Points.AddXY(nombreCategoria, cantidad);
                }
            }
        }
    }
}
