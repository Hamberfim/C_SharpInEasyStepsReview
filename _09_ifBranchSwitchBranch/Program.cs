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
            int usrDayInput = Convert.ToInt32(Console.ReadLine());
            if(usrDayInput == 1)
            {
                Console.WriteLine(daysArray[usrDayInput - 1]);
            } else if(usrDayInput == 2)
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
            } else
            {
                Console.WriteLine($"{usrDayInput} is an invalid choice for a day of the week. Must be 1-7.");
            }

            // decalre and initialize
            Console.WriteLine();  // space in output
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
                default: day = "Monday is the start of the work week, Saturdays are the start of the weekend.";
                    break;
            }
            Console.WriteLine($"Based on your input of {usrDayInput} the Switch/Case output is: {day}");
        }
    }
}
