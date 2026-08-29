# Шпаргалка C# (one-pager)

## Перший шаблон

```csharp
Console.OutputEncoding = System.Text.Encoding.UTF8;  // українські літери
Console.WriteLine("Привіт!");
string name = Console.ReadLine()!;
Console.WriteLine($"Радий бачити, {name}!");
```

## Типи даних

| Тип | Що зберігає | Приклад |
|-----|------------|---------|
| `int` | ціле число | `int age = 16;` |
| `double` | дробове | `double pi = 3.14;` |
| `string` | текст | `string name = "Олена";` |
| `bool` | true/false | `bool ok = true;` |
| `char` | символ | `char letter = 'A';` |

## Введення / виведення

```csharp
Console.Write("Введіть вік: ");
int age = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Вам {age} років.");
```

## Оператори

```csharp
+ - * / %      // арифметика
== != < > <= >=// порівняння
&& || !        // логічні
+=  -=  *=  /= // присвоєння з операцією
```

## Розгалуження

```csharp
if (age >= 18) Console.WriteLine("Дорослий");
else if (age >= 14) Console.WriteLine("Підліток");
else Console.WriteLine("Дитина");

string day = "понеділок";
string mood = day switch {
    "понеділок" => "немає сил терпіти ці борошна...",
    "пʼятниця"  => "воля жадана",
    _           => "живем"
};
```

## Цикли

```csharp
for (int i = 1; i <= 10; i++) Console.WriteLine(i);

int n = 0;
while (n < 5) { Console.WriteLine(n); n++; }

do { Console.Write("?"); } while (false);
```

## Масиви і списки

```csharp
int[] nums = { 5, 2, 9, 1 };
foreach (int x in nums) Console.WriteLine(x);

List<string> names = new() { "Аня", "Іван" };
names.Add("Олег");
Console.WriteLine(names.Count);
```

## Методи

```csharp
static int Sum(int a, int b) => a + b;

static void Greet(string name) {
    Console.WriteLine($"Привіт, {name}!");
}

int total = Sum(3, 4);
Greet("Олена");
```

## Класи (ООП)

```csharp
class Student {
    public string Name { get; set; } = "";
    public int Age { get; set; }

    public Student(string name, int age) {
        Name = name; Age = age;
    }

    public void Hello() => Console.WriteLine($"Я {Name}, мені {Age}.");
}

var s = new Student("Олена", 16);
s.Hello();
```

## Спадкування

```csharp
class Animal {
    public virtual void Sound() => Console.WriteLine("...");
}

class Dog : Animal {
    public override void Sound() => Console.WriteLine("Гав!");
}
```

## Корисні гарячі клавіші Visual Studio

| Клавіша | Дія |
|---------|-----|
| F5 | Запустити з відлагодженням |
| Ctrl+F5 | Запустити без відлагодження |
| F9 | Поставити мітку для зупинки |
| F10 | Крок вперед |
| F11 | Крок всередину |
| Ctrl+K, Ctrl+D | Форматувати документ |
| Ctrl+. | Quick action / швидке виправлення |
| Ctrl+Space | IntelliSense |
| F12 | Перейти до визначення |
