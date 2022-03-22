using System;

namespace _01_helloConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Press any key to continue...");  // not necessary with current IDE run config
            Console.ReadKey();  // not necessary with current IDE run config
            /* 
             To automatically close the console when debugging stops, 
             enable Tools->Options->Debugging->Automatically close the console when debugging stops.
             */
        }
    }
}
