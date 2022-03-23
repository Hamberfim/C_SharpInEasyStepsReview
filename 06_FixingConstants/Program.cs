using System;

namespace _06_FixingConstants
{
    class Program
    {
        enum Days { Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday};

        static void Main(string[] args)
        {
            Console.Title = "Fixing Constants";

            const double piValue = 3.14159265358979;
            Console.WriteLine($"piValue Type: {piValue.GetType()}");

            var daysType = typeof(Days);
            Console.WriteLine($"Circumference: {piValue * 3}");

            Console.WriteLine($"First Weekend day of the week is {Days.Saturday}");
            Console.WriteLine($"Saturdays index number in the enum list is {(int)Days.Saturday}");
        }
    }
}
