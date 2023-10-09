using System;

namespace ConsoleApp13
{
    class Program
    {
        static int[] DO = new int[] { 131, 262, 523, 1046 };
        static int[] RE = new int[] { 147, 294, 587, 1174 };
        static int[] MI = new int[] { 165, 330, 659, 1318 };
        static int[] FA = new int[] { 175, 349, 698, 1396 };
        static int[] SO = new int[] { 196, 392, 784, 1568 };
        static int[] LA = new int[] { 220, 440, 880, 1760 };
        static int[] SI = new int[] { 247, 494, 988, 1976 };

        static void Main(string[] args)
        {
            Console.WriteLine("Для переключения между октавами нажмите F1 или F2 или F3 или F4");
            Console.WriteLine("Нажмите Ecs для Выхода");
            int octava = 3;

            while (true)
            {
                ConsoleKey key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.Q:
                        Console.Beep(DO[octava], 200);
                        Console.Write("DO");
                        break;
                    case ConsoleKey.W:
                        Console.Beep(RE[octava], 200);
                        Console.Write("RE");
                        break;
                    case ConsoleKey.E:
                        Console.Beep(MI[octava], 200);
                        Console.Write("MI");
                        break;
                    case ConsoleKey.R:
                        Console.Beep(FA[octava], 200);
                        Console.Write("FA");
                        break;
                    case ConsoleKey.T:
                        Console.Beep(SO[octava], 200);
                        Console.Write("SO");
                        break;
                    case ConsoleKey.Y:
                        Console.Beep(LA[octava], 200);
                        Console.Write("LA");
                        break;
                    case ConsoleKey.U:
                        Console.Beep(SI[octava], 200);
                        Console.Write("SI");
                        break;
                    case ConsoleKey.F1:
                        octava = 0;
                        Console.Write("1");
                        break;
                    case ConsoleKey.F2:
                        octava = 1;
                        Console.Write("2");
                        break;
                    case ConsoleKey.F3:
                        octava = 2;
                        Console.Write("3");
                        break;
                    case ConsoleKey.F4:
                        octava = 3;
                        Console.Write("4");
                        break;
                    case ConsoleKey.Escape:
                        return;
                }
            }
        }
    }
}
