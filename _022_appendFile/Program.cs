using System;
using System.IO;

namespace _022_appendFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Append/Write file";

            string wendallBerry = "\tThe Peace of Wild Things";
            wendallBerry += "\r\n\tby Wendall Berry";

            // appending content
            string[] appendBerry = new string[]
            {
                "",
                "",
                "...apended content...",
                "",
                "",
                "The Peace of Wild Things by Wendall Berry",
                "",
                "When despair for the world grows in me",
                "and I wake in the night at the least sound",
                "in fear of what my life and my children’s lives may be,",
                "rests in his beauty on the water, and the great heron feeds.",
                "",
                "I come into the peace of wild things",
                "who do not tax their lives with forethought of grief.",
                "I come into the presence of still water.",
                "",
                "And I feel above me the day-blind stars waiting with their light. ",
                "For a time I rest in the grace of the world, and am free.",
                "",
                "Copyright (c) 2012 by Wendell Berry."
            };

            // set path to file
            string currentDir = AppDomain.CurrentDomain.BaseDirectory;
            string sourcePath = Path.Combine(currentDir, @"..\..\..\sourceDir\appendTextFile.txt");
            string getFilePath = Path.GetFullPath(sourcePath);

            // test if file exists only
            if (File.Exists(getFilePath)) 
            {
                Console.WriteLine($"The file exists at: {getFilePath}.");

                // Append string array (WriteAllLines) content to file

                File.WriteAllLines(getFilePath, appendBerry);  // write string array lines
                Console.WriteLine($"Appended content to file at: {getFilePath}");
                // read file and output contents
                string[] lines = File.ReadAllLines(getFilePath);
                Console.WriteLine(" === File Output === ");
                foreach (var line in lines)
                {
                    Console.WriteLine("\t" + line);
                }

                Console.WriteLine();  // Space in output
            }
            else
            {
                Console.WriteLine($"File Not Found at {getFilePath}.");

                // try/catch write string (WriteAllText) 'title and by'
                try
                {
                    File.WriteAllText(getFilePath, wendallBerry);  // writes string text
                    Console.WriteLine($"Title and author written to file at: {getFilePath}");
                    // read file and output contents
                    string[] lines = File.ReadAllLines(getFilePath);
                    Console.WriteLine(" === File Output === ");
                    foreach (var line in lines)
                    {
                        Console.WriteLine("\t" + line);
                    }

                    Console.WriteLine();  // Space in output
                }
                catch (Exception error)
                {
                    Console.WriteLine($"ERROR!  {error.Message}");
                }
            }
            Console.WriteLine();  //  Space in output

        }
    }
}
