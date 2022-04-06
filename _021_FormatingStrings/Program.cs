using System;

namespace _021_FormatingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "String & Date Formatting";
            double numericAmount = 25000;
            double pi = 3.14159265359;
            double perecentNum = .56;

            // concat String "Format" method as currency example 
            Console.WriteLine("String ToString 'Format' as Currency : " + numericAmount.ToString("C"));
            Console.WriteLine("String ToString 'Format' as Fixed Point (11 decimal places): " + pi.ToString("F11"));
            Console.WriteLine();  // space in output

            // String "Format" method as currency using placeholders/position values
            Console.WriteLine("String 'Format' as Currency using placeholder: {0:C}", numericAmount);
            Console.WriteLine("String 'Format' as Fixed Point using placeholder: {0:F4}", pi);
            Console.WriteLine("String 'Format' using placeholder (multiple items): {0:F4}, {1:C}", pi, numericAmount);
            Console.WriteLine(String.Format("String 'Format' using placeholder With Zero Padding Format: {0:00.0000}", numericAmount));
            Console.WriteLine();  // space in output

            // String "Format" method as currency using string interpolation
            Console.WriteLine($"String 'Format' method as currency using string interpolation {numericAmount:C}");

            // other numeric format
            Console.WriteLine($"General Format: {numericAmount:G}");
            Console.WriteLine($"Number Format: {numericAmount:N}");
            Console.WriteLine($"Fixed Point Format: {numericAmount:F}");
            Console.WriteLine($"Percent Format: {perecentNum:P0}");  // multipled by 100
            Console.WriteLine($"Percent Format: {perecentNum:P3}");  // multipled by 100
            Console.WriteLine();  // space in output

            // using split
            string nameData = "Bill, Jimmy, Carol, Sammy";
            string[] nameDataSplit = nameData.Split(", ");
            foreach (var item in nameDataSplit)
            {
                Console.WriteLine($"{item} is coming to the party.");
            }
            Console.WriteLine();  // space in output

            // using the '@' verbatim identifier
            string[] @names = {"Bill", "Jimmy", "Carol", "Sammy"};
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{@names[i]} is having a Birthday this month.");
            }

            //


            Console.WriteLine();  // space in output



        }
    }
}
