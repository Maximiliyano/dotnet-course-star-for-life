# Урок 9. Нотатки для вчителя

## Стовпи ООП

| Стовп | Що означає |
|-------|-----------|
| **Інкапсуляція** | приховування внутрішнього стану (`private`) |
| **Спадкування** | один клас — нащадок іншого (`:`) |
| **Поліморфізм** | один інтерфейс — різна поведінка (`virtual`/`override`) |
| **Абстракція** | модель без зайвих деталей (`abstract`) |

## Демо: Animal → Dog

```csharp
class Animal
{
    public string Name { get; set; } = "";
    public virtual string Sound() => "...";
}

class Dog : Animal
{
    public override string Sound() => "Гав!";
}

class Cat : Animal
{
    public override string Sound() => "Мяу!";
}

Animal[] zoo = { new Dog { Name = "Рекс" },
                 new Cat { Name = "Мурчик" } };

foreach (var a in zoo)
    Console.WriteLine($"{a.Name}: {a.Sound()}");
```

Виведе:
```
Рекс: Гав!
Мурчик: Мяу!
```

Це і є **поліморфізм** — один цикл, різна поведінка.

## `virtual` + `override`

- `virtual` у батька — «дочірні можуть перевизначити».
- `override` у нащадка — «перевизначаю».

Якщо `virtual` немає, `override` не працює.

## `abstract`

```csharp
abstract class Shape
{
    public abstract double Area();
}

class Circle : Shape
{
    public double Radius;
    public override double Area() => Math.PI * Radius * Radius;
}
```

- `abstract` клас НЕ можна створити: `new Shape()` — помилка.
- `abstract` метод **не має тіла**, дочірні **зобовʼязані** реалізувати.

## `base`

```csharp
class Dog : Animal
{
    public override string Sound()
    {
        return "Гав, " + base.Sound();  // викликає Animal.Sound()
    }

    public Dog(string name) : base()  // викликає конструктор Animal
    {
        Name = name;
    }
}
```

## Найчастіші помилки

| Помилка | Рішення |
|---------|--------|
| `override` без `virtual` | У батьківському методі має бути `virtual`. |
| Створення `abstract` класу | Не можна — лише через нащадків. |
| Доступ до `private` зовні | Зробити `protected` або `public`. |
| Забули `: base(...)` | Якщо у батька конструктор з параметрами — обов'язково. |

## Час перевірки розуміння

Запитайте учнів:
1. Що таке поліморфізм? (Один метод, різна поведінка.)
2. Чому `abstract class Shape`? (Бо не існує «шейпу взагалі», лише коло, квадрат…)
3. Що означає `Dog : Animal`? (Dog успадковує Animal.)
