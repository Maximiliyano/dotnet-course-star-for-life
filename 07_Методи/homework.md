# Урок 7. Домашнє завдання

## Завдання: «Бібліотека MathLib»

Створіть проєкт `HW07_MathLib`. У ньому реалізуйте методи:

| Метод | Що робить |
|-------|-----------|
| `int Add(int a, int b)` | сума |
| `int Subtract(int a, int b)` | різниця |
| `int Multiply(int a, int b)` | добуток |
| `double Divide(int a, int b)` | частка (double!) |
| `int Power(int a, int b)` | a в степені b |
| `int Min(int a, int b)` | мінімум |
| `int Max(int a, int b)` | максимум |
| `bool IsEven(int n)` | парне? |
| `int Abs(int n)` | модуль |
| `long Factorial(int n)` | факторіал |

У `Main` створіть «меню»:
```
=== MathLib ===
1. Сума
2. Різниця
...
0. Вихід
Виберіть:
```

Через `switch` викличте відповідний метод і виведіть результат.

## Бонус (★)

Додайте методи `string ToBinary(int n)` (переведення у двійкову систему) і `int FromBinary(string s)`.

## Що далі?

- Урок 8: **класи та об'єкти** — справжній ООП.
- Створимо клас `Student` і `Book` (бібліотека).
