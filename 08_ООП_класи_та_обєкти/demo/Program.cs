// Урок 8. Демо: Клас Student + міні-бібліотека.

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Створюємо обʼєкти класу Student
var s1 = new Student("Олена Коваленко", 16, 10.5);
var s2 = new Student("Іван Петренко", 17, 9.2);
var s3 = new Student("Марта Сидорчук", 16, 11.0);

s1.Introduce();
s2.Introduce();
s3.Introduce();

Console.WriteLine();

// Міні-бібліотека
var library = new Library();
library.AddBook(new Book("Кобзар", "Тарас Шевченко", 1840));
library.AddBook(new Book("Тигролови", "Іван Багряний", 1944));
library.AddBook(new Book("Місто", "Валер'ян Підмогильний", 1928));

Console.WriteLine("=== БІБЛІОТЕКА ===");
library.ShowAll();
Console.WriteLine();

// Видача книги
var book = library.FindByTitle("Кобзар");
if (book != null)
{
    book.TakeOut();
    Console.WriteLine($"Видали \"{book.Title}\"");
}

Console.WriteLine();
library.ShowAll();

Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();


// ---------- Класи ----------

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double AverageGrade { get; set; }

    public Student(string name, int age, double averageGrade)
    {
        Name = name;
        Age = age;
        AverageGrade = averageGrade;
    }

    public void Introduce()
    {
        Console.WriteLine($"Я {Name}, {Age} р., середня — {AverageGrade}");
    }
}

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public bool IsAvailable { get; private set; } = true;

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public void TakeOut() => IsAvailable = false;
    public void Return()  => IsAvailable = true;

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

    public Book? FindByTitle(string title)
    {
        foreach (var b in _books)
            if (b.Title == title) return b;
        return null;
    }
}
