using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonStatConversion
{
    // MIS220-002
    // Jon-Alec Parker
    class Program
    {
        // Global Variables
        const double kilogramToOunce = 35.274;
        const double meterToInch = 39.3701;

        static void Main(string[] args)
        {
            // Local Variables
            string name;
            string type;
            string buffer;
            double hp;
            double hearts;
            double heightMeters;
            double heightInches;
            string heightClass;
            double weightKilograms;
            double weightOunces;
            string weightClass;

            // Changing title
            Console.Title = "Pokemon Stat Conversion";

            // Getting Input
            #region "Getting Input"
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("\t\tPokemon Stat Converter");
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Enter the information for your Pokemon.");

            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Type: ");
            type = Console.ReadLine();

            Console.Write("Hp: ");
            buffer = Console.ReadLine();
            double.TryParse(buffer, out hp);
            hp = IsValidHp(hp);

            Console.Write("Height (m): ");
            buffer = Console.ReadLine();
            double.TryParse(buffer, out heightMeters);
            heightMeters = IsValidHeight(heightMeters);

            Console.Write("Weight (kg): ");
            buffer = Console.ReadLine();
            double.TryParse(buffer, out weightKilograms);
            weightKilograms = IsValidWeight(weightKilograms);

            Console.WriteLine("Press any key to convert statistics.");
            Console.ReadLine();
            Console.Clear();
            #endregion

            // Converting Inputs
            hearts = hp / 4.0;
            heightInches = Math.Round(heightMeters * meterToInch, 2);
            weightOunces = Math.Round(weightKilograms * kilogramToOunce, 1);
            heightClass = HeightClassLookup(heightInches);
            weightClass = WeightClassLookup(weightOunces);


            // Display Output
            #region "Display Output"
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("\t\tPokemon Information");
            Console.WriteLine("---------------------------------------------------");

            Console.Write("Name        : ");
            Console.WriteLine("{0}", name);

            Console.Write("Type        : ");
            ChooseFontColor(type);
            Console.WriteLine("{0}", type);
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("Hearts      : ");
            Console.WriteLine("{0:F2}", hearts);

            Console.Write("Height (m)  : ");
            Console.WriteLine("{0}", heightMeters);

            Console.Write("Height (in) : ");
            Console.WriteLine("{0}", heightInches);

            Console.Write("Height Class: ");
            Console.WriteLine("{0}", heightClass);

            Console.Write("Weight (kg) : ");
            Console.WriteLine("{0}", weightKilograms);

            Console.Write("Weight (oz) : ");
            Console.WriteLine("{0}", weightOunces);

            Console.Write("Weight Class: ");
            Console.WriteLine("{0}", weightClass);


            Console.WriteLine("---------------------------------------------------");
            #endregion


            WaitForEnter();
        }

        private static string HeightClassLookup(double heightInches)
        {
            if (heightInches < 40)
            {
                return "Short";
            }
            else if (heightInches >= 100)
            {
                return "Tall";
            }
            else
            {
                return "Normal";
            }
        }

        private static string WeightClassLookup(double weightOunces)
        {
            if (weightOunces < 30)
            {
                return "Extra Small";
            }
            else if (weightOunces >= 800)
            {
                return "Extra Lrge";
            }
            else
            {
                return "Normal";
            }
        }

        private static double IsValidHp(double hp)
        {
            if (hp < 1 || hp > 4000)
            {
                string buffer;
                Console.WriteLine("Please enter a number between 1 and 4000");
                buffer = Console.ReadLine();
                double.TryParse(buffer, out hp);
                return IsValidHp(hp);
            }
            else
            {
                return hp;
            }
        }

        private static double IsValidWeight(double weight)
        {
            if (weight < 0.001 || weight > 3000)
            {
                string buffer;
                Console.WriteLine("Please enter a number between 0.01 and 3000");
                buffer = Console.ReadLine();
                double.TryParse(buffer, out weight);
                return IsValidWeight(weight);
            }
            else
            {
                return weight;
            }
        }

        private static double IsValidHeight(double height)
        {
            if (height < 0.001 || height > 800)
            {
                string buffer;
                Console.WriteLine("Please enter a number between 0.001 and 800");
                buffer = Console.ReadLine();
                double.TryParse(buffer, out height);
                return IsValidHeight(height);
            }
            else
            {
                return height;
            }
        }

        private static void ChooseFontColor(string type)
        {
            if (type == "Electric" || type == "electric")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (type == "Water" || type == "water")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                return;
            }
        }

        private static void WaitForEnter()
        {
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }

    }
}
