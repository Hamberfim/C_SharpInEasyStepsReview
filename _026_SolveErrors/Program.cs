using System;

namespace _026_SolveErrors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Solve Errors";

            bool flag = true;
            /* IConvertible converted = flag;
            char letter = converted.ToChar(null); */

            // complile-time error
            try
            {
                IConvertible converted = flag;
                char letter = converted.ToChar(null);
            }
            catch (Exception error)
            {

                Console.WriteLine($"{error.GetType()} {error.Message}");
            }

            // runtime error



            Console.WriteLine();  // space in output
        }
    }
}
