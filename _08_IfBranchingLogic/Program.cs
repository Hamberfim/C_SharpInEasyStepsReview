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
            // Console.WriteLine(negNumericBool);  // test results
            // Console.WriteLine(posNumericBool);  // test results

            // Ternary operation logic
            string negflagResult = (negNumericFlag == negNumericBool) ? "Camparision-Both are negative." : "Camparision-Both are NOT negative";
            Console.WriteLine(negflagResult);
            string posflagResult = (posNumericFlag == posNumericBool) ? "Camparision-Both are positive." : "Camparision-Both are NOT positive";
            Console.WriteLine(posflagResult);
            string notEqualflagResult = (negNumericFlag == posNumericBool) ? "Camparision-Both are Equal." : "Camparision-Both are NOT Equal";
            Console.WriteLine(notEqualflagResult);

            Console.WriteLine();  // space in output
            if(negNumericFlag >= 0)
            {
                Console.WriteLine($"{negNumericFlag} Flag is greater than or equal to 0");
            } else
            {
                Console.WriteLine($"{negNumericFlag} Flag is NOT greater than equal to 0");
            }

            
        }
    }
}
