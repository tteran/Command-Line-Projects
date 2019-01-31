using System;
using System.Collections.Generic;
using System.Linq;

namespace MadLib
{
    class Program
    {
        static void Main(string[] args)
        {

            // Greet user to the Mad Lib
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName}! Welcome to the Mad Lib application where you " +
                $"can enter different inputs to create a (hopefully) hilarious story!");

            // User inputs
            string adjective = ReadPromptValue("Enter an adjective: ");

            string number = ReadPromptValue("Enter a number: ");

            string noun = ReadPromptValue("Enter a noun: ");

            string famousPerson = ReadPromptValue("Enter a famous person's name: ");

            string pastTenseVerb = ReadPromptValue("Enter a past tense verb: ");

            string room = ReadPromptValue("Enter a room in the building: ");

            string anotherRoom = ReadPromptValue("Enter another room in the building: ");

            string hormone = ReadPromptValue("Enter an hormone: ");

            string bodyPart = ReadPromptValue("Enter a body part: ");

            string animalPart = ReadPromptValue("Enter a plural animal part: ");

            string respectableJob = ReadPromptValue("Enter a respectable job: ");

            string temperature = ReadPromptValue("Enter a desriptive word for temperature: ");

            string emotion = ReadPromptValue("Enter an emotion: ");

            string god = ReadPromptValue("Enter any god: ");

            string verbIng = ReadPromptValue("Enter a verb ending in ing: ");

            string food = ReadPromptValue("Enter a type of food: ");

            string adjective1 = ReadPromptValue("Enter an adjective: ");

            string numberGreaterThan1 = ReadPromptValue("Enter a number greater than 1: ");

            string newNoun = ReadPromptValue("Enter plural things: ");

            string place = ReadPromptValue("Enter a fictional place: ");

            string exoticGetaway = ReadPromptValue("Enter an exotic getaway: ");

      
            // Print story
            Console.WriteLine("Enjoy :)");

            Console.WriteLine($"It was a {adjective} morning at the Tech Elevator.");

            Console.WriteLine($"{number} inches of {noun}'s fell the night before.");

            Console.WriteLine($"No one was able to get in besides {famousPerson}.");

            Console.WriteLine($"They {pastTenseVerb} from the {room} to the {anotherRoom}.");

            Console.WriteLine($"All of a sudden a huge rush of {hormone} poured out of their {bodyPart}.");

            Console.WriteLine($"Not knowing what to do they screamed, \"{animalPart}'s!\"");

            Console.WriteLine($"Consequently a {respectableJob} busted down the door and yelled, \"{temperature}!\"");

            Console.WriteLine($"{famousPerson} felt {emotion} to see the {respectableJob}");

            Console.WriteLine($"\"Oh thank {god} you are here.\" said {famousPerson}.");

            Console.WriteLine($"I was just {verbIng} when I heard {food} cooking.");

            Console.WriteLine("And so I wanted to come inside and see what was happening.");

            Console.WriteLine($"But the {respectableJob} had a {adjective1} look on their face");

            Console.WriteLine($"\"I don't buy that for one second. I'm taking you to {place}.\"");

            Console.WriteLine($"After a long journey of {numberGreaterThan1} days they arrived.");

            Console.WriteLine($"An odd gust of {newNoun} swept through {place} and when the");

            Console.WriteLine($"{respectableJob} turned around {famousPerson} vanished from sight!");

            Console.WriteLine($"The {respectableJob} looked towards the sky and exclaimed,");

            Console.WriteLine($"\"OH {exoticGetaway}!\"");

            Console.ReadLine();
        }

        private static string ReadPromptValue(string promptMessage)
        {
            Console.Write(promptMessage);
            return Console.ReadLine().ToUpper();
        }
    }
}