using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Stock_Data_Analyzer
{
    public partial class formLoader : Form
    {
        ///initial definition of variables
        readCSV candlestickRead = null;
        List<candlestick> candlestickList = null;
        formChart chartForm = null;
        public formLoader()
        {
            ///intialization of important variables at startup
            InitializeComponent();
            candlestickRead = new readCSV();
            candlestickList = new List<candlestick>();
            chartForm = new formChart(candlestickList);
            ThemeManager.OnThemeChanged += ApplyTheme;
            ApplyTheme();


        }

    private void Form_Load(object sender, EventArgs e)
        {
            ///period defined by the radiobutton selected
            string period = String.Empty;
            if (dailyRadio.Checked) { period = "Day"; }
            else if (weeklyRadio.Checked) { period = "Week"; }
            else if (monthlyRadio.Checked) { period = "Month"; }
            else { period = "Day"; }
            ///populate the ComboBox with the appropriate files based on the period
            string[] files = Directory.GetFiles(@"Stock Data\", $"*-{period}.csv");

            foreach (var file in files)
            {
                string fileName = Path.GetFileName(file);
                string ticker = fileName.Split('-')[0];
                comboStock.Items.Add(ticker);
            }
        }

        /// Handles calls for darkmode/lightmode
        public void ApplyTheme(bool isDarkMode = false)
        {
            if (isDarkMode)
            {
                this.BackColor = Color.FromArgb(50, 54, 115);
                STARTDATE.ForeColor = Color.FromArgb(255, 255, 255);
                ENDDATE.ForeColor = Color.FromArgb(255, 255, 255);
                PERIOD.ForeColor = Color.FromArgb(255, 255, 255);
                labelTicker.ForeColor = Color.FromArgb(255, 255, 255);
                dailyRadio.ForeColor = Color.FromArgb(255, 255, 255);
                weeklyRadio.ForeColor = Color.FromArgb(255, 255, 255);
                monthlyRadio.ForeColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                this.BackColor = SystemColors.Control;
                STARTDATE.ForeColor = Color.FromArgb(0, 0, 0);
                ENDDATE.ForeColor = Color.FromArgb(0, 0, 0);
                PERIOD.ForeColor = Color.FromArgb(0, 0, 0);
                labelTicker.ForeColor = Color.FromArgb(0, 0, 0);
                dailyRadio.ForeColor = Color.FromArgb(0, 0, 0);
                weeklyRadio.ForeColor = Color.FromArgb(0, 0, 0);
                monthlyRadio.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }


        private void loadbtn_Click(object sender, EventArgs e)
        {
            /// Check if a period is selected
            if (!dailyRadio.Checked && !weeklyRadio.Checked && !monthlyRadio.Checked)
            {
                MessageBox.Show("No period selected!");
                return;
            }

            /// Check if a ticker has been selected
            if (comboStock.SelectedIndex == -1)
            {
                MessageBox.Show("No ticker selected!");
                return;
            }

            /// Clears chart and datagrid
            candlestickList.Clear();

            /// Ticker defined by the ComboBox selected
            string ticker = comboStock.Text;

            /// Period defined by the radiobutton selected
            string period = String.Empty;
            if (dailyRadio.Checked) { period = "Day"; }
            else if (weeklyRadio.Checked) { period = "Week"; }
            else if (monthlyRadio.Checked) { period = "Month"; }
            else { period = "Day"; }

            /// Translate candlestick class container to datagridview, also sends through some text to certain labels
            candlestickList = candlestickRead.readStock(ticker, period, dateStart.Value, dateEnd.Value);

            /// Create a deep copy of the data to avoid sharing the same data across forms
            List<candlestick> independentData = candlestickList.Select(c => new candlestick(c)).ToList();


            /// Create a new instance of the formChart class with the deep copied data
            formChart chartForm = new formChart(independentData);

            /// Subscribe to the OnThemeChanged event
            ThemeManager.OnThemeChanged += chartForm.ApplyTheme;

            /// Apply the current theme
            chartForm.ApplyTheme(ThemeManager.GetCurrentDarkModeStatus());


            /// Set the form's name to the selected ticker
            chartForm.SetFormName(comboStock.Text, period);


            /// Clear and initialize the chart on the new form
            chartForm.chartMain.Series.Clear();
            chartForm.chartMain.Series.Add("Candlestick");
            chartForm.chartMain.Series["Candlestick"].ChartType = SeriesChartType.Candlestick;
            chartForm.chartMain.Series["Candlestick"]["ShowOpenClose"] = "Both";
            chartForm.chartMain.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            chartForm.chartMain.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            chartForm.chartMain.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd/yyyy";
            chartForm.chartMain.Series["Candlestick"].XValueType = ChartValueType.Date;
            chartForm.chartMain.Series["Candlestick"].IsVisibleInLegend = false;

            /// Add uptrend series to the chart legend
            Series uptrendSeries = chartForm.chartMain.Series.Add("uptrend");
            uptrendSeries.ChartType = SeriesChartType.Point;
            uptrendSeries.Color = Color.Green;
            uptrendSeries.MarkerStyle = MarkerStyle.Square;
            uptrendSeries.MarkerSize = 10;

            /// Add downtrend series to the chart legend
            Series downtrendSeries = chartForm.chartMain.Series.Add("downtrend");
            downtrendSeries.ChartType = SeriesChartType.Point;
            downtrendSeries.Color = Color.White;
            downtrendSeries.MarkerStyle = MarkerStyle.Square;
            downtrendSeries.MarkerSize = 10;
            downtrendSeries.MarkerBorderColor = Color.Red;


            foreach (var c in independentData)
            {
                /// Create a new data point for the candlestick
                DataPoint dp = new DataPoint();
                dp.SetValueXY(c.Date, c.High, c.Low, c.Open, c.Close);

                /// Set the color of the data point based on whether it resembles a Classic Doji pattern
                dp.Color = c.Open < c.Close ? Color.Green :
                    c.Open > c.Close ? Color.Red :
                    Color.Black;
                dp.BorderWidth = 1;

                /// Add the data point to the "Candlestick" series
                chartForm.chartMain.Series["Candlestick"].Points.Add(dp);
            }

            /// sets highest and lowest value of the charts y-axis
            decimal lowestValue = independentData.Min(c => c.Low);
            decimal highestValue = independentData.Max(c => c.High);

            chartForm.chartMain.ChartAreas[0].AxisY.Minimum = (double)lowestValue;
            chartForm.chartMain.ChartAreas[0].AxisY.Maximum = (double)highestValue;

            /// Show the new form
            chartForm.Show();
        }


        private void darkmodeBtn_Click(object sender, EventArgs e)
        {
            ThemeManager.ToggleTheme();
        }

        private void start_ValueChanged(object sender, EventArgs e)
        {

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            candlestickList.Clear();
        }

        private void disclaimer_Click(object sender, EventArgs e)
        {

        }

    }
}
