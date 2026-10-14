// Урок 9. Розв'язки.

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Завдання 1 — Dog
var rex = new Dog("Рекс");
Console.WriteLine($"{rex.Name}: {rex.Sound()}");
Console.WriteLine();

// Завдання 2 — Поліморфізм
List<Animal> zoo = new()
{
    new Dog("Рекс"), new Cat("Мурчик"), new Cow("Зірочка"),
    new Duck("Кряклик"), new Dog("Барсик")
};
Console.WriteLine("=== Зоопарк ===");
foreach (var a in zoo)
    Console.WriteLine($"{a.Name}: {a.Sound()}");
Console.WriteLine();

// Завдання 3 — base.Sound()
Console.WriteLine("base.Sound():");
var dogWithBase = new DogWithBase("Барбос");
Console.WriteLine(dogWithBase.Sound());
Console.WriteLine();

// Завдання 4 — Shapes (абстрактний клас)
Console.WriteLine("=== Фігури ===");
List<Shape> shapes = new()
{
    new Circle(5),
    new Rectangle(4, 3),
    new Triangle(6, 4)
};
foreach (var s in shapes)
    Console.WriteLine($"{s.GetType().Name}: площа = {Math.Round(s.Area(), 2)}");
Console.WriteLine();

// Завдання 5 — Vehicle
List<Vehicle> vehicles = new()
{
    new Car("Toyota", 120),
    new Bicycle("Giant", 25),
    new Plane("Airbus", 850)
};
foreach (var v in vehicles) v.Move();
Console.WriteLine();

// Завдання 6 — Інкапсуляція
var savings = new SavingsAccount(0.05);
savings.Deposit(1000);
savings.AddInterest();
Console.WriteLine($"Баланс зі % : {Math.Round(savings.GetBalance(), 2)}");

Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();


// ---------- Класи ----------

class Animal
{
    public string Name { get; }
    public Animal(string name) { Name = name; }
    public virtual string Sound() => "...";
}
class Dog : Animal { public Dog(string n) : base(n) { } public override string Sound() => "Гав!"; }
class Cat : Animal { public Cat(string n) : base(n) { } public override string Sound() => "Мяу!"; }
class Cow : Animal { public Cow(string n) : base(n) { } public override string Sound() => "Му!"; }
class Duck : Animal { public Duck(string n) : base(n) { } public override string Sound() => "Кря!"; }

class DogWithBase : Animal
{
    public DogWithBase(string n) : base(n) { }
    public override string Sound() => "Я собака. " + base.Sound();
}

abstract class Shape { public abstract double Area(); }
class Circle : Shape { public double R; public Circle(double r) { R = r; } public override double Area() => Math.PI * R * R; }
class Rectangle : Shape { public double W, H; public Rectangle(double w, double h) { W = w; H = h; } public override double Area() => W * H; }
class Triangle : Shape { public double B, H; public Triangle(double b, double h) { B = b; H = h; } public override double Area() => 0.5 * B * H; }

class Vehicle
{
    public string Model { get; }
    public int Speed { get; }
    public Vehicle(string model, int speed) { Model = model; Speed = speed; }
    public virtual void Move() => Console.WriteLine($"{Model} рухається з {Speed} км/год");
}

class Car : Vehicle
{
    public Car(string m, int s) : base(m, s) { }
    public override void Move() => Console.WriteLine($"{Model} їде дорогою зі швидкістю {Speed} км/год");
}

class Bicycle : Vehicle
{
    public Bicycle(string m, int s) : base(m, s) { }
    public override void Move() => Console.WriteLine($"{Model} крутиться педалями зі швидкістю {Speed} км/год");
}

class Plane : Vehicle
{
    public Plane(string m, int s) : base(m, s) { }
    public override void Move() => Console.WriteLine($"{Model} летить зі швидкістю {Speed} км/год");
}

class BankAccount
{
    protected double _balance;

    public void Deposit(double amount)
    {
        if (amount > 0) _balance += amount;
    }

    public bool Withdraw(double amount)
    {
        if (amount <= 0 || amount > _balance) return false;
        _balance -= amount;
        return true;
    }

    public double GetBalance() => _balance;
}

class SavingsAccount : BankAccount
{
    public double Interest { get; }
    public SavingsAccount(double interest) { Interest = interest; }
    public void AddInterest() => _balance += _balance * Interest;
}
