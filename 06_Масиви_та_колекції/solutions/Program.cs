// Урок 6. Розв'язки.

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Завдання 1 — Виведення
int[] nums = { 5, 12, 7, 3, 18 };
Console.WriteLine("Масив:");
foreach (int x in nums) Console.WriteLine(x);
Console.WriteLine();

// Завдання 2 — Сума
int sum = 0;
foreach (int x in nums) sum += x;
Console.WriteLine($"Сума: {sum}");
Console.WriteLine();

// Завдання 3 — Max/Min
int max = nums[0], min = nums[0];
for (int i = 1; i < nums.Length; i++)
{
    if (nums[i] > max) max = nums[i];
    if (nums[i] < min) min = nums[i];
}
Console.WriteLine($"Max: {max}, Min: {min}");
Console.WriteLine();

// Завдання 4 — Середнє
double avg = (double)sum / nums.Length;
Console.WriteLine($"Середнє: {Math.Round(avg, 2)}");
Console.WriteLine();

// Завдання 5 — List<string> фільмів
List<string> films = new() { "Avatar", "Inception", "Interstellar", "Joker", "Dune" };
Console.WriteLine($"Кількість фільмів: {films.Count}");
foreach (var f in films) Console.WriteLine($"  - {f}");
Console.WriteLine();

// Завдання 6 — Журнал оцінок
Console.Write("Скільки оцінок? ");
int n = int.Parse(Console.ReadLine()!);
List<int> grades = new();
for (int i = 1; i <= n; i++)
{
    Console.Write($"Оцінка #{i}: ");
    grades.Add(int.Parse(Console.ReadLine()!));
}
int gSum = 0, gMax = grades[0], gMin = grades[0], twelves = 0;
foreach (int g in grades)
{
    gSum += g;
    if (g > gMax) gMax = g;
    if (g < gMin) gMin = g;
    if (g == 12) twelves++;
}
Console.WriteLine($"Середнє: {(double)gSum / grades.Count:F2}");
Console.WriteLine($"Максимум: {gMax}, Мінімум: {gMin}");
Console.WriteLine($"Кількість 12-к: {twelves}");
Console.WriteLine();

// Завдання 7 — Пошук у масиві
int[] arr = { 10, 20, 30, 40, 50 };
Console.Write("Яке число шукати? ");
int target = int.Parse(Console.ReadLine()!);
int pos = -1;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == target) { pos = i; break; }
}
if (pos >= 0) Console.WriteLine($"Знайдено на позиції {pos}");
else Console.WriteLine("Не знайдено");
Console.WriteLine();

// Завдання 8 — Сортування
var rnd = new Random();
List<int> randomNums = new();
for (int i = 0; i < 5; i++) randomNums.Add(rnd.Next(1, 100));
Console.Write("До сортування: ");
foreach (int x in randomNums) Console.Write($"{x} ");
Console.WriteLine();
randomNums.Sort();
Console.Write("Після сортування: ");
foreach (int x in randomNums) Console.Write($"{x} ");
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();
