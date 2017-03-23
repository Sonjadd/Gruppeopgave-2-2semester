namespace Gruppeopgave_2
{
    partial class BT_Form
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BT_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.BT_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.BT_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BT_chart.Legends.Add(legend1);
            this.BT_chart.Location = new System.Drawing.Point(-12, -4);
            this.BT_chart.Name = "BT_chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Systole";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Diastole";
            this.BT_chart.Series.Add(series1);
            this.BT_chart.Series.Add(series2);
            this.BT_chart.Size = new System.Drawing.Size(456, 426);
            this.BT_chart.TabIndex = 0;
            this.BT_chart.Text = "chart1";
            this.BT_chart.Click += new System.EventHandler(this.BT_chart_Click);
            // 
            // BT_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 418);
            this.Controls.Add(this.BT_chart);
            this.Name = "BT_Form";
            this.Text = "BT_Form";
            ((System.ComponentModel.ISupportInitialize)(this.BT_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart BT_chart;
    }
}