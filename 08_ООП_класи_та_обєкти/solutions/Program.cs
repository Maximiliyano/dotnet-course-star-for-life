// Урок 8. Розв'язки.

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Завдання 1 — Point
var p1 = new Point(3, 5);
Console.WriteLine($"Точка ({p1.X}, {p1.Y})");

// Завдання 2 — Конструктор Point (уже у класі Point)
var p2 = new Point(10, 20);
Console.WriteLine($"Точка ({p2.X}, {p2.Y})");
Console.WriteLine();

// Завдання 3 — Student
var s1 = new Student("Олена", 16, "10-А", 10.5);
s1.Introduce();
Console.WriteLine();

// Завдання 4 — Список студентів
var classmates = new List<Student>
{
    new("Олена",  16, "10-А", 10.5),
    new("Іван",   17, "10-А", 9.2),
    new("Марта",  16, "10-А", 11.0),
    new("Олег",   17, "10-А", 8.7),
    new("Софія",  16, "10-А", 12.0)
};
Console.WriteLine("=== Учні класу ===");
foreach (var s in classmates) s.Introduce();
Console.WriteLine();

// Завдання 5 — Book
var book = new Book("Кобзар", "Шевченко", 1840);
book.Print();
book.TakeOut();
book.Print();
book.Return();
book.Print();
Console.WriteLine();

// Завдання 6 — Library
var lib = new Library();
lib.AddBook(new Book("Кобзар", "Шевченко", 1840));
lib.AddBook(new Book("Тигролови", "Багряний", 1944));
lib.AddBook(new Book("Місто", "Підмогильний", 1928));
lib.AddBook(new Book("Сонячна машина", "Винниченко", 1928));

Console.WriteLine("=== Усі книги ===");
lib.ShowAll();

Console.WriteLine();
Console.WriteLine("=== Книги Шевченка ===");
foreach (var b in lib.FindByAuthor("Шевченко"))
    b.Print();
Console.WriteLine();

// Завдання 7 — BankAccount
var account = new BankAccount();
account.Deposit(1000);
account.Deposit(500);
Console.WriteLine($"Баланс: {account.GetBalance()} грн");

bool ok = account.Withdraw(700);
Console.WriteLine($"Зняли 700: {ok}. Баланс: {account.GetBalance()}");

ok = account.Withdraw(2000);
Console.WriteLine($"Зняли 2000: {ok}. Баланс: {account.GetBalance()}");

Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();


// ---------- Класи ----------

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public Point(int x, int y) { X = x; Y = y; }
}

class Student
{
    public string Name { get; }
    public int Age { get; }
    public string ClassName { get; }
    public double AverageGrade { get; }

    public Student(string name, int age, string className, double avg)
    {
        Name = name; Age = age; ClassName = className; AverageGrade = avg;
    }

    public void Introduce() =>
        Console.WriteLine($"  {Name}, {Age} р., {ClassName}, середня {AverageGrade}");
}

class Book
{
    public string Title { get; }
    public string Author { get; }
    public int Year { get; }
    public bool IsAvailable { get; private set; } = true;

    public Book(string title, string author, int year)
    {
        Title = title; Author = author; Year = year;
    }

    public void TakeOut() => IsAvailable = false;
    public void Return() => IsAvailable = true;

    public void Print()
    {
        string status = IsAvailable ? "доступна" : "видана";
        Console.WriteLine($"  \"{Title}\" — {Author} ({Year}) [{status}]");
    }
}

class Library
{
    private List<Book> _books = new();

    public void AddBook(Book b) => _books.Add(b);

    public void ShowAll()
    {
        foreach (var b in _books) b.Print();
    }

    public List<Book> FindByAuthor(string author)
    {
        var result = new List<Book>();
        foreach (var b in _books)
            if (b.Author.Contains(author)) result.Add(b);
        return result;
    }
}

class BankAccount
{
    private double _balance;

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
