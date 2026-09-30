// Урок 4. Демо: Камінь-Ножиці-Папір.

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("=== КАМІНЬ-НОЖИЦІ-ПАПІР ===");
Console.WriteLine();
Console.WriteLine("Варіанти: rock, paper, scissors");
Console.WriteLine();

Console.Write("Гравець 1: ");
string p1 = Console.ReadLine()!.Trim().ToLower();

Console.Write("Гравець 2: ");
string p2 = Console.ReadLine()!.Trim().ToLower();

Console.WriteLine();

if (p1 == p2)
{
    Console.WriteLine("Нічия!");
}
else if ((p1 == "rock"     && p2 == "scissors") ||
         (p1 == "paper"    && p2 == "rock")     ||
         (p1 == "scissors" && p2 == "paper"))
{
    Console.WriteLine("Гравець 1 переміг!");
}
else if (p1 == "rock" || p1 == "paper" || p1 == "scissors")
{
    Console.WriteLine("Гравець 2 переміг!");
}
else
{
    Console.WriteLine("Невірний ввід!");
}

Console.WriteLine();

// Демо switch-expression
Console.Write("Який зараз день тижня (1-7)? ");
int day = int.Parse(Console.ReadLine()!);
string dayName = day switch
{
    1 => "понеділок",
    2 => "вівторок",
    3 => "середа",
    4 => "четвер",
    5 => "пʼятниця",
    6 => "субота",
    7 => "неділя",
    _ => "?"
};
Console.WriteLine($"Сьогодні: {dayName}");

Console.WriteLine();
Console.WriteLine("Натисніть будь-яку клавішу...");
Console.ReadKey();
