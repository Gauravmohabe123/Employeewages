using System;

namespace Employee_wages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage computation");
            Console.WriteLine(" Name of employee is:");
            string name=Console.ReadLine();
            Random random= new Random();
            int n=random.Next(0,2);
            if(n==0)
            {
                Console.WriteLine("Employee is Absent");
            }
            else
            {
                Console.WriteLine("Employee is Present");
            }
        }
    }
}
