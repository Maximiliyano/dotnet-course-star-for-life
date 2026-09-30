// Урок 2. Демо: змінні та типи даних.
// "Анкета учня"

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Оголошення змінних різних типів
string name = "Олена";
int age = 16;
double height = 1.65;
bool isStudent = true;
char favouriteLetter = 'O';

// Інтерполяція рядків через $"..."
Console.WriteLine("=== АНКЕТА УЧНЯ ===");
Console.WriteLine($"Імʼя: {name}");
Console.WriteLine($"Вік: {age}");
Console.WriteLine($"Зріст: {height} м");
Console.WriteLine($"Учень/учениця: {isStudent}");
Console.WriteLine($"Улюблена літера: {favouriteLetter}");
Console.WriteLine();

// Тип var — компілятор автоматично вгадує
var country = "Україна";     // string
var population = 41_000_000;  // int (можна підкреслення для читабельності)
Console.WriteLine($"{country}, населення ~ {population}");

// Зміна значення
age = 17;
Console.WriteLine($"З днем народження! Тепер {name} має {age} років.");

Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();
