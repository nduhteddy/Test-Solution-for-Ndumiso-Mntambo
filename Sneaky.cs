using System;
using System.Collections.Generic;

namespace Test_Solution_for_Ndumiso_Mntambo
{
    internal class Sneaky
    {

        static void Main()
        {
            // Define a list to store the input outcomes
            List<long> outcomes;
            int attemptCount = 0;
            const int maxAttempts = 5;

            // Loop until valid input is received or max attempts reached
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

                // Prompt the user to enter outcomes separated by spaces
                Console.WriteLine("Enter the outcomes separated by spaces:");

                string input = Console.ReadLine();

                // Check if input is null
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Error: Input cannot be empty. Please try again.");
                    continue;
                }

                // Split the input string into parts based on spaces
                string[] parts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // Check if all parts are valid long integers
                if (parts.All(p => long.TryParse(p, out _)))
                {
                    // Convert parts to long integers and store them in the outcomes list
                    outcomes = parts.Select(long.Parse).ToList();
                    break;
                }

                // If input is invalid, display an error message and prompt again
                Console.WriteLine("Error: Please enter only integers separated by spaces.");
            }

            // Find duplicates using LINQ (values appearing at least twice)
            var duplicates = outcomes
                .GroupBy(x => x)
                .Where(g => g.Count() >= 2)
                .Select(g => g.Key);

            // Display the duplicate values in the console
            Console.WriteLine($"[{string.Join(", ", duplicates)}]");
        }



    }
}
