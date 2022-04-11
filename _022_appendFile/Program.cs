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

            string appendBerry = "\r\n";  // carrage return and new WriteLine
            appendBerry += "\r\nWhen despair for the world grows in me";
            appendBerry += "\r\nand I wake in the night at the least sound";
            appendBerry += "\r\nin fear of what my life and my children’s lives may be,";
            appendBerry += "\r\nrests in his beauty on the water, and the great heron feeds.";
            appendBerry += "\r\n";
            appendBerry += "\r\nI come into the peace of wild things";
            appendBerry += "\r\nwho do not tax their lives with forethought of grief.";
            appendBerry += "\r\nI come into the presence of still water.";
            appendBerry += "\r\n";
            appendBerry += "\r\nAnd I feel above me the day-blind stars waiting with their light. ";
            appendBerry += "\r\nFor a time I rest in the grace of the world, and am free.";
            appendBerry += "\r\n";
            appendBerry += "\r\nCopyright (c) 2012 by Wendell Berry";

            // set path to file
            string currentDir = AppDomain.CurrentDomain.BaseDirectory;
            string sourcePath = Path.Combine(currentDir, @"..\..\..\sourceDir\appendTextFile.txt");
            string getFilePath = Path.GetFullPath(sourcePath);

            // test if file exists
            if (File.Exists(getFilePath)) 
            {
                Console.WriteLine($"The file exists at: {getFilePath}.");
            }
            else
            {
                Console.WriteLine($"File Not Found at {getFilePath}.");
            }

            Console.WriteLine();  //  Space in output
        }
    }
}
