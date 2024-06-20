using System.Windows.Forms.DataVisualization.Charting;

namespace Graph.Transformers
{
    public class StretchXTransformer : ITransformer
    {
        public void Transform(Series series, double coefficient)
        {
            foreach (var point in series.Points)
            {
                double x = coefficient < 0
                    ? point.XValue * Math.Abs(coefficient) // якщо коефіцієнт від'ємний, то ми множимо точку на його абсолютне значення
                    : point.XValue / coefficient;           // якщо коефіцієнт додатній, то ми ділимо точку на його значення

                point.XValue = x;
            }
        }
    }
}
