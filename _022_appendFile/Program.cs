using System;
using System.IO;

namespace _022_appendFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Append/Write file";

            string[] wendallBerry = new string[]
            {
                "\tThe Peace of Wild Things",
                "\tby Wendall Berry"
            };

            // set path to file
            string currentDir = AppDomain.CurrentDomain.BaseDirectory;
            string sourcePath = Path.Combine(currentDir, @"..\..\..\sourceDir\appendTextFile.txt");
            string getFilePath = Path.GetFullPath(sourcePath);


            // test if file exists
            if (File.Exists(getFilePath)) { 
            
            }
            else
            {
                Console.WriteLine($"File Not Found at {getFilePath}.");
            }

            Console.WriteLine();  //  Space in output
        }
    }
}
