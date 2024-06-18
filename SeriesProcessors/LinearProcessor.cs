using Graph.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Graph.SeriesProcessors
{
    public class LinearProcessor : ISeriesProcessor
    {
        public List<SeriesPoint> Process(SeriesDetails details)
        {
            var result = new List<SeriesPoint>();

            foreach (var x in details.XPoints)
            {
                var y = x;

                result.Add(new SeriesPoint(x, y));
            }
            return result;
        }
    }
}
