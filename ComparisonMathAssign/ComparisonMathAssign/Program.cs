using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonMathAssign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User input//
            Console.WriteLine("Enter your favorite number: ");
            int favNum = Convert.ToInt32(Console.ReadLine());

            //Mulitply input//
            int multiNum = favNum * 50;
            Console.WriteLine("Your favorite number times 50 is: " + multiNum);
          

            //User input plus 25//
            Console.WriteLine("Enter your age: ");
            int ageNum = Convert.ToInt32(Console.ReadLine());
            int agePlus = ageNum + 25;
            Console.WriteLine("You age in 25 years: " + agePlus);

            //User input plus 25//
            Console.WriteLine("Enter the square footage of your house: ");
            double val = Convert.ToDouble(Console.ReadLine());
            double footHouse = val / 12.5;
            Console.WriteLine("The floors in your house are:  " + footHouse);

            //User input greater than 50 if true or false//
            Console.WriteLine("Enter the miles of your last car trip: ");
            int carMiles = Convert.ToInt32(Console.ReadLine());
            int moreMiles = 50;
            bool isMore = carMiles > moreMiles;
            Console.WriteLine(isMore);

            //User input division and remainder//
            Console.WriteLine("Enter the number of socks you own: ");
            int socksNum = Convert.ToInt32(Console.ReadLine());
            int socksLeftOver = socksNum % 7;
            Console.WriteLine("The number of left over socks is: " + socksLeftOver);

            Console.ReadLine();


        }
    }
}
