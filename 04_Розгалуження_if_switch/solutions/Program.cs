// Урок 4. Розв'язки.

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Завдання 1 — Парне/непарне
Console.Write("Число: ");
int n = int.Parse(Console.ReadLine()!);
if (n % 2 == 0) Console.WriteLine("парне");
else Console.WriteLine("непарне");
Console.WriteLine();

// Завдання 2 — Більше з двох
Console.Write("a = "); int a = int.Parse(Console.ReadLine()!);
Console.Write("b = "); int b = int.Parse(Console.ReadLine()!);
if (a > b) Console.WriteLine($"Більше: {a}");
else if (b > a) Console.WriteLine($"Більше: {b}");
else Console.WriteLine("Рівні!");
Console.WriteLine();

// Завдання 3 — Більше з трьох
Console.Write("a = "); int x1 = int.Parse(Console.ReadLine()!);
Console.Write("b = "); int x2 = int.Parse(Console.ReadLine()!);
Console.Write("c = "); int x3 = int.Parse(Console.ReadLine()!);
int max = x1;
if (x2 > max) max = x2;
if (x3 > max) max = x3;
Console.WriteLine($"Найбільше: {max}");
Console.WriteLine();

// Завдання 4 — Оцінювач знань
Console.Write("Оцінка (0-100): ");
int score = int.Parse(Console.ReadLine()!);
string grade;
if (score < 0 || score > 100) grade = "Невірно введено";
else if (score >= 90) grade = "Відмінно";
else if (score >= 75) grade = "Добре";
else if (score >= 60) grade = "Задовільно";
else grade = "Не складено";
Console.WriteLine($"Рівень: {grade}");
Console.WriteLine();

// Завдання 5 — День тижня
Console.Write("Номер дня (1-7): ");
int dayNum = int.Parse(Console.ReadLine()!);
string day = dayNum switch
{
    1 => "понеділок",
    2 => "вівторок",
    3 => "середа",
    4 => "четвер",
    5 => "пʼятниця",
    6 => "субота",
    7 => "неділя",
    _ => "невірний день"
};
Console.WriteLine(day);
Console.WriteLine();

// Завдання 6 — Камінь-Ножиці-Папір
Console.Write("Гравець 1: ");
string p1 = Console.ReadLine()!.Trim().ToLower();
Console.Write("Гравець 2: ");
string p2 = Console.ReadLine()!.Trim().ToLower();

if (p1 == p2) Console.WriteLine("Нічия!");
else if ((p1 == "rock"     && p2 == "scissors") ||
         (p1 == "paper"    && p2 == "rock") ||
         (p1 == "scissors" && p2 == "paper"))
    Console.WriteLine("Переміг гравець 1!");
else Console.WriteLine("Переміг гравець 2!");
Console.WriteLine();

// Завдання 7 — Високосний рік
Console.Write("Рік: ");
int year = int.Parse(Console.ReadLine()!);
bool isLeap = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
Console.WriteLine($"Високосний? {isLeap}");
Console.WriteLine();

// Завдання 8 — Калькулятор з операцією
Console.Write("a = "); double da = double.Parse(Console.ReadLine()!);
Console.Write("op (+-*/): "); string op = Console.ReadLine()!;
Console.Write("b = "); double db = double.Parse(Console.ReadLine()!);
double result = op switch
{
    "+" => da + db,
    "-" => da - db,
    "*" => da * db,
    "/" => db == 0 ? 0 : da / db,
    _ => double.NaN
};
if (double.IsNaN(result)) Console.WriteLine("Невідома операція");
else if (op == "/" && db == 0) Console.WriteLine("Ділення на 0!");
else Console.WriteLine($"Результат: {result}");

Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();
