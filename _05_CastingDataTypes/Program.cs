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
            double numSum = num1 + num2;  // implicit cast
            Console.WriteLine($"Implicit: {num1} + {num2} = {numSum}");

            double numSum2 = (double)11 / num2;  // Explicit cast
            Console.WriteLine($"Explicit: 11 / {num2} = {numSum2}");
            double numSum3 = 11 / num2;  // Truncated cast - no cast
            Console.WriteLine($"Truncated: 11 / {num2} = {numSum3}");

            Console.WriteLine("Cast a numerical ASCII values to a char.");
            char letterT = (char)84;  // T explicit casting
            char letterO = (char)79;  // O explicit casting
            char letterN = (char)78;  // N explicit casting
            char letterY = (char)89;  // Y explicit casting
            Console.WriteLine($"ASCII values of 84, 79, 78, 89 with explicit casting and combined = {letterT}{letterO}{letterN}{letterY}");

            Console.WriteLine("Cast ASCII values back to their numerical values.");
            int asciiT = (int)'T';  // 84 explicit casting
            int asciiO = (int)'O';  // 79 explicit casting
            int asciiN = (int)'N';  // 78 explicit casting
            int asciiY = (int)'Y';  // 89 explicit casting
            Console.WriteLine($"ASCII values of T, O, N, Y with explicit casting  = {asciiT}, {asciiO}, {asciiN}, {asciiY}");

        }
    }
}
