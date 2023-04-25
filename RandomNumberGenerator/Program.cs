using System;

namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! This is the Random Number Generator Console App!");
            Console.WriteLine("Created by: Bruno Saenz           Date: 7/27/2022");
            Console.WriteLine("-----------------------------------------------------\n\n");

            Console.WriteLine("Please enter a lower limit: ");

            string lowerLimit = string.Empty;
            int lowLimit = 0;
            lowerLimit = Console.ReadLine();

            try
            {
                lowLimit = Convert.ToInt16(lowerLimit);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid character!!!");
                
            }

            Console.WriteLine("Please enter an upper limit: ");
            string upperLimit = string.Empty;
            int upLimit = 0;
            upperLimit = Console.ReadLine();

            try
            {
                upLimit = Convert.ToInt16(upperLimit);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid character!!!");

            }

            Console.WriteLine("\n\nLower Limit: " + lowerLimit);
            Console.WriteLine("Upper Limit: " + upperLimit);

            Random rand = new Random();
            int randomNumber = rand.Next(lowLimit, upLimit);

            Console.WriteLine(string.Format("The Random number generated within the range ({0}-{1}): {2}", lowLimit, upLimit, randomNumber));
        }
    }
}
