using System;
using System.IO;

namespace _021_WriteFileToSys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Writting a text file to the system.";

            // text to use to write to file  - \r\n carrage return and new line
            string SaraTeasdale = "\r\nPEACE";

            SaraTeasdale += "\r\n ";

            SaraTeasdale += "\r\nPeace flows into me";
            SaraTeasdale += "\r\nAs the tide to the pool by the shore;";
            SaraTeasdale += "\r\nIt is mine forevermore,";
            SaraTeasdale += "\r\nIt ebbs not back like the sea.";

            SaraTeasdale += "\r\n ";

            SaraTeasdale += "\r\nI am the pool of blue";
            SaraTeasdale += "\r\nThat worships the vivid sky;";
            SaraTeasdale += "\r\nMy hopes were heaven-high,";
            SaraTeasdale += "\r\nThey are all fulfilled in you.";

            SaraTeasdale += "\r\n ";

            SaraTeasdale += "\r\nI am the pool of gold";
            SaraTeasdale += "\r\nWhen sunset burns and dies, —";
            SaraTeasdale += "\r\nYou are my deepening skies,";
            SaraTeasdale += "\r\nGive me your stars to hold.";

            SaraTeasdale += "\r\n ";

            SaraTeasdale += "\r\nSara Teasdale  1884 - 1933 American";

            // set local path to dir and file
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sourceFile = Path.Combine(currentDirectory, @"..\..\..\sourceDocs\fileToReadWrite.txt");
            string getFilePath = Path.GetFullPath(sourceFile);


            // check for file at path location - display path to file - Found/Not Found
            if (File.Exists(getFilePath))
            {
                Console.WriteLine($"The file exists at: {getFilePath}.");
                // read file and output contents
                string[] fileContents = File.ReadAllLines(getFilePath);
                Console.WriteLine(" === File Output === ");
                foreach (var line in fileContents)
                {
                    Console.WriteLine("\t" + line);
                }
                
            }
            else
            {
                Console.WriteLine($"File NOT FOUND at: {getFilePath}.");
            }
            Console.WriteLine();  // Space in output

            // try/catch
            try
            {
                // write to file
                File.WriteAllText(getFilePath, SaraTeasdale);
                Console.WriteLine($"File written to: {getFilePath}");

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
