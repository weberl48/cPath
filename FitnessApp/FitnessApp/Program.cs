using System;
namespace FitnessApp
{
    class Program
    {
        static void Main()
        {
            bool keepGoing = true;
            int runningTotal = 0;
            while (keepGoing)
            {
                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
                string minutesEntry = Console.ReadLine();
                if (minutesEntry == "quit")
                {
                    keepGoing = false;
                }
                else
                {
                   
                    try
                    {
                        int minutes = int.Parse(minutesEntry);
                        if (minutes <= 0)
                        {
                            Console.WriteLine(minutes + " is not an acceptable value.");
                        }
                        else if (minutes <= 10)
                        {
                            Console.WriteLine("Better than nothing, am I right?");
                        }
                        else if (minutes <= 30)
                        {
                            Console.WriteLine("Way to go!");
                        }
                        else if (minutes <= 60)
                        {
                            Console.WriteLine("You must be a ninja warrior in training!");
                        }
                        else
                        {
                            Console.WriteLine("Okay, now you're just showing off!");
                        }
                        runningTotal += minutes;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("That is not valid input.");
                        continue;
                    }
                    Console.WriteLine("You've worked out " + runningTotal + " minutes");

                }
            }

        }
    }
}