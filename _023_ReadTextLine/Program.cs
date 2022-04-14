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

            // check for existing file
            if(File.Exists(getFilePath))
            {
                Console.WriteLine($"Found file at: {getFilePath}.");

                // try/catch read
                try
                {
                    // read the text
                    string readText = File.ReadAllText(getFilePath);
                    Console.WriteLine($"File Read {getFilePath} \n");
                    // output text line by line
                    Console.WriteLine($"{readText}\n");

                    Console.WriteLine();  // space in output

                    // read the lines of the text doc
                    string [] lines = File.ReadAllLines(getFilePath);
                    // counter
                    int count = 1;
                    foreach (var line in lines)
                    {
                        // output each line with a line number
                        Console.WriteLine($"{count}: {line}");
                        count++;
                    }

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
