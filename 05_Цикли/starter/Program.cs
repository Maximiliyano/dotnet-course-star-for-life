// Урок 5. Starter: цикли.

Console.OutputEncoding = System.Text.Encoding.UTF8;

// TODO 1: Цикл for виведе числа 1..10 по одному на рядку.
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}

//// TODO 2: Зворотний відлік 10..1, потім "Старт!"
//for (int i = 10; i >= 1; i--)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine("Старт");

// TODO 3: Прочитайте N. Обчисліть 1+2+...+N через цикл.
//int n = int.Parse(Console.ReadLine()!);
//int sum = 0;
//for (int i = 1; i <= n; i++)
//{
//    sum += i;
//}
//Console.WriteLine(sum);

// TODO 4: Таблиця множення на 7 (від 7*1 до 7*10).
//Console.WriteLine("Таблиця множення");
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"7 * {i} = {7 * i}");
//}

// Завдання 5 — Парні від 2 до 20
//Console.WriteLine("Парні числа до 20");
//for (int i = 2; i <= 20; i += 2)
//{
//    Console.WriteLine(i);
//}

// TODO 5 (бонус): Гра "Вгадай число" 1..100 (див. exercises.md).
// Підказка: var rnd = new Random(); int secret = rnd.Next(1, 101);
/*Сonsole.WriteLine("Гра \"Вгадай число\"");
Random random = new Random();
int secret = random.Next(1, 101);
int attempt = 0;
int guess;
do
{
    Console.Write("Спроба: ");
    guess = int.Parse(Console.ReadLine()!);
    attempt++;
    if (guess < secret) Console.WriteLine("Число є більшим");
    else if (guess > secret) Console.WriteLine("Число є меншим");
}
while (guess != secret);

Console.WriteLine($"Ви вгадали на {attempt} спробі!");*/

// Завдання 7 — Факторіал

// Завдання 8 — Просте число

Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();
