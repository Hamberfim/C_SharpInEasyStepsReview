using System;

namespace _012_RefactoringCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Refactoring Code";
            // syntax | return-data-type method-name (parameter-list)
            // {
            //      statements-to-be-executed;
            //      updater;
            //      conditional-test-to-recall-or-exit;
            // }

            // recursive method to return the factorial value of an integer -
            // i.e., each consecutive number is multipled by the previous product. (1*1=1; 2*1=2; 3*2=6; 4*6=24; 5*24=120; 6*120=720; 7*720=5040, etc.)
            static int factorial(int number)
            {
                int result;
                if(number == 1)
                {
                    result = 1;
                }
                else
                {
                    result = (factorial(number - 1) * number);
                }
                return result;
            }

            // display factorial range values via loop
            static void computeFactorials(int number, int maximum)
            {
                while(number <= maximum)
                {
                    // calls factorial method above
                    Console.WriteLine($"Factorial of {number} is {factorial(number)}. (Why? {number}*{factorial(number)/number}={factorial(number)})");
                    number++;
                }
            }

            // call computeFactorials method
            computeFactorials(1, 10);

        }
    }
}
