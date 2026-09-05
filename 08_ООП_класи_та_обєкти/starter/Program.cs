// Урок 8. Starter: класи та обʼєкти.

Console.OutputEncoding = System.Text.Encoding.UTF8;

// TODO 1: Створіть обʼєкт Point(3, 5). Виведіть його X і Y.


// TODO 2: Створіть 3 студентів (Student) і виведіть їх інформацію через Introduce().


// TODO 3: Створіть List<Student> з 5 студентів. Виведіть усіх.


// TODO 4 (бонус): Створіть бібліотеку (Library), додайте 3 книги (Book),
// викличте ShowAll().


Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();


// ---------- Класи (вже готові) ----------

class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

class Student
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public string ClassName { get; set; } = "";
    public double AverageGrade { get; set; }

    public Student(string name, int age, string className, double averageGrade)
    {
        Name = name;
        Age = age;
        ClassName = className;
        AverageGrade = averageGrade;
    }

    public void Introduce()
    {
        Console.WriteLine($"Я {Name}, {Age} р., {ClassName} клас, середня {AverageGrade}");
    }
}

class Book
{
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public int Year { get; set; }
    public bool IsAvailable { get; set; } = true;
}

class Library
{
    public List<Book> Books { get; } = new();

    public void AddBook(Book b) => Books.Add(b);

    public void ShowAll()
    {
        foreach (var b in Books)
            Console.WriteLine($"  \"{b.Title}\" — {b.Author} ({b.Year})");
    }
}
