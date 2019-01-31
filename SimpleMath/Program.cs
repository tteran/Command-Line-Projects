using System;

namespace SimpleMath
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple Math program:
            // User can enter in a series of numbers twice
            // Then they are asked if they would like to be added or subtracted
            // Prints the result

            // Steps:
            // 1. Greet messages using Console.WriteLine()
            // 2. Prompt user to enter in a series of numbers separated by a space
            // 3. Get another series of numbers
            // 3. Take those values and save them as a string using Console.ReadLine()
            // 4. Prompt user to pick whether they would like to add or subtract the numbers
            // 5. Save the result as a string using Console.ReadLine()
            // 6. Create a string array to hold the series of number inputs and split
            // 7. Create int variable to hold total result
            // 8. Iterate through values using for loop
            // 9. Parse the string values into an integer
            // 10. IF statement to figure out whether to add or subtract
            // 11. Calculate result
            // 12. Print result

            // Greet user and program title name
            Console.WriteLine("Welcome to the Simple Math program!");

            // Prompt user for a series of numbers separated by a space
            Console.Write("Please enter in a series of numbers separated by a space: ");
            // Save user input answer as a string
            string numsInput = Console.ReadLine();

            Console.Write("Please enter in another series of numbers of equal length separated by a space: ");
            string numsInput2 = Console.ReadLine();

            //Prompt user whether they would like to add or subtract the numbers
            Console.Write("Would you like to use addition (ADD) or subtraction (SUB)?: ");
            //Save user input as a string
            string addOrSub = Console.ReadLine();

            // Split string up into separate values
            string[] numsArray = numsInput.Split(" ");
            string[] numsArray2 = numsInput2.Split(" ");

            // Create variable to hold result
            int total = 0;

            // Iterate through array
            for (int i = 0; i < numsArray.Length; i++)
            {
                // Parse string values into an int
                int totalResult = int.Parse(numsArray[i]);
                int totalResult1 = int.Parse(numsArray2[i]);

                // Write IF statements and calculate
                if (addOrSub == "ADD")
                {
                    total = totalResult + totalResult1;
                    Console.WriteLine($"The total is {total}.");
                }
                else if (addOrSub == "SUB")
                {
                    total = totalResult - totalResult1;
                    Console.WriteLine($"The total is {total}.");
                }

            }
        }
    }
}
