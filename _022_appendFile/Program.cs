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
            wendallBerry += "\tby Wendall Berry";

            // appending content
            string[] appendBerry = new string[]
            {   "\r\n",
                "\r\nWhen despair for the world grows in me",
                "\r\nand I wake in the night at the least sound",
                "\r\nin fear of what my life and my children’s lives may be,",
                "\r\nrests in his beauty on the water, and the great heron feeds.",
                "\r\n",
                "\r\nI come into the peace of wild things",
                "\r\nwho do not tax their lives with forethought of grief.",
                "\r\nI come into the presence of still water.",
                "\r\n",
                "\r\nAnd I feel above me the day-blind stars waiting with their light. ",
                "\r\nFor a time I rest in the grace of the world, and am free.",
                "\r\n",
                "\r\nCopyright (c) 2012 by Wendell Berry."
            };

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

            // try/catch write 'title and by'
            try
            {
                File.WriteAllText(getFilePath, wendallBerry);
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
            Console.WriteLine();  // Space in output

            // try/catch append content to file
            try
            {
                File.WriteAllText(getFilePath, appendBerry);
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
            catch (Exception error)
            {
                Console.WriteLine($"ERROR!  {error.Message}");
            }
            Console.WriteLine();  // Space in output

        }
    }
}
