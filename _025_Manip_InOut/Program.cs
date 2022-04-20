using System;
using System.IO;

namespace _025_Manip_InOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Manipulating Input and Output";

            // set path to dir/file
            string workingDir = AppDomain.CurrentDomain.BaseDirectory;
            string workingPath = Path.Combine(workingDir, @"..\..\..\sourceDir\manipText.csv");
            string filePath = Path.GetFullPath(workingPath);

            // read stream
            try
            {
                // using constructor
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while((line = reader.ReadLine()) != null)
                    {
                        // modify case of header line
                        if(line.IndexOf("Id") != -1)
                        {
                            line = line.ToUpper();
                        }

                        // display the rest of the contents
                        string[] lineSub = line.Split(',');
                        line = String.Format("{0,-5}{1,-30}{2,-20}", lineSub[0], lineSub[1], lineSub[2]);
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }


            Console.WriteLine();  // space in output
        }
    }
}
