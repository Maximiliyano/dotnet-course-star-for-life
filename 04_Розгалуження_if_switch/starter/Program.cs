// Урок 4. Starter: розгалуження if/switch.

using System.Runtime.CompilerServices;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// TODO 1: Прочитайте число. Виведіть "парне" або "непарне" через if.
//Console.WriteLine("Введіть число ");
//int number = int.Parse(Console.ReadLine()!);
//if (number % 2 == 0)
//{
//    Console.WriteLine("Число парне");
//}
//else
//{
//    Console.WriteLine("Число непарне");
//}

// TODO 2: Прочитайте 2 числа. Виведіть більше (без Math.Max).
//Console.WriteLine("Введіть 1 число ");
//int firstNumber = int.Parse(Console.ReadLine()!);
//Console.WriteLine("Введіть 2 число ");
//int secondNumber = int.Parse(Console.ReadLine()!);
//if (firstNumber > secondNumber)
//{
//    Console.WriteLine($"Більше: {firstNumber}");
//}
//else if (secondNumber > firstNumber)
//{
//    Console.WriteLine($"Більше: {secondNumber}");
//}
//else
//{
//    Console.WriteLine("Рівні");
//}

// TODO 3: Прочитайте оцінку (0-100). Виведіть рівень:
// 90-100 -> "Відмінно"
// 75-89  -> "Добре"
// 60-74  -> "Задовільно"
// 0-59   -> "Не складено"
// інакше -> "Невірний ввід"
Console.WriteLine("Оцінка від 0 до 100: ");
int score = int.Parse(Console.ReadLine()!);
if (score < 0 || score > 100) Console.WriteLine("Невірний ввід");
else if (score >= 90) Console.WriteLine("Відмінно");
else if (score >= 75) Console.WriteLine("Добре");
else if (score >= 60) Console.WriteLine("Задовільно");
else Console.WriteLine("Не складено");
Console.WriteLine($"Ваш {score}");

//
Console.WriteLine("Введіть номер тижня 1-7");
int dayNumber = int.Parse(Console.ReadLine()!);

switch (dayNumber)
{
    case 1:
    {
        Console.WriteLine();
        return;
    }
    default:
        {
            Console.WriteLine();
            return;
        }
}

string day = dayNumber switch
{
    1 => "понеділок",
    2 => "вівторок",
    _ => "неправильний день"
};
Console.WriteLine($"Сьогодні {day}");

// TODO 4 (бонус): Камінь-Ножиці-Папір (див. exercises.md).


Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();
