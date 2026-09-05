# Урок 10. Завдання на уроці (поетапна збірка QuizApp)

## Етап 1 (★) — Клас Question

Створіть клас `Question`:
```csharp
class Question
{
    public string Text { get; set; } = "";
    public string[] Options { get; set; } = new string[4];
    public int CorrectIndex { get; set; }

    public Question(string text, string[] options, int correct) { ... }
}
```

## Етап 2 (★★) — Метод Ask

Додайте метод `bool Ask()`. Він:
1. Виводить питання.
2. Виводить 4 варіанти (з номерами 1–4).
3. Читає число.
4. Повертає `true`, якщо відповідь правильна, `false` — інакше.

## Етап 3 (★★) — Клас Quiz

```csharp
class Quiz
{
    public List<Question> Questions { get; } = new();
    public void AddQuestion(Question q) => Questions.Add(q);
    public void Start() { /* пробігтись питаннями, рахувати правильні */ }
}
```

## Етап 4 (★★★) — Меню

У `Main` створіть меню:
```
=== ВІКТОРИНА ===
1. Почати тест
2. Подивитись питання
3. Додати своє питання
0. Вихід
```

## Етап 5 (★★★) — Початкові питання

Додайте 5–10 «зашитих» питань про шкільну програму. Тематика на ваш смак.

## Етап 6 (★★★★ бонус) — Категорії

У класі `Question` додайте поле `Category`. У меню — пункт «Обрати категорію».

## Етап 7 (★★★★ бонус) — Збереження

Збережіть результати тестів у файл (`File.AppendAllText("results.txt", ...)`) з ім'ям, датою, балом.

---

## Здача проєкту

1. Збережіть проєкт у `.zip`.
2. Запишіть **screencast** (2–3 хв), де ви проходите тест.
3. Захистіть на уроці.
