namespace Stock_Data_Analyzer
{
    partial class formChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formChart));
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboPattern = new System.Windows.Forms.ComboBox();
            this.PATTERNS = new System.Windows.Forms.Label();
            this.patternBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.zoom_Btn = new System.Windows.Forms.Button();
            this.zoomuse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMain
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMain.Legends.Add(legend1);
            this.chartMain.Location = new System.Drawing.Point(0, -4);
            this.chartMain.Margin = new System.Windows.Forms.Padding(4);
            this.chartMain.Name = "chartMain";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMain.Series.Add(series1);
            this.chartMain.Size = new System.Drawing.Size(2168, 1096);
            this.chartMain.TabIndex = 0;
            this.chartMain.Text = "chart1";
            this.chartMain.Click += new System.EventHandler(this.chartMain_Click);
            // 
            // comboPattern
            // 
            this.comboPattern.FormattingEnabled = true;
            this.comboPattern.Location = new System.Drawing.Point(1903, 243);
            this.comboPattern.Margin = new System.Windows.Forms.Padding(4);
            this.comboPattern.Name = "comboPattern";
            this.comboPattern.Size = new System.Drawing.Size(210, 33);
            this.comboPattern.TabIndex = 1;
            // 
            // PATTERNS
            // 
            this.PATTERNS.AutoSize = true;
            this.PATTERNS.Location = new System.Drawing.Point(1959, 195);
            this.PATTERNS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PATTERNS.Name = "PATTERNS";
            this.PATTERNS.Size = new System.Drawing.Size(92, 25);
            this.PATTERNS.TabIndex = 2;
            this.PATTERNS.Text = "Patterns";
            // 
            // patternBtn
            // 
            this.patternBtn.Location = new System.Drawing.Point(1934, 303);
            this.patternBtn.Margin = new System.Windows.Forms.Padding(4);
            this.patternBtn.Name = "patternBtn";
            this.patternBtn.Size = new System.Drawing.Size(148, 63);
            this.patternBtn.TabIndex = 3;
            this.patternBtn.Text = "Load";
            this.patternBtn.UseVisualStyleBackColor = true;
            this.patternBtn.Click += new System.EventHandler(this.patternBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(1957, 393);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(6);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(105, 37);
            this.resetBtn.TabIndex = 4;
            this.resetBtn.Text = "Clear";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // zoom_Btn
            // 
            this.zoom_Btn.Location = new System.Drawing.Point(1934, 606);
            this.zoom_Btn.Name = "zoom_Btn";
            this.zoom_Btn.Size = new System.Drawing.Size(148, 37);
            this.zoom_Btn.TabIndex = 5;
            this.zoom_Btn.Text = "Zoom-out";
            this.zoom_Btn.UseVisualStyleBackColor = true;
            this.zoom_Btn.Click += new System.EventHandler(this.zoomBtn_Click);
            // 
            // zoomuse
            // 
            this.zoomuse.AutoSize = true;
            this.zoomuse.Location = new System.Drawing.Point(1898, 535);
            this.zoomuse.Name = "zoomuse";
            this.zoomuse.Size = new System.Drawing.Size(216, 50);
            this.zoomuse.TabIndex = 6;
            this.zoomuse.Text = "drag over any portion\r\nof the graph to zoom\r\n";
            // 
            // formChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2140, 940);
            this.Controls.Add(this.zoomuse);
            this.Controls.Add(this.zoom_Btn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.patternBtn);
            this.Controls.Add(this.PATTERNS);
            this.Controls.Add(this.comboPattern);
            this.Controls.Add(this.chartMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formChart";
            this.Text = "Stock Display";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formChart_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.ComboBox comboPattern;
        private System.Windows.Forms.Label PATTERNS;
        private System.Windows.Forms.Button patternBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button zoom_Btn;
        public System.Windows.Forms.Label zoomuse;
    }
}