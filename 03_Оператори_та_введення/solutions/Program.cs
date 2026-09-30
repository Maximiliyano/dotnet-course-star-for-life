// Урок 3. Розв'язки усіх 7 завдань.

using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

// Завдання 1 — Привітайся
Console.Write("Як вас звати? ");
string name = Console.ReadLine()!;
Console.Write("Скільки вам років? ");
int age = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Привіт, {name}! Через рік вам буде {age + 1}.");
Console.WriteLine();

// Завдання 2 — Сума двох
Console.Write("Введіть перше число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введіть друге число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сума:    {a + b}");
Console.WriteLine($"Різниця: {a - b}");
Console.WriteLine($"Добуток: {a * b}");
Console.WriteLine($"Частка:  {(double)a / b}");
Console.WriteLine();

// Завдання 3 — ІМТ
Console.Write("Вага (кг): ");
double weight = double.Parse(Console.ReadLine()!);
Console.Write("Зріст (м): ");
double height = double.Parse(Console.ReadLine()!);
double bmi = Math.Round(weight / (height * height), 1);
Console.WriteLine($"Ваш ІМТ: {bmi}");
Console.WriteLine();

// Завдання 4 — Конвертер валют
Console.Write("Сума у грн: ");
double uah = double.Parse(Console.ReadLine()!);
Console.WriteLine($"У USD: {Math.Round(uah / 41.5, 2)}");
Console.WriteLine($"У EUR: {Math.Round(uah / 45.2, 2)}");
Console.WriteLine();

// Завдання 5 — Парність
Console.Write("Число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Парне? {n % 2 == 0}");
Console.WriteLine();

// Завдання 6 — Площа трикутника (Герон)
Console.Write("Сторона a: "); double sa = double.Parse(Console.ReadLine()!);
Console.Write("Сторона b: "); double sb = double.Parse(Console.ReadLine()!);
Console.Write("Сторона c: "); double sc = double.Parse(Console.ReadLine()!);
double p = (sa + sb + sc) / 2.0;
double area = Math.Sqrt(p * (p - sa) * (p - sb) * (p - sc));
Console.WriteLine($"Площа трикутника: {Math.Round(area, 2)}");
Console.WriteLine();

// Завдання 7 — Безпечне читання
Console.Write("Введіть число: ");
string input = Console.ReadLine()!;
if (int.TryParse(input, out int parsed))
    Console.WriteLine($"Парне? {parsed % 2 == 0}");
else
    Console.WriteLine("Невірне число!");

Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();
