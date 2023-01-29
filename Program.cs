using System;

namespace Employee_wages
{
    internal class Program
    {static void wage_Attendance()
        {
            Console.WriteLine("Welcome to the Employee Wage Computation");
        }
        static void Main(string[] args)
        {
               
            int WageperHour = 20;
            int FullDayHour = 8;
            int partTimehour = 4;
            int wage = 0;
            Random rnd = new Random();
            int monthlyWage = 0;
            int day = 1;
            int count = 1;
            int absent = 1;
            while (day != 20 && count != 30)

            {
                int n = rnd.Next(0, 3);
                switch (n)

                {
                    case 0:
                        absent++;
                        count++;
                        break;

                    case 1:

                        wage = partTimehour * WageperHour;
                        monthlyWage = wage + monthlyWage;
                        count++;
                        day++;
                        break;
                    case 2:
                        wage = FullDayHour * WageperHour;
                        monthlyWage = wage + monthlyWage;
                        count++;
                        day++
                        break;

                }

            }
            Console.WriteLine("monthly wage :" + monthlyWage);
            Console.WriteLine("prasent days :" + day);
            Console.WriteLine("total absent in a month:" + absent);
            wage_Attendance();
            
        }
    }
}
