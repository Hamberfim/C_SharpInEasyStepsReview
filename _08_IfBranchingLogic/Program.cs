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
                Console.WriteLine($"Flag {negNumericFlag} is greater than or equal to 0");
            } else
            {
                Console.WriteLine($"Flag {negNumericFlag} is NOT greater than equal to 0");
            }

            Console.WriteLine();  // space in output
            if (posNumericFlag >= 1)
            {
                Console.WriteLine($"Flag {posNumericFlag} is greater than or equal to 1");
            }
            else
            {
                Console.WriteLine($"Flag {posNumericFlag} is NOT greater than or equal to 1");
            }

            Console.WriteLine();  // space in output
            if (negNumericFlag >= 1)
            {
                Console.WriteLine($"Flag {negNumericFlag} is greater than or equal to 1");
            }
            else
            {
                Console.WriteLine($"Flag {negNumericFlag} is NOT greater than or equal to 1");
            }

            // decare and intialize
            Console.WriteLine();  // space in output
            Console.WriteLine("Please enter a number: ");
            double usrNumber = Convert.ToDouble(Console.ReadLine());

            if(usrNumber >= 1 && usrNumber <= 10)
            {
                Console.WriteLine($"Your number of {usrNumber} is within the range of 1-10.");
            }else
            {
                Console.WriteLine($"Your number of {usrNumber} is outside the range of 1-10.");
            }

            // decare and intialize
            Console.WriteLine();  // space in output
            Console.WriteLine("Thanks, now enter a single letter: ");
            char usrLetter = Convert.ToChar(Console.ReadLine());
            usrLetter = char.ToLower(usrLetter);  // normalize input for use

            if((usrNumber >= 1 && usrNumber <= 10) && usrLetter == 'c')
            {
                Console.WriteLine($"Your input combination of '{usrNumber}' and '{usrLetter}' is the magic combo! You're a wizard!");
            } else if((usrNumber >= 1 && usrNumber <= 10) && usrLetter != 'c')
            {
                Console.WriteLine($"Your number of '{usrNumber}' is greater than zero and your letter choice of '{usrLetter}' is acceptible.");
            } else if(usrNumber < 1)
            {
                Console.WriteLine($"You should have picked a number greater '{usrNumber}' but your letter choice of '{usrLetter}' is acceptible.");
            }

        }
    }
}
