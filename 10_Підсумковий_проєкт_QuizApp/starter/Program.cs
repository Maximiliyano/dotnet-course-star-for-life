// Урок 10. Starter: основа QuizApp.
// Завершіть цей шаблон, щоб отримати власну вікторину.

Console.OutputEncoding = System.Text.Encoding.UTF8;

var quiz = new Quiz();

// TODO 1: Додайте 5+ власних питань через quiz.AddQuestion(new Question(...))


// TODO 2: Реалізуйте меню (поки тестово запускаємо одразу)
quiz.Start();


// TODO 3 (бонус): зробіть нескінченне меню з вибором почати/додати/вихід.


Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();


// ---------- Класи (вже готові — використовуйте) ----------

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
        Console.WriteLine(Text);
        for (int i = 0; i < Options.Length; i++)
            Console.WriteLine($"  {i + 1}. {Options[i]}");

        Console.Write("Ваш варіант (1-4): ");
        int answer = int.Parse(Console.ReadLine()!) - 1;
        bool ok = answer == CorrectIndex;
        Console.WriteLine(ok ? "Правильно!" : $"Неправильно. Правильна: {Options[CorrectIndex]}");
        return ok;
    }
}

class Quiz
{
    public List<Question> Questions { get; } = new();

    public void AddQuestion(Question q) => Questions.Add(q);

    public void Start()
    {
        if (Questions.Count == 0)
        {
            Console.WriteLine("Спочатку додайте питання!");
            return;
        }

        int correct = 0;
        foreach (var q in Questions)
            if (q.Ask()) correct++;

        double pct = (double)correct / Questions.Count * 100;
        Console.WriteLine();
        Console.WriteLine($"Результат: {correct} з {Questions.Count} ({pct:F0}%)");

        if (pct >= 90) Console.WriteLine("Відмінно!");
        else if (pct >= 75) Console.WriteLine("Добре!");
        else if (pct >= 60) Console.WriteLine("Задовільно");
        else Console.WriteLine("Спробуй ще раз!");
    }
}
