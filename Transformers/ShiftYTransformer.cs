using System.Windows.Forms.DataVisualization.Charting;

namespace Graph.Transformers
{
    public class ShiftYTransformer : ITransformer
    {
        public void Transform(Series series, double coefficient)
        {
            foreach (var point in series.Points)
            {
                var y = point.YValues.First() + coefficient; // додаємо до точки коефіцієнт

                point.YValues = new[] { y };
            }
        }
    }
}
