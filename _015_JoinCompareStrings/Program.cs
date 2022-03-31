using System;

namespace _015_JoinCompareStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Joining and Comparing Strings";

            // join a string
            string[] greekText = new string[24] { "Alpha", "Beta", "Gamma", "Delta", "Epsilon", "Zeta", "Eta", "Theta", "Iota", "Kappa", 
                "Lambda", "Mu", "Nu", "Xi", "Omikron", "Pi", "Rho", "Sigma", "Tau", "Upsilon", "Phi", "Chi", "Psi", "Omega" };

            // Concatenation vs Join
            // Concatenation
            string catStr = String.Concat(greekText[0], greekText[1], greekText[2]);
            Console.WriteLine($"Concatenation:\t{catStr}");
            // Join
            string joinStr = String.Join(", ", greekText[0], greekText[1], greekText[2]);
            Console.WriteLine($"Joined:\t{joinStr}");
            // html example
            string htmlJoinStr = String.Join("<br>", greekText);
            Console.WriteLine($"HTML:\t{htmlJoinStr}");

            Console.WriteLine();  // space in output
            // compare alphabet order - what comes after <---
            int number1 = String.Compare(greekText[0], greekText[1]);
            Console.WriteLine($"Does {greekText[0]} come after {greekText[1]}? {number1}");

            int number2 = String.Compare(greekText[1], greekText[0]);
            Console.WriteLine($"Does {greekText[1]} come after {greekText[0]}? {number2}");

            int number3 = greekText[0].CompareTo(greekText[0]);
            Console.WriteLine($"Does {greekText[0]} come after {greekText[0]}:? {number3}");

            Console.WriteLine();  // space in output
            // compare are they of equal value
            bool flag = (greekText[0] == greekText[1]);
            Console.WriteLine($"{greekText[0]} == {greekText[1]}: {flag}");
            flag = (greekText[3] == greekText[3]);
            Console.WriteLine($"{greekText[3]} == {greekText[3]}: {flag}");
            flag = (greekText[4].Equals(greekText[4]));
            Console.WriteLine($"{greekText[4]} Equals {greekText[4]}: {flag}");

        }
    }
}
