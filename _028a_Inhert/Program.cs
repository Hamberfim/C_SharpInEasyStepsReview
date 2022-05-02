using System;

namespace _028a_Inhert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Inheritance";

            double WeeksPay(double salary)
            {
                return salary / 52;
            }

            // create an instance object of Person
            Person human = new Person();
            human.FName = "Jerry";
            human.LName = "Samson";

            // create an instance object of the derived Employee using the Person Object
            Employee jerrySamson = new Employee();

            // call the inherited setter method for Employee, initialize variable members using the Person Object
            jerrySamson.SetEmployeeValues(human.FName, human.LName, "Admin. Assist.", "Compliance", 58000.00);

            // output employee with a call to the WeeksPay method
            Console.WriteLine($"At {WeeksPay(jerrySamson.GetSalary):C2} a week, our {jerrySamson.GetTitle} {jerrySamson.GetFName} {jerrySamson.GetLName} from {jerrySamson.GetDepartment} is a bargan.");

            Console.WriteLine();  // space in output

            // create an instance object of the derived Employee
            Employee timMedows = new Employee();

            // call the inherited setter method for Employee, initialize variable members
            timMedows.SetEmployeeValues("Tim", "Medows", "Lead Engineer II", "IT Application Development", 74000.00);

            // output employee with a call to the WeeksPay method
            Console.WriteLine($"{timMedows.GetTitle}, {timMedows.FName} {timMedows.LName} from the {timMedows.GetDepartment} department is paid {WeeksPay(timMedows.GetSalary):C2} per week.");
            
            Console.WriteLine();  // space in output



        }
    }
}
