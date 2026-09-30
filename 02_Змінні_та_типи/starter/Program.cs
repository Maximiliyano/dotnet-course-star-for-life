// Урок 2. Starter: змінні та типи даних.

using System.Numerics;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// TODO 1: Створіть 4 змінні для свого «паспорту»:
// - name (string)
// - age (int)
// - height (double)
// - isFemale (bool)
string name = "Maksym";
int age = 20;
double height = 180.5;
bool isFemale = true;
string femaleText = isFemale == true ? "Жінка" : "Чоловік";
char letter = 'S';

// TODO 2: Виведіть один рядок через інтерполяцію:
// "Імʼя: <name>, Вік: <age>, Зріст: <height>, Стать (true=Ж): <isFemale>"
Console.WriteLine($"Ім'я: {name}, Вік: {age}, Зріст: {height}, Стать {femaleText}, Буква {letter}");

// TODO 3: Створіть змінну counter = 0, виведіть її,
// потім присвойте counter = 100, виведіть знову.
int counter = 0;
Console.WriteLine(counter);

counter = 100;
Console.WriteLine(counter);

// TODO 4: Прочитайте на сторінці exercises.md "Завдання 4 - Площа кімнати".
// Створіть length, width (double), обчисліть area = length * width.
// Виведіть результат.
// Створіть 2 змінні: double length = 4.5; і double width = 3.2;. Створіть третю — area, у яку запишіть length * width. Виведіть: Площа кімнати: 14.4 кв.м.
double length = 4.5;
double width = 3.2;
double area = length * width;
Console.WriteLine($"Площа кімнати: {area} кв.м");

// TODO 5 (бонус): Спробуйте var x = 5; потім x = "текст";
// Що скаже компілятор? Запишіть у коментарі.

Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();
