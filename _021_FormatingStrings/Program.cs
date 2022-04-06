using System;

namespace _021_FormatingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "String Formatting";
            double numericAmount = 25000;
            double pi = 3.14159265359;

            // concat String "Format" method as currency example 
            Console.WriteLine("String ToString 'Format' as Currency : " + numericAmount.ToString("C"));
            Console.WriteLine("String ToString 'Format' as Fixed Point (11 decimal places): " + pi.ToString("F11"));
            Console.WriteLine();  // space in output

            // String "Format" method as currency using placeholders/position values
            Console.WriteLine("String 'Format' as Currency using placeholder: {0:C}", numericAmount);
            Console.WriteLine("String 'Format' as Fixed Point using placeholder: {0:F4}", pi);
            Console.WriteLine("String 'Format' using placeholder (multiple items): {0:F4}, {1:C}", pi, numericAmount);
            Console.WriteLine();  // space in output

            // String "Format" method as currency using string interpolation
            Console.WriteLine($"String 'Format' method as currency using string interpolation {numericAmount:C}");

            // other numeric format
            Console.WriteLine($"General format: {numericAmount:G}");
            Console.WriteLine($"Number format: {numericAmount:N}");
            Console.WriteLine($"Fixed Point format: {numericAmount:F}");


            Console.WriteLine();  // space in output



        }
    }
}
