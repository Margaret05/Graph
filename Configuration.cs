﻿using Graph.Enums;
using Graph.SeriesProcessors;
using Graph.Transformers;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graph
{
    // статичний клас, куди ми занесли усі налаштування нашого проекту.
    public static class Configuration
    {
        // Ми поставили у відповідність до кожного варіанту з випадаючого списку - його аналог у ChartArea
        public static Dictionary<ChartSeriesDisplayType, SeriesChartType> TypeMappings =

            new Dictionary<ChartSeriesDisplayType, SeriesChartType>
            {
                { ChartSeriesDisplayType.Point, SeriesChartType.Point },
                { ChartSeriesDisplayType.Column, SeriesChartType.Column },
                { ChartSeriesDisplayType.Spline, SeriesChartType.Spline }
            };

        // Ми вказали, для якого графіку використовувати який спосіб побудови
        public static Dictionary<string, ISeriesProcessor> SeriesMappings =

            new Dictionary<string, ISeriesProcessor>
            {
                { Constants.MainFunctionSeries, new MainFunctionProcessor() },
                { Constants.LinearSeries,  new LinearProcessor() },
                { Constants.SinSeries,  new SinProcessor() },
                { Constants.RandomSeries, new RandomProcessor() }

            };

        // Ми вказали, як змінювати графіки в залежності від натиснутого чекбоксу
        public static Dictionary<string, ITransformer> TransformMappings =

            new Dictionary<string, ITransformer>
            {
                { Constants.ShiftXCheckBox,  new ShiftXTransformer() },
                { Constants.ShiftYCheckBox,  new ShiftYTransformer() },
                { Constants.StretchXCheckBox,  new StretchXTransformer() },
                { Constants.StretchYCheckBox,  new StretchYTransformer() },
            };
    }
}
