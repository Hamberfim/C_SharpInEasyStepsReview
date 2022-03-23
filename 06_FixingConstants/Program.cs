using System;
using System.Collections.Generic;
using System.Linq;

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

            Console.WriteLine();  // space in output
            /* 
             The idea is to use the Enum.GetValues() method to get an array of the enum constants’ values. 
             To get an IEnumerable<T> of all the values in the enum, call Cast<T>() on the array.
             To get a list, call ToList() after casting.
             */
            List<Days> days = Enum.GetValues(typeof(Days)).Cast<Days>().ToList();  // need to work with these further
            Console.WriteLine(String.Join(Environment.NewLine, days));  // need to work with these further
        }
    }
}
