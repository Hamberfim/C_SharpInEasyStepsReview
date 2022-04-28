using System;

namespace _027_EncapData
{
    /*
             * Grouping together the data structure and functionality in the class member is Encapsulation 
             * A class is a data structure that can contain both variables and methods.
             * Access to class members is controlled an ACCESS SPECIFIER in the class declaration. 
             * Usually, access is denied to variables but allow to the methods that can then store and retrieve data from those variable members.
             * 
             * A class that is not declared as STATIC can be used to create INSTANCES that are assigned to a variable and the used by other classes
             * 
             * A class declaration has:
             *      a class ACCESS SPECIFIER | public, private, protected, internal 
             *      a class KEYWORD and 
             *      a SPECIFIED NAME addhering to C# naming convensions beginging with an uppercase letter followed by a pair of curly braces.
             *      
             * Syntax EXAMPLE:     
             *      access-specifier class ClassName 
             *      {
             *          // member variable
             *          access-specifier data-type variable-name;
             *          
             *          // member method
             *          access-specifier return-type method-name ( parameter-list) 
             *          {
             *              statements
             *          }
             *      }
             *      
             *      EXAMPLE:
             *      
             *      // access-specifier class ClassName   -- note not STATIC
             *      public class Cat 
             *      {
             *          // creating the data structure of the Cat class
             *          // member variables -- access denied
             *          // access-specifier data-type variable-name;
             *          private string catName;
             *          private int catAge;
             *          private string catColor;
             *          
             *          // member method ... if any
             *          
             *          // Setter and Getter methods  -- access allowed
             *          public void setName(string name)
             *          {
             *              name = name;
             *          }
             *          
             *          public string getName ()
             *          {
             *              return catName;
             *          }
             *          
             *          public void setAge(string age)
             *          {
             *              age = age;
             *          }
             *          
             *          public string getAge ()
             *          {
             *              return catAge;
             *          }
             *          
             *          public void setColor (string color)
             *          {
             *              color = color;
             *          }
             *          
             *          public string getcolor ()
             *          {
             *              return catColor;
             *          }
             *          
             *          // other methods
             *          public string meow () 
             *          {
             *              return "\nMeow!, Meow!";
             *          }
             *          
             *      }
             *      
             *      // create an instance of the Cat class
             *      Cat fefe = new Cat();
             *      
             *      
             */

    class Program
    {
        public class Cat
        {
            // creating the data structure of the Cat class
            // member variables -- access denied
            // access-specifier data-type variable-name;
            private string catName;
            private int catAge;
            private string catColor;

            // member method 
            // single setter
            public void setValues(string name, int age, string color)
            {
                this.catName = name;
                this.catAge = age;
                this.catColor = color;
            }

            // getters
            public string getName()
            {
                return catName;
            }

            public int getAge()
            {
                return catAge;
            }

            public string getColor()
            {
                return catColor;
            }

            // other methods
            public string meow()
            {
                return "\nMeow! Meow!\n";
            }


        }


        static void Main(string[] args)
        {
            Console.Title = "OOP -Encapsulating Data";

            // create an instance of the Cat class
            Cat bob = new Cat();
            // call the instances setter method to initialize all its variables
            bob.setValues("Bob", 1, "White");
            // retrieve all the properties of the new instance of the object - output using String.Format
            string bobOutput = String.Format("{0} is a {1} year-old {2} cat", bob.getName(), bob.getAge(), bob.getColor());
            // ouput with a method call
            Console.WriteLine(bobOutput + bob.meow());

            Console.WriteLine();  // spaced in output

            // create an instance of the Cat class
            Cat fefe = new Cat();

            // call the instances setter method to initialize all its variables
            fefe.setValues("Fefe", 2, "orange");
            // retrieve all the properties of the new instance of the object  -- ouput with a method call
            Console.WriteLine($"{fefe.getName()} is a {fefe.getAge()} year-old {fefe.getColor()} cat." + fefe.meow());

            Console.WriteLine();  // spaced in output

            // create another instance of the Cat class
            Cat lady = new Cat();
            // call the instances setter method to initialize all its variables
            lady.setValues("Lady", 4, "Gray");
            // retrieve all the properties of the new instance of the object  -- ouput with a method call
            Console.WriteLine($"{lady.getName()} is a {lady.getAge()} year-old {lady.getColor()} cat." + lady.meow());

            Console.WriteLine();  // spaced in output

        }
    }
}
