// Урок 7. Демо: Математична бібліотека з методами.

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Використовуємо власні методи (оголошення нижче)
Console.WriteLine($"Sum(3, 4)        = {Sum(3, 4)}");
Console.WriteLine($"Sum3(1, 2, 3)    = {Sum3(1, 2, 3)}");
// Примітка: справжнє перевантаження методів (Sum(int,int) і Sum(int,int,int))
// можливе, лише якщо обʼєднати їх у клас. У Top-level statements
// локальні функції не можуть перевантажуватись.
Console.WriteLine($"Square(5)     = {Square(5)}");
Console.WriteLine($"Max3(7, 2, 9) = {Max3(7, 2, 9)}");
Console.WriteLine($"IsPrime(17)   = {IsPrime(17)}");
Console.WriteLine($"Factorial(5)  = {Factorial(5)}");
Console.WriteLine();

Greet("Олена");
Greet("Іван");
Greet("Світ");

Console.WriteLine();

// out-параметри
int[] arr = { 5, 12, 7, 3, 18, 9 };
MinMax(arr, out int mn, out int mx);
Console.WriteLine($"min = {mn}, max = {mx}");

Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();


// ---------- Методи ----------

static int Sum(int a, int b) => a + b;

static int Sum3(int a, int b, int c) => a + b + c;

static int Square(int x) => x * x;

static int Max3(int a, int b, int c)
{
    int max = a;
    if (b > max) max = b;
    if (c > max) max = c;
    return max;
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
    long result = 1;
    for (int i = 2; i <= n; i++) result *= i;
    return result;
}

static void Greet(string name)
{
    Console.WriteLine($"Привіт, {name}!");
}

static void MinMax(int[] arr, out int min, out int max)
{
    min = arr[0];
    max = arr[0];
    foreach (int x in arr)
    {
        if (x < min) min = x;
        if (x > max) max = x;
    }
}
