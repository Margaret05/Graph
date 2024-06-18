using Graph.Models;

namespace Graph.SeriesProcessors
{
    public class RandomProcessor : ISeriesProcessor
    {
        public List<SeriesPoint> Process(SeriesDetails details)
        {
            var result = new List<SeriesPoint>();

            var random = new Random();

            if (!details.RandomMinimum.HasValue || !details.RandomMaximum.HasValue)
                throw new InvalidOperationException("The limits of the random number are not defined");

            var range = details.RandomMaximum.Value - details.RandomMinimum.Value;

            foreach (var x in details.XPoints)
            {
                var randomNumber = random.NextDouble();

                var y = randomNumber * (range) + details.RandomMinimum.Value;

                result.Add(new SeriesPoint(x, y));
            }

            return result;
        }
    }
}
