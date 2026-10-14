// Урок 10. Демо: повна вікторина QuizApp.

Console.OutputEncoding = System.Text.Encoding.UTF8;

var quiz = new Quiz();
SeedQuestions(quiz);

while (true)
{
    Console.WriteLine();
    Console.WriteLine("════════════════════════════════");
    Console.WriteLine("       КВІЗ - ВІКТОРИНА");
    Console.WriteLine("════════════════════════════════");
    Console.WriteLine($"Питань у базі: {quiz.Questions.Count}");
    Console.WriteLine();
    Console.WriteLine("1. Почати тест");
    Console.WriteLine("2. Показати всі питання");
    Console.WriteLine("3. Додати своє питання");
    Console.WriteLine("0. Вихід");
    Console.Write("Виберіть: ");

    string choice = Console.ReadLine()?.Trim() ?? "";

    if (choice == "0") break;

    switch (choice)
    {
        case "1": quiz.Start(); break;
        case "2": quiz.ShowAll(); break;
        case "3": AddCustomQuestion(quiz); break;
        default: Console.WriteLine("Невірний пункт меню."); break;
    }
}

Console.WriteLine();
Console.WriteLine("До побачення!");


static void SeedQuestions(Quiz q)
{
    q.AddQuestion(new Question(
        "Столиця України?",
        new[] { "Київ", "Львів", "Одеса", "Харків" },
        0));

    q.AddQuestion(new Question(
        "Хто написав 'Кобзар'?",
        new[] { "Леся Українка", "Іван Франко", "Тарас Шевченко", "Михайло Коцюбинський" },
        2));

    q.AddQuestion(new Question(
        "Скільки буде 7 * 8?",
        new[] { "54", "56", "64", "48" },
        1));

    q.AddQuestion(new Question(
        "Найвища гора України?",
        new[] { "Говерла", "Бребенескул", "Петрос", "Піп Іван" },
        0));

    q.AddQuestion(new Question(
        "Хто винайшов C#?",
        new[] { "Microsoft", "Google", "Apple", "IBM" },
        0));

    q.AddQuestion(new Question(
        "Що означає WriteLine?",
        new[] {
            "Записати у файл",
            "Вивести у консоль з новим рядком",
            "Прочитати дані",
            "Закрити програму"
        },
        1));
}

static void AddCustomQuestion(Quiz q)
{
    Console.Write("Текст питання: ");
    string text = Console.ReadLine() ?? "";

    string[] options = new string[4];
    for (int i = 0; i < 4; i++)
    {
        Console.Write($"Варіант {i + 1}: ");
        options[i] = Console.ReadLine() ?? "";
    }

    Console.Write("Номер правильної відповіді (1-4): ");
    int correct = int.Parse(Console.ReadLine()!) - 1;

    q.AddQuestion(new Question(text, options, correct));
    Console.WriteLine("Питання додано!");
}


class Question
{
    public string Text { get; set; }
    public string[] Options { get; set; }
    public int CorrectIndex { get; set; }

    public Question(string text, string[] options, int correctIndex)
    {
        Text = text;
        Options = options;
        CorrectIndex = correctIndex;
    }

    public bool Ask()
    {
        Console.WriteLine();
        Console.WriteLine($"➤ {Text}");
        for (int i = 0; i < Options.Length; i++)
            Console.WriteLine($"  {i + 1}. {Options[i]}");

        Console.Write("Ваш варіант (1-4): ");
        if (!int.TryParse(Console.ReadLine(), out int ans))
        {
            Console.WriteLine("Невірний ввід — зараховано як неправильна.");
            return false;
        }

        bool isCorrect = (ans - 1) == CorrectIndex;
        Console.WriteLine(isCorrect ? "✓ Правильно!" : $"✗ Неправильно. Правильна: {Options[CorrectIndex]}");
        return isCorrect;
    }
}

class Quiz
{
    public List<Question> Questions { get; } = new();

    public void AddQuestion(Question q) => Questions.Add(q);

    public void ShowAll()
    {
        Console.WriteLine();
        Console.WriteLine("=== УСІ ПИТАННЯ ===");
        for (int i = 0; i < Questions.Count; i++)
            Console.WriteLine($"{i + 1}. {Questions[i].Text}");
    }

    public void Start()
    {
        if (Questions.Count == 0)
        {
            Console.WriteLine("База питань порожня!");
            return;
        }

        int correct = 0;
        var startTime = DateTime.Now;

        foreach (var q in Questions)
            if (q.Ask()) correct++;

        var duration = DateTime.Now - startTime;
        double pct = (double)correct / Questions.Count * 100;

        Console.WriteLine();
        Console.WriteLine("══════════════════════════════════");
        Console.WriteLine("           РЕЗУЛЬТАТ");
        Console.WriteLine("══════════════════════════════════");
        Console.WriteLine($"Правильно: {correct} з {Questions.Count} ({pct:F0}%)");
        Console.WriteLine($"Час: {duration.TotalSeconds:F0} сек.");

        string verdict = pct switch
        {
            >= 90 => "🏆 Відмінно!",
            >= 75 => "⭐ Добре!",
            >= 60 => "👍 Задовільно",
            _     => "📚 Спробуй ще раз — ти зможеш!"
        };
        Console.WriteLine($"Оцінка: {verdict}");
    }
}
