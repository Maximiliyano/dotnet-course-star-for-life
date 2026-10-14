---
title: "Урок 9. Спадкування і поліморфізм"
date: "Заняття 9 з 10"
---

# Урок 9. Спадкування, поліморфізм, інкапсуляція

Класи стають родинами

---

# Чотири стовпи ООП

1. **Інкапсуляція** — приховуй внутрішнє
2. **Спадкування** — успадковуй риси
3. **Поліморфізм** — різна поведінка одного методу
4. **Абстракція** — модель без зайвого

---

# Спадкування — навіщо?

Без спадкування:
```csharp
class Dog { public string Name; public void Eat() {...} }
class Cat { public string Name; public void Eat() {...} }
class Cow { public string Name; public void Eat() {...} }
```

😱 Однакові методи дублюються.

---

# Зі спадкуванням

```csharp
class Animal
{
    public string Name = "";
    public void Eat() { ... }
}

class Dog : Animal { }
class Cat : Animal { }
class Cow : Animal { }
```

✅ `Eat` і `Name` — успадковуються.

---

# virtual / override

```csharp
class Animal
{
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
```

---

# Поліморфізм — магія

```csharp
List<Animal> zoo = new();
zoo.Add(new Dog());
zoo.Add(new Cat());
zoo.Add(new Cow());

foreach (var a in zoo)
    Console.WriteLine(a.Sound());
```

Виведе:
```
Гав!
Мяу!
Му!
```

**Один цикл — різна поведінка**!

---

# abstract клас

```csharp
abstract class Shape
{
    public abstract double Area();
}

class Circle : Shape
{
    public double R;
    public override double Area() => Math.PI * R * R;
}
```

`abstract` клас — лише шаблон. Реальні — нащадки.

---

# Інкапсуляція

```csharp
class BankAccount
{
    private double _balance;

    public void Deposit(double x)
    {
        if (x > 0) _balance += x;
    }

    public bool Withdraw(double x)
    {
        if (x > _balance) return false;
        _balance -= x;
        return true;
    }
}
```

Поле приватне → жодних злих хакерів.

---

# base — виклик батька

```csharp
class Dog : Animal
{
    public override string Sound()
    {
        return "Я собака. " + base.Sound();
    }
}
```

`base` — повернутись до батьківської реалізації.

---

# Що далі?

- Урок 10: **підсумковий проєкт**
- Збираємо власну текстову вікторину
- Захищаємо свій проєкт

---

# Завдання

🎯 **На уроці:** 6 завдань

📝 **Додому:** Зоопарк з 5+ тваринами
