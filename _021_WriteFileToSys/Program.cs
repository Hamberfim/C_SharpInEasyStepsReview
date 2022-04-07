using System;
using System.IO;

namespace _021_WriteFileToSys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Writting a text file to the system.";

            // set local path to dir and file
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sourceFile = Path.Combine(currentDirectory, @"..\..\..\sourceDocs\fileToReadWrite.txt");
            string getFilePath = Path.GetFullPath(sourceFile);
            // check for file at path location - display path to file - Found/Not Found
            if (File.Exists(getFilePath))
            {
                Console.WriteLine($"The file exists at: {getFilePath}.");
            }
            else
            {
                Console.WriteLine($"File NOT FOUND at: {getFilePath}.");
            }



            Console.WriteLine();  // Space in output
        }
    }
}
