using System;
using System.IO;

namespace _023_ReadTextLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Reading text and lines";

            // set path to file
            string currentDir = AppDomain.CurrentDomain.BaseDirectory;
            string sourcePath = Path.Combine(currentDir, @"..\..\..\sourceDir\ReadTextLine.txt");
            string getFilePath = Path.GetFullPath(sourcePath);

            if(File.Exists(getFilePath))
            {
                Console.WriteLine($"Found file at: {getFilePath}.");

                // try read
                try
                {
                    string readText = File.ReadAllText(getFilePath);
                    Console.WriteLine($"File Read {getFilePath} \n");
                    Console.WriteLine($"{readText}\n");
                }
                catch (Exception error)
                {
                    Console.WriteLine($"Error: {error.Message}");
                }

            }
            else
            {
                Console.WriteLine($"File Not Found at {getFilePath}.");
            }

            Console.WriteLine();  // space in output

        }
    }
}
