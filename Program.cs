using System;

namespace Employee_wages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation");
            Console.WriteLine("Name of the Employee: ");
            string name=Console.ReadLine();
            int fullDayHour = 8;
            int perHourWage = 20;
            int halfDayHour = 4;
            int DailyWage = 0;
            Random random= new Random();
            int n=random.Next(0,3);
            switch(n)
            {
                    case 0:
                    Console.WriteLine(name+ "Employee is absent");
                    Console.WriteLine("Daily wage Employee is:" + DailyWage);
                    break;

                    case 1:
                    DailyWage = fullDayHour * perHourWage;
                    Console.WriteLine(name+ "Employee is present for full day");
                    Console.WriteLine("Daily wage Employee is:" +DailyWage);
                    break;

                    case 2:
                    DailyWage= perHourWage * halfDayHour;
                    Console.WriteLine(name+ "Employee is present for half day");
                    Console.WriteLine("Daily wage employee is:" + DailyWage);
                    break;

                    default:
                    break;


            }

        }
    }
}
