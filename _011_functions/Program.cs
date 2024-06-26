﻿using System;
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

            // refractored book example to make more sense
            Console.WriteLine();  // space in output
            double weight;
            string number;
            // Arguments passed by value - changes inside the method DO NOT affect the original external values
            // Arguments passed by reference - changes inside the method DO affect the original external values
            // Arguments passed via 'out' keyword are able to return more than one value and pass from the method rather than to the method and behave like reference types
            static string setBaseWeight(out double theBaseWeight)  
            {
                theBaseWeight = 10;
                return "Ten";
            }

            static double convertPoundsToKilograms(double pounds = 5)  // default parameter argument provide in case one isn't declared
            {
                return (pounds * 0.45359237);  // multiple pounds weight to get value in kilograms
            }

            static void convertKilogramsToPounds(ref double weight)  
            {
                weight = (weight / 0.45359237);  // divide kilogram weight to get value in pounds
            }
            number = setBaseWeight(out weight);  // get base weight for example conversions
            Console.WriteLine($"{number} pounds in kilograms is {convertPoundsToKilograms(weight)}Kg");
            convertKilogramsToPounds(ref weight);
            Console.WriteLine($"{number} kilograms in pounds is {weight}lbs");
            // end of refactored book example


            // simple area function/method
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

            Console.WriteLine();  // space in output
            int birthYear = 1966;

            static int determineAge(int currentYear, int outBirthYear)
            {
                return currentYear - outBirthYear;
            }

            Console.WriteLine($"If your birth year is {birthYear} then you are {determineAge(2022, birthYear)}");

            // overloading Methods - area revisited
            Console.WriteLine();  // space in output
            static double getArea(double width)
            {
                double radius = width / 2;
                double area = (radius * radius) * 3.141593;
                return area;
            }
            double hatbox = getArea(8);
            Console.WriteLine($"The area of my circle hat box is {hatbox.ToString("N3")} inches");  // .ToString("N2") - String.Format() pattern

            Console.WriteLine();  // space in output
            static double areaString(double width, double length)
            {
                double area = width * length;
                return area;
            }
            double movingBox = areaString(9, 12);
            Console.WriteLine($"The area of my moving box is {movingBox.ToString("N3")}");  // .ToString("N2") - String.Format() pattern

            Console.WriteLine();  // space in output
            Console.WriteLine("Plase Enter your dimensions: ");
            double measurement = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The area of a circle is {measurement.ToString("N3")} inches");
            double box = areaString(measurement, measurement);
            Console.WriteLine($"The area of a box is {box.ToString("N3")}");

        }

    }
}
