using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My dog wants to know how many dog treats do you have today?");
            int numb = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = numb == 8;

            while (!isGuessed)
            {
                switch (numb)
                {
                    case 0:
                    case 1:
                        Console.WriteLine("You did not bring enough treats.  Bring more next time!!");
                        numb = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 2:
                    case 3:
                        Console.WriteLine("You still did not bring enough treats but at least you brought something!");
                        numb = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 4:

                        Console.WriteLine("You brought enough treats.  Thank you!");
                        isGuessed = true;
                        break;

                    case 5:
                    case 6:

                        Console.WriteLine("You brought extra treats! You are nice.");
                        numb = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 7:
                    case 8:
                        Console.WriteLine("You are my favorite person!");
                        isGuessed = true;
                        break;

                    default:
                        Console.WriteLine("You brought too many treats!");
                        numb = Convert.ToInt32(Console.ReadLine());
                        break;


                }


            }
            Console.ReadLine();
        }
    }
}