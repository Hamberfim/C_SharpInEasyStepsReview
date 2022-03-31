using System;

namespace _014_StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "String Manipulation";
            Console.WriteLine("Please enter some text: ");
            string userText = Console.ReadLine();

            Console.WriteLine($"You have entered: \n\t{userText}");
            Console.WriteLine($"Your text character length is: \n\t{userText.Length}");

            // trim and remove word spacing
            userText = userText.Trim();
            string userTextNoSpace = userText.Replace(" ", "");
            Console.WriteLine($"With space trimmed and removed your text character lenght is: \n\t{userTextNoSpace.Length}");

            userText = userText.ToUpper();
            Console.WriteLine($"Uppercase: \n\t{userText}");
            userText = userText.ToLower();
            Console.WriteLine($"Lowercase: \n\t{userText}");


            Console.WriteLine();  // space in output



        }
    }
}
