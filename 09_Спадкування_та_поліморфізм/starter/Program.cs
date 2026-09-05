// Урок 9. Starter: спадкування і поліморфізм.

Console.OutputEncoding = System.Text.Encoding.UTF8;

// TODO 1: Створіть об'єкт Dog("Рекс") і викличте Sound().


// TODO 2: Створіть List<Animal> з 4-5 тварин різних типів.
// У foreach викличте Sound() кожній — побачите поліморфізм у дії.


// TODO 3: Перевизначте Dog.Sound(), щоб виводив "Я собака, " + base.Sound().


// TODO 4 (бонус): Створіть Circle, Rectangle, Triangle і обчисліть площу кожної.


Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();


// ---------- Класи (вже готові) ----------

class Animal
{
    public string Name { get; }
    public Animal(string name) { Name = name; }
    public virtual string Sound() => "...";
}

class Dog : Animal
{
    public Dog(string name) : base(name) { }
    public override string Sound() => "Гав!";
}

class Cat : Animal
{
    public Cat(string name) : base(name) { }
    public override string Sound() => "Мяу!";
}

// TODO: додайте Cow ("Му!"), Duck ("Кря!")
