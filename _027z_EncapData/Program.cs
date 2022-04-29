using System;

namespace SomeObjects
{
    // class object
    public class Employee
    {
        // member vars
        private int _empId;
        private string _fName, _lName, _empTitle, _empDepartment;
        
        // constructor
        public Employee(int empId = -1, string fName = "!enter first name", string lName = "!enter last name", string empTitle = "!enter title", string empDepartment = "!enter depart")
        {
            this._empId = empId;
            this._fName = fName;
            this._lName = lName;
            this._empTitle = empTitle;
            this._empDepartment = empDepartment;
            
        }

        // setters
        public void SetId(int id)
        {
            this._empId = id;
        }
        
        public void SetFName(string fname)
        {
            this._fName = fname;
        }
        
        public void SetLName(string lname)
        {
            this._lName = lname;
        }
        
        public void SetTitle(string title)
        {
            this._empTitle = title;
        }
        
        public void SetEmpDepartment(string department)
        {
            this._empDepartment = department;
        }
        
        // getter methods
        public int GetEmpId()
        {
            return _empId;
        }
        
        public string GetFName()
        {
            return _fName;
        }
        
        public string GetLName()
        {
            return _lName;
        }
        
        public string GetTitle()
        {
            return _empTitle;
        }
        
        public string GetEmpDepart()
        {
            return _empDepartment;
        }

    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "class objects";

            Employee jamesMichael = new Employee();  // object created with default values
            Console.WriteLine($"Employee: {jamesMichael.GetEmpId()}, {jamesMichael.GetFName()} {jamesMichael.GetLName()}, {jamesMichael.GetTitle()} in {jamesMichael.GetEmpDepart()}");
            jamesMichael.SetId(01);
            jamesMichael.SetFName("James");
            jamesMichael.SetLName("Michael");
            jamesMichael.SetTitle("Production Manager");
            jamesMichael.SetEmpDepartment("E-Commerce");
            // object populated with real values
            Console.WriteLine($"Employee: {jamesMichael.GetEmpId()}, {jamesMichael.GetFName()} {jamesMichael.GetLName()}, {jamesMichael.GetTitle()} in {jamesMichael.GetEmpDepart()}");
            
            Console.WriteLine();  // space in output
            
            // object created with set values
            Employee lindaBeltcher = new Employee(02, "Linda", "Beltcher", "Mother-Waitress", "Bob's Burgers");
            Console.WriteLine($"Employee: {lindaBeltcher.GetEmpId()}, {lindaBeltcher.GetFName()} {lindaBeltcher.GetLName()}, {lindaBeltcher.GetTitle()} at {lindaBeltcher.GetEmpDepart()}");

        }
    }
}