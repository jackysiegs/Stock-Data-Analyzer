using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Data_Analyzer
{
    public class readCSV
    {
        ///definition of initial variables
        const string dataFolder = "Stock Data";
        public List<candlestick> candlestickList = null;
        public List<long> volumeList = null;
        public long Fail = 69;

        public readCSV()
        {
            ///assignment of lists (one of these was a test list I used)
            candlestickList = new List<candlestick>(256);
            volumeList = new List<long>(256);
        }

        static List<string[]> ReadCSV(string filename)
        {
            ///reads through file from filename
            List<string[]> data = new List<string[]>();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] row = line.Split(',');
                    data.Add(row);
                }
            }
            return data;
        }

        public List<candlestick> readList(string csvFilename, DateTime startDate, DateTime endDate)
        {
            string filename = csvFilename;
            List<string[]> stockData = ReadCSV(filename);

            /// print the stock data to the console
            foreach (string[] row in stockData)
            {
                Console.WriteLine("Date: {0}, Open: {1}, High: {2}, Low: {3}, Close: {4}, Volume: {5}",
                    row[0], row[1], row[2], row[3], row[4], row[6]); 
            }

            /// parse the data into variables
            for (int i = 1; i < stockData.Count; i++)
            { /// start at index 1 to skip the header row
                string[] row = stockData[i];
                DateTime date = DateTime.Parse(row[0]);

                if (date >= startDate && date <= endDate)
                {
                    Decimal Open = decimal.Parse(row[1]);
                    Decimal High = decimal.Parse(row[2]);
                    Decimal Low = decimal.Parse(row[3]);
                    Decimal Close = decimal.Parse(row[4]);
                    long Volume = long.Parse(row[6]);
                    /// do something with the variables

                    candlestick candleStick = new candlestick(date, Open, High, Low, Close, Volume);
                    candlestickList.Add(candleStick);
                }
            }
            return candlestickList;
        }

        public List<candlestick> readStock(String ticker, String period, DateTime startDate, DateTime endDate)
        {
            ///calls readList() and returns data so it can be used with Form1.cs
            String csvFilename = dataFolder + @"\" + ticker + "-" + period + ".csv";
            candlestickList = readList(csvFilename, startDate, endDate);
            return candlestickList;
        }
    }
}
