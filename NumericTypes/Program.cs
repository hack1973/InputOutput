using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length of the rectangle?");
            string userLength = Console.ReadLine();
            float length = float.Parse(userLength);

            Console.WriteLine("What is the width of the rectangle?");
            string userWidth = Console.ReadLine();
            float width = float.Parse(userWidth);

            float area = length * width;

            Console.WriteLine("The area of the rectangle is " + area.ToString());
        }
    }
}
