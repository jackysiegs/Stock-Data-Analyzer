using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Data_Analyzer
{
    ///class for my candlestick data so that it can be translated to datagridview
    public class candlestick
    {
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public long Volume { get; set; }

        ///variables that define candlestick properties
        public decimal bodySize => Math.Abs(Close - Open);
        public decimal upperShadowSize => High - Math.Max(Close, Open);
        public decimal lowerShadowSize => Math.Min(Close, Open) - Low;
        public decimal totalSize => High - Low;

        public candlestick(DateTime date, decimal open, decimal high, decimal low, decimal close, long volume)
        {
            Date = date;
            Open = open;
            High = high;
            Low = low;
            Close = close;
            Volume = volume;
        }

        /// class defining the storage of data for each individual chart spawned
        public candlestick(candlestick other)
        {
            Date = other.Date;
            Open = other.Open;
            High = other.High;
            Low = other.Low;
            Close = other.Close;
            Volume = other.Volume;
        }



    }


}

