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

            // text to work with... a chapter from Brave_New_World_Aldous_Huxley
            string[] chapter = new string[]
            {
                "The door of the lighthouse was ajar.", 
                "They pushed it open and walked into a shuttered twilight.",
                "Through an archway on the further side of the room they could see the bottom of the staircase that led up to the higher floors.", 
                "Just under the crown of the arch dangled a pair of feet."
            };


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
