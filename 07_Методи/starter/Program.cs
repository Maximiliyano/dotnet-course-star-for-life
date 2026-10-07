// Урок 7. Starter: методи.
namespace Lesson07
{
    public class MathLibrary
    {
        public void Start()
        {
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Starter();

            // Урок 7. Демо: Математична бібліотека з методами.
            //new MathLibrary().Start();

            Console.WriteLine($"Sum(3, 4)        = {Sum(3, 4)}");
            Console.WriteLine($"Sum3(1, 2, 3)    = {Sum(1, 2, 3)}");

            Console.WriteLine($"Square(5)     = {Square(5)}");
            Console.WriteLine($"Max3(7, 2, 9) = {Max3(7, 2, 9)}");
            Console.WriteLine($"IsPrime(17)   = {IsPrime(17)}");
            Console.WriteLine($"Factorial(5)  = {Factorial(5)}");

            Greet("Олена");
            Greet("Іван");
            Greet("Світ");

            int[] arr = { 5, 12, 7, 3, 18, 9 };
            MinMax(arr, out int min, out int max);
            Console.WriteLine($"min = {min}, max = {max}");

            int numberTest = 10;
            InMethod(numberTest);

            int testNum = 99;
            RefMethod(ref testNum);

            Console.WriteLine();
            Console.WriteLine("Натисніть будь-яку клавішу...");
            Console.ReadKey();


            // ---------- Методи (вже готові — використовуйте) ----------
        }

        // ref - reference address RAM
        static void RefMethod(ref int test)
        {
            test = 100;
            Console.WriteLine(test);
        }

        // in - only readonly
        static void InMethod(in int num)
        {
            //num = 12;
            Console.WriteLine(num);
        }

        // out - always will be set
        static void MinMax(int[] array, out int min, out int max)
        {
            min = array[0];
            max = array[0];

            foreach (int x in array)
            {
                if (x < min) min = x;
                if (x > max) max = x;
            }
        }

        private static void Starter()
        {
            // TODO 1: Викличте метод Greet з 3 різними іменами.
            Greet("Alex");
            Greet("Jessica");
            Greet("Max");

            // TODO 2: Виведіть Square(5), Square(7), Square(10).
            int num1 = Square(5);
            Console.WriteLine(num1);
            int num2 = Square(7);
            Console.WriteLine(num2);
            int num3 = Square(10);
            Console.WriteLine(num3);

            // TODO 3: Викличте Sum(2, 3) і перевантажений Sum(1, 2, 3).
            Sum(2, 3);
            Sum(1, 2, 3);

            // TODO 4: Знайдіть Max3(15, 7, 22).
            Max3(15, 7, 22);

            // TODO 5 (бонус): Виведіть усі прості числа від 2 до 50,
            // використовуючи метод IsPrime.
            for (int i = 2; i <= 50; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write($"{i} ");
                }
            }

            // Завдання 6(★★★) — «Метод Factorial»
            // Напишіть метод long Factorial(int n), що повертає n!.Виведіть факторіали 1..10.
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}! = {Factorial(i)}");
            }
        }

        // private - range class
        // public - default accessiable everywhere
        // static - always compli
        // internal

        // abstract
        // virtual

        static long Factorial(int n)
        {
            long r = 1;
            for (int i = 2; i <= n; i++)
            {
                r *= i;
            }
            return r;
        }

        static void Greet(string name)
        {
            Console.WriteLine($"Привіт, {name}!");
        }

        static int Square(int x) => x * x;

        public static int Sum(int a, int b) => a + b;
        static int Sum(int a, int b, int c) => a + b + c;

        static int Max3(int a, int b, int c)
        {
            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            return max;
        }

        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;

            return true;
        }
    }
}