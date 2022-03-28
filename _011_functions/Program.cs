using System;

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

        }
    }
}
