using System;

namespace _021_FormatingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "String Formatting";
            double numericAmount = 25000;

            // concat String "Format" method as currency example 
            Console.WriteLine("String ToString 'Format' as Currency : " + numericAmount.ToString("C"));
            // String "Format" method as currency using placeholders
            Console.WriteLine("String 'Format' as Currency using placeholder: {0:C}" + numericAmount);
            // String "Format" method as currency using string interpolation
            Console.WriteLine($"String 'Format' method as currency using string interpolation {numericAmount:C}");



            Console.WriteLine();  // space in output



        }
    }
}
