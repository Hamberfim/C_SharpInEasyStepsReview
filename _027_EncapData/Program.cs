using System;

namespace _027_EncapData
{
            /*
             * A class is a data structure that can contains both variables and methods.
             * Grouping together the data structure and functionality in the classes members is Encapsulation 
             * Access to class members is controlled by an ACCESS SPECIFIER in the class declaration. 
             * Usually, access is denied to variables but allow to the methods that can then store and retrieve data from those variable members.
             * 
             * A class that is not declared as STATIC can be used to create INSTANCES that are assigned to a variable and then used by other classes
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

        public class Dog
        {
            private string name, color;
            private int age;

            // methods
            // a constructor (with defaults) to initialize class members instead of calling a setValues setter method
            public Dog(string name = "Roy", int age = 1, string color = "brown")
            {
                this.name = name;
                this.age = age;
                this.color = color;
            }

            // setter methods
            public void setName(string name)
            {
                this.name = name;
            }

            public void setAge(int age)
            {
                this.age = age;
            }

            public void setColor(string color)
            {
                this.color = color;
            }

            // getter methods
            public string getName()
            {
                return name;
            }

            public int getAge()
            {
                return age;
            }

            public string getColor()
            {
                return color;
            }

            // other methods
            public string bark()
            {
                return "\nBark, bark...bark!\n";
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

            // initializes Dog class using contructor with its default values
            Dog roy = new Dog();
            // retrieve all the properties of the new instance of the object with its default values  -- ouput with a method call
            Console.WriteLine($"{roy.getName()} is a {roy.getColor()}, {roy.getAge()} year-old dog." + roy.bark());

            Console.WriteLine();  // spaced in output

            // initializes Dog class and set its property values
            Dog sukha = new Dog();
            sukha.setName("Sukha");
            sukha.setAge(1);
            sukha.setColor("light red tricolor");
            // retrieve all the properties of the new instance of the object with its set values  -- ouput with a method call
            Console.WriteLine($"{sukha.getName()} is a {sukha.getColor()}, {sukha.getAge()} year-old dog." + sukha.bark());

        }
    }
}
