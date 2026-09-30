// Урок 3. Демо: Калькулятор ІМТ (індекс маси тіла).

using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
// Щоб double парсився з крапкою:
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

Console.WriteLine("=== Калькулятор ІМТ ===");
Console.WriteLine();

Console.Write("Введіть вашу вагу (кг): ");
double weight = double.Parse(Console.ReadLine()!);

Console.Write("Введіть ваш зріст (м, з крапкою): ");
double height = double.Parse(Console.ReadLine()!);

double bmi = weight / (height * height);
double bmiRounded = Math.Round(bmi, 1);

Console.WriteLine();
Console.WriteLine($"Ваш ІМТ: {bmiRounded}");

// Простий аналіз (без if — це наступний урок)
Console.WriteLine("Норма: 18.5 - 24.9");
Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();
