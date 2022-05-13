using System;

namespace _030_hideBaseMethods
{
    internal class Program
    {
        
        public class Man
        {
            public void speak()
            {
                Console.Write("Hello");
            }
            
            public void speak(string message)
            {
                Console.WriteLine($"{message} !\n");
            }
        }
        
        // derived class
        public class Hombre : Man
        {
            public new void speak(string message)
            {
                Console.WriteLine(message);
            }
        }
        
        static void Main(string[] args)
        {
            
            
            Console.WriteLine();  // space in output
        }
    }
}
