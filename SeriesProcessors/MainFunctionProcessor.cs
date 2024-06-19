using Graph.Models;
using AutoFixture;
using System;

namespace Graph.SeriesProcessors
{
    public class MainFunctionProcessor : ISeriesProcessor
    {
        public List<SeriesPoint> Process(SeriesDetails details)
        {
            var result = new List<SeriesPoint>();

            foreach (var x in details.XPoints)
            {
                if (x == 0)
                {
                    var y = x;
                    result.Add(new SeriesPoint(x, y));
                }
                else if (x > 8 && x <= 10)
                {
                    // 0.2 це п'ятий корінь, еквівалентний (2 / (7 * x))^(1/5)
                    var y = (Math.Log(Math.Sqrt(Math.Abs(2 - x)) + 6, 2)) * (1 / (2 + Math.Exp(Math.Abs(-x)))) + Math.Pow(2.0 / (7 * x), 0.2);
                    result.Add(new SeriesPoint(x, y));
                }
                else if (x >= -5 && x < 0 && x > 0 && x <= 5)
                {
                    var y = Math.Pow(x, -25);
                    result.Add(new SeriesPoint(x, y));
                }
                else
                {
                    var y = Math.Pow(x, -17) - 6;
                    result.Add(new SeriesPoint(x, y));
                }
            }
            return result;
        }
    }
}
