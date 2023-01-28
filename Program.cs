using System;

namespace Employee_wages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage computation");
            Console.WriteLine(" Name of employee is:");
            string name = Console.ReadLine();
            int fullDayHour = 8;
            int perHourWage = 20;
            int halfDayHour = 4;
            Random random = new Random();
            int isEmp = random.Next(0, 3);
            int DailyWage = 0;
            if (isEmp == 0)
            {

                Console.WriteLine(name + " Employee is  Abesent ");
                Console.WriteLine("Daily  Wage of Employee is:" + DailyWage);


            }
            else if(isEmp==1)
            {
                DailyWage = fullDayHour * perHourWage;
                Console.WriteLine(name + " Employee is Present for full day");
                Console.WriteLine("Daily  Wage of Employee is:" + DailyWage);
            }
            else
            {
                DailyWage = halfDayHour * perHourWage;
                Console.WriteLine(name + " Employee is Present for half day");
                Console.WriteLine("Daily  Wage of Emloyee is:" + DailyWage);
            }
        }
    }
}
