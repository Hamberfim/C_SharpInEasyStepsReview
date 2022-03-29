using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_EmployyeWebAppDB.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int _Age { get; set; }
        public string Position { get; set; }
        public decimal _Salary { get; set; }
        public bool UniversityDegree { get; set; }
        public double _GPA { get; set; }
        public char _Gender { get; set; }

        public int Age
        {
            get { return _Age; }
            set
            {
                if (value <= 18)
                {
                    _Age = 18;
                }
                else if (value >= 64)
                {
                    _Age = 64;
                }
                else
                {
                    _Age = value;
                }

            }

        }

        public decimal Salary
        {
            get { return _Salary; }
            set
            {
                if (value < 30000)
                {
                    _Salary = 30000;
                }
                else
                {
                    _Salary = value;
                }
            }
        }

        public double GPA
        {
            get { return _GPA; }
            set
            {
                if (value <= 1.0)
                {
                    _GPA = 1.0;
                }
                else if (value >= 5.0)
                {
                    _GPA = 5.0;
                }
                else
                {
                    _GPA = value;
                }
            }
        }
        public char Gender  // M = Male, F = Female, O = Other
        {
            get { return _Gender; }
            set
            {
                if (value == 'M' || value == 'm')
                {
                    _Gender = 'M';
                }
                else if (value == 'F' || value == 'f')
                {
                    _Gender = 'F';
                }
                else
                {
                    _Gender = 'O';
                }
            }
        }




    }
}
