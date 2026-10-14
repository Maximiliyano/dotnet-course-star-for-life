// Урок 9. Starter: спадкування і поліморфізм.

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Завдання 1 (★) — «Animal та Dog»
// Створіть клас Animal з полями Name і методом Sound() (виводить «...»). Створіть Dog : Animal, де Sound() виводить «Гав!». Створіть і виведіть
var dog = new Dog("Rex");
Console.WriteLine($"{dog.Name}: {dog.Sound()}");
Console.WriteLine();

// Завдання 2 (★★) — «Більше тварин»
// Додайте класи Cat («Мяу!»), Cow («Му!»), Duck («Кря!»). Створіть List<Animal> з різними тваринами, у циклі викличте Sound() кожній. Це — поліморфізм.
Console.WriteLine();
List<Animal> zoo = new()
{
    new Dog("Рекс"),
    new Cat("Мурчик"),
    new Cow("Зірочка"),
    new Duck("Кряклик"),
    new Dog("Барсик")
};

foreach (var animal in zoo)
{
    Console.WriteLine($"{animal.Name} - {animal.Sound()}");
}

// Завдання 3 (★★) — «base — виклик батька»
// У Dog.Sound() спочатку виведіть «Я собака,», а потім викличте base.Sound() (поведінку батька). Подивіться різницю.
Console.WriteLine();
Console.WriteLine("base.Sound(): ");
Console.WriteLine(dog.SoundBase());

// Завдання 4 (★★★) — «Shape ієрархія»
// Створіть абстрактний клас Shape з абстрактним методом double Area(). Створіть Circle, Rectangle, Triangle зі своїми реалізаціями.
Console.WriteLine();
List<Shape> shapes = new()
{
    new Circle(5),
    new Rectangle(4, 3),
    new Triangle(6, 4)
};
foreach (var shape in shapes)
{
    Console.WriteLine($"{shape.GetType().Name}: площа = {Math.Round(shape.Area(), 2)}");
}

// Завдання 5 (★★★) — «Vehicle ієрархія»
// Клас Vehicle з полем Speed. Класи Car, Bicycle, Plane із власною Speed. Метод Move() виводить «Я їду/їжджу/лечу зі швидкістю X».
Console.WriteLine();


// Завдання 6 (★★★★) — «Інкапсуляція BankAccount»
// Клас BankAccount з приватним полем _balance. Методи Deposit, Withdraw, GetBalance. Зняти не можна більше, ніж є. Створіть SavingsAccount : BankAccount +
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();

// TODO: додайте Cow ("Му!"), Duck ("Кря!")

//=========================

public class Vehicle
{
    public int Speed { get; set; }

    public Vehicle(string model, int speed) { Speed = speed; }

    public virtual void Move()
    {
        Console.WriteLine($"Ви рухались зі швидкістю {Speed} км/год");
    }
}

class Car : Vehicle
{
    public Car(string m, int s) : base(m, s) { }
    public override void Move() => Console.WriteLine($"їде дорогою зі швидкістю {Speed} км/год");
}

class Bicycle : Vehicle
{
    public Bicycle(string m, int s) : base(m, s) { }
    public override void Move() => Console.WriteLine($"крутиться педалями зі швидкістю {Speed} км/год");
}

class Plane : Vehicle
{
    public Plane(string m, int s) : base(m, s) { }
    public override void Move() => Console.WriteLine($"летить зі швидкістю {Speed} км/год");
}

public class Triangle : Shape
{
    public double B { get; set; }

    public double H { get; set; }

    public Triangle(double b, double h)
    {
        B = b;
        H = h;
    }

    public override double Area()
    {
        return 0.5 * B * H;
    }
}

public class Rectangle : Shape
{
    public double W { get; set; }

    public double H { get; set; }

    public Rectangle(double w, double h)
    {
        W = w;
        H = h;
    }

    public override double Area()
    {
        return W * H;
    }
}

public class Circle : Shape
{
    public double R { get; set; }

    public Circle(double r)
    {
        R = r;
    }

    public override double Area()
    {
        return Math.PI * R * R;
    }
}

// Parent
public abstract class Shape
{
    public abstract double Area();
}

// Parent class
public class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public virtual string Sound()
    {
        return "...";
    }
}

// Child class
public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    public override string Sound()
    {
        return "Гав!";
    }

    public string SoundBase()
    {
        return "Я собака, " + base.Sound();
    }
}

public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public override string Sound()
    {
        return "Мяу!";
    }
}

public class Cow : Animal
{
    public Cow(string name) : base(name)
    {
    }

    public override string Sound()
    {
        return "Му!";
    }
}

public class Duck : Animal
{
    public Duck(string name) : base(name)
    {
    }

    public override string Sound()
    {
        return "Кря!";
    }
}