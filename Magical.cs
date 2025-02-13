using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Solution_for_Ndumiso_Mntambo
{
    internal class Magical
    {
        static void Main()
        {
            long power;
            int attemptCount = 0;
            const int maxAttempts = 5;

            // Keep asking for input until valid number is provided
            while (true)
            {
                // Check if max attempts have been reached
                if (attemptCount >= maxAttempts)
                {
                    Console.WriteLine("Error: Maximum attempts reached. Exiting.");
                    return;
                }
                // Increment attempt count
                attemptCount++;

                Console.Write("Enter power level: ");
                string input = Console.ReadLine();

                // Check if input is empty
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Error: You must enter a value.");
                    continue;
                }

                // Convert string to interger
                if (long.TryParse(input, out power))
                    break;
                else
                    Console.WriteLine("Error: Please enter a valid integer.");
            }
            Console.WriteLine(IsPerfectCube(power) ? "YES" : "NO");
        }

        static bool IsPerfectCube(long n)
        {
            // Numbers less than zero can't be cubes of natural numbers
            if (n < 0) return false;

            // Calculate approximate cube root and round to nearest integer
            long cubeRoot = (long)Math.Round(Math.Pow(n, 1.0 / 3.0));

            // Verify by cubing the calculated root
            return cubeRoot * cubeRoot * cubeRoot == n;
        }
    }
}
