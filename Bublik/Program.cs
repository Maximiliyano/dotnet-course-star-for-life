using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.CursorVisible = false;
        Console.Clear();

        const int width = 64;
        const int height = 25;
        int cx = width / 2;        // center column
        int cy = height / 2;       // center row
        double radius = 11;        // bubble size in rows (increase for bigger)

        double rotation = 0;

        char[,] chars = new char[height, width];
        ConsoleColor[,] colors = new ConsoleColor[height, width];

        while (!Console.KeyAvailable)   // press any key to stop
        {
            // Clear buffer
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    chars[y, x] = ' ';
                    colors[y, x] = ConsoleColor.Gray;
                }

            // Draw the bubble outline
            for (double a = 0; a < Math.PI * 2; a += 0.02)
            {
                int x = cx + (int)Math.Round(Math.Cos(a) * radius * 2); // x2: console cells are tall
                int y = cy + (int)Math.Round(Math.Sin(a) * radius);

                if (x < 0 || x >= width || y < 0 || y >= height) continue;

                // Angular distance between this point and the rotating shine
                double diff = Math.Abs(a - rotation);
                if (diff > Math.PI) diff = Math.PI * 2 - diff;

                if (diff < 0.4) { chars[y, x] = '#'; colors[y, x] = ConsoleColor.White; }
                else if (diff < 0.9) { chars[y, x] = 'O'; colors[y, x] = ConsoleColor.Cyan; }
                else { chars[y, x] = 'o'; colors[y, x] = ConsoleColor.DarkCyan; }
            }

            // Draw the whole frame at once (no flicker)
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.ForegroundColor = colors[y, x];
                    Console.Write(chars[y, x]);
                }
                Console.WriteLine();
            }

            rotation += 0.08;
            if (rotation > Math.PI * 2) rotation -= Math.PI * 2;

            Thread.Sleep(30);
        }

        Console.ResetColor();
        Console.CursorVisible = true;
        Console.Clear();
    }
} 