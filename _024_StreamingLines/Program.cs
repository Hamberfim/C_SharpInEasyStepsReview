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

            if(File.Exists(getFilePath))
            {
                try
                {
                    // StreamWriter name = new StreamWriter(PATH);
                    // using construct
                    using (StreamWriter name = new StreamWriter(getFilePath))
                    {

                    }
                    Console.WriteLine();  // space in outut
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
            
        }
    }
}
