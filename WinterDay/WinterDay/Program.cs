using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterDay
{
    class Program
    {
        //MIS220-002
        //Jon-Alec Parker
        static void Main(string[] args)
        {
            int height = 5;
            int spaces = height - 1;
            int stars = 1;

            // Christmas Tree
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }
                for (int g = 0; g < stars; g++)
                {
                    Console.Write("*");
                }
                spaces--;
                stars += 2;
                Console.Write("\n");
            }
            for (int i = 0; i < height - 1; i++)
            {
                Console.Write(" ");
            }
            Console.Write("*");

            Console.Write("\n");
            Console.Write("\n");

            // Snowman
            Console.WriteLine("  _===_");
            Console.WriteLine("  (.,.)");
            Console.WriteLine(">-( : )-<");
            Console.WriteLine("  ( : )");
            Console.WriteLine("  -----");

            Console.Write("\n");
            Console.Write("\n");

            // Snowman 2
            Console.WriteLine(" _===_");
            Console.WriteLine(" (o.o)");
            Console.WriteLine("<( : )>");
            Console.WriteLine(" (\" \")");
            Console.WriteLine(" -----");

            Console.Write("\n");
            Console.Write("\n");

            // Snowflake
            Console.WriteLine("     /\\");
            Console.WriteLine("__   \\/   __");
            Console.WriteLine("\\_\\_\\/\\/_/_/");
            Console.WriteLine("  _\\_\\/_/_");
            Console.WriteLine(" __/_/\\_\\__");
            Console.WriteLine("/_/ /\\/\\ \\_\\");
            Console.WriteLine("     /\\");
            Console.WriteLine("     \\/");



            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.WriteLine("Do you want to build a snowman?");
            Console.WriteLine("It doesn't have to be a snowman");
            Console.WriteLine("Okay, bye...");
            System.Threading.Thread.Sleep(6400);
        }
    }
}
