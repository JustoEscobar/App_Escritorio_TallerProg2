namespace CapaPresentacion
{
    partial class FRM_GraficoTorta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.ChartCantidad_ventas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ChartCantidad_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de ventas en el mes";
            // 
            // ChartCantidad_ventas
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartCantidad_ventas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartCantidad_ventas.Legends.Add(legend1);
            this.ChartCantidad_ventas.Location = new System.Drawing.Point(362, 87);
            this.ChartCantidad_ventas.Name = "ChartCantidad_ventas";
            this.ChartCantidad_ventas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartCantidad_ventas.Series.Add(series1);
            this.ChartCantidad_ventas.Size = new System.Drawing.Size(364, 344);
            this.ChartCantidad_ventas.TabIndex = 1;
            this.ChartCantidad_ventas.Text = "chart1";
            // 
            // FRM_GraficoTorta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 487);
            this.Controls.Add(this.ChartCantidad_ventas);
            this.Controls.Add(this.label1);
            this.Name = "FRM_GraficoTorta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_GraficoTorta";
            this.Load += new System.EventHandler(this.FRM_GraficoBarras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartCantidad_ventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartCantidad_ventas;
    }
}