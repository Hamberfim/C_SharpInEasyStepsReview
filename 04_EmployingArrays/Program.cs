using System;

namespace _04_EmployingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Employing Arrays Arrays";

            string[] cars = new string[5];  // declared

            // add and element to the array - initialized
            cars[0] = "BMW";
            cars[1] = "Fiat";
            cars[2] = "Ford";
            cars[3] = "GMC";
            cars[4] = "Nissan";

            Console.WriteLine("Cars:");
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nBoat Types:");
            string[] boatTypes = { "row", "sail", "motorized" };
            foreach (var item in boatTypes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
