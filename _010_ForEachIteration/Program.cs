using System;

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



        }
    }
}
