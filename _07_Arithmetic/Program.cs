using System;

namespace _07_Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Arithmetic";
            int ten = 10;
            int four = 4;

            Console.WriteLine($"Addition: {ten} + {four} = " + (ten + four));
            Console.WriteLine($"Substraction: {ten} - {four} = " + (ten - four));
            Console.WriteLine($"Multiplication: {ten} * {four} = " + (ten * four));
            Console.WriteLine($"Division: {ten} / {four} = " + ((double)ten / four));  // cast to double for decimal remainder
            Console.WriteLine($"Modulus: 7 % 4 = " + (7 % 4));

            Console.WriteLine();  // space in output
            Console.WriteLine($"Postfix increment ({ten}++): " + (ten++));
            Console.WriteLine($"Postfix result: " + ten);
            Console.WriteLine($"Postfix increment ({four}++): " + (four++));
            Console.WriteLine($"Postfix result: " + four);

            Console.WriteLine();  // space in output
            Console.WriteLine($"Pretfix increment (++{ten}): " + (++ten));
            Console.WriteLine($"Prefix result: " + ten);
            Console.WriteLine($"Pretfix increment (++{four}): " + (++four));
            Console.WriteLine($"Prefix result: " + four);

            Console.WriteLine();  // space in output
            Console.WriteLine("Short hand value assignment");
            int a;
            int b;
            Console.WriteLine($"a = {a = 5}");
            Console.WriteLine($"b = {b = 3}");
            Console.WriteLine($"Add and assign: a += b (5 += 3), result is a = {a += b}");
            Console.WriteLine($"Subtract and assign: a -= b (8 -= 3), result is a = {a -= b}");
            Console.WriteLine($"Multiply and assign: a *= b (5 *= 3), result is a = {a *= b}");
            Console.WriteLine($"Divide and assign: a /= b (15 /= 3), result is a = {a /= b}");
            Console.WriteLine($"Modulus and assign: a %= b (5 %= 3), result is a = {a %= b}");

            Console.WriteLine();  // space in output
            Console.WriteLine("Comparing Values");
            int zero = 0;
            int number = 0;
            int max = 1;
            char letterA = 'A';
            char leter_a = 'a';
            Console.WriteLine($"Equality: 0 == 0, {zero == number}");

        }
    }
}
