using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years until you are able to get your driving license?");
            string x = Console.ReadLine();
            int y = Convert.ToInt32(x);


            Console.WriteLine("What year will you obtain the driving license?");
            string year = Console.ReadLine();
            int driveYear = Convert.ToInt32(year);


            Console.WriteLine("In the year {0}, which is {1} year(s) from now, you will obtain your driving license.  Congradulations!", driveYear, y);
            Console.ReadLine();

        }
    }
}
