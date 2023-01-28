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
            Random random = new Random();
            int isEmp = random.Next(0, 2);
            int DailyWage = 0;
            if (isEmp == 0)
            {

                Console.WriteLine(name + " Employee is not Abesent ");
                Console.WriteLine("Daily  Wage of Employee is:" + DailyWage);


            }
            else
            {
                DailyWage = fullDayHour * perHourWage;
                Console.WriteLine(name + " Employee is Presentsent");
                Console.WriteLine("Daily  Wage of Employee is:" + DailyWage);
            }
        }
    }
}
