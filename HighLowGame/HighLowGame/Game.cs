using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLowGame
{
    class Game
    {
        const int minimum = 1;
        const int maximum = 400;

        private int wins;
        private int losses;
        private int ties = 0;

        public int Wins { get => wins; set => wins = value; }
        public int Losses { get => losses; set => losses = value; }
        public int Ties { get => ties; set => ties = value; }

        public Game(string userName)
        {
            string buffer = "";
            int numGames;
            int roundNum = 0;
            Console.Write("How many games would you like to play? ");
            buffer = Console.ReadLine();
            int.TryParse(buffer, out numGames);

            do
            {
                Console.WriteLine("┌───────────────────────────────────────────────┐");
                Console.WriteLine("│                  Round: {0}\t\t\t│", roundNum);
                Console.WriteLine("└───────────────────────────────────────────────┘");

                int playerNum = DealPlayer();

                Console.WriteLine("\t{0} was dealt {1}.", userName, playerNum);
                Console.Write("\tWill the dealer roll [H]igher or [L]ower? ");
                buffer = Console.ReadLine().ToLower();
                buffer = IsValid(buffer);

                int dealerNum = DealDealer();
                switch (buffer)
                {
                    case "h":
                        DetermineWinner(playerNum, dealerNum, "higher", userName);
                        break;
                    case "higher":
                        DetermineWinner(playerNum, dealerNum, "higher", userName);
                        break;
                    case "l":
                        DetermineWinner(playerNum, dealerNum, "lower", userName);
                        break;
                    case "lower":
                        DetermineWinner(playerNum, dealerNum, "lower", userName);
                        break;
                    case "q":
                        Console.WriteLine("Sorry to see you leave. I hope you enjoyed playing High/Low!");
                        Program.EndGame(userName);
                        break;
                    case "quit":
                        Console.WriteLine("Sorry to see you leave. I hope you enjoyed playing High/Low!");
                        Program.EndGame(userName);
                        break;
                    default:
                        break;
                }
                DisplayScore(userName, numGames);


                roundNum++;
                numGames--;
            } while (numGames > 0);

        }

        private static int DealPlayer()
        {
            Random rnd = new Random();
            int playerNum = rnd.Next(minimum, maximum);
            return playerNum;
        }

        private static int DealDealer()
        {
            Random rnd = new Random();
            int dealerNum = rnd.Next(minimum, maximum);
            return dealerNum;
        }

        private void DetermineWinner(int playerNum, int dealerNum, string playerChoice, string userName)
        {
            if (playerChoice == "higher")
            {
                if (dealerNum > playerNum)
                {
                    // player wins
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\nWinner! ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Dealer's {0} is higher than {1}'s {2}.", dealerNum, userName, playerNum);
                    Wins++;
                }
                else if (playerNum > dealerNum)
                {
                    // player loses
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\nNot a winner, but keep trying! ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Dealer's {0} is not higher than {1}'s {2}.", dealerNum, userName, playerNum);
                    Losses++;
                }
                else
                {
                    // player ties
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\nIt's a Tie! ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Dealer's {0} is the same as {1}'s {2}.", dealerNum, userName, playerNum);
                    Ties++;
                }
            }

            if (playerChoice == "lower")
            {
                if (dealerNum > playerNum)
                {
                    // player loses
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\nNot a winner, but keep trying! ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Dealer's {0} is higher than {1}'s {2}.", dealerNum, userName, playerNum);
                    Losses++;

                }
                else if (playerNum > dealerNum)
                {
                    // player wins
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\nWinner! ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Dealer's {0} is not higher than {1}'s {2}.", dealerNum, userName, playerNum);
                    Wins++;
                }
                else
                {
                    // player ties
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\nIt's a Tie! ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Dealer's {0} is the same as {1}'s {2}.", dealerNum, userName, playerNum);
                    Ties++;
                }
            }
        }

        private void DisplayScore(string userName, int numGames)
        {
            if (numGames == 1)
            {
                Console.Write("\n");
                Console.WriteLine("┌───────────────────────────────────────────────┐");
                Console.WriteLine("│                  Final Score                  │");
                Console.WriteLine("├───────────────────────────────────────────────┤");
                Console.WriteLine("│\tDealer: {0}\t\t\t\t│", losses);
                Console.WriteLine("│\t{0}: {1}\t\t\t\t\t│", userName, wins);
                Console.WriteLine("│\tTie: {0}\t\t\t\t\t│", ties);
                Console.WriteLine("└───────────────────────────────────────────────┘");
                Console.Write("Press any key to advance to the next round.");

                Console.ReadKey();
                Console.Clear();
            }
            Console.Write("\n");
            Console.WriteLine("┌───────────────────────────────────────────────┐");
            Console.WriteLine("│                     Score                     │");
            Console.WriteLine("├───────────────────────────────────────────────┤");
            Console.WriteLine("│\tDealer: {0}\t\t\t\t│", losses);
            Console.WriteLine("│\t{0}: {1}\t\t\t\t\t│", userName, wins);
            Console.WriteLine("│\tTie: {0}\t\t\t\t\t│", ties);
            Console.WriteLine("└───────────────────────────────────────────────┘");
            Console.Write("Press any key to advance to the next round.");

            Console.ReadKey();
            Console.Clear();

        }

        private string IsValid(string buffer)
        {
            string[] acceptedValues = new string[] {"q", "h", "l", "quit", "higher", "lower"};

            for (int i = 0; i < acceptedValues.Length; i++)
            {
                if (buffer == acceptedValues[i])
                {
                    return buffer;
                }
            }
            Console.WriteLine("Enter either higher, lower or quit");
            buffer = Console.ReadLine();
            return IsValid(buffer);
        }

    }
}
