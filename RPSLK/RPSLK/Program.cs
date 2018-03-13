using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLK
{
    // MIS 220-002
    // Jon-Alec Parker
    class Program
    {
        const int boxSize = 58;
        const int minValue = 0;
        const int maxValue = 5;
        const string opponent = "WOPR 9000";
        static int playerOneWins = 0;
        static int playerTwoWins = 0;

        static void Main(string[] args)
        {
            string buffer = "";
            int players = 0;
            int numRounds = 0;

            // Game initialization
            #region Game initialization
            Console.Title = "Rock/Paper/Scissors/Lizard/Spock";
            Console.WriteLine("┌──────────────────────────────────────────────────────────┐");
            Console.Write("│       ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Welcome to Rock/Paper/Scissors/Lizard/Spock");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("        │\n");
            Console.WriteLine("└──────────────────────────────────────────────────────────┘");
            Console.Write("How many players would like to play (");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1 ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("or ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("2");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(")? ");

            buffer = Console.ReadLine();
            players = ValidPlayer(buffer);

            Console.Write("How many rounds would you like to play? ");
            buffer = Console.ReadLine();
            numRounds = ValidRounds(buffer);

            if (players == 1)
            {
                PlayOnePlayer(numRounds);
            } else
            {
                PlayTwoPlayer(numRounds);
            }

            #endregion

        }

        private static void EndGame()
        {
            Console.WriteLine("Thank you for playing Rock/Paper/Scissors/Lizard/Spock!");
            Console.WriteLine("Press any key to exit the game");
            Console.ReadKey();
            System.Environment.Exit(1);
        }

        private static void PrintRound(int round)
        {
            var size = round.ToString().Length;
            // 7 is the size of "round: "
            var left = (boxSize - 7 - size) / 2;
            var right = left;
            if (left + right != boxSize - 7 - size) { right += 1; }

            Console.WriteLine("┌──────────────────────────────────────────────────────────┐");
            Console.Write("│");
            for (int i = 0; i < left; i++)
            {
                Console.Write(" ");
            }
            Console.Write("Round: {0}", round);
            for (int i = 0; i < right; i++)
            {
                Console.Write(" ");
            }
            Console.Write("│\n");
            Console.WriteLine("└──────────────────────────────────────────────────────────┘");
        }

        private static void PlayOnePlayer(int numRounds)
        {
            string buffer = "";
            string playerName = "";
            string move;
            int curRound = 1;
            string opponentMove;

            Console.Write("Enter your name: ");
            buffer = Console.ReadLine();
            playerName = buffer;
            Console.Clear();

            do
            {
                PrintRound(curRound);
                Console.WriteLine("{0}, what is your move?", playerName);
                move = GetPlayerMove();
                opponentMove = GetOpponentMove();
                DisplayResults(move, opponentMove, curRound, playerName, opponent);
                if (numRounds - curRound > 1)
                {
                    Console.WriteLine("Press any key to continue to the next round. {0} rounds remaining.", numRounds - curRound);
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (numRounds - curRound == 1)
                {
                    Console.WriteLine("Press any key to continue to the next round. {0} round remaining.", numRounds - curRound);
                    Console.ReadKey();
                    Console.Clear();
                } else
                {
                    EndGame();
                }
                curRound++;
            } while (curRound <= numRounds) ;
        }

        private static void PlayTwoPlayer(int numRounds)
        {
            string buffer;
            string playerOneName;
            string playerTwoName;
            string playerOneMove;
            string playerTwoMove;
            int curRound = 1;

            Console.Write("Enter Player one's name: ");
            buffer = Console.ReadLine();
            playerOneName = buffer;            

            Console.Write("Enter Player two's name: ");
            buffer = Console.ReadLine();
            playerTwoName = buffer;
            Console.Clear();

            do
            {
                PrintRound(curRound);

                Console.WriteLine("{0}, what is your move?", playerOneName);
                playerOneMove = GetPlayerMove();

                Console.Clear();

                Console.WriteLine("{0}, what is your move?", playerTwoName);
                playerTwoMove = GetPlayerMove();

                DisplayResults(playerOneMove, playerTwoMove, curRound, playerOneName, playerTwoName);

                if (numRounds - curRound > 1)
                {
                    Console.WriteLine("Press any key to continue to the next round. {0} rounds remaining.", numRounds - curRound);
                }
                else if (numRounds - curRound == 1)
                {
                    Console.WriteLine("Press any key to continue to the next round. {0} round remaining.", numRounds - curRound);
                }
                else
                {
                    EndGame();
                    break;
                }
                Console.ReadKey();
                Console.Clear();

                curRound++;
            } while (curRound <= numRounds);
        }

        private static string GetPlayerMove()
        {
            string move = "";
            string buffer = "";

            Console.Write("\t[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("R");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("]ock,\n");

            Console.Write("\t[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("P");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("]aper,\n");

            Console.Write("\t[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("S");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("]cissors,\n");

            Console.Write("\t[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("L");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("]izard, or\n");

            Console.Write("\tSpoc[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("k");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("]? ");

            buffer = Console.ReadLine().ToLower();
            move = ValidMove(buffer);

            return move;
        }

        private static string GetOpponentMove()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            int numMove;
            int count = 0;
            string opponentMove = "";

            numMove = r.Next(minValue, maxValue);
            
            switch (numMove)
            {
                case 0:
                    return "rock";
                    break;
                case 1:
                    return "paper";
                    break;
                case 2:
                    return "scissors";
                    break;
                case 3:
                    return "lizard";
                    break;
                case 4:
                    return "spock";
                    break;
                default:
                    return "o";
            }
        }

        private static string ValidMove(string move)
        {
            string[] valid = { "rock", "paper", "scissors", "lizard", "spock" };

            if (move == "q" || move == "quit")
            {
                EndGame();
            }
       
            for (int i = 0; i < valid.Length; i++)
            {
                if (move == valid[i])
                {
                    return move;
                }
            }
            Console.Write("Please enter a valid move: ");
            string buffer = Console.ReadLine();
            return ValidMove(buffer);
        }
     
        private static void DisplayResults(string move, string opponentMove, int curRound, string playerOneName, string playerTwoName)
        {

            Console.Clear();
            PrintRound(curRound);
            Console.WriteLine("\tPlayer 1 ({0}) selected {1}", playerOneName, move);
            Console.WriteLine("\tPlayer 2 ({0}) selected {1}", playerTwoName, opponentMove);

            switch (move)
            {
                case "rock":
                    switch(opponentMove)
                    {
                        case "rock":
                            Console.WriteLine("\tIt's a tie");
                            break;
                        case "paper":
                            Console.WriteLine("\tPaper covers Rock");
                            Console.WriteLine("\t{0} won!", playerTwoName);
                            playerTwoWins++;
                            break;
                        case "scissors":
                            Console.WriteLine("\tRock crushes Scissors");
                            Console.WriteLine("\t{0} won!", playerOneName);
                            playerOneWins++;
                            break;
                        case "lizard":
                            Console.WriteLine("\tRock crushes Lizard");
                            Console.WriteLine("\t{0} won!", playerOneName);
                            playerOneWins++;
                            break;
                        case "spock":
                            Console.WriteLine("\tSpock vaporizes Rock");
                            Console.WriteLine("\t{0} won!", playerTwoName);
                            playerTwoWins++;
                            break;
                    }
                    break;
                case "paper":
                    switch (opponentMove)
                    {
                        case "rock":
                            Console.WriteLine("\tPaper covers Rock");
                            Console.WriteLine("\t{0} won!", playerOneName);
                            playerOneWins++;
                            break;
                        case "paper":
                            Console.WriteLine("\tIt's a tie");
                            break;
                        case "scissors":
                            Console.WriteLine("\tScissors cuts Paper");
                            Console.WriteLine("\t{0} won!", playerTwoName);
                            playerTwoWins++;
                            break;
                        case "lizard":
                            Console.WriteLine("\tLizard eats Paper");
                            Console.WriteLine("\t{0} won!", playerTwoName);
                            playerTwoWins++;
                            break;
                        case "spock":
                            Console.WriteLine("\tPaper disproves Spock");
                            Console.WriteLine("\t{0} won!", playerOneName);
                            playerOneWins++;
                            break;
                    }
                    break;
                case "scissors":
                    switch (opponentMove)
                    {
                        case "rock":
                            Console.WriteLine("\tRock crushes Scissors");
                            Console.WriteLine("\t{0} won!", playerTwoName);
                            playerTwoWins++;
                            break;
                        case "paper":
                            Console.WriteLine("\tScissors cuts Paper");
                            Console.WriteLine("\t{0} won!", playerOneName);
                            playerOneWins++;
                            break;
                        case "scissors":
                            Console.WriteLine("\tIt's a tie");
                            break;
                        case "lizard":
                            Console.WriteLine("\tScissors decapitates Lizard");
                            Console.WriteLine("\t{0} won!", playerOneName);
                            playerOneWins++;
                            break;
                        case "spock":
                            Console.WriteLine("\tSpock smashes Scissors");
                            Console.WriteLine("\t{0} won!", playerTwoName);
                            playerTwoWins++;
                            break;
                    }
                    break;
                case "lizard":
                    switch (opponentMove)
                    {
                        case "rock":
                            Console.WriteLine("\tRock crushes Lizard");
                            Console.WriteLine("\t{0} won!", playerTwoName);
                            playerTwoWins++;
                            break;
                        case "paper":
                            Console.WriteLine("\tLizard eats Paper");
                            Console.WriteLine("\t{0} won!", playerOneName);
                            playerOneWins++;
                            break;
                        case "scissors":
                            Console.WriteLine("\tScissors decapitates Lizard");
                            Console.WriteLine("\t{0} won!", playerTwoName);
                            playerTwoWins++;
                            break;
                        case "lizard":
                            Console.WriteLine("\tIts a tie");
                            break;
                        case "spock":
                            Console.WriteLine("\tLizard poisons Spock");
                            Console.WriteLine("\t{0} won!", playerOneName);
                            playerOneWins++;
                            break;
                    }
                    break;
                case "spock":
                    switch (opponentMove)
                    {
                        case "rock":
                            Console.WriteLine("\tSpock vaporizes Rock");
                            Console.WriteLine("\t{0} won!", playerOneName);
                            playerOneWins++;
                            break;
                        case "paper":
                            Console.WriteLine("\tPaper disproves Spock");
                            Console.WriteLine("\t{0} won!", playerTwoName);
                            playerTwoWins++;
                            break;
                        case "scissors":
                            Console.WriteLine("\tSpock smashes Scissors");
                            Console.WriteLine("\t{0} won!", playerOneName);
                            playerOneWins++;
                            break;
                        case "lizard":
                            Console.WriteLine("\tLizard poisons Spock");
                            Console.WriteLine("\t{0} won!", playerTwoName);
                            playerTwoWins++;
                            break;
                        case "spock":
                            Console.WriteLine("\tIt's a tie");
                            break;
                    }
                    break;
                case "other":
                    break;
            }

            DisplayScore(playerOneName, playerTwoName);

        }

        private static void DisplayScore(string playerOneName, string playerTwoName)
        {
            int playerOneSize = playerOneName.Length + 3 + playerOneWins.ToString().Length;
            int playerTwoSize = playerTwoName.Length + 3 + playerTwoWins.ToString().Length;

            int playerOneLeft = (boxSize - playerOneSize) / 2;
            int playerOneRight = playerOneLeft;
            if (playerOneLeft + playerOneRight != boxSize - playerOneSize) { playerOneRight += 1; }

            int playerTwoLeft = (boxSize - playerTwoSize) / 2;
            int playerTwoRight = playerTwoLeft;
            if (playerTwoLeft + playerTwoRight != boxSize - playerTwoSize) { playerTwoRight += 1; }

            Console.WriteLine("┌──────────────────────────────────────────────────────────┐");
            Console.Write    ("│");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("                         Score                            ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("│\n");

            // print player 1 score
            Console.Write("│");
            for (int i = 0; i < playerOneLeft; i++)
            {
                Console.Write(" ");
            }
            Console.Write("{0} : {1}", playerOneName, playerOneWins);
            for (int i = 0; i < playerOneRight; i++)
            {
                Console.Write(" ");
            }
            Console.Write("│\n");

            // print player 2 score
            Console.Write("│");
            for (int i = 0; i < playerTwoLeft; i++)
            {
                Console.Write(" ");
            }
            Console.Write("{0} : {1}", playerTwoName, playerTwoWins);
            for (int i = 0; i < playerTwoRight; i++)
            {
                Console.Write(" ");
            }
            Console.Write("│\n");
            Console.WriteLine("└──────────────────────────────────────────────────────────┘");
        }

        private static int ValidPlayer(string buffer)
        {
            if (buffer == "q" || buffer == "quit")
            {
                EndGame();
            }

            int players;
            int.TryParse(buffer, out players);
            if (players == 1 || players == 2)
            {
                return players;
            } else
            {
                Console.Write("Please enter either 1 or 2: ");
                buffer = Console.ReadLine();
                return ValidPlayer(buffer);
            }
        }

        private static int ValidRounds(string buffer)
        {
            if (buffer == "q" || buffer == "quit")
            {
                EndGame();
            }

            int numRounds;
            bool isNumeric = int.TryParse(buffer, out numRounds);

            if (!isNumeric || numRounds < 1) {
                Console.Write("Please enter a number greater than 0: ");
                buffer = Console.ReadLine();
                return ValidRounds(buffer);
            }
            else
            {
                return numRounds;
            }
        }
    }
}
