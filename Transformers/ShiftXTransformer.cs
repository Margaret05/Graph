﻿using System.Windows.Forms.DataVisualization.Charting;

namespace Graph.Transformers
{
    public class ShiftXTransformer : ITransformer
    {
        public void Transform(Series series, double coefficient)
        {
            foreach (var point in series.Points)
            {
                var x = point.XValue + coefficient;// додаємо до точки коефіцієнт

                point.XValue = x;
            }
        }
    }
}
