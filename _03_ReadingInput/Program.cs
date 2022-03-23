using System;

namespace _03_ReadingInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Read and use User Input";

            Console.WriteLine("Please Enter Your First Name: ");
            string fName = Console.ReadLine();

            Console.WriteLine("\n" + "Welcome " + fName + " to C# in Visual Studo!");

            Console.WriteLine("\nLet's do some conversion. When you provide input it is captured as a string data type");

            Console.WriteLine("Please enter a number: ");

            // convert user input, whcih is a string and convert it to a double data type
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            double sum = number + Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("These two numbers have been converted from string to a double data type so they can be added together. \nTotal equals: " + sum);
        }
    }
}
