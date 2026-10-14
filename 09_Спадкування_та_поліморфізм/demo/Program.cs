// Урок 9. Демо: Спадкування і поліморфізм.

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Список тварин різних типів
List<Animal> zoo = new()
{
    new Dog("Рекс"),
    new Cat("Мурчик"),
    new Cow("Зірочка"),
    new Duck("Кряклик")
};

Console.WriteLine("=== ЗООПАРК ===");
foreach (var animal in zoo)
{
    Console.WriteLine($"{animal.Name}: {animal.Sound()}");
}
Console.WriteLine();

// Демо абстрактного класу Shape
Console.WriteLine("=== ФІГУРИ ===");
List<Shape> shapes = new()
{
    new Circle(5),
    new Rectangle(4, 3),
    new Triangle(6, 4)
};
foreach (var s in shapes)
{
    Console.WriteLine($"{s.GetType().Name}: площа = {Math.Round(s.Area(), 2)}");
}

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

class Cow : Animal
{
    public Cow(string name) : base(name) { }
    public override string Sound() => "Му!";
}

class Duck : Animal
{
    public Duck(string name) : base(name) { }
    public override string Sound() => "Кря!";
}

abstract class Shape
{
    public abstract double Area();
}

class Circle : Shape
{
    public double Radius { get; }
    public Circle(double r) { Radius = r; }
    public override double Area() => Math.PI * Radius * Radius;
}

class Rectangle : Shape
{
    public double Width { get; }
    public double Height { get; }
    public Rectangle(double w, double h) { Width = w; Height = h; }
    public override double Area() => Width * Height;
}

class Triangle : Shape
{
    public double Base { get; }
    public double Height { get; }
    public Triangle(double b, double h) { Base = b; Height = h; }
    public override double Area() => 0.5 * Base * Height;
}
