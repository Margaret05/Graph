using System.Windows.Forms.DataVisualization.Charting;

namespace Graph.Transformers
{
    public class StretchYTransformer : ITransformer
    {
        public void Transform(Series series, double coefficient)
        {
            foreach (var point in series.Points)
            {
                var yValue = point.YValues.First();

                double y = coefficient < 0
                    ? yValue * Math.Abs(coefficient)// якщо коефіцієнт від'ємний, то ми множимо точку на його абсолютне значення
                    : yValue / coefficient;         // якщо коефіцієнт додатній, то ми ділимо точку на його значення

                point.YValues = new[] { y };
            }
        }
    }
}
