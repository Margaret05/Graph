using System.ComponentModel;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;
using Graph.Enums;
using Graph.Forms;
using Graph.Helpers;
using Graph.Models;
using Microsoft.VisualBasic;
using OfficeOpenXml;

namespace Graph
{
    public partial class MainForm : Form
    {
        public double? RandomMinimum { get; set; }
        public double? RandomMaximum { get; set; }
        public MainForm()
        {
            InitializeComponent();

            // проставляємо ім'я чекбоксів, щоб вони співпадали з іменем графіків
            SetUpCheckBoxes();
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            // Помістили зчитування усіх вихідних полів у єдиний метод, щоб зробити головну функцію більш стисло
            var isConfigurationValid = Configure(out var xFirst, out var xLast, out var step);

            // якщо перевірка пройдена успішно
            if (isConfigurationValid)
            {
                // очищаємо графіки
                ClearSeries();

                // перевіряємо кінцеві точки ( if a > b => swap (a,b) ) та крок
                ValidateRange(ref xFirst, ref xLast);
                ValidateStep(ref step);

                // перевіряємо, щоб хоча б один графік було обрано. Якщо ні - обрати графік за замовченням
                EnsureSeriesCheckBoxes();

                // отримуємо і записуємо точки
                var xPoints = GetXPoints(xFirst, xLast, step);

                // створюємо об'єкт, який містить інформацію про точки Х, а також додаткові дані необхідні для побудови графіків. У нашому випадку це границі випадкових чисел
                var details = GetSeriesDetails(xPoints);

                // дістаємо імена усіх натиснутих графіків
                var checkedSeries = GetListOfCheckedSeries();

                // проходимося по кожному з них
                foreach (var seriesName in checkedSeries)
                {
                    // дістаємо відповідний графік з нашого графічного компонента
                    var series = DataChart.Series[seriesName];

                    // дістаємо відповідний йому процессор
                    var processor = Configuration.SeriesMappings[seriesName];

                    // виконуємо процес побудови списку точок (X, Y)
                    var points = processor.Process(details);

                    // наносимо точки на відповідний графік
                    foreach (var point in points)
                    {
                        series.Points.AddXY(point.X, point.Y);
                    }
                }
            }
            // якщо перевірка не пройдена
            else
            {
                MessageBox.Show("Check your input, please");
            }
        }

        private bool Configure(out double xFirst, out double xLast, out double step)
        {
            // зчитуємо три поля вводу. Перевіряємо їх зміст. Повертаємо true, коли усі три введені правильно
            var xFirstText = InputXfirst.Text;
            var xLastText = InputXlast.Text;
            var stepText = InputStep.Text;

            // перевірити на правильність (мають бути числа)
            var isFirstValid = InputHelper.ParseDoubleInput(xFirstText, Label_x_first.Text, out xFirst);
            var isLastValid = InputHelper.ParseDoubleInput(xLastText, Label_x_last.Text, out xLast);
            var isStepValid = InputHelper.ParseDoubleInput(stepText, StepLabel.Text, out step);

            return isFirstValid && isLastValid && isStepValid;
        }
        private void EnsureSeriesCheckBoxes()
        {
            var isChecked = false;

            // можна звернутися до певного GroupBox і дістати всі його дочірні елементи.
            var controls = VisualisationGroupBox.Controls;

            // проходимося по кожному
            foreach (var control in controls)
            {
                // конструкція is Checkbox перевіряє тип змінної control. Якщо це чекбокс - створює змінну
                // типу CheckBox з нашою назвою, у якої можна перевірити, чи відмічена вона
                if (control is CheckBox checkbox && checkbox.Checked)
                {
                    isChecked = true;
                    break;
                }
            }

            // Якщо ми перевірили усі чекбокси і жодний не є обраним
            if (!isChecked)
            {
                // встановлюємо лінійний графік за замовченням
                MainFunctionCheckBox.Checked = true;
            }
        }
        private SeriesDetails GetSeriesDetails(List<double> xPoints)
        {
            return new SeriesDetails
            {
                XPoints = xPoints,
                RandomMaximum = RandomMaximum,
                RandomMinimum = RandomMinimum
            };
        }
        private void SetUpCheckBoxes()
        {
            MainFunctionCheckBox.Text = Constants.MainFunctionSeries;
            LinearCheckBox.Text = Constants.LinearSeries;
            SinCheckBox.Text = Constants.SinSeries;

        }
        private List<string> GetListOfCheckedSeries()
        {
            var result = new List<string>();

            // можна звернутися до певного GroupBox і дістати всі його дочірні елементи.
            var groupBoxControls = VisualisationGroupBox.Controls;

            // проходимося по кожному
            foreach (var control in groupBoxControls)
            {
                // конструкція is Checkbox перевіряє тип змінної control. Якщо це чекбокс - створює
                // змінну типу CheckBox з нашою назвою, у якої можна перевірити, чи відмічена вона
                if (control is CheckBox checkbox && checkbox.Checked)
                {
                    result.Add(checkbox.Text);
                }
            }

            return result;
        }
        // функція, що очищає графіки
        private void ClearSeries()
        {
            var allSeries = DataChart.Series;
            foreach (var series in allSeries)
            {
                series.Points.Clear();
            }
        }
        // створюємо точки на осі X на відрізку [A;B] з кроком step
        private List<double> GetXPoints(double xFirst, double xLast, double step)
        {
            var result = new List<double>();
            for (var xPoint = xFirst; xPoint <= xLast; xPoint += step)
            {
                result.Add(xPoint);
            }
            return result;
        }
        // якщо значення х початкового більше за х останнє, ми міняємо їх місцями
        private void ValidateRange(ref double xFirst, ref double xLast)
        {
            if (xFirst > xLast)
            {
                (xFirst, xLast) = (xLast, xFirst);

                InputXfirst.Text = xFirst.ToString();
                InputXlast.Text = xLast.ToString();

                // @ - рядок не містить символів \w, \n, \t та тому подібних
                // $ дозволяє інтерполювати текст за допомогою змінних з коду
                MessageBox.Show(@$"Interval ({xLast};{xFirst}) is changed to ({xFirst};{xLast})");
            }
        }
        // перевірка кроку
        private void ValidateStep(ref double step)
        {
            if (step == 0)
            {
                throw new InvalidDataException("Step cannot be 0.");
            }
            if (step < 0)
            {
                step = Math.Abs(step);
                InputStep.Text = step.ToString();
                MessageBox.Show(@$"Step is changed from ({step}) to ({step})");
            }
        }
        // функція для вибору виду графіка у комбінованому списку
        private void ChartTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            var allSeries = DataChart.Series;               // усі варіанти графіків
            var selectedType = ChartTypeComboBox.SelectedIndex; // обраний вид графіку

            var type = (ChartSeriesDisplayType)selectedType;        // отримуємо вид графіка
            var relatedChartType = Configuration.TypeMappings[type];// знаходимо відповідний графік у конфігураціях

            // реалізуємо потрібний нам графік
            foreach (var item in allSeries)
            {
                item.ChartType = relatedChartType;
            }
        }

        private void RandomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // якщо елемент став натиснутим - відкриваємо форму
            if (RandomCheckBox.Checked)
            {
                // створюємо нову форму
                var randomNumberForm = new RandomNumbersForm();

                // визначаємо операцію, яку необхідно виконати після зачинення форми. Нам необхідно зчитати уведені користувачем дані
                randomNumberForm.FormClosed += (o, args) =>
                {
                    RandomMinimum = randomNumberForm.RandomMinimum;
                    RandomMaximum = randomNumberForm.RandomMaximum;
                };

                // показуємо форму
                randomNumberForm.ShowDialog();

                // коли вона зачинилася, відображаємо текст з діапазоном випадкових значень
                RandomRangeLabel.Text = $"({RandomMinimum};{RandomMaximum})";
                RandomRangeLabel.Visible = true;
            }
            // якщо вимкнули, треба обнулити попередні дані
            else
            {
                RandomMinimum = null;
                RandomMaximum = null;
                RandomRangeLabel.Text = string.Empty;
                RandomRangeLabel.Visible = false;
            }
        }
        private void TransformButton_Click(object sender, EventArgs e)
        {
            // обираємо назви графіків, які необхідно перевірити
            var checkedSeries = GetListOfCheckedSeries();

            // якщо графіків немає, або жодний з них не обраний для модифікації - пишемо повідомлення і нічого далі не робимо
            if (!checkedSeries.Any() || !DoesSeriesExist())
            {
                MessageBox.Show("Створіть хоча б один графік");
                return;
            }

            // зчитуємо введений коефіцієнт
            var coefficientInput = TransformationInput.Text;
            var isCoefficientValid = InputHelper.ParseDoubleInput(coefficientInput, TransformationLabel.Text, out var coefficient);

            // якщо він правильний - робимо перетворення
            if (isCoefficientValid)
            {
                foreach (var seriesName in checkedSeries)
                {
                    // дістаємо графік за його ім'ям
                    var series = DataChart.Series[seriesName];

                    // дістаємо усі елементи управління з блоку транформування
                    var controls = TransformationGroupBox.Controls;

                    foreach (var control in controls)
                    {
                        // якщо це натиснутий чекбокс
                        if (control is CheckBox checkBox && checkBox.Checked)
                        {
                            // за ім'ям чекбоксу знаходимо відповідний механізм обробки
                            var transformer = Configuration.TransformMappings[checkBox.Name];

                            // виконуємо перетворення точок
                            transformer.Transform(series, coefficient);
                        }
                    }
                }
                // перебудовуємо графік
                DataChart.Invalidate();
            }
            // інакше повідомляємо користувача
            else
            {
                MessageBox.Show("Перевірьте коефіцієнт");
            }
        }
        private bool DoesSeriesExist()
        {
            var result = false;

            // проходимося по кожному графіку
            foreach (var series in DataChart.Series)
            {
                // якщо є хоч одна точка. Any() повертає 1, якщо є елменти у колекції, або 0 якщо колекція пуста
                if (series.Points.Any())
                {
                    result = true;
                    break; // зупиняємо цикл. Нам достатньо хоча б одного графіку
                }
            }

            return result;
        }
        // тут ви маєте реалізувати відчинення вашої форми. Створіть її самостійно і напишіть код, який буде її закривати
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();

            // open form with info
            aboutForm.ShowDialog();
        }
        // механізм збереження наших графіків до Excel файлу
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // намагаємося виконати код у фігурних скобках. Якщо виникне помилка - програма автоматично продовжиться у блоці catch
            try
            {
                // відкриваємо провідник файлів, щоб користувач обрав місце і вписав назву новому файлу
                using (var dialog = new SaveFileDialog())
                {
                    dialog.OverwritePrompt = true;          // дозволяємо виводити вікно з підтвердженням перезапису файла
                    dialog.Title = Constants.DialogTitle;   // встановлюємо текст вікна
                    dialog.Filter = Constants.DialogFormat; // встановлюємо тип файлу, який збережеться. У нашому випадку це excel

                    // якщо користувач ввів назву, натиснув на кнопку зберегти. Якщо він закриє вікно, або щось інше - повернеться інший статус
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        // отримуємо шлях, куди нам необхідно покласти новий файл, а також його ім'я
                        var filePath = dialog.FileName;

                        // якщо такий самий файл вже існує - його треба перезаписати. У windows перезапис фактично виконує 2 операції:
                        // видалення і створення
                        if (File.Exists(filePath))
                        {
                            // видаляємо файл
                            File.Delete(filePath);
                        }
                        // зберігаємо новий
                        SaveExcelFile(filePath);
                    }
                }
            }
            // сюди надійде інформація про виключення, яке сталося під час обробки файлу
            catch (Exception exception)
            {
                // кажемо про це користувачеві
                MessageBox.Show(exception.Message);
            }
        }
        // механізм побудови ексель файлу
        private void SaveExcelFile(string filePath)
        {
            // дістаємо метадані файлу
            var fileInfo = new FileInfo(filePath);
            //ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            // створюємо новий ексель файл. using у C# викликає після завершення блоку коду операцію звільнення
            using (var excelPackage = new ExcelPackage(fileInfo))
            {
                // беремо усі обрані графіки
                var checkedSeries = GetListOfCheckedSeries();

                foreach (var seriesName in checkedSeries)
                {
                    // дістаємо графік за ім'ям
                    var series = DataChart.Series[seriesName];

                    // створюємо у файлі вкладку з ім'ям нашого графіку
                    var worksheet = excelPackage.Workbook.Worksheets.Add(seriesName);

                    var row = Constants.ExcelStartRow;

                    // пишемо назву колонок у першому рядку
                    worksheet.Cells[row, Constants.XValueInExcel].Value = Constants.XColumnTitle;
                    worksheet.Cells[row, Constants.YValueInExcel].Value = Constants.YColumnTitle;

                    // переходимо на новий рядок
                    row++;

                    // дістаємо усі наявні точки графіку
                    var seriesPoints = series.Points;

                    // кожну точку записуємо у окремий рядок
                    foreach (var point in seriesPoints)
                    {
                        worksheet.Cells[row, Constants.XValueInExcel].Value = point.XValue;
                        worksheet.Cells[row, Constants.YValueInExcel].Value = point.YValues.First();

                        row++;
                    }
                }

                excelPackage.SaveAs(fileInfo);
            }
        }
        // механізм відкривання збереженого файлу
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // намагаємося виконати вказаний фрагмент коду
            try
            {
                // відкриваємо діалог де користувач має обрати файл
                using (var dialog = new OpenFileDialog())
                {
                    dialog.Title = Constants.DialogTitle;   // встановлюємо повідомлення
                    dialog.Filter = Constants.DialogFormat; // дозволяємо завантажити тільки excel файли

                    if (dialog.ShowDialog() == DialogResult.OK) // якщо файл успішно обраний
                    {
                        var filePath = dialog.FileName; // зчитуємо шлях та ім'я обраного файлу

                        var fileInfo = new FileInfo(filePath); // дістаємо метадані файлу

                        using (var excelPackage = new ExcelPackage(fileInfo)) // завантажуємо excel файл
                        {
                            //ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                            ClearSeries(); // очищаємо наші точки на графіку

                            // дістаємо усі вкладки у файлі
                            var worksheets = excelPackage.Workbook.Worksheets;

                            // проходимося по кожній
                            foreach (var worksheet in worksheets)
                            {
                                // завантажуємо графік з вкладки у наш графічний компонент
                                LoadSeriesFromWorksheet(worksheet);
                            }

                            // оновлюємо графічник компонент
                            DataChart.Invalidate();
                        }
                    }
                }
            }
            // Якщо виникла помилка - повідомляємо користувача
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        // механізм зчитування excel файлу
        private void LoadSeriesFromWorksheet(ExcelWorksheet excelWorksheet)
        {
            // дістаємо графік за назвою вкладки, вони мають співпадати
            var series = DataChart.Series[excelWorksheet.Name];

            // сюди ми будемо записувати отримані з файлу точки
            var points = new List<SeriesPoint>();

            // дивимося максимальну кількість точок у вкладці
            var maxRows = excelWorksheet.Dimension.Rows;

            // проходимося від початку таблиці до кінця, рядок за рядком
            for (var row = Constants.ExcelReadStartRow; row <= maxRows; row++)
            {
                // якщо ми ще не дочитали файл, але зустріли пусту клітинку - повідомляємо про помилку
                if (string.IsNullOrWhiteSpace(excelWorksheet.Cells[row, Constants.XValueInExcel].Value?.ToString()))
                    throw new InvalidOperationException("File contains empty rows");

                // за замовченням в клітинках знаходиться текст. Нам необхідно перетворити його на тип double
                var x = Convert.ToDouble(excelWorksheet.Cells[row, Constants.XValueInExcel].Value);
                var y = Convert.ToDouble(excelWorksheet.Cells[row, Constants.YValueInExcel].Value);

                // створюємо нашу точку
                var point = new SeriesPoint(x, y);

                // додаємо до списку
                points.Add(point);
            }

            // після того, як ми зчитали усі точки з файлу - додаємо їх до відповідного графіку
            foreach (var point in points)
            {
                series.Points.AddXY(point.X, point.Y);
            }
        }
    }
}
