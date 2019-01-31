using System;

namespace TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tip Calculator program function:
            // Ask user for total bill amount
            // Ask user what their service was like on a 1- 10 scale
            // IF 3 or below, 10 % -- IF between 4 and 7, 15% -- IF 8 or higher, 20%
            // Return statement:
            // Print "Your bill was {totalBillAmount} and the service you received was a {serviceRating} 
            // so your tip will be {tipResult}

            // 1. Print messages Console.WriteLine() or Console.Write();
            // 2. Prompt user for input using Console.ReadLine() which will be a string
            // 3. Total Bill amount will be a decimal so I'll need to parse that
            // 4. Service rating will be an integer so I will need to parse that as well
            // 5. Create variable to hold the tip amount
            // 5. Write my if else..if statements and do tip calculations within
            // 6. Print output


            // Greet user
            Console.WriteLine("Welcome to the Tip Calculator Program!");

            // Prompt user for input on total bill amount
            Console.Write("Please enter your total bill amount: (ex; 25.50) ");
            // Read the total bill amount and save as a decimal
            decimal totalBillAmount = decimal.Parse(Console.ReadLine());

            // Prompt user to rate their service on a 1- 10 scale
            Console.Write("Rate your service on a 1-10 scale: ");
            // Read the service rating and save as integer
            int serviceRating = int.Parse(Console.ReadLine());

            // Create variable to hold tip amount
            decimal tipAmount = 0M;

            // IF statements
            if (serviceRating <= 3)
            {
                tipAmount = totalBillAmount * 0.10M;
            }
            else if (serviceRating >= 4 && serviceRating <= 7)
            {
                tipAmount = totalBillAmount * 0.15M;
            }
            else if (serviceRating >= 8 && serviceRating <= 10)
            {
                tipAmount = totalBillAmount * 0.20M;
            }

            Console.WriteLine($"Your total bill amount was {totalBillAmount:C2} and your service was a {serviceRating}. " +
                $"Your tip will be ${tipAmount:N2}.");

        }
    }
}
