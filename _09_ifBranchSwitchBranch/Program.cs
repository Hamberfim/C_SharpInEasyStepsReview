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



        }
    }
}
