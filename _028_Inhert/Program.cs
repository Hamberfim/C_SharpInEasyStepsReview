using System;

namespace _028_Inhert
{
    class Program
    {
        // classes for inheritance
        public class Polygon
        {
            protected int width, height;
            
            // setter method
            public void SetValues(int width, int height)
            {
                this.width = width;
                this.height = height;
            }
        }
        
        public class Rectangle : Polygon
        {
            public int area()
            {
                return (width * height);
            }
        }
        
        public class Triangle : Polygon
        {
            public int area()
            {
                return ((width * height) / 2);
            }
        }
        
        
        static void Main(string[] args)
        {
            Console.Title = "Inheritance";
            // create instance of inheritance classes
            Rectangle rect = new Rectangle();
            rect.SetValues(4, 5);

            Triangle cone = new Triangle();
            cone.SetValues(4, 5);
            Console.WriteLine($"Rectangle area: {rect.area()}");
            Console.WriteLine();  // space in output
            Console.WriteLine($"Triangle area: {cone.area()}");
        }
    }
}