namespace Graph.Helpers
{
    public static class InputHelper
    {
        // перевірка рядка на наявність літер
        public static bool ParseDoubleInput(string input, string nameOfField, out double value)
        {
            var isValid = double.TryParse(input, out value);
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show($"{nameOfField} cannot be empty");
            }
            if (!isValid)
            {
                MessageBox.Show($"{nameOfField} cannot contain letters");
            }
            return isValid;
        }
    }
}
