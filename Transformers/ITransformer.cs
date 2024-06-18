using System.Windows.Forms.DataVisualization.Charting;

namespace Graph.Transformers
{
    public interface ITransformer
    {
        public void Transform(Series series, double coefficient);
    }
}
