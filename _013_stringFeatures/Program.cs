using System;

namespace _013_stringFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "String Features";

            Console.WriteLine("Enter your text: ");
            string text = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Error: No text found!");
            }
            else
            {
                Console.WriteLine($"Thanks, you entered: \n\t{text}");
                Console.WriteLine($"\tcharacter space lenght is {text.Length}");
            }
            Console.WriteLine();  // space in output
            string qry1 = "C#";
            string queryStr1 = text.StartsWith(qry1) ? "Does" : "Does Not";
            Console.WriteLine($"Your text {queryStr1} start with '{qry1}'.");

            Console.WriteLine();  // space in output
            string qry2 = ".";
            string queryStr2 = text.EndsWith(qry2) ? "Does" : "Does Not";
            Console.WriteLine($"Your text {queryStr2} end with '{qry2}'.");

            Console.WriteLine();  // space in output
            string qry3 = "is";
            string queryStr3 = text.Contains(qry3) ? "Does" : "Does Not";
            Console.WriteLine($"Your text {queryStr3} end with '{qry3}'.");
        }
    }
}
