using System;

namespace _016_CopySwapStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Copy and Swap strings";

            string truck1 = "GMC";
            string truck2 = "Dodge Ram";
            string emptyStrVar = "";
            Console.WriteLine($"Original strings: truck1={truck1}, truck2={truck2}, emptyStrVar={emptyStrVar}");

            Console.WriteLine();  // space in output
            // emptyStrVar = String.Copy(truck2);  // Starting with .NET Core 3.0, this method is obsolete
            // Console.WriteLine($"Copy string (emptyStrVar = String.Copy(truck2)): truck1={truck1}, truck2={truck2}, emptyStrVar={emptyStrVar}");

            emptyStrVar = truck1;  // straight forward
            Console.WriteLine($"Copy string (emptyStrVar = truck1;): truck1={truck1}, truck2={truck2}, emptyStrVar={emptyStrVar}");

            Console.WriteLine();  // space in output
            int truck2Length = truck2.Length;
            char[] model = new char[truck2Length];  // char array length is now dynamic
            truck2.CopyTo(0, model, 0, truck2Length);  // space seperated list of the character array



        }
    }
}
