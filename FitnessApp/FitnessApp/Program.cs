using System;
namespace FitnessApp
{
    class Program
    {
        static void Main()
        {
            
            var runningTotal = 0.0;
         
           
            while (true)
            {
                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
                var minutesEntry = Console.ReadLine();
                if (minutesEntry.ToLower() == "quit")
                {
                    break;
                }
             
                   
                try
                {
                    var minutes = double.Parse(minutesEntry);
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