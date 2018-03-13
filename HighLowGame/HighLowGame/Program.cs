using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowGame
{

    // Jon-Alec Parker
    // MIS220-002

    class Program
    {

        static void Main(string[] args)
        {
            string username;
            string buffer;
            int numGames;

            Console.Title = "High/Low Game";

            // initial game setup
            Console.WriteLine("┌───────────────────────────────────────────────┐");
            Console.WriteLine("│         Welcome to the High/Low Game!         │");
            Console.WriteLine("└───────────────────────────────────────────────┘");
            Console.Write("What is your name: ");
            buffer = Console.ReadLine();
            username = buffer;

            Game game = new Game(username);






            EndGame(username);
        }

        public static void EndGame(string username)
        {
            Console.WriteLine("Thank you for playing {0}, the game of High/Low!", username);
            Console.WriteLine("Press any key to close the applicaion.");
            Console.ReadKey();
        }

    }
}
