using System;

namespace d20_dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("==============================================");
            Console.WriteLine();
            Console.WriteLine("██████████████████████████████████████████████\n█░░░░░░░░░░░░███░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█\n█░░▄▀▄▀▄▀▄▀░░░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█\n█░░▄▀░░░░▄▀▄▀░░█░░░░░░░░░░▄▀░░█░░▄▀░░░░░░▄▀░░█\n█░░▄▀░░██░░▄▀░░█████████░░▄▀░░█░░▄▀░░██░░▄▀░░█\n█░░▄▀░░██░░▄▀░░█░░░░░░░░░░▄▀░░█░░▄▀░░██░░▄▀░░█\n█░░▄▀░░██░░▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀░░██░░▄▀░░█\n█░░▄▀░░██░░▄▀░░█░░▄▀░░░░░░░░░░█░░▄▀░░██░░▄▀░░█\n█░░▄▀░░██░░▄▀░░█░░▄▀░░█████████░░▄▀░░██░░▄▀░░█\n█░░▄▀░░░░▄▀▄▀░░█░░▄▀░░░░░░░░░░█░░▄▀░░░░░░▄▀░░█\n█░░▄▀▄▀▄▀▄▀░░░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█\n█░░░░░░░░░░░░███░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█\n██████████████████████████████████████████████\nCreated by: MCC a.k.a. Hyde\nv2.0");
            Console.WriteLine("==============================================");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("===========================================================================");
            Console.WriteLine();
            Console.WriteLine("█░█░█ █▀▀ █░░ █▀▀ █▀█ █▀▄▀█ █▀▀ ░   █▀█ █▀█ █░░ █░░   ▄▀█   █▀▄ █ █▀▀ █▀▀▀\n▀▄▀▄▀ ██▄ █▄▄ █▄▄ █▄█ █░▀░█ ██▄ █   █▀▄ █▄█ █▄▄ █▄▄   █▀█   █▄▀ █ █▄▄ ██▄");
            Console.WriteLine();
            Console.WriteLine("===========================================================================");
            Console.ResetColor();

            Random rnd = new Random();
            int calc = 1;
        a:
            Console.ReadLine();
            Console.WriteLine(calc + ".roll");
            calc++;
            int roll = rnd.Next(1, 21); 
            Console.WriteLine("Rolled: "+roll);
            if (roll == 20)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("!!!CRITICAL HIT!!!");
                Console.ResetColor();
            }
            if (roll == 1)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("SORRY :(:(:(");
                Console.ResetColor();
            }
            goto a;  


        }
    }
}
