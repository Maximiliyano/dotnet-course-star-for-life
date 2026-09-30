// Урок 5. Демо: Гра "Вгадай число".

Console.OutputEncoding = System.Text.Encoding.UTF8;

var random = new Random();
int secret = random.Next(1, 101);  // 1..100

Console.WriteLine("=== ВГАДАЙ ЧИСЛО ===");
Console.WriteLine("Я загадав число від 1 до 100. Спробуй вгадати!");
Console.WriteLine();

int attempts = 0;
int guess;

do
{
    Console.Write("Твій варіант: ");
    if (!int.TryParse(Console.ReadLine(), out guess))
    {
        Console.WriteLine("Введіть число!");
        continue;
    }

    attempts++;

    if (guess < secret) Console.WriteLine("Загадане більше →");
    else if (guess > secret) Console.WriteLine("Загадане менше ←");
} while (guess != secret);

Console.WriteLine();
Console.WriteLine($"🎉 Вгадав за {attempts} спроб!");

// Демо for: таблиця Піфагора 1-5
Console.WriteLine();
Console.WriteLine("Таблиця Піфагора 1..5:");
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= 5; j++)
    {
        Console.Write($"{i * j,4}");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();
