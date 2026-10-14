using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    internal class Quiz
    {
        public List<Question> Questions { get; } = new List<Question>();

        public void AddQuestion(Question question)
        {
            if (Questions.Any(q => q.Text.Equals(question.Text, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Питання уже існує");
                return;
            }

            Questions.Add(question);
        }

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
                : Questions.Where(q => q.Category.Equals(category)).ToList();

            if (subset.Count == 0)
            {
                Console.WriteLine("Запитань немає!");
                return;
            }

            int correct = 0;
            var start = DateTime.Now;

            foreach (Question question in subset)
            {
                if (question.Ask())
                {
                    correct++;
                }
            }

            var duration = DateTime.Now - start;

            double score = (double)correct / subset.Count * 100;

            Console.WriteLine();
            Console.WriteLine("══════════════════════════════════");
            Console.WriteLine($"Результат: {correct} з {subset.Count} ({score:F0}%)");
            Console.WriteLine($"Час: {duration.TotalSeconds:F0} сек");

            string verdict = score switch
            {
                >= 90 => "🏆 Відмінно",
                >= 75 => "⭐ Добре",
                >= 60 => "👍 Задовільно",
                _ => "Спробуй ще раз!"
            };

            Console.WriteLine($"  Оцінка: {verdict}");
            Console.WriteLine("══════════════════════════════════");

            string line = $"{DateTime.Now:yyyy-MM-dd HH:mm}  cat={category ?? "all"}  {correct}/{subset.Count} ({score:F0}%)";
            File.AppendAllText("quiz_history.txt", line + Environment.NewLine);
        }
    }
}
