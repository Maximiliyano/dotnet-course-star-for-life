# Курс .NET Starter for Juniors

**Інструменти:** .NET 8/10, C# 12, Visual Studio Community 2022.

---

## Цілі курсу

Після завершення курсу студенти зможуть:
- знати принципи комунікації ПК з програмами;
- встановити середовище розробки та створити перший .NET-проєкт;
- працювати з базовими типами даних, операторами і вводом/виводом;
- будувати алгоритми з розгалуженнями, циклами, масивами;
- розкладати програму на методи та власні класи;
- застосовувати базові принципи об'єктно-орієнтованого програмування;

## Структура

```
DotNet_Lessons/
├── README.md                      ← загальна інформація про курс
├── DotNetLessons.sln              ← єдиний solution (відкривається у VS)
├── 00_Setup/                      ← базове встановлення
└── 01_… 10_…/                     ← уроки
    ├── README.md                  ← план уроку
    ├── presentation.pptx          ← презентація
    ├── exercises.md               ← практичні завдання
    ├── homework.md                ← домашнє завдання
    ├── starter/                   ← шаблон заготовка для учнів
    └── solutions/                 ← еталонні розв'язки
```

## Програма курсу

| № | Тема | Приклад | Онлайн завдання |
|---|------|------------------|--------|
| 1 | Вступ до .NET та C#. Перша програма | `HelloWorld` | https://dotnetfiddle.net/ImV13Q |
| 2 | Змінні та типи даних | «Анкета учня» | https://dotnetfiddle.net/TVB3Ra |
| 3 | Введення з консолі, оператори, перетворення типів | Калькулятор ІМТ | https://dotnetfiddle.net/4KSFpu
| 4 | Розгалуження: `if`, `else`, `switch` | «Камінь-Ножиці-Папір» | https://dotnetfiddle.net/LUpmvH
| 5 | Цикли: `for`, `while`, `do-while` | «Вгадай число» | https://dotnetfiddle.net/m4yHSv
| 6 | Масиви та `List<T>` | Журнал оцінок | https://dotnetfiddle.net/h1jAN1
| 7 | Методи (функції) | Математична бібліотека | https://dotnetfiddle.net/Xj0T3f
| 8 | ООП: класи та об'єкти | Клас `Student` + Бібліотека | https://dotnetfiddle.net/WK8TpW
| 9 | Спадкування, поліморфізм, інкапсуляція | Ієрархія `Animal` | https://dotnetfiddle.net/kzSvhR
| 10 | Підсумковий проєкт | `QuizApp` (текстова вікторина) | https://dotnetfiddle.net/XFYCks

## Як користуватися курсом

1. Відкрийте `DotNetLessons.sln` у Visual Studio.
2. Знайдіть у Solution Explorer проєкт відповідного уроку (наприклад, `Lesson01.Starter`).
3. ПКМ → «**Set as Startup Project**» → натисніть **F5** для запуску.
4. Виконуйте `TODO`-завдання у `Program.cs`. Якщо застрягли — підгляньте `00_Setuo/cheatsheet.md`.

## Корисні ресурси

- Офіційна документація .NET (uk): https://learn.microsoft.com/uk-ua/dotnet/
- C# для початківців (Microsoft Learn): https://learn.microsoft.com/uk-ua/training/paths/csharp-first-steps/
- .NET Fiddle, онлайн-редактор C# у браузері: https://dotnetfiddle.net
- Visual Studio Code документація як почати роботу на .NET https://code.visualstudio.com/docs/languages/dotnet
- Visual Studio https://visualstudio.microsoft.com/
