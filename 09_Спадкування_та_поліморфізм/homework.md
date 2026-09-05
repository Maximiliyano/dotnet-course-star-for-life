# Урок 9. Домашнє завдання

## Завдання: «Зоопарк»

Створіть проєкт `HW09_Zoo`.

### Базовий клас `Animal`

```csharp
abstract class Animal
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public abstract string Sound();
    public virtual void Introduce()
    {
        Console.WriteLine($"Я {Name}, мені {Age} р. Я кажу: {Sound()}");
    }
}
```

### Дочірні класи (мінімум 5)

- `Lion` (Sound = "Рик!")
- `Elephant` ("Топ!")
- `Monkey` ("У-у!")
- `Parrot` ("Привіт!")
- `Snake` ("С-с-с!")

### Клас `Zoo`

- Поле `List<Animal> animals`
- Метод `AddAnimal(Animal a)`
- Метод `MorningRound()` — обходить усіх і кожен «представляється» (виклик `Introduce()`)
- Метод `FindOldest()` — повертає найстарішу тварину
- Метод `CountByType<T>()` — кількість тварин конкретного типу

### `Main`

1. Створіть зоопарк.
2. Додайте 5–7 тварин.
3. Зробіть ранковий обхід.
4. Виведіть найстарішу.

## Бонус (★)

Створіть `Bird : Animal` із полем `bool CanFly` і методом `Fly()`. `Parrot` тоді буде `Parrot : Bird`.

## Що далі?

- Урок 10: **підсумковий проєкт — QuizApp**
- Збираємо все в одну гру: класи, цикли, колекції, методи
