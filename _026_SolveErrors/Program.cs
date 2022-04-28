using System;

namespace _026_SolveErrors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Solve Errors";

            // complile-time error -- invalid cast
            bool flag = true;
            /* IConvertible converted = flag;
            char letter = converted.ToChar(null); */

            try
            {
                IConvertible converted = flag;
                char letter = converted.ToChar(null);
            }
            catch (Exception error)
            {

                Console.WriteLine($"{error.GetType()} {error.Message}");
            }

            Console.WriteLine();  // space in output

            // runtime error -- overflow exception
            /* Console.WriteLine("Enter a number: ");  // using 123456
            double num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            double num2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"Total is: {num1 + num2}"); */

            try
            {
                Console.WriteLine("Enter a number: ");  // using 123456
                double num1 = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Enter another number: ");
                double num2 = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine($"Total is: {num1 + num2}");

            }
            catch (Exception error)
            {
                Console.WriteLine($"{error.GetType()} {error.Message} | Maximum input is: {Int16.MaxValue}");
            }

            
        }
    }
}
