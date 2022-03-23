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
            var daysType = typeof(Days);


            Console.WriteLine("Hello World!");
        }
    }
}
