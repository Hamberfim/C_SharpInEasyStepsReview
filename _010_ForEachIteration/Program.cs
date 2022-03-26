using System;
using System.Collections.Generic;  //required for dictionary use
using System.Linq;

namespace _010_ForEachIteration
{
    class Program
    {
        class EmployeeInfo  // for declared and initialized dictionary below
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }
        }

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

            Console.WriteLine(); // space in output
            Console.WriteLine("=== Core Staff ==="); 
            var employees = new Dictionary<int, EmployeeInfo>() 
            {
                { 001, new EmployeeInfo { FirstName="Harison", LastName="Karnik", Department="Director of Information Technology" } },
                { 002, new EmployeeInfo { FirstName="William", LastName="Spinoza", Department="Asst. Dir. of Information Technology" } },
                { 003, new EmployeeInfo { FirstName="Bradley", LastName="Wonkov", Department="Director of Communications" } },
                { 004, new EmployeeInfo { FirstName="Cynthia", LastName="Brockman", Department="Asst. Dir. of Communications" } },
                { 005, new EmployeeInfo { FirstName="Ruthann", LastName="Zinkler", Department="Director of Human Resources" } },
                { 006, new EmployeeInfo { FirstName="Angelica", LastName="Hintz", Department="Asst. Dir. of Human Resources" } },
                { 007, new EmployeeInfo { FirstName="Rachell", LastName="Obermen", Department="Chief Financial Officer" } },
                { 008, new EmployeeInfo { FirstName="Debrah", LastName="Hoodisha", Department="Chief Executive Officer" } }
            };

            // Range(start, count) not sure I understand this use of Enumerable
            foreach (var idx in Enumerable.Range(001, 8))  // Range(start, count) ?? How would one use dynamic start/count variables ??
            {
                Console.WriteLine($"ID: {idx} is {employees[idx].FirstName} {employees[idx].LastName} and is the {employees[idx].Department}");
            }

            Console.WriteLine(); // space in output
            // This makes more sense than Enumerable.Range and I do not need to know the start id or the record count
            foreach (KeyValuePair<int, EmployeeInfo> employee in employees)
            {
                Console.WriteLine($"Key(ID): {employee.Key}, Value(FirstName): {employee.Value.FirstName}, Value(LastName): {employee.Value.LastName}, Value(Department): {employee.Value.Department}");
            }
         
        }
    }
}
