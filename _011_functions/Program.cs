using System;
using System.Collections.Generic;

namespace _011_functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Creating Functions - Methods";

            // syntax | access-specifier return-data-type method-name (parameters) {statements}
            static void bodyTempC()
            {
                Console.WriteLine("======= Body Temperate =======");
                Console.WriteLine($"\tIn Centigrade: 37{'\u00B0'}C");  // Windows Alt Code = (char)0176 in ascii OR Unicode escape sequence '\u00B0'
            }

            static double bodyTempF()  // method returns floating value for body temp in Farenheit
            {
                double temp = 98.6;
                return temp;
            }

            static int bodyTempK()  // method returns value for body temp in kelvin
            {
                int temp = 310;
                return temp;
            }

            bodyTempC();
            Console.WriteLine($"\tIn Farenheit: {bodyTempF()}{'\u00B0'}F");
            Console.WriteLine($"\tIn Kelvin: {bodyTempK()}{'\u00B0'}K");

            // function/method declared but no initialized values | passing arguments in the parameters
            static string setUser(string name, int age = 18)  // default age is set in case not age argument is specified for the perameter
            {
                string userInfo = $"{name} {age}";
                return userInfo;
            }
            // initialized via passing arguments for the parameters
            Console.WriteLine();  // space in output
            Console.WriteLine(setUser("Tina Jorgenson", 42));
            Console.WriteLine(setUser("Orlanda Willson"));

            Console.WriteLine();  // space in output
            static double getAreaDouble(double width, double length)
            {
                double area = width * length;
                return area;
            }

            Console.WriteLine($"My moving box is {getAreaDouble(2, 3)} inches in area.");

            Console.WriteLine();  // space in output
            static string getAreaString(double width, double length)
            {
                string area = $"My moving box of {width} X {length} inches is {width * length} inches in area.";
                return area;
            }

            double width = 4;
            double length = 6;
            Console.WriteLine(getAreaString(width, length));

        }

    }
}
