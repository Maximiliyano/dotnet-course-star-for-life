// Урок 10. Solutions: повний QuizApp з категоріями, збереженням, статистикою.

using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

var quiz = new Quiz();
SeedQuestions(quiz);

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
        case "0": Console.WriteLine("До побачення!"); return;
        case "1": quiz.Start(null); break;
        case "2": StartByCategory(quiz); break;
        case "3": quiz.ShowAll(); break;
        case "4": AddCustomQuestion(quiz); break;
        case "5": ShowHistory(); break;
        default: Console.WriteLine("Невірний пункт."); break;
    }
}


static void StartByCategory(Quiz q)
{
    var categories = new HashSet<string>();
    foreach (var qst in q.Questions) categories.Add(qst.Category);

    Console.WriteLine("Доступні категорії:");
    int n = 1;
    var catList = new List<string>(categories);
    foreach (var c in catList)
    {
        int cnt = q.Questions.Count(qq => qq.Category == c);
        Console.WriteLine($"  {n++}. {c} ({cnt})");
    }

    Console.Write("Номер категорії: ");
    if (int.TryParse(Console.ReadLine(), out int idx) && idx >= 1 && idx <= catList.Count)
    {
        q.Start(catList[idx - 1]);
    }
    else Console.WriteLine("Невірно.");
}

static void AddCustomQuestion(Quiz q)
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

    q.AddQuestion(new Question(text, options, correct, cat));
    Console.WriteLine("Додано!");
}

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

static void SeedQuestions(Quiz q)
{
    // Історія
    q.AddQuestion(new Question("Столиця України?",
        new[] { "Київ", "Львів", "Одеса", "Харків" }, 0, "Україна"));
    q.AddQuestion(new Question("Хто написав 'Кобзар'?",
        new[] { "Леся Українка", "Іван Франко", "Тарас Шевченко", "Михайло Коцюбинський" }, 2, "Україна"));
    q.AddQuestion(new Question("Рік прийняття Конституції України?",
        new[] { "1991", "1996", "2004", "2014" }, 1, "Україна"));

    // Математика
    q.AddQuestion(new Question("Скільки буде 7 * 8?",
        new[] { "54", "56", "64", "48" }, 1, "Математика"));
    q.AddQuestion(new Question("Чому дорівнює π (з округленням)?",
        new[] { "3.10", "3.14", "3.20", "3.25" }, 1, "Математика"));
    q.AddQuestion(new Question("Квадратний корінь з 144?",
        new[] { "10", "11", "12", "13" }, 2, "Математика"));

    // Програмування
    q.AddQuestion(new Question("Хто розробив C#?",
        new[] { "Microsoft", "Google", "Apple", "IBM" }, 0, "Програмування"));
    q.AddQuestion(new Question("Що повертає WriteLine?",
        new[] { "string", "int", "нічого (void)", "bool" }, 2, "Програмування"));
    q.AddQuestion(new Question("Тип для збереження true/false?",
        new[] { "int", "string", "bool", "char" }, 2, "Програмування"));
}


class Question
{
    public string Text { get; set; }
    public string[] Options { get; set; }
    public int CorrectIndex { get; set; }
    public string Category { get; set; }

    public Question(string text, string[] options, int correctIndex, string category = "Загальна")
    {
        Text = text;
        Options = options;
        CorrectIndex = correctIndex;
        Category = category;
    }

    public bool Ask()
    {
        Console.WriteLine();
        Console.WriteLine($"[{Category}] ➤ {Text}");
        for (int i = 0; i < Options.Length; i++)
            Console.WriteLine($"   {i + 1}. {Options[i]}");

        Console.Write("Ваш варіант (1-4): ");
        if (!int.TryParse(Console.ReadLine(), out int ans))
        {
            Console.WriteLine("✗ Невірний ввід");
            return false;
        }

        bool ok = (ans - 1) == CorrectIndex;
        Console.WriteLine(ok ? "✓ Правильно!" : $"✗ Неправильна. Правильна: {Options[CorrectIndex]}");
        return ok;
    }
}

class Quiz
{
    public List<Question> Questions { get; } = new();

    public void AddQuestion(Question q) => Questions.Add(q);

    public void ShowAll()
    {
        Console.WriteLine();
        Console.WriteLine("=== Усі питання ===");
        for (int i = 0; i < Questions.Count; i++)
        {
            var q = Questions[i];
            Console.WriteLine($"{i + 1}. [{q.Category}] {q.Text}");
        }
    }

    public void Start(string? category)
    {
        var subset = category == null
            ? Questions
            : Questions.Where(q => q.Category == category).ToList();

        if (subset.Count == 0)
        {
            Console.WriteLine("Немає питань!");
            return;
        }

        int correct = 0;
        var start = DateTime.Now;
        foreach (var q in subset)
            if (q.Ask()) correct++;
        var duration = DateTime.Now - start;

        double pct = (double)correct / subset.Count * 100;

        Console.WriteLine();
        Console.WriteLine("══════════════════════════════════");
        Console.WriteLine($"  Результат: {correct} з {subset.Count} ({pct:F0}%)");
        Console.WriteLine($"  Час: {duration.TotalSeconds:F0} сек");

        string verdict = pct switch
        {
            >= 90 => "🏆 ВІДМІННО",
            >= 75 => "⭐ ДОБРЕ",
            >= 60 => "👍 ЗАДОВІЛЬНО",
            _ => "📚 Спробуй ще!"
        };
        Console.WriteLine($"  Оцінка: {verdict}");
        Console.WriteLine("══════════════════════════════════");

        // Збереження результату
        string line = $"{DateTime.Now:yyyy-MM-dd HH:mm}  cat={category ?? "all"}  {correct}/{subset.Count} ({pct:F0}%)";
        File.AppendAllText("quiz_history.txt", line + Environment.NewLine);
    }
}
