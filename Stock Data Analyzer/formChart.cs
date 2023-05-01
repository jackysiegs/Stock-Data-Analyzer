using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Stock_Data_Analyzer
{
    public partial class formChart : Form
    {
        /// Sets up List elements for candlestick and PatternRecognizer
        private List<candlestick> _candlestickList;
        private List<PatternRecognizer> _patternRecognizers;
        public formChart(List<candlestick> candlestickList)
        {
            ///  Defines candlestickList and checks the list of PatternRecognizer for each pattern and sets up darkmode/lightmode
            InitializeComponent();

            ThemeManager.OnThemeChanged += ApplyTheme;
            ApplyTheme();

            this.FormClosed += formChart_FormClosed;

            EnableChartZoomingAndScrolling();
            _candlestickList = candlestickList;

            UpdatePatternColors();

            _patternRecognizers = new List<PatternRecognizer>
            {
                new Hammer(),
                new Inverted_Hammer(),
                new Good_Marubozo(),
                new Bad_Marubozo(),
                new Gravestone_Doji(),
                new Dragonfly_Doji(),
                new Long_Legged_Doji(),
                new Four_Price_Doji(),
                new Normal_Doji(),
                new Bullish_Engulfing(),
                new Bearish_Engulfing(),
                new Morning_Star(),
                new Evening_Star(),
                new Bullish_Pin_Bar(),
                new Bearish_Pin_Bar(),
                new Bullish_Harami(),
                new Bearish_Harami()
                
            };

            DetectPatterns();
        }

        private void formChart_FormClosed(object sender, FormClosedEventArgs e)
        {
            ThemeManager.OnThemeChanged -= ApplyTheme;
        }

        /// Handles calls for darkmode/lightmode
        public void ApplyTheme(bool isDarkMode = false)
        {
            if (isDarkMode)
            {
                this.BackColor = Color.FromArgb(50, 54, 115);
                chartMain.BackColor = Color.FromArgb(50, 54, 115);
                chartMain.ChartAreas[0].BackColor = Color.FromArgb(50, 54, 115);
                chartMain.Legends[0].BackColor = Color.FromArgb(50, 54, 115);
                chartMain.Legends[0].ForeColor = Color.FromArgb(255, 255, 255);
                chartMain.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.FromArgb(255, 255, 255);
                chartMain.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.FromArgb(255, 255, 255);
                PATTERNS.ForeColor = Color.FromArgb(255, 255, 255);
                zoomuse.ForeColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                this.BackColor = SystemColors.Control;
                chartMain.BackColor = SystemColors.Control;
                chartMain.ChartAreas[0].BackColor = SystemColors.Control;
                chartMain.Legends[0].BackColor = SystemColors.Control;
                chartMain.Legends[0].ForeColor = Color.FromArgb(0, 0, 0);
                chartMain.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.FromArgb(0, 0, 0);
                chartMain.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.FromArgb(0, 0, 0);
                PATTERNS.ForeColor = Color.FromArgb(0, 0, 0);
                zoomuse.ForeColor = Color.FromArgb(0, 0, 0);
            }

            UpdatePatternColors();
        }

        /// Updates annotations depending on darmode toggle
        private void UpdatePatternColors()
        {
            if (_patternRecognizers == null)
            {
                return;
            }

            Color color;
            Color labelColor;

            if (chartMain.BackColor == Color.FromArgb(50, 54, 115))
            {
                color = Color.Orange;
                labelColor = Color.White;
            }
            else
            {
                color = Color.Purple;
                labelColor = Color.Black;
            }

            foreach (var patternRecognizer in _patternRecognizers)
            {
                string patternName = patternRecognizer.GetType().Name;
                if (chartMain.Series.IndexOf(patternName) != -1)
                {
                    chartMain.Series[patternName].Color = color;
                    foreach (var point in chartMain.Series[patternName].Points)
                    {
                        point.Color = color;
                        point.LabelForeColor = labelColor;
                    }
                }
            }
        }



        /// sets name of the form to the ticker and period
        public void SetFormName(string ticker, string period)
        {
            this.Text = ticker + "-" + period;
        }

        /// if pattern is detected in chart then it is added to the combobox
        private void DetectPatterns()
        {
            foreach (var patternRecognizer in _patternRecognizers)
            {
                for (int i = 1; i < _candlestickList.Count; i++)
                {
                    var candle = _candlestickList[i];
                    var previousCandle = _candlestickList[i - 1];

                    if (patternRecognizer.RecognizePattern(candle, previousCandle))
                    {
                        string patternName = patternRecognizer.GetType().Name;
                        comboPattern.Items.Add(patternName);
                        patternRecognizer.PatternFound = true;
                        break;
                    }
                }
            }
        }

        private void EnableChartZoomingAndScrolling()
        {
            /// Enable range selection and zooming for the X-axis
            chartMain.ChartAreas[0].CursorX.IsUserEnabled = true;
            chartMain.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartMain.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chartMain.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            /// Enable range selection and zooming for the Y-axis
            chartMain.ChartAreas[0].CursorY.IsUserEnabled = true;
            chartMain.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chartMain.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chartMain.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;

            /// Set the color and width of the zooming rectangle
            chartMain.ChartAreas[0].CursorX.SelectionColor = Color.LightGray;
            chartMain.ChartAreas[0].CursorX.LineWidth = 1;
            chartMain.ChartAreas[0].CursorY.SelectionColor = Color.LightGray;
            chartMain.ChartAreas[0].CursorY.LineWidth = 1;
        }



        /// annotates pattern on chart depending on what pattern was selected in the combobox
        private void patternBtn_Click(object sender, EventArgs e)
        {
            /// sends error message to user if no pattern is selected
            if (comboPattern.SelectedItem == null)
            {
                MessageBox.Show("No pattern selected!");
                return;
            }
            string selectedPattern = comboPattern.SelectedItem.ToString();

            /// Remove any previously selected pattern
            foreach (var patternRecognizer in _patternRecognizers)
            {
                string patternName = patternRecognizer.GetType().Name;
                if (chartMain.Series.IndexOf(patternName) != -1)
                {
                    chartMain.Series.Remove(chartMain.Series[patternName]);
                }
            }

            var color = Color.Purple;
            var labelColor = Color.Black;

            if (chartMain.BackColor == Color.FromArgb(50, 54, 115))
            {
                color = Color.Orange;
                labelColor = Color.White;
            }
            /// loop that runs through the chart and annotates candlesticks of the respective pattern
            foreach (var patternRecognizer in _patternRecognizers)
            {
                string patternName = patternRecognizer.GetType().Name;
                if (patternName == selectedPattern && patternRecognizer.PatternFound)
                {
                    chartMain.Series.Add(patternName);
                    chartMain.Series[patternName].ChartType = SeriesChartType.Candlestick;
                    chartMain.Series[patternName]["ShowOpenClose"] = "Both";
                    chartMain.Series[patternName].Color = color;
                    chartMain.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
                    chartMain.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
                    chartMain.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd/yyyy";
                    chartMain.Series[patternName].XValueType = ChartValueType.Date;

                    var patternType = patternRecognizer.GetType().Name;
                    

                    for (int i = 1; i < _candlestickList.Count; i++)
                    {
                        var candle = _candlestickList[i];
                        var previousCandle = _candlestickList[i - 1];

                        if (patternRecognizer.RecognizePattern(candle, previousCandle))
                        {
                            var dp = new DataPoint();
                            dp.SetValueXY(candle.Date, candle.High, candle.Low, candle.Open, candle.Close);
                            dp.Color = color;
                            dp.BorderWidth = 2;
                            dp.LabelForeColor = labelColor;
                            dp.Label = patternType;
                            chartMain.Series[patternName].Points.Add(dp);


                            if (patternRecognizer is Bullish_Engulfing || patternRecognizer is Bearish_Engulfing)
                            {
                                var prevCandleDp = new DataPoint();
                                prevCandleDp.SetValueXY(previousCandle.Date, previousCandle.High, previousCandle.Low, previousCandle.Open, previousCandle.Close);
                                prevCandleDp.Color = color;
                                prevCandleDp.BorderWidth = 2;
                                chartMain.Series[patternName].Points.Add(prevCandleDp);
                            }
                        }
                    }
                }
            }
        }


        private void resetBtn_Click(object sender, EventArgs e)
        {
            /// Remove any previously selected pattern
            foreach (var patternRecognizer in _patternRecognizers)
            {
                string patternName = patternRecognizer.GetType().Name;
                if (chartMain.Series.IndexOf(patternName) != -1)
                {
                    chartMain.Series.Remove(chartMain.Series[patternName]);
                }
            }

            /// Clear the selected pattern in the combobox
            comboPattern.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        /// Resets zoom
        private void zoomBtn_Click(object sender, EventArgs e)
        {
            chartMain.ChartAreas[0].AxisX.ScaleView.ZoomReset();
            chartMain.ChartAreas[0].AxisY.ScaleView.ZoomReset();
        }

        private void chartMain_Click(object sender, EventArgs e)
        {

        }
    }
}
