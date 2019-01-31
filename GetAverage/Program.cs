using System;

namespace GetAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get Average Program:
            // User can enter in a series of numbers separated by commas
            // Output is the average. Simple as that

            // Steps:
            // 1. Greet user
            // 2. Ask for a series of numbers
            // 3. Save that answer as a string
            // 4. Split string up into separate values 
            // 5. Create variable to hold the sum total
            // 6. Create variable to hold the result
            // 7. Create for loop to iterate through the string
            // 8. Parse the numbersArray values into an integer data type
            // 9. Sum the values
            // 10. Calculate the average
            // 11. Print the result

            // Greet user
            Console.WriteLine("Welcome to the Get Average Program!");

            // Ask for a series of numbers
            Console.Write("Please enter in a series of numbers separated by a space: ");
            // Save answer as a string
            string seriesOfNumbers = Console.ReadLine();

            // Split string up into separate values
            string[] numbersArray = seriesOfNumbers.Split(" ");

            // Create variable to hold sum of numbers in the array
            decimal total = 0;

            // Create result variable to hold the average
            decimal result = 0;

            // Create for loop and look through it
            for (int i = 0; i < numbersArray.Length; i++)
            {
                // Parse the numbersArray into an integer data type
                decimal numberValues = decimal.Parse(numbersArray[i]);

                // Sum the numbers
                total += numberValues;

                // Calculate the average
                result = total / numbersArray.Length;
            }

            // Print result
            Console.WriteLine($"The average is {result}");
        }
    }
}
