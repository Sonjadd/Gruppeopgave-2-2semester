﻿namespace Gruppeopgave_2
{
    partial class BS_Form
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
            this.BS_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.BS_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // BS_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.BS_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BS_chart.Legends.Add(legend1);
            this.BS_chart.Location = new System.Drawing.Point(-3, -2);
            this.BS_chart.Name = "BS_chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Blodsukker";
            this.BS_chart.Series.Add(series1);
            this.BS_chart.Size = new System.Drawing.Size(459, 381);
            this.BS_chart.TabIndex = 0;
            this.BS_chart.Text = "chart1";
            this.BS_chart.Click += new System.EventHandler(this.BS_chart_Click);
            // 
            // BS_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 377);
            this.Controls.Add(this.BS_chart);
            this.Name = "BS_Form";
            this.Text = "BS_Form";
            ((System.ComponentModel.ISupportInitialize)(this.BS_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart BS_chart;
    }
}