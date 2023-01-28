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
            int isEmp=random.Next(0,2);
            if(isEmp==0)
            {
                Console.WriteLine(name +" Employee is present");
            }
            else
            {
                Console.WriteLine(name +" Employee is absent");
            }
        }
    }
}
