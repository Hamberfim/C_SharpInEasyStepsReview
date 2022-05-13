using System;

namespace _030_hideBaseMethods
{
    internal class Program
    {
        
        public class Man
        {
            public void speak()
            {
                Console.Write("First Hello - ");
            }
            
            public void speak(string message)
            {
                Console.WriteLine($"Second Hello - {message} !\n ");
            }
        }
        
        // derived class
        public class Hombre : Man
        {
            public new void speak(string message)
            {
                Console.WriteLine(message);
                base.speak();
            }
        }
        
        static void Main(string[] args)
        {
            Man larry = new Man();
            Hombre juan = new Hombre();
            
            larry.speak();
            larry.speak("Larry is speaking again.");

            juan.speak("Hello from Juan.");

            // explicit cast - explicitly call overload method
            ((Man)juan).speak("Explicit Hello");


            Console.WriteLine();  // space in output
        }
    }
}
