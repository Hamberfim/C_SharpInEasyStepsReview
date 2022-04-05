using System;

namespace _017_FindSubStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Find SubStrings";

            string txtToSearch = "My dog Sukha is cute but stinky.";

            static void report(int position, string substr)
            {
                if(position != -1)
                {
                    Console.WriteLine($"'{substr}' is found at {position}");
                }else
                {
                    Console.WriteLine($"'{substr}' is not found.");
                }
                
            }

            Console.WriteLine($"The current text \n\t{txtToSearch} \nis {txtToSearch.Length} characters in length.");

            Console.WriteLine();  // space in output
            Console.WriteLine("Enter a substring to search for: ");
            string usrSubStr = Console.ReadLine();

            Console.WriteLine();  // space in output
            // create a char array of the user search substring
            char[] usrCharArray = new char[usrSubStr.Length];
            usrSubStr.CopyTo(0, usrCharArray, 0, usrSubStr.Length);

            // find first occurance of usrSubStr
            int position = txtToSearch.IndexOf(usrSubStr);
            report(position, usrSubStr);

            Console.WriteLine();  // space in output

            // find last occurance of usrSubStr
            position = txtToSearch.LastIndexOf(usrSubStr);
            report(position, usrSubStr);

            Console.WriteLine();  // space in output

            // find first of any occurance of in the usrSubStr Array
            position = txtToSearch.IndexOfAny(usrCharArray);
            report(position, txtToSearch.Substring(position, 1));

            Console.WriteLine();  // space in output

            // find last of any occurance of in the usrSubStr Array
            position = txtToSearch.LastIndexOfAny(usrCharArray);
            report(position, txtToSearch.Substring(position, 1));

        }
    }
}
