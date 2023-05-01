namespace Stock_Data_Analyzer
{
    partial class formLoader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLoader));
            this.loadBtn = new System.Windows.Forms.Button();
            this.testLabel = new System.Windows.Forms.Label();
            this.PERIOD = new System.Windows.Forms.Label();
            this.dailyRadio = new System.Windows.Forms.RadioButton();
            this.weeklyRadio = new System.Windows.Forms.RadioButton();
            this.monthlyRadio = new System.Windows.Forms.RadioButton();
            this.STARTDATE = new System.Windows.Forms.Label();
            this.ENDDATE = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.comboStock = new System.Windows.Forms.ComboBox();
            this.labelTicker = new System.Windows.Forms.Label();
            this.darkmodeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(76, 444);
            this.loadBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(248, 108);
            this.loadBtn.TabIndex = 2;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(832, 579);
            this.testLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(0, 25);
            this.testLabel.TabIndex = 3;
            // 
            // PERIOD
            // 
            this.PERIOD.AutoSize = true;
            this.PERIOD.Location = new System.Drawing.Point(40, 271);
            this.PERIOD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PERIOD.Name = "PERIOD";
            this.PERIOD.Size = new System.Drawing.Size(91, 25);
            this.PERIOD.TabIndex = 5;
            this.PERIOD.Text = "PERIOD";
            // 
            // dailyRadio
            // 
            this.dailyRadio.AutoSize = true;
            this.dailyRadio.Location = new System.Drawing.Point(30, 310);
            this.dailyRadio.Margin = new System.Windows.Forms.Padding(4);
            this.dailyRadio.Name = "dailyRadio";
            this.dailyRadio.Size = new System.Drawing.Size(91, 29);
            this.dailyRadio.TabIndex = 6;
            this.dailyRadio.TabStop = true;
            this.dailyRadio.Text = "Daily";
            this.dailyRadio.UseVisualStyleBackColor = true;
            // 
            // weeklyRadio
            // 
            this.weeklyRadio.AutoSize = true;
            this.weeklyRadio.Location = new System.Drawing.Point(30, 356);
            this.weeklyRadio.Margin = new System.Windows.Forms.Padding(4);
            this.weeklyRadio.Name = "weeklyRadio";
            this.weeklyRadio.Size = new System.Drawing.Size(114, 29);
            this.weeklyRadio.TabIndex = 7;
            this.weeklyRadio.TabStop = true;
            this.weeklyRadio.Text = "Weekly";
            this.weeklyRadio.UseVisualStyleBackColor = true;
            // 
            // monthlyRadio
            // 
            this.monthlyRadio.AutoSize = true;
            this.monthlyRadio.Location = new System.Drawing.Point(30, 400);
            this.monthlyRadio.Margin = new System.Windows.Forms.Padding(4);
            this.monthlyRadio.Name = "monthlyRadio";
            this.monthlyRadio.Size = new System.Drawing.Size(114, 29);
            this.monthlyRadio.TabIndex = 8;
            this.monthlyRadio.TabStop = true;
            this.monthlyRadio.Text = "Monthy";
            this.monthlyRadio.UseVisualStyleBackColor = true;
            // 
            // STARTDATE
            // 
            this.STARTDATE.AutoSize = true;
            this.STARTDATE.Location = new System.Drawing.Point(120, 40);
            this.STARTDATE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.STARTDATE.Name = "STARTDATE";
            this.STARTDATE.Size = new System.Drawing.Size(143, 25);
            this.STARTDATE.TabIndex = 9;
            this.STARTDATE.Text = "START DATE";
            // 
            // ENDDATE
            // 
            this.ENDDATE.AutoSize = true;
            this.ENDDATE.Location = new System.Drawing.Point(132, 138);
            this.ENDDATE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ENDDATE.Name = "ENDDATE";
            this.ENDDATE.Size = new System.Drawing.Size(118, 25);
            this.ENDDATE.TabIndex = 10;
            this.ENDDATE.Text = "END DATE";
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(12, 83);
            this.dateStart.Margin = new System.Windows.Forms.Padding(4);
            this.dateStart.MaxDate = new System.DateTime(2023, 4, 8, 0, 0, 0, 0);
            this.dateStart.MinDate = new System.DateTime(2018, 4, 7, 0, 0, 0, 0);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(360, 31);
            this.dateStart.TabIndex = 11;
            this.dateStart.Value = new System.DateTime(2018, 4, 7, 0, 0, 0, 0);
            this.dateStart.ValueChanged += new System.EventHandler(this.start_ValueChanged);
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(12, 179);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dateEnd.MaxDate = new System.DateTime(2023, 4, 8, 0, 0, 0, 0);
            this.dateEnd.MinDate = new System.DateTime(2018, 4, 7, 0, 0, 0, 0);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(360, 31);
            this.dateEnd.TabIndex = 12;
            this.dateEnd.Value = new System.DateTime(2023, 4, 7, 0, 0, 0, 0);
            // 
            // comboStock
            // 
            this.comboStock.FormattingEnabled = true;
            this.comboStock.Location = new System.Drawing.Point(216, 306);
            this.comboStock.Margin = new System.Windows.Forms.Padding(4);
            this.comboStock.Name = "comboStock";
            this.comboStock.Size = new System.Drawing.Size(120, 33);
            this.comboStock.TabIndex = 16;
            // 
            // labelTicker
            // 
            this.labelTicker.AutoSize = true;
            this.labelTicker.Location = new System.Drawing.Point(228, 271);
            this.labelTicker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTicker.Name = "labelTicker";
            this.labelTicker.Size = new System.Drawing.Size(88, 25);
            this.labelTicker.TabIndex = 17;
            this.labelTicker.Text = "TICKER";
            // 
            // darkmodeBtn
            // 
            this.darkmodeBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.darkmodeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("darkmodeBtn.BackgroundImage")));
            this.darkmodeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.darkmodeBtn.Location = new System.Drawing.Point(339, 12);
            this.darkmodeBtn.Name = "darkmodeBtn";
            this.darkmodeBtn.Size = new System.Drawing.Size(33, 34);
            this.darkmodeBtn.TabIndex = 18;
            this.darkmodeBtn.UseVisualStyleBackColor = false;
            this.darkmodeBtn.Click += new System.EventHandler(this.darkmodeBtn_Click);
            // 
            // formLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 566);
            this.Controls.Add(this.darkmodeBtn);
            this.Controls.Add(this.labelTicker);
            this.Controls.Add(this.comboStock);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.ENDDATE);
            this.Controls.Add(this.STARTDATE);
            this.Controls.Add(this.monthlyRadio);
            this.Controls.Add(this.weeklyRadio);
            this.Controls.Add(this.dailyRadio);
            this.Controls.Add(this.PERIOD);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.loadBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formLoader";
            this.Text = "Stock Selection";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Label testLabel;
        public System.Windows.Forms.Label PERIOD;
        private System.Windows.Forms.RadioButton dailyRadio;
        private System.Windows.Forms.RadioButton weeklyRadio;
        private System.Windows.Forms.RadioButton monthlyRadio;
        private System.Windows.Forms.Label STARTDATE;
        private System.Windows.Forms.Label ENDDATE;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.ComboBox comboStock;
        private System.Windows.Forms.Label labelTicker;
        private System.Windows.Forms.Button darkmodeBtn;
    }
}

