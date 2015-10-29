namespace freqtest123
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Hz = new System.Windows.Forms.Label();
            this.Freq1display = new System.Windows.Forms.TextBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Freq2display = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.runTests = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(64, 120);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "test1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "test2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(301, 194);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Hz
            // 
            this.Hz.AutoSize = true;
            this.Hz.Location = new System.Drawing.Point(180, 43);
            this.Hz.Name = "Hz";
            this.Hz.Size = new System.Drawing.Size(44, 13);
            this.Hz.TabIndex = 2;
            this.Hz.Text = "Freq Hz";
            this.Hz.Click += new System.EventHandler(this.label1_Click);
            // 
            // Freq1display
            // 
            this.Freq1display.Location = new System.Drawing.Point(230, 40);
            this.Freq1display.Name = "Freq1display";
            this.Freq1display.Size = new System.Drawing.Size(109, 20);
            this.Freq1display.TabIndex = 4;
            this.Freq1display.TextChanged += new System.EventHandler(this.Freq1display_TextChanged);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(398, 120);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "test1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "test2";
            this.chart2.Series.Add(series3);
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(301, 194);
            this.chart2.TabIndex = 5;
            this.chart2.Text = "chart2";
            // 
            // Freq2display
            // 
            this.Freq2display.Location = new System.Drawing.Point(502, 37);
            this.Freq2display.Name = "Freq2display";
            this.Freq2display.Size = new System.Drawing.Size(109, 20);
            this.Freq2display.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Freq Hz";
            // 
            // runTests
            // 
            this.runTests.Location = new System.Drawing.Point(307, 65);
            this.runTests.Name = "runTests";
            this.runTests.Size = new System.Drawing.Size(189, 49);
            this.runTests.TabIndex = 8;
            this.runTests.Text = "run tests";
            this.runTests.UseVisualStyleBackColor = true;
            this.runTests.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 381);
            this.Controls.Add(this.runTests);
            this.Controls.Add(this.Freq2display);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.Freq1display);
            this.Controls.Add(this.Hz);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label Hz;
        private System.Windows.Forms.TextBox Freq1display;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TextBox Freq2display;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button runTests;
    }
}

