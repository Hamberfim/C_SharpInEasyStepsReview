using System;

namespace _029_BaseConstructors
{
    public class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent Called");
        }

        // overloaded constructor method
        public Parent(int num)
        {
            Console.WriteLine($"Parent+ Called {num}");
        }
    }

    public class Daughter : Parent
    {
        public Daughter()
        {
            Console.WriteLine("\tDaughter Called\n");
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
            Console.WriteLine($"\tSon+ Called {num}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
