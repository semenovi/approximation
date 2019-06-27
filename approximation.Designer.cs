namespace approximation
{
    partial class approximation
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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.input_x_t = new System.Windows.Forms.TextBox();
            this.output_t = new System.Windows.Forms.TextBox();
            this.linear = new System.Windows.Forms.Button();
            this.input_y_t = new System.Windows.Forms.TextBox();
            this.x_l = new System.Windows.Forms.Label();
            this.y_l = new System.Windows.Forms.Label();
            this.chart_c = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_c)).BeginInit();
            this.SuspendLayout();
            // 
            // input_x_t
            // 
            this.input_x_t.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_x_t.Location = new System.Drawing.Point(17, 176);
            this.input_x_t.Name = "input_x_t";
            this.input_x_t.Size = new System.Drawing.Size(265, 13);
            this.input_x_t.TabIndex = 0;
            // 
            // output_t
            // 
            this.output_t.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output_t.Location = new System.Drawing.Point(2, 237);
            this.output_t.Name = "output_t";
            this.output_t.ReadOnly = true;
            this.output_t.Size = new System.Drawing.Size(280, 13);
            this.output_t.TabIndex = 3;
            // 
            // linear
            // 
            this.linear.Location = new System.Drawing.Point(2, 211);
            this.linear.Name = "linear";
            this.linear.Size = new System.Drawing.Size(280, 23);
            this.linear.TabIndex = 2;
            this.linear.Text = "linear";
            this.linear.UseVisualStyleBackColor = true;
            this.linear.Click += new System.EventHandler(this.calculate_b_Click);
            // 
            // input_y_t
            // 
            this.input_y_t.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_y_t.Location = new System.Drawing.Point(17, 195);
            this.input_y_t.Name = "input_y_t";
            this.input_y_t.Size = new System.Drawing.Size(265, 13);
            this.input_y_t.TabIndex = 1;
            // 
            // x_l
            // 
            this.x_l.AutoSize = true;
            this.x_l.Location = new System.Drawing.Point(3, 176);
            this.x_l.Name = "x_l";
            this.x_l.Size = new System.Drawing.Size(12, 13);
            this.x_l.TabIndex = 4;
            this.x_l.Text = "x";
            // 
            // y_l
            // 
            this.y_l.AutoSize = true;
            this.y_l.Location = new System.Drawing.Point(3, 195);
            this.y_l.Name = "y_l";
            this.y_l.Size = new System.Drawing.Size(12, 13);
            this.y_l.TabIndex = 5;
            this.y_l.Text = "y";
            // 
            // chart_c
            // 
            this.chart_c.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "chart_area_ca";
            this.chart_c.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "legend_l";
            this.chart_c.Legends.Add(legend1);
            this.chart_c.Location = new System.Drawing.Point(2, 0);
            this.chart_c.Name = "chart_c";
            series1.BorderWidth = 2;
            series1.ChartArea = "chart_area_ca";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Green;
            series1.Legend = "legend_l";
            series1.Name = "input_s";
            series2.ChartArea = "chart_area_ca";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.Green;
            series2.IsVisibleInLegend = false;
            series2.Legend = "legend_l";
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series2.Name = "input_points_s";
            series3.BorderWidth = 2;
            series3.ChartArea = "chart_area_ca";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.DarkRed;
            series3.Legend = "legend_l";
            series3.Name = "output_s";
            series4.ChartArea = "chart_area_ca";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Color = System.Drawing.Color.DarkRed;
            series4.IsVisibleInLegend = false;
            series4.Legend = "legend_l";
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series4.Name = "output_points_s";
            this.chart_c.Series.Add(series1);
            this.chart_c.Series.Add(series2);
            this.chart_c.Series.Add(series3);
            this.chart_c.Series.Add(series4);
            this.chart_c.Size = new System.Drawing.Size(280, 173);
            this.chart_c.TabIndex = 6;
            this.chart_c.TabStop = false;
            this.chart_c.Text = "chart";
            this.chart_c.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // approximation
            // 
            this.AcceptButton = this.linear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 252);
            this.Controls.Add(this.chart_c);
            this.Controls.Add(this.y_l);
            this.Controls.Add(this.x_l);
            this.Controls.Add(this.input_y_t);
            this.Controls.Add(this.linear);
            this.Controls.Add(this.output_t);
            this.Controls.Add(this.input_x_t);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "approximation";
            this.ShowIcon = false;
            this.Text = "approximation";
            ((System.ComponentModel.ISupportInitialize)(this.chart_c)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_x_t;
        private System.Windows.Forms.TextBox output_t;
        private System.Windows.Forms.Button linear;
        private System.Windows.Forms.TextBox input_y_t;
        private System.Windows.Forms.Label x_l;
        private System.Windows.Forms.Label y_l;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_c;
    }
}

