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
            Dictionary<string, string> BabyNamesGender = new Dictionary<string, string>();
            // populate dictionary
            BabyNamesGender.Add("Liam", "male");
            BabyNamesGender.Add("Olivia", "female");
            BabyNamesGender.Add("Noah", "male");
            BabyNamesGender.Add("Emma", "female");
            BabyNamesGender.Add("Oliver", "male");
            BabyNamesGender.Add("Ava", "female");
            BabyNamesGender.Add("Elijah", "male");
            BabyNamesGender.Add("Charlotte", "female");
            BabyNamesGender.Add("William", "male");
            BabyNamesGender.Add("Sophia", "female");

            Console.WriteLine(); // space in output
            Console.WriteLine("=== Baby Names & Gender ===");
            foreach(KeyValuePair<string, string> babyName in BabyNamesGender)
            {
                Console.WriteLine($"Key(name): {babyName.Key}, Value(gender): {babyName.Value}");
            }

            Dictionary<string, string> Employees = new Dictionary<string, string>();
            Employees.Add("Harison", "IT");
            Employees.Add("William", "HR");
            Employees.Add("Linda", "COM");
            Employees.Add("Cynthia", "COM");
            Employees.Add("Bradly", "ADMIN");
         
        }
    }
}
