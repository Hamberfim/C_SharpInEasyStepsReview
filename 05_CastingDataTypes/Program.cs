using System;

namespace _05_CastingDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Casting Data Types";

            Console.WriteLine("Implicit casting is automatic i.e., a double of 1.2 plus an int of 7. The int is cast to a double.");
            int seven = 7;
            double onePointTwo = 1.2;
            double sum = onePointTwo + seven;
            Console.WriteLine($"{onePointTwo} + {seven} = {sum} is an example of implicit casting.");

            Console.WriteLine("To store an accurate floating point number without it being tructed requires casting int to double.");
            int intNub1 = 7;
            int intNub2 = 2;
            int sum1 = intNub1 / intNub2;
            double sum2 = (double)intNub1 / intNub2;
            double sum3 = (double)(7 / 2);
            Console.WriteLine($"{intNub1}/{intNub2} = {sum2} otherwise it would tructed to {sum1}");

            Console.WriteLine("Be causious with order of opperations.");
            Console.WriteLine("Because double sum2 = (double)(intNub1 / intNub2) will result in a truction of the decimal position too");
            Console.WriteLine($"double sum3 = (double)(7 / 2) = {sum3}");

            Console.WriteLine("More examples:");
            double num1 = 10.5;
            int num2 = 2;
            double numSum = num1 + num2;
            Console.WriteLine($"Implicit: {num1} + {num2} = {numSum}");

        }
    }
}
