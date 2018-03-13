using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMFORCESFIX
{
    // MIS220-002
    // Jon-Alec Parker
    class Program
	{
        // Global Variables
        const double LBFTONEWTON = 4.44822;
 
        static void Main(string[] args)
		{
			// Local Variables
			string buffer = "";
			double newtons = 0.0;
			double lbf = 0.0;

			// Get input from user
			Console.Write("Enter the value of Force in lbf: ");
			buffer = Console.ReadLine();
			double.TryParse(buffer, out lbf);

			// Clear screen now
			Console.Clear();

			// Perform Calculations
			newtons = lbf * LBFTONEWTON;

			// Display Output
			Console.WriteLine("------------------------------");
			Console.WriteLine("\tSM_FORCES_FIX");
			Console.WriteLine("------------------------------");

			Console.Write("\tForce (");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("lbf");
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine("): {0:F3}", lbf);

			Console.Write("\tForce (");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("N");
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine(")  : {0:F3}", newtons);

			Console.WriteLine("------------------------------\n");



			#region "Wait for enter"
			Console.WriteLine("Press Enter to Continue");
			Console.ReadLine();
            #endregion

            /* Test Cases
			 * #1: input = 1; expected = 4.448; output = 4.448
             * #2: input = 5; expected = 22.241; output = 22.241
             * #3: input = 3; expected = 13.344; output = 13.345
			 * 
			 * Values were validated using Google's unit converter.
			 * 
			 */



        }
    }
}
