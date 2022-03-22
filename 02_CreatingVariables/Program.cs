using System;

namespace _02_CreatingVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Creating Variables";

            char letterA;  // declared
            letterA = 'A';  // initialized
            Console.WriteLine("char data type: " + letterA);  // output

            int number = 100;
            Console.WriteLine("int data type: " + number);

            float bodyTemp = 98.6f;  // 7 digit precision
            Console.WriteLine("floating point data type: " + bodyTemp);  

            double pi = 3.14159;  // 15 digit precision
            Console.WriteLine("double data type: " + pi);  

            decimal sumDollarAmount = 1597.55m;  // 28 digit precision
            Console.WriteLine("decimal data type: $" + sumDollarAmount);

        }
    }
}
