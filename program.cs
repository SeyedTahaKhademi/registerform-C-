using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("inter Your name");
            string name = Console.ReadLine();
            Console.WriteLine("inter Your family");
            string family = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("██████████████████████████████████████████████████████████████████████████████████");
            Console.WriteLine("██                                                                              ██");
            Console.WriteLine("██                                                                              ██");
            Console.WriteLine("██          ┌─────────────────┐                   ┌─────────────────┐           ██");
            Console.WriteLine("██   name:  │                 │           family  │                 │           ██");
            Console.WriteLine("██          └─────────────────┘                   └─────────────────┘           ██ ");
            Console.WriteLine("██                                                                              ██");
            Console.WriteLine("██                                                                              ██");
            Console.WriteLine("██             ┌─────────────────┐                      ┌─────────────────┐     ██");
            Console.WriteLine("██   birthday: │                 │          id Number:  │                 │     ██");
            Console.WriteLine("██             └─────────────────┘                      └─────────────────┘     ██");
            Console.WriteLine("██                                                                              ██");
            Console.WriteLine("██           ┌─────────────────────────────────────────────────────────┐        ██");
            Console.WriteLine("██   address:│                                                         │        ██");
            Console.WriteLine("██           └─────────────────────────────────────────────────────────┘        ██");
            Console.WriteLine("██                                                                              ██");
            Console.WriteLine("██                                                                              ██");
            Console.WriteLine("██                                                                              ██");
            Console.WriteLine("██████████████████████████████████████████████████████████████████████████████████");

            Console.SetCursorPosition(13, 9);Console.Write(name);
            Console.SetCursorPosition(52,9); Console.Write(family);
            Console.SetCursorPosition(13, 9); Console.Write(name);
            Console.ReadKey();
        }
    }
}
