using System;

namespace _09_ifBranchSwitchBranch
{
    class Program
    {
        static void Main(string[] args)
        {
            // decalre and initialize
            string[] daysArray = new string [] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
           
            Console.WriteLine("Enter an number for a day of the week:");
            var usrInputAsStr = Console.ReadLine();
            int usrDayInput;
            bool parseSuccess = int.TryParse(usrInputAsStr, out usrDayInput);

            Console.WriteLine("=== if branching ===");
            if (parseSuccess)
            {
                if (usrDayInput == 1)
                {
                    Console.WriteLine(daysArray[usrDayInput - 1]);
                }
                else if (usrDayInput == 2)
                {
                    Console.WriteLine(daysArray[usrDayInput - 1]);
                }
                else if (usrDayInput == 3)
                {
                    Console.WriteLine(daysArray[usrDayInput - 1]);
                }
                else if (usrDayInput == 4)
                {
                    Console.WriteLine(daysArray[usrDayInput - 1]);
                }
                else if (usrDayInput == 5)
                {
                    Console.WriteLine(daysArray[usrDayInput - 1]);
                }
                else if (usrDayInput == 6)
                {
                    Console.WriteLine(daysArray[usrDayInput - 1]);
                }
                else if (usrDayInput == 7)
                {
                    Console.WriteLine(daysArray[usrDayInput - 1]);
                }
            } else
            {
                usrDayInput = -1; // default in case nothing is entered by user
                Console.WriteLine("User input was not valid so it was set to -1. Program Exited!");
            }
            
            

            // decalre and initialize
            Console.WriteLine();  // space in output
            Console.WriteLine("=== switch branching ===");
            string day;
            switch(usrDayInput)
            {
                case 1: day = daysArray[0];
                    break;
                case 2: day = daysArray[1];
                    break;
                case 3: day = daysArray[2];
                    break;
                case 4: day = daysArray[3];
                    break;
                case 5: day = daysArray[4];
                    break;
                case 6: day = daysArray[5];
                    break;
                case 7: day = daysArray[6];
                    break;
                default: day = "User input was not valid so it was set to -1. Program Exited!";
                    break;
            }
            Console.WriteLine(day);
        }
    }
}
