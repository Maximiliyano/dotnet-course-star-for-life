// Урок 2. Розв'язки усіх 6 завдань.

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Завдання 1
string name = "Олена";
int age = 16;
double height = 1.65;
bool isFemale = true;

Console.WriteLine($"Імʼя: {name}");
Console.WriteLine($"Вік: {age}");
Console.WriteLine($"Зріст: {height}");
Console.WriteLine($"Стать (true=Ж): {isFemale}");
Console.WriteLine();

// Завдання 2 — інтерполяція
Console.WriteLine($"Імʼя: {name}, Вік: {age}, Зріст: {height} м");
Console.WriteLine();

// Завдання 3 — заміна значення
int counter = 0;
Console.WriteLine($"counter = {counter}");
counter = 100;
Console.WriteLine($"counter = {counter}");
// У "коробці" з імʼям counter тепер 100, а 0 — стерто.
Console.WriteLine();

// Завдання 4 — площа кімнати
double length = 4.5;
double width = 3.2;
double area = length * width;
Console.WriteLine($"Площа кімнати: {area} кв.м.");
Console.WriteLine();

// Завдання 5 — візитна картка
string school = "Ліцей № 24";
string favouriteSubject = "фізика";
bool isProgrammer = true;
Console.WriteLine("========================");
Console.WriteLine($"| Привіт! Я {name}.    |");
Console.WriteLine($"| Мені {age} років.       |");
Console.WriteLine($"| Школа: {school}|");
Console.WriteLine($"| Улюблений: {favouriteSubject}    |");
Console.WriteLine($"| Програміст? {isProgrammer}      |");
Console.WriteLine("========================");

// Завдання 6 — var
// var x = 5; x = "текст";
// Помилка: cannot implicitly convert type 'string' to 'int'.
// Тип фіксується при ініціалізації і не змінюється.

Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();
