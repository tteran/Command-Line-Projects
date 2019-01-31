using System;

namespace AreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {

            // Program function:
            // User is prompted to input a series of numbers, separated by spaces
            // Return the result of the area of a circle
            // The radius of a circle of ___ has an area of ____

            Console.WriteLine("Welcome to the Area of a Circle Program!");

            // Prompt user to enter in the radius
            Console.Write("Please enter a series of radius' separated by spaces: ");
            // Save input as a string so it can be split
            string radius = Console.ReadLine();

            // Split the string up into separate values
            string[] radiusArray = radius.Split(" ");

            // Loop through inputs and perform calculation
            for (int i = 0; i < radiusArray.Length; i++)
            {
                // Parse values of radius array into a double
                double radiusArrayValues = double.Parse(radiusArray[i]);

                // Calculate
                double areaOfCircle = 3.14 * radiusArrayValues * radiusArrayValues;

                // Print message
                Console.WriteLine($"You entered {radiusArray[i]} units and the area of the circle is {areaOfCircle:N2} square units.");
            }
        }
    }
}