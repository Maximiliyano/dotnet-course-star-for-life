// Урок 6. Starter: масиви та List.

using System.Security;
using System.Text.Json.Serialization.Metadata;
using static System.Net.WebRequestMethods;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// TODO 1: Створіть масив int[] nums = { 5, 12, 7, 3, 18 }.
// Виведіть кожне число через foreach.
int[] nums = { 5, 12, 7, 3, 18 };
Console.WriteLine(string.Join(',', nums));
foreach (int num in nums)
{
}

// TODO 2: Знайдіть середню суму усіх елементів масиву.
Console.Write("Avg num ");
double sum = 0;
foreach (int num in nums)
{
    sum += num;
}
double average = sum / nums.Length;
Console.WriteLine(average);

// TODO 3: Знайдіть найбільше і найменше число (без LINQ Max/Min).
int max = nums[0];
int min = nums[0];
foreach (int num in nums)
{
    if (num > max)
    {
        max = num;
    }

    if (num < min)
    {
        min = num;
    }
} // Data Algorith
Console.WriteLine($"Max: {max}");
Console.WriteLine($"Min: {min}");

// TODO 4: Створіть List<string> films, додайте 5 фільмів через Add,
// виведіть кількість і кожен фільм.
Console.WriteLine("============== Films");
List<string> films = new List<string>()
{
    "Test1"
};
films.Add("Test1");
films.Add("Test2");
films.Add("Test3");
films.Add("Test4");
films.Add("Test5");
int a = 0;
foreach (string film in films)
{
    a++;
    Console.WriteLine($"{a}. {film}");
}
Console.WriteLine("------");
for (int i = 0; i < films.Count; i++)
{
    Console.WriteLine($"{i + 1}. {films[i]}");
}
Console.WriteLine("------");

// TODO 5 (бонус): Журнал оцінок — введіть N оцінок з консолі,
// виведіть середнє, максимум, мінімум, кількість 12-к.
Console.WriteLine("--- Журнал Оцінок ---");
List<int> grades = new() { 10, 12, 8, 11, 9, 7, 12, 10 };

Console.WriteLine($"Всього оцінок: {grades.Count}");
Console.Write("Усі оцінки: ");
foreach (int grade in grades)
{
    Console.Write($"{grade} ");
}
Console.WriteLine();
Console.WriteLine();

double sum1 = 0;
foreach (int grade in grades)
{
    sum1 += grade;
}
double avg = sum1 / grades.Count;
Console.WriteLine($"Average: {Math.Round(avg, 2)}");

int max1 = grades[0];
int min1 = grades[0];
foreach (int grade in grades)
{
    if (grade > max1)
    {
        max1 = grade;
    }

    if (grade < min1)
    {
        min1 = grade;
    }
}
Console.WriteLine($"Max: {max1}");
Console.WriteLine($"Min: {min1}");

int twelves = 0;
foreach(int grade in grades)
{
    if (grade == 12)
    {
        twelves++;
    }
}
Console.WriteLine($"Twelve: {twelves}");

// Add new grade
grades.Add(10);
Console.WriteLine("Нова оцінка 10");

// Sort
grades.Sort();
Console.Write("Посортовані оцінки оцінки: ");
foreach (int grade in grades)
{
    Console.Write($"{grade} ");
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();
