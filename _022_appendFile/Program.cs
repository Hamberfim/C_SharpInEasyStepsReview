using System;
using System.IO;

namespace _022_appendFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Append/Write file";

            string[] wendallBerryStrArr = new string[]
            {
                "\tThe Peace of Wild Things",
                "\tby Wendall Berry"
            };

            // appending content
            string appendBerry = "";
            appendBerry += "\r\n";
            appendBerry += "\r\n...appended content...";
            appendBerry += "\r\n";
            appendBerry += "\r\n";
            appendBerry += "\r\n\tThe Peace of Wild Things by Wendall Berry";
            appendBerry += "\r\n";
            appendBerry += "\r\n\tWhen despair for the world grows in me";
            appendBerry += "\r\n\tand I wake in the night at the least sound";
            appendBerry += "\r\n\tin fear of what my life and my children’s lives may be,";
            appendBerry += "\r\n\trests in his beauty on the water, and the great heron feeds.";
            appendBerry += "\r\n";
            appendBerry += "\r\n\tI come into the peace of wild things";
            appendBerry += "\r\n\twho do not tax their lives with forethought of grief.";
            appendBerry += "\r\n\tI come into the presence of still water.";
            appendBerry += "\r\n";
            appendBerry += "\r\n\tAnd I feel above me the day-blind stars waiting with their light. ";
            appendBerry += "\r\n\tFor a time I rest in the grace of the world, and am free.";
            appendBerry += "\r\n";
            appendBerry += "\r\n\tCopyright (c) 2012 by Wendell Berry.";

            // set path to file
            string currentDir = AppDomain.CurrentDomain.BaseDirectory;
            string sourcePath = Path.Combine(currentDir, @"..\..\..\sourceDir\appendTextFile.txt");
            string getFilePath = Path.GetFullPath(sourcePath);

            // test if file exists only
            if (File.Exists(getFilePath)) 
            {
                Console.WriteLine($"Appending file at: {getFilePath}.");

                // Append write string (WriteAllText) 'title and by'
                File.AppendAllText(getFilePath, appendBerry);  // write string lines
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

                // try/catch string array (WriteAllLines) content to file
                try
                {
                    File.WriteAllLines(getFilePath, wendallBerryStrArr);  // writes string array text
                    Console.WriteLine($"Title and author written to new file at: {getFilePath}");
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
