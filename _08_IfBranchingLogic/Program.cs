using System;

namespace _08_IfBranchingLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ternary logic";

            // decare and intialize
            int negNumericFlag = 0;
            int posNumericFlag = 1;
            bool negFlag = false;
            bool posFlag = true;

            // can't cast a bool to int so use ternary
            int negNumericBool = (negFlag) ? 1 : 0;  // returns false so result is zero
            int posNumericBool = (posFlag) ? 1 : 0;  // returns true so result is one
            // Console.WriteLine(negNumericBool);
            // Console.WriteLine(posNumericBool);

            // Ternary operation logic
            string negflagResult = (negNumericFlag == negNumericBool) ? "Camparision-Both are negative" : "Camparision-Both are NOT negative";
            Console.WriteLine(negflagResult);
            Console.WriteLine();  // space in output
        }
    }
}
