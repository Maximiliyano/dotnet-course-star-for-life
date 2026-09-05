// Урок 7. Starter: методи.

Console.OutputEncoding = System.Text.Encoding.UTF8;

// TODO 1: Викличте метод Greet з 3 різними іменами.


// TODO 2: Виведіть Square(5), Square(7), Square(10).


// TODO 3: Викличте Sum(2, 3) і перевантажений Sum(1, 2, 3).


// TODO 4: Знайдіть Max3(15, 7, 22).


// TODO 5 (бонус): Виведіть усі прості числа від 2 до 50,
// використовуючи метод IsPrime.


Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();


// ---------- Методи (вже готові — використовуйте) ----------

static void Greet(string name)
{
    Console.WriteLine($"Привіт, {name}!");
}

static int Square(int x) => x * x;

static int Sum(int a, int b) => a + b;
static int Sum3(int a, int b, int c) => a + b + c;  // інше імʼя, бо локальні функції у Top-level НЕ перевантажуються

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
