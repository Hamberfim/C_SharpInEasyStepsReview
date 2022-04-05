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
            foreach(char c in model)
            {
                Console.Write($"{c} ");
            }
            Console.WriteLine();  // space in output

            // remove the end of the string
            truck2 = truck2.Remove(8);
            Console.WriteLine($"Remove index position 8 of the string (truck2 = truck2.Remove(8);): {truck2}");
            Console.WriteLine();  // space in output

            // insert two string in the empty original string
            emptyStrVar = "";
            emptyStrVar = emptyStrVar.Insert(0, "FirstString ");  // 12 char spaces
            emptyStrVar = emptyStrVar.Insert(12, "LastString");
            Console.WriteLine($"Inserted string: {emptyStrVar}");

            // replace
            Console.WriteLine();  // space in output
            emptyStrVar = emptyStrVar.Replace("FirstString", "We are at the beginning,");
            emptyStrVar = emptyStrVar.Replace("LastString", "We are at the end.");
            Console.WriteLine($"Replaced string: {emptyStrVar}");


        }
    }
}
