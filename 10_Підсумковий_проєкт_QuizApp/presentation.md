---
title: "Урок 10. Підсумковий проєкт QuizApp"
date: "Заняття 10 з 10"
---

# Урок 10. Підсумковий проєкт

QuizApp — текстова вікторина

---

# 🎉 Ми пройшли курс!

За 10 уроків ви вивчили:
- Змінні, типи, ввід/вивід
- Оператори, перетворення
- Розгалуження і цикли
- Масиви та колекції
- Методи
- ООП: класи, спадкування, поліморфізм

Час зібрати все докупи!

---

# Завдання: QuizApp

Текстова вікторина з:
- класами `Question` і `Quiz`;
- меню;
- ≥ 5 питаннями;
- підрахунком балів;
- оцінкою результату.

---

# Архітектура

```
class Question
{
    string Text
    string[] Options (4)
    int CorrectIndex
    bool Ask()
}

class Quiz
{
    List<Question> Questions
    void AddQuestion(Question q)
    void Start()
}
```

---

# Метод Ask()

```csharp
public bool Ask()
{
    Console.WriteLine(Text);
    for (int i = 0; i < Options.Length; i++)
        Console.WriteLine($"{i + 1}. {Options[i]}");

    int answer = int.Parse(Console.ReadLine()!) - 1;
    return answer == CorrectIndex;
}
```

---

# Метод Start()

```csharp
public void Start()
{
    int correct = 0;
    foreach (var q in Questions)
    {
        if (q.Ask()) correct++;
    }
    double pct = (double)correct / Questions.Count * 100;
    Console.WriteLine($"Результат: {correct}/{Questions.Count} ({pct:F0}%)");
}
```

---

# Меню в Main

```csharp
while (true)
{
    Console.WriteLine("1. Почати");
    Console.WriteLine("2. Додати");
    Console.WriteLine("0. Вихід");
    string choice = Console.ReadLine()!;
    if (choice == "0") break;
    if (choice == "1") quiz.Start();
    if (choice == "2") AddQuestion(quiz);
}
```

---

# Демо

Учитель показує готовий QuizApp у `solutions/`.

---

# Захист

- 3 хвилини на учня
- Що показати:
  1. Запустити QuizApp
  2. Пройти 2–3 питання
  3. Показати бонусну фічу
  4. Відповісти на 1 запитання класу

---

# 🚀 Куди далі?

- **Unity** — створювати ігри
- **ASP.NET Core** — веб-сайти
- **.NET MAUI** — мобільні застосунки
- Microsoft Learn — безкоштовні онлайн-курси
- Книги: «C# Player's Guide», «Pro C#»

---

# 🎓 Дякую за чудовий курс!

Вітаю — ви зробили перші професійні кроки у програмуванні.

Удачі у вашому шляху розробника!
