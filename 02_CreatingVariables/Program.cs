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

            float bodyTemp = 98.6f;
            Console.WriteLine("floating point data type: " + bodyTemp);



        }
    }
}
