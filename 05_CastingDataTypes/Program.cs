using System;

namespace _05_CastingDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implicit casting is automatic i.e., a double of 1.2 plus an int of 7. The int is cast to a double.");
            int seven = 7;
            double onePointTwo = 1.2;
            double sum = onePointTwo + seven;
            Console.WriteLine($"{onePointTwo} + {seven} = {sum} is an example of implicit casting.");

        }
    }
}
