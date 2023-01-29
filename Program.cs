using System;

namespace Employee_wages
{
    internal class Program
    {static void Wage_Attendance()
        {
            Console.WriteLine("Welcome to emplyee wage computation");

        }
        static void Main(string[] args)
        {
            Wage_Attendance();
            int WageperHour = 20;
            int FullDayHour = 8;
            int partTimehour = 4;
            int wage = 0;
            Random rnd = new Random();
            int monthlyWage = 0;
            int day = 0;
            int count = 0;
            int absent = 0;
            int TotalHour = 0;
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
                        TotalHour += partTimehour;
                        break;
                    case 2:
                        wage = FullDayHour * WageperHour;
                        monthlyWage = wage + monthlyWage;
                        count++;
                        day++
                        TotalHour += FullDayHour;
                        break;

                }

            }
            Console.WriteLine("monthly wage :" + monthlyWage);
            Console.WriteLine("present days :" + day);
            Console.WriteLine("Total half day:" + partTimehour);
            Console.WriteLine("Total full Day:" + FullDayHour);
            Console.WriteLine("Total absent in a month:" + absent);
            Console.WriteLine("Total Worked Hour in a month:" + TotalHour);
            
        }
    }
}
