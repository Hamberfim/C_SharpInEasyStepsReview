using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028a_Inhert
{
    class Employee : Person
    {
        private string title, department;
        private double salary;

        // setter method
        public void SetEmployeeValues(string fName, string lName, string title, string department, double salary)
        {
            FName = fName;
            LName = lName;
            this.title = title;
            this.department = department;
            this.salary = salary;
        }

        // getters 

        public string GetFName
        {
            get => FName;
        }
        public string GetLName
        {
            get => LName;
        }
        public string GetTitle 
        { 
            get => title;
        }
        public string GetDepartment 
        { 
            get => department;
        }
        public double GetSalary 
        { 
            get => salary;
        }

    }
}
