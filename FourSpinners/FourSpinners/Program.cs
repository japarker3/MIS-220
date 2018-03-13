using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSpinners
{
    class program
    {
        const int _left = 10;
        const int _top = 10;

        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Console.SetCursorPosition(_left, _top);
                Console.Write("\\\t|\t/\t-");
                System.Threading.Thread.Sleep(40);

                Console.Clear();
                Console.SetCursorPosition(_left, _top);
                Console.Write("|\t/\t-\t\\");
                System.Threading.Thread.Sleep(40);

                Console.Clear();
                Console.SetCursorPosition(_left, _top);
                Console.Write("/\t-\t\\\t|");
                System.Threading.Thread.Sleep(40);

                Console.Clear();
                Console.SetCursorPosition(_left, _top);
                Console.Write("-\t\\\t|\t/");
                System.Threading.Thread.Sleep(40);
            }

            Console.Write("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}
