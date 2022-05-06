using System;

namespace _029_BaseConstructors
{
    public class Parent
    {
        public Parent()
        {
            Console.WriteLine("\tParent Called\n");
        }

        // overloaded constructor method
        public Parent(int num)
        {
            Console.WriteLine($"\tParent+ Called {num}\n");
        }
    }

    public class Daughter : Parent
    {
        public Daughter()
        {
            Console.WriteLine("\tDaughter Called\n");
        }

        public Daughter(int num)
        {
            Console.WriteLine($"\tDaughter+ Called {num}\n");
        }

    }

    
    public class Son : Parent
    {
        public Son()
        {
            Console.WriteLine("\tSon Called\n");
        }

        // overloaded constructor method
        public Son(int num) : base(num)
        {
            Console.WriteLine($"\tSon+ Called {num}\n");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Parent mom = new Parent();
            Parent dad = new Parent(2);

            Daughter lillie = new Daughter();
            Daughter natalie = new Daughter(2);

            Son tony = new Son();
            Son andrew = new Son(10);

            Console.WriteLine();  // space in output
        }
    }
}
