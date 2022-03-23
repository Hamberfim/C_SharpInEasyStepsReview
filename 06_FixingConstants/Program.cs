﻿using System;

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

            Console.WriteLine($"First work day of the week is {Days.Monday}");
            Console.WriteLine($"Mondays index number in the enum list is {(int)Days.Monday}");

            string nameWed = Enum.GetName(daysType, 4);
            Console.WriteLine($"Mid work day is {nameWed}");

            bool flag = Enum.IsDefined(daysType, "Friday");  // is Friday defined in the enum list - True
            Console.WriteLine($"Is Friday defined in the enum list? {flag}");

            if(flag)
            {
                Console.WriteLine($"Yes, Friday is defined in the enum list.");
            } else
            {
                Console.WriteLine($"No, Friday is not defined in the enum list.");
            }
        }
    }
}
