// Урок 7. Розв'язки.

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Завдання 1
Greet("Олена");
Greet("Іван");
Greet("Світ");
Console.WriteLine();

// Завдання 2
Console.WriteLine($"5² = {Square(5)}");
Console.WriteLine($"7² = {Square(7)}");
Console.WriteLine($"10² = {Square(10)}");
Console.WriteLine();

// Завдання 3
Console.WriteLine($"Sum(2,3) = {Sum(2, 3)}");
Console.WriteLine($"Sum3(1,2,3) = {Sum3(1, 2, 3)}");
Console.WriteLine();

// Завдання 4
Console.WriteLine($"Max3(15, 7, 22) = {Max3(15, 7, 22)}");
Console.WriteLine();

// Завдання 5 — Прості числа 2..50
Console.Write("Прості числа 2..50: ");
for (int i = 2; i <= 50; i++)
    if (IsPrime(i)) Console.Write($"{i} ");
Console.WriteLine();
Console.WriteLine();

// Завдання 6 — Факторіали 1..10
Console.WriteLine("Факторіали:");
for (int i = 1; i <= 10; i++)
    Console.WriteLine($"  {i}! = {Factorial(i)}");
Console.WriteLine();

// Завдання 7 — Середнє масиву
int[] sample = { 4, 9, 12, 7, 18, 25 };
Console.WriteLine($"Середнє: {Average(sample):F2}");
Console.WriteLine();

// Завдання 8 — out-параметри
MinMax(sample, out int mn, out int mx);
Console.WriteLine($"min = {mn}, max = {mx}");

Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();


// ---------- Методи ----------

static void Greet(string name) =>
    Console.WriteLine($"Привіт, {name}!");

static int Square(int x) => x * x;

static int Sum(int a, int b) => a + b;
static int Sum3(int a, int b, int c) => a + b + c;

static int Max3(int a, int b, int c)
{
    int m = a;
    if (b > m) m = b;
    if (c > m) m = c;
    return m;
}

static bool IsPrime(int n)
{
    if (n < 2) return false;
    for (int i = 2; i * i <= n; i++)
        if (n % i == 0) return false;
    return true;
}

static long Factorial(int n)
{
    long r = 1;
    for (int i = 2; i <= n; i++) r *= i;
    return r;
}

static double Average(int[] arr)
{
    int s = 0;
    foreach (int x in arr) s += x;
    return (double)s / arr.Length;
}

static void MinMax(int[] arr, out int min, out int max)
{
    min = arr[0]; max = arr[0];
    foreach (int x in arr)
    {
        if (x < min) min = x;
        if (x > max) max = x;
    }
}
