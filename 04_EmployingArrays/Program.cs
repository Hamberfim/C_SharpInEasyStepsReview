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
            Console.WriteLine("My favorite car is a " + cars[1]);
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nBoat Types:");
            
            string[] boatTypes = { "row", "sail", "motorized" };
            Console.WriteLine("My favorite boat type is a " + boatTypes[2] + " boat.");

            foreach (var item in boatTypes)
            {
                Console.WriteLine(item);
            }

            // 2-dimentional array - 2 columns, 3 rows (column one first) (column two second)
            int[,] coordinates = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("X0,Y0 is a " + coordinates[0, 0]);
            Console.WriteLine("X1,Y1 is a " + coordinates[1, 1]);
            Console.WriteLine("X0,Y2 is a " + coordinates[0, 2]);

        }
    }
}
