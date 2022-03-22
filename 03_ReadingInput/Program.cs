using System;

namespace _03_ReadingInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Read User Input";

            Console.WriteLine("Please Enter Your First Name: ");
            string fName = Console.ReadLine();

            Console.WriteLine("\n" + "Welcome " + fName + " to C# in Visual Studo!");
        }
    }
}
