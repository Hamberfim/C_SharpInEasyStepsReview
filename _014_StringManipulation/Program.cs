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
            string userTextPleft = userText.PadLeft(50);
            Console.WriteLine($"Padded Left:\t '{userTextPleft}'");
            string userTextPright = userText.PadRight(50, '#');
            Console.WriteLine($"Padded Right:\t '{userTextPright}'");
            string userTextPboth = userText.PadLeft(30, '*').PadRight(40, '*');  // ??? doesn't seem to have an affect ???
            Console.WriteLine($"Padded Both:\t '{userTextPboth}'");

            Console.WriteLine($"Trimmed Start:\t '{userTextPleft.TrimStart()}'");
            Console.WriteLine($"Trimmed End:\t '{userTextPboth.TrimEnd()}'");

        }
    }
}
