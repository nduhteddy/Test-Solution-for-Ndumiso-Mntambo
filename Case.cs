using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Solution_for_Ndumiso_Mntambo
{
    internal class Case
    {
        static void Main()
        {
            while (true) // Loop to allow multiple inputs
            {
                Console.WriteLine("\nEnter a string (or type 'exit' to quit):");
                string input = Console.ReadLine();

                // Check if user wants to exit the program
                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }

                // Ensure input is not null or a single character
                if (string.IsNullOrEmpty(input) || input.Length == 1)
                {
                    Console.WriteLine("Error: Input cannot be null or a single character. Please enter a valid string.");
                    continue;
                }

                // Display formatted output
                Console.WriteLine("Formatted Output: " + FormatAlternatingCase(input));
            }
        }

        static string FormatAlternatingCase(string input)
        {
            char[] result = input.ToCharArray(); // Convert string to character array
            bool toUpper = true; // Starts the string with an uppercase

            for (int i = 0; i < result.Length; i++)
            {
                if (char.IsLetter(result[i])) // Checks if character is a letter
                {
                    result[i] = toUpper ? char.ToUpper(result[i]) : char.ToLower(result[i]); // Apply alternating case
                    toUpper = !toUpper; // Toggle case for the next letter
                }
            }

            return new string(result); // Turn character array back to string
        }
    }
}
