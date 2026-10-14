// Урок 10. Побудова першого проекту Starter: основа QuizApp.

using QuizApp;
using System.Diagnostics;
using System.Net;

Console.OutputEncoding = System.Text.Encoding.UTF8;


// TODO 1: Додайте 5+ власних питань через quiz.AddQuestion(new Question(...))
Quiz quiz = new();
SeedQuestions(quiz);

// TODO 2: Реалізуйте меню (поки тестово запускаємо одразу)
// TODO 3 (бонус): зробіть нескінченне меню з вибором почати/додати/вихід.
while (true)
{
    Console.WriteLine();
    Console.WriteLine("════════════════════════════════════");
    Console.WriteLine("       К В І З     -    ВІКТОРИНА   ");
    Console.WriteLine("════════════════════════════════════");
    Console.WriteLine($"Усього питань: {quiz.Questions.Count}");
    Console.WriteLine();
    Console.WriteLine("1. Почати тест (усі категорії)");
    Console.WriteLine("2. Почати тест (обрати категорію)");
    Console.WriteLine("3. Показати усі питання");
    Console.WriteLine("4. Додати своє питання");
    Console.WriteLine("5. Подивитись історію результатів");
    Console.WriteLine("0. Вихід");
    Console.Write("Виберіть пункт: ");

    string choice = Console.ReadLine()?.Trim() ?? "";

    switch (choice)
    {
        case "0": return;
        case "1": quiz.Start(null); break;
        case "2": StartByCategory(quiz); break;
        case "3": quiz.ShowAll(); break;
        case "4": AddCustomQuestion(quiz); break;
        case "5": ShowHistory(); break;
        default: Console.WriteLine("Не правильний вибір"); break;
    }
}

Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();

static void ShowHistory()
{
    string file = "quiz_history.txt";
    if (!File.Exists(file))
    {
        Console.WriteLine("Історія порожня.");
        return;
    }
    Console.WriteLine("=== Історія результатів ===");
    foreach (var line in File.ReadAllLines(file))
        Console.WriteLine(line);
}

static void AddCustomQuestion(Quiz quiz)
{
    Console.Write("Категорія: ");
    string cat = Console.ReadLine() ?? "Загальна";

    Console.Write("Питання: ");
    string text = Console.ReadLine() ?? "";

    string[] options = new string[4];
    for (int i = 0; i < 4; i++)
    {
        Console.Write($"Варіант {i + 1}: ");
        options[i] = Console.ReadLine() ?? "";
    }

    Console.Write("Правильна відповідь (1-4): ");
    int correct = int.Parse(Console.ReadLine()!) - 1;

    quiz.AddQuestion(new Question(text, options, correct, cat));
    Console.WriteLine("Додано!");
}

static void StartByCategory(Quiz quiz)
{
    var categories = new HashSet<string>();

    foreach (var question in quiz.Questions)
    {
        categories.Add(question.Category);
    }

    Console.WriteLine("Доступні категорії: ");
    int n = 1;
    var categoryList = new List<string>(categories);
    foreach (var category in categoryList)
    {
        int cnt = quiz.Questions.Count(qq => qq.Category == category);
        Console.WriteLine($"  {n++}. {category} ({cnt})");
    }

    Console.Write("Номер категорії: ");
    if (int.TryParse(Console.ReadLine(), out int idx) && idx >= 1 && idx <= categoryList.Count)
    {
        quiz.Start(categoryList[idx - 1]);
    }
    else Console.WriteLine("Невірно.");
}

static void SeedQuestions(Quiz quiz)
{
    quiz.AddQuestion(new Question("Столиця України?", [
        "Київ", "Львів", "Одеса", "Харків"
    ], 0, "Історія"));
    quiz.AddQuestion(new Question("Хто написав 'Кобзар'?",
       new[] { "Леся Українка", "Іван Франко", "Тарас Шевченко", "Михайло Коцюбинський" }, 2, "Історія"));
    quiz.AddQuestion(new Question("Рік прийняття Конституції України?",
        new[] { "1991", "1996", "2004", "2014" }, 1, "Історія"));

    // Математика
    quiz.AddQuestion(new Question("Скільки буде 7 * 8?",
        new[] { "54", "56", "64", "48" }, 1, "Математика"));
    quiz.AddQuestion(new Question("Чому дорівнює π (з округленням)?",
        new[] { "3.10", "3.14", "3.20", "3.25" }, 1, "Математика"));
    quiz.AddQuestion(new Question("Квадратний корінь з 144?",
        new[] { "10", "11", "12", "13" }, 2, "Математика"));

    // Програмування
    quiz.AddQuestion(new Question("Хто розробив C#?",
        new[] { "Microsoft", "Google", "Apple", "IBM" }, 0, "Програмування"));
    quiz.AddQuestion(new Question("Що повертає WriteLine?",
        new[] { "string", "int", "нічого (void)", "bool" }, 2, "Програмування"));
    quiz.AddQuestion(new Question("Тип для збереження true/false?",
        new[] { "int", "string", "bool", "char" }, 2, "Програмування"));
}