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
                    int minutes = int.Parse(minutesEntry);
                    runningTotal +=  minutes;
                    Console.WriteLine("You've worked out " + runningTotal + " minutes");
                }
            }

        }
    }
}