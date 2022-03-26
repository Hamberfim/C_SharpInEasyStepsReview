using System;
using System.Collections.Generic;  //required for dictionary use

namespace _010_ForEachIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Foreach iteration - arrays & dictionaries";
            // declare and initialize
            // array syntax | data-type variable-name = new data-type[array length] {array items}
            string[] babyNames = new string[10] { "Liam", "Olivia", "Noah", "Emma", "Oliver", "Ava", "Elijah", "Charlotte", "William", "Sophia" };

            Console.WriteLine("=== Popular Baby Names ===");
            int listIndex = 1;
            // syntax | foreach(data-type variable name in array-name/collection) {statements}
            foreach (string babyName in babyNames)
            {
                Console.WriteLine($"    List position: {listIndex} - {babyName}");
                listIndex++;
            }

            // dictionary collection is a key: value pair
            // dictionary declaration syntax | Dictionary <data-type, data-type> dictionary-name = new Dictionary <data-type, data-type>();
            Dictionary<string, string> babyNamesGender = new Dictionary<string, string>();
            // populate dictionary
            babyNamesGender.Add("Liam", "male");
            babyNamesGender.Add("Olivia", "female");
            babyNamesGender.Add("Noah", "male");
            babyNamesGender.Add("Emma", "female");
            babyNamesGender.Add("Oliver", "male");
            babyNamesGender.Add("Ava", "female");
            babyNamesGender.Add("Elijah", "male");
            babyNamesGender.Add("Charlotte", "female");
            babyNamesGender.Add("William", "male");
            babyNamesGender.Add("Sophia", "female");

            Console.WriteLine("=== Baby Names & Gender ===");

        }
    }
}
