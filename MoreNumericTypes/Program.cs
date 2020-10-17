using System;

namespace MoreNumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that asks a user for the number of miles they have driven and the amount of gas they’ve consumed (in gallons),
            //and print their miles-per-gallon.
            Console.WriteLine("How many miles have you driven? ");
            string userMiles = Console.ReadLine();
            float miles = float.Parse(userMiles);
            Console.WriteLine("How many gallons have you consumed? ");
            string userGallons = Console.ReadLine();
            float gallons = float.Parse(userGallons);
            float mpg = miles / gallons;
            Console.WriteLine("Your MPG is " + mpg);
        }
    }
}
