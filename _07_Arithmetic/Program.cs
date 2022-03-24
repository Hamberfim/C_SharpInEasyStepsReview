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
            char letter_a = 'a';
            Console.WriteLine($"Equality: 0 == 0, {zero == number}");
            Console.WriteLine($"Equality: A == A, {letterA == letterA}");
            Console.WriteLine($"Inequality: 0 != A, {zero != letterA}");
            Console.WriteLine($"Inequality: 0 != a, {zero != letter_a}");
            Console.WriteLine($"Inequality: 0 == A, {zero == letterA}");
            Console.WriteLine($"Inequality: 0 == a, {zero == letter_a}");
            Console.WriteLine($"Less Than: 0 < 1, {zero < max}");
            Console.WriteLine($"Less Than or Equal: 1 <= 1, {max <= max}");
            Console.WriteLine($"Greater Than: 1 > 0, {max > zero}");
            Console.WriteLine($"Greater Than or Equal: 1 >= 1, {zero >= zero}");

            Console.WriteLine();  // space in output
            Console.WriteLine("AND Logical Comparisons");
            bool yes = true, no = false;
            Console.WriteLine($"yes && yes : {yes && yes}");  // expected true
            Console.WriteLine($"yes && no : {yes && no}");  // expected false
            Console.WriteLine($"no && no : {no && no}");  // expected false
            Console.WriteLine("OR Logical Comparisons");
            Console.WriteLine($"yes || yes : {yes || yes}");  // expected true
            Console.WriteLine($"yes || no : {yes || no}");  // expected true
            Console.WriteLine($"no || no : {no || no}");  // expected false
            Console.WriteLine("NOT Logical Comparisons");
            Console.WriteLine($"yes = {yes}");  // expected true
            Console.WriteLine($"no = {no}");  // expected false
            Console.WriteLine($"!yes = {!yes}");  // expected false
            Console.WriteLine($"!no = {!no}");  // expected true

            Console.WriteLine();  // space in output
            Console.WriteLine("Condition Comparisons - Tenary");
            Console.WriteLine("(test-expresion)? if-true-do-this:if-false-do-this");
            Console.WriteLine("(yes)? if-true-do-this : if-false-do-this = " + (string)(yes ? "true" : "false"));  //cast bool to string
            Console.WriteLine("(!yes)? if-true-do-this : if-false-do-this = " + (string)(!yes ? "true" : "false"));  //cast bool to string
            int evenNumb = 6;
            int oddNumb = 7;
            Console.WriteLine();  // space in output
            string parity = (evenNumb % 2 != 0)? "odd" : "even";
            Console.WriteLine($"({evenNumb} % 2 != 0)? 'odd' : 'even' = {parity}");
            Console.WriteLine("OR");
            parity = (evenNumb % 2 == 0)? "even" : "odd";
            Console.WriteLine($"({evenNumb} % 2 == 0)? 'even' : 'odd' = {parity}");

            Console.WriteLine();  // space in output
            parity = (oddNumb % 2 != 0) ? "odd" : "even";
            Console.WriteLine($"({oddNumb} % 2 != 0)? 'odd' : 'even' = {parity}");
            Console.WriteLine("OR");
            parity = (oddNumb % 2 == 0) ? "even" : "odd";
            Console.WriteLine($"({oddNumb} % 2 == 0)? 'even' : 'odd' = {parity}");

            Console.WriteLine();  // space in output
            int biggestNumb = (evenNumb > oddNumb) ? evenNumb : oddNumb;
            Console.WriteLine($"int biggestNumb = (evenNumb > oddNumb) ? evenNumb : oddNumb  >>> The biggest number is : {biggestNumb}");
        }
    }
}
