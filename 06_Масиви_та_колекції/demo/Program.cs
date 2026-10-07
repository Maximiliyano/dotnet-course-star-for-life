// Урок 6. Демо: Журнал оцінок класу.

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("=== ЖУРНАЛ ОЦІНОК ===");

// TODO 1 Створюємо список оцінок
List<int> grades = new() { 10, 12, 8, 11, 9, 7, 12, 10 };

Console.WriteLine($"Всього оцінок: {grades.Count}");
Console.Write("Усі оцінки: ");
foreach (int g in grades) Console.Write($"{g} ");
Console.WriteLine();
Console.WriteLine();

// TODO 2 Середнє
double sum = 0;
foreach (int g in grades) sum += g;
double avg = sum / grades.Count;
Console.WriteLine($"Середнє: {Math.Round(avg, 2)}");

// TODO 3 Max / Min
int max = grades[0], min = grades[0];
foreach (int g in grades)
{
    if (g > max) max = g;
    if (g < min) min = g;
}
Console.WriteLine($"Максимум: {max}");
Console.WriteLine($"Мінімум:  {min}");

// Кількість 12-к
int twelves = 0;
foreach (int g in grades) if (g == 12) twelves++;
Console.WriteLine($"Кількість 12-к: {twelves}");

Console.WriteLine();

// Додати нову оцінку
grades.Add(11);
Console.WriteLine($"Додали 11. Тепер у журналі: {grades.Count} оцінок.");

// Сортування
grades.Sort();
Console.Write("Відсортовано: ");
foreach (int g in grades) Console.Write($"{g} ");
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();
