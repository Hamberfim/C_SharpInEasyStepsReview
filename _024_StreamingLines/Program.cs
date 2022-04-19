using System;
using System.IO;

namespace _24_StreamingLines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Streaming Lines -  StreamWriter - WriteStream";

            // set path to file
            string currentDir = AppDomain.CurrentDomain.BaseDirectory;
            string sourcePath = Path.Combine(currentDir, @"..\..\..\sourceDir\StreamWriterDoc.txt");
            string getFilePath = Path.GetFullPath(sourcePath);

            // text to work with... a selection from Brave New World Aldous Huxley
            string[] brave = new string[]
            {
                "\tThe door of the lighthouse was ajar.", 
                "\tThey pushed it open and walked into a shuttered twilight.",
                "\tThrough an archway on the further side of the room they could see the bottom of the staircase that led up to the higher floors.", 
                "\tJust under the crown of the arch dangled a pair of feet."
            };

            string attrib = "\r\n\tBrave New World (Aldous Huxley 1931)";

            // try/catch to write and append file stream
            try
            {
                // StreamWriter name = new StreamWriter(PATH);
                // using construct - write file
                using (StreamWriter writer = new StreamWriter(getFilePath))
                {
                    foreach (string line in brave)
                    {
                        writer.WriteLine(line);
                    }
                }

                // append
                using (StreamWriter writer = new StreamWriter(getFilePath, true))
                {
                    writer.WriteLine(attrib);
                    Console.WriteLine($"File written and appended: {getFilePath}");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }


            Console.WriteLine();  // space in outut

        }
    }
}
