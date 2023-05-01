using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// initalization of abstract class
namespace Stock_Data_Analyzer
{
    public abstract class PatternRecognizer
    {
        public bool PatternFound { get; set; }
        public abstract bool RecognizePattern(candlestick candle, candlestick previousCandle = null);
    }

    ///hammer pattern recognizer
    public class Hammer : PatternRecognizer
    {
        public override bool RecognizePattern(candlestick candle, candlestick previousCandle = null)
        {

            if (candle.lowerShadowSize >= 1.2m * candle.bodySize && candle.upperShadowSize <= .4m * candle.bodySize + 0.05m * candle.totalSize)
            {
                return true;
            }

            return false;
        }
    }

    ///inverted hammer pattern recognizer
    public class Inverted_Hammer : PatternRecognizer
    {
        public override bool RecognizePattern(candlestick candle, candlestick previousCandle = null)
        {

            if (candle.upperShadowSize >= 1.2m * candle.bodySize && candle.lowerShadowSize <= .4m * candle.bodySize + 0.05m * candle.totalSize)
            {
                return true;
            }

            return false;
        }
    }

    ///bullish marubozo pattern recognizer
    public class Good_Marubozo : PatternRecognizer
    {
        public override bool RecognizePattern(candlestick candle, candlestick previousCandle = null)
        {
            if (previousCandle == null)
            {
                return false;
            }

            decimal toleranceFactor = 0.1m;
            decimal bodySizeTolerance = toleranceFactor * candle.totalSize;

            if (candle.bodySize >= (1m - toleranceFactor) * previousCandle.bodySize && candle.upperShadowSize <= bodySizeTolerance && candle.lowerShadowSize <= bodySizeTolerance && candle.Close > candle.Open)
            {
                return true;
            }

            return false;
        }
    }

    ///bearish marubozo pattern recognizer
    public class Bad_Marubozo : PatternRecognizer
    {
        public override bool RecognizePattern(candlestick candle, candlestick previousCandle = null)
        {
            if (previousCandle == null)
            {
                return false;
            }

            decimal toleranceFactor = 0.1m;
            decimal bodySizeTolerance = toleranceFactor * candle.totalSize;

            if (candle.bodySize >= (1m - toleranceFactor) * previousCandle.bodySize && candle.upperShadowSize <= bodySizeTolerance && candle.lowerShadowSize <= bodySizeTolerance && candle.Close < candle.Open)
            {
                return true;
            }

            return false;
        }
    }

    ///gravestone doji pattern recognizer
    public class Gravestone_Doji : PatternRecognizer
    {
        public override bool RecognizePattern(candlestick candle, candlestick previousCandle = null)
        {
            decimal bodySizeTolerance = 0.1m;
            decimal maxBodySize = (1 - 2 * bodySizeTolerance) * candle.totalSize;

            if (candle.upperShadowSize >= 2 * maxBodySize && candle.lowerShadowSize <= 0m * maxBodySize && candle.bodySize <= maxBodySize)
            {
                return true;
            }

            return false;
        }
    }

    ///dragonfly doji pattern recognizer
    public class Dragonfly_Doji : PatternRecognizer
    {
        public override bool RecognizePattern(candlestick candle, candlestick previousCandle = null)
        {
            if (candle.lowerShadowSize >= 2m * candle.bodySize && candle.upperShadowSize <= 0m && candle.bodySize <= 0.2m * candle.totalSize)
            {
                return true;
            }

            return false;
        }
    }


    ///long-legged doji pattern recognizer
    public class Long_Legged_Doji : PatternRecognizer
    {
        public override bool RecognizePattern(candlestick candle, candlestick previousCandle = null)
        {
            decimal bodyToleranceFactor = 0.1m;
            decimal shadowToleranceFactor = 0.1m;

            if (candle.bodySize <= bodyToleranceFactor * candle.totalSize &&
                candle.upperShadowSize >= shadowToleranceFactor * candle.totalSize &&
                candle.lowerShadowSize >= shadowToleranceFactor * candle.totalSize &&
                Math.Abs(candle.upperShadowSize - candle.lowerShadowSize) >= 0.12m * candle.totalSize)
            {
                return true;
            }

            return false;
        }
    }

    ///four-price doji pattern recognizer
    public class Four_Price_Doji : PatternRecognizer
    {
        public override bool RecognizePattern(candlestick candle, candlestick previousCandle = null)
        {
            decimal bodyToleranceFactor = 0.05m; // Increase to make it more lenient towards larger body size
            decimal shadowToleranceFactor = 0.05m; // Decrease to make it more lenient towards shorter shadows

            if (candle.bodySize <= bodyToleranceFactor * candle.totalSize &&
                candle.upperShadowSize <= shadowToleranceFactor * candle.totalSize &&
                candle.lowerShadowSize <= shadowToleranceFactor * candle.totalSize)
            {
                return true;
            }

            return false;
        }
    }

    ///normal doji pattern recognizer
    public class Normal_Doji : PatternRecognizer
    {
        public override bool RecognizePattern(candlestick candle, candlestick previousCandle = null)
        {

            if (candle.upperShadowSize >= .4m * candle.totalSize && candle.lowerShadowSize >= .4m * candle.totalSize && Math.Abs(candle.upperShadowSize - candle.lowerShadowSize) <= 0.5m * candle.totalSize)
            {
                return true;
            }

            return false;
        }
    }

    ///bullish engulfing pattern recognizer
    public class Bullish_Engulfing : PatternRecognizer
    {
        public override bool RecognizePattern(candlestick candle, candlestick previousCandle = null)
        {
            if (previousCandle == null)
            {
                return false;
            }

            if (previousCandle.Open > previousCandle.Close && candle.Open < candle.Close)
            {
                if (candle.Open < previousCandle.Close && candle.Close > previousCandle.Open)
                {
                    return true;
                }
            }

            return false;
        }
    }

    ///bearish engulfing pattern recognizer
    public class Bearish_Engulfing : PatternRecognizer
    {
        public override bool RecognizePattern(candlestick candle, candlestick previousCandle = null)
        {
            if (previousCandle == null)
            {
                return false;
            }

            if (previousCandle.Open < previousCandle.Close && candle.Open > candle.Close)
            {
                if (candle.Open > previousCandle.Close && candle.Close < previousCandle.Open)
                {
                    return true;
                }
            }

            return false;
        }
    }

    ///evening star pattern recognizer
    public class Evening_Star : PatternRecognizer
    {
        public override bool RecognizePattern(candlestick candle, candlestick previousCandle = null)
        {
            if (previousCandle == null)
            {
                return false;
            }

            candlestick firstCandle = previousCandle;
            candlestick secondCandle = candle;
            candlestick thirdCandle = previousCandle;

            bool isFirstCandleBullish = firstCandle.Close > firstCandle.Open;
            bool isThirdCandleBearish = thirdCandle.Close < thirdCandle.Open;

            if (isFirstCandleBullish && isThirdCandleBearish &&
                secondCandle.Open > firstCandle.Close &&
                thirdCandle.Open < secondCandle.Close && thirdCandle.Close < firstCandle.Close)
            {
                return true;
            }

            return false;
        }
    }

    ///morning star pattern recognizer
    public class Morning_Star : PatternRecognizer
    {
        public override bool RecognizePattern(candlestick candle, candlestick previousCandle = null)
        {
            if (previousCandle == null)
            {
                return false;
            }

            candlestick firstCandle = previousCandle;
            candlestick secondCandle = candle;
            candlestick thirdCandle = previousCandle;

            bool isFirstCandleBearish = firstCandle.Close < firstCandle.Open;
            bool isThirdCandleBullish = thirdCandle.Close > thirdCandle.Open;

            if (isFirstCandleBearish && isThirdCandleBullish &&
                secondCandle.Open < firstCandle.Close &&
                thirdCandle.Open > secondCandle.Close && thirdCandle.Close > firstCandle.Close)
            {
                return true;
            }

            return false;
        }
    }

    ///bullish pin bar pattern recognizer
    public class Bullish_Pin_Bar : PatternRecognizer
    {
        public override bool RecognizePattern(candlestick candle, candlestick previousCandle = null)
        {
            decimal bodySizeTolerance = 0.2m;

            if (candle.lowerShadowSize >= 2m * candle.bodySize &&
                candle.upperShadowSize <= bodySizeTolerance * candle.totalSize &&
                candle.Close > candle.Open)
            {
                return true;
            }

            return false;
        }
    }

    ///bearish pin bar pattern recognizer
    public class Bearish_Pin_Bar : PatternRecognizer
    {
        public override bool RecognizePattern(candlestick candle, candlestick previousCandle = null)
        {
            decimal bodySizeTolerance = 0.2m;

            if (candle.upperShadowSize >= 2m * candle.bodySize &&
                candle.lowerShadowSize <= bodySizeTolerance * candle.totalSize &&
                candle.Close < candle.Open)
            {
                return true;
            }

            return false;
        }
    }

    ///bullish harami pattern recognizer
    public class Bullish_Harami : PatternRecognizer
    {
        public override bool RecognizePattern(candlestick candle, candlestick previousCandle = null)
        {
            if (previousCandle == null)
            {
                return false;
            }

            if (previousCandle.Close < previousCandle.Open &&
                candle.Close > candle.Open &&
                candle.Close < previousCandle.Close &&
                candle.Open > previousCandle.Open)
            {
                return true;
            }

            return false;
        }
    }

    ///bearish harami pattern recognizer
    public class Bearish_Harami : PatternRecognizer
    {
        public override bool RecognizePattern(candlestick candle, candlestick previousCandle = null)
        {
            if (previousCandle == null)
            {
                return false;
            }

            if (previousCandle.Close > previousCandle.Open &&
                candle.Close < candle.Open &&
                candle.Close > previousCandle.Close &&
                candle.Open < previousCandle.Open)
            {
                return true;
            }

            return false;
        }
    }


}
