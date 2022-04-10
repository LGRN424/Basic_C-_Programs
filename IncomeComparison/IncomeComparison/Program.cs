using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            //Person 1 pay rate and hours per week//
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int rate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worrked per week");
            int hours1 = Convert.ToInt32(Console.ReadLine());

            //Person 2 pay rate and hours per week//
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int rate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worrked per week");
            int hours2 = Convert.ToInt32(Console.ReadLine());

            //Annual salary of each person//
            int salary1 = (rate1 + hours1) * 52;
            int salary2 = (rate2 + hours2) * 52;

            Console.WriteLine("Annual Salary of Person 1:" );
            Console.WriteLine(salary1);

            Console.WriteLine("Annual Salary of Person 2:");
            Console.WriteLine(salary2);

            //Comparison of salaries//
            bool moreMoney = salary1 > salary2;
            Console.WriteLine(moreMoney);
            Console.ReadLine();


        }
    }
}
