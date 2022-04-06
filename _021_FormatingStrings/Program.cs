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
            Console.WriteLine("String ToString format as Currency : " + numericAmount.ToString("C"));
            // using placeholders
            Console.WriteLine("String format as Currency using placeholder: {0:C}" + numericAmount);



            Console.WriteLine();  // space in output



        }
    }
}
