// Урок 3. Starter: ввід, оператори, перетворення.

using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

bool test = true;
string test2 = test ? "Yes" : "No";
Console.WriteLine(test2);

int age = 20;
int money = 3000;
if (age == 19 || money == 3000) // Shift + \\
{
    Console.WriteLine("Salut");
}

// TODO 1: Запитайте у користувача імʼя і вік.
// Виведіть: "Привіт, <імʼя>! Через рік вам буде <вік+1>."
/*Console.Write("Привіт, напиши своє ім'я: ");
string? name = Console.ReadLine();

Console.Write("Напиши свій вік: ");
int age = int.Parse(Console.ReadLine());*/
/*
Console.WriteLine($"Привіт, {name}! Через рік вам буде {age + 1}");*/

// TODO 2: Прочитайте 2 цілі числа. Виведіть суму, різницю, добуток, частку.
/*Console.Write("Введіть перше число: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Введіть друге число: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine(firstNumber + secondNumber);
Console.WriteLine(firstNumber - secondNumber);
Console.WriteLine(firstNumber * secondNumber);
Console.WriteLine((double)firstNumber / secondNumber);*/

// TODO 3: Запитайте вагу і зріст. Обчисліть ІМТ.
// Виведіть, заокруглений до 1 знака після коми.
Console.Write("Вага ");
double weight = double.Parse(Console.ReadLine());
Console.Write("Зріст ");
double height = double.Parse(Console.ReadLine());
Console.WriteLine($"ІМТ {Math.Round(weight / (height * height), 1)}");

// TODO 4 (бонус): Перевірте, чи число парне (n % 2 == 0).


Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();
