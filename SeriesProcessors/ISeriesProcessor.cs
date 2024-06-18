using Graph.Models;

namespace Graph.SeriesProcessors
{
    // визначає прототип класів, які будуть займатися будуванням графіків.
    // Тобто кожний новий клас, який хочу унаслідувати цей інтерфейс має визначити свою реалізацію методу Process
    public interface ISeriesProcessor
    {
        public List<SeriesPoint> Process(SeriesDetails details);
    }
}
