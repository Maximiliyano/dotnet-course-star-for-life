// Урок 5. Розв'язки.

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Завдання 1 — Числа 1..10
Console.WriteLine("=== 1..10 ===");
for (int i = 1; i <= 10; i++) Console.WriteLine(i);
Console.WriteLine();

// Завдання 2 — Зворотний відлік
Console.WriteLine("=== Зворотний відлік ===");
for (int i = 10; i >= 1; i--) Console.WriteLine(i);
Console.WriteLine("Старт!");
Console.WriteLine();

// Завдання 3 — Сума 1..N
Console.Write("N = ");
int n = int.Parse(Console.ReadLine()!);
int sum = 0;
for (int i = 1; i <= n; i++) sum += i;
Console.WriteLine($"Сума 1..{n} = {sum}");
Console.WriteLine();

// Завдання 4 — Таблиця множення на 7
Console.WriteLine("=== Таблиця множення на 7 ===");
for (int i = 1; i <= 10; i++)
    Console.WriteLine($"7 × {i} = {7 * i}");
Console.WriteLine();

// Завдання 5 — Парні до 20
Console.Write("Парні числа до 20: ");
for (int i = 2; i <= 20; i += 2) Console.Write($"{i} ");
Console.WriteLine();
Console.WriteLine();

// Завдання 6 — Гра "Вгадай число"
Console.WriteLine("=== ВГАДАЙ ЧИСЛО ===");
var rnd = new Random();
int secret = rnd.Next(1, 101);
int attempts = 0;
int guess;
do
{
    Console.Write("Спроба: ");
    guess = int.Parse(Console.ReadLine()!);
    attempts++;
    if (guess < secret) Console.WriteLine("більше");
    else if (guess > secret) Console.WriteLine("менше");
} while (guess != secret);
Console.WriteLine($"Вгадали за {attempts} спроб!");
Console.WriteLine();

// Завдання 7 — Факторіал
Console.Write("N для факторіалу: ");
int fn = int.Parse(Console.ReadLine()!);
long fact = 1;
for (int i = 1; i <= fn; i++) fact *= i;
Console.WriteLine($"{fn}! = {fact}");
Console.WriteLine();

// Завдання 8 — Просте число
Console.Write("Число для перевірки на простоту: ");
int p = int.Parse(Console.ReadLine()!);
bool isPrime = p > 1;
for (int i = 2; i < p; i++)
{
    if (p % i == 0) { isPrime = false; break; }
}
Console.WriteLine($"{p} {(isPrime ? "є" : "НЕ є")} простим числом.");

Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();
