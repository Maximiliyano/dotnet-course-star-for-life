// Урок 8. Starter: класи та обʼєкти.

Console.OutputEncoding = System.Text.Encoding.UTF8;

// TODO 1: Створіть обʼєкт Point(3, 5). Виведіть його X і Y.
Point point = new Point(3, 5);
Console.WriteLine($"Point X = {point.X}; Y = {point.Y}");

// TODO 2: Створіть клас Student з полями: Name, Age, Class, AverageGrade (double). Конструктор з 4 параметрів. Метод Introduce(), що виводить інформацію.
Student student = new Student("Сашко", 15, "7-А", 10.7);
student.Introduce();

// TODO 3: Створіть List<Student> з 5 студентів. Виведіть усіх.
List<Student> students = new List<Student>()
{
    new("Олена",  16, "10-А", 10.5),
    new("Іван",   17, "10-А", 9.2),
    new("Марта",  16, "10-А", 11.0),
    new("Олег",   17, "10-А", 8.7),
    new("Софія",  16, "10-А", 12.0)
};
Console.WriteLine("Учні класу");
foreach (Student student1 in students)
{
    student1.Introduce();
}

// TODO 4 Створіть клас Book з властивостями Title, Author, Year, IsAvailable. Додайте методи TakeOut() (видати книгу — IsAvailable = false) і Return() (повернути — IsAvailable = true).
Book book = new Book();
book.Title = "Кобзар";
book.Author = "Шевченко";
book.Year = 1840;
book.Print();

book.TakeOut();
book.Print();

book.Return();
book.Print();

Console.WriteLine();

// TODO 5 Створіть клас Library, всередині — List<Book>. Методи: AddBook(Book b), ShowAll(), FindByAuthor(string author).

// TODO 6 (бонус): Створіть бібліотеку (Library), додайте 3 книги (Book),
// викличте ShowAll().
Library library = new Library();
library.AddBook(new Book("Кобзар", "Шевченко", 1840));
library.AddBook(new Book("Тигролови", "Багряний", 1944));
library.AddBook(new Book("Місто", "Підмогильний", 1928));
library.AddBook(new Book("Сонячна машина", "Винниченко", 1928));

Console.WriteLine("=== Усі книги ===");
library.ShowAll();

Console.WriteLine();
Console.WriteLine("=== Книги Шевченка ===");
foreach (Book book1 in library.FindByAuthor("Шевченко"))
{
    book1.Print();
}
Console.WriteLine();


Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();

public class Library
{
    private List<Book> _books = new();

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public void ShowAll()
    {
        foreach (Book book in _books)
        {
            book.Print();
        }
    }

    public List<Book> FindByAuthor(string author)
    {
        List<Book> result = new();

        foreach (Book book in _books)
        {
            if (book.Author.Contains(author))
            {
                result.Add(book);
            }
        }

        return result;
    }
}

public class Book
{
    public string Title { get; set; }

    public string Author { get; set; }

    public int Year { get; set; }

    public bool IsAvailable { get; set; } = true;

    public Book()
    {
    }

    public Book(string title, string author, int year)
    {
        Title = title; Author = author; Year = year;
    }

    public void TakeOut()
    {
        IsAvailable = false;
    }

    public void Return()
    {
        IsAvailable = true;
    }

    public void Print()
    {
        string status = IsAvailable ? "доступна" : "видана";
        Console.WriteLine($"{Title} - {Author} ({Year}) [{status}]");
    }
}

public class Point
{
    public int X { get; set; }

    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

public class Student
{
    public string Name { get; set; }

    public int Age { get; set; }

    public string Class { get; set; }

    public double AverageGrade { get; set; }

    public Student(string name, int age, string className, double averageGrade)
    {
        Name = name;
        Age = age;
        Class = className;
        AverageGrade = averageGrade;
    }

    public void Introduce()
    {
        Console.WriteLine($"  {Name}, {Age} р., {Class}, середня {AverageGrade}");
    }
}