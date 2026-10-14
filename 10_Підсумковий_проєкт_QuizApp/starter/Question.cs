using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    internal class Question
    {
        public string Text { get; set; }

        public string[] Options { get; set; }

        public int CorrectIndex { get; set; }

        public string? Category { get; set; }

        public Question(string text, string[] options, int correct, string? category)
        {
            Text = text;
            Options = options;
            CorrectIndex = correct;
            Category = category;
        }

        /*
            Етап 2 (★★) — Метод Ask
            Додайте метод bool Ask(). Він:

            Виводить питання.
            Виводить 4 варіанти (з номерами 1–4).
            Читає число.
            Повертає true, якщо відповідь правильна, false — інакше.
         */
        public bool Ask()
        {
            Console.WriteLine();
            Console.WriteLine($"{Text}");

            for (int i = 0; i < Options.Length; i++)
            {
                Console.WriteLine($"[{Category ?? "Не визначена"}]: {i + 1}. {Options[i]}");
            }

            Console.Write($"Ваш варіант (1-{Options.Length + 1}): ");
            if (!int.TryParse(Console.ReadLine(), out int answer))
            {
                Console.WriteLine("Неправильна відповідь");
                return false;
            }

            bool isCorrectAnswer = (answer - 1) == CorrectIndex;

            Console.WriteLine(isCorrectAnswer ? "Відповідь правильна" : $"Відповідь неправильна. Правильний варіант - {Options[CorrectIndex]}");

            return isCorrectAnswer;
        }
    }
}
