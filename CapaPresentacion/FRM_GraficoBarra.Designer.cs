﻿namespace CapaPresentacion
{
    partial class FRM_GraficoBarra
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
            this.Chart_categorias_mas_vendidas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_categorias_mas_vendidas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de productos vendidos por cagorias";
            // 
            // Chart_categorias_mas_vendidas
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart_categorias_mas_vendidas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart_categorias_mas_vendidas.Legends.Add(legend1);
            this.Chart_categorias_mas_vendidas.Location = new System.Drawing.Point(321, 77);
            this.Chart_categorias_mas_vendidas.Name = "Chart_categorias_mas_vendidas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart_categorias_mas_vendidas.Series.Add(series1);
            this.Chart_categorias_mas_vendidas.Size = new System.Drawing.Size(372, 355);
            this.Chart_categorias_mas_vendidas.TabIndex = 1;
            this.Chart_categorias_mas_vendidas.Text = "Grafico";
            // 
            // FRM_GraficoBarra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 487);
            this.Controls.Add(this.Chart_categorias_mas_vendidas);
            this.Controls.Add(this.label1);
            this.Name = "FRM_GraficoBarra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_GraficoBarra";
            this.Load += new System.EventHandler(this.FRM_GraficoTorta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_categorias_mas_vendidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_categorias_mas_vendidas;
    }
}