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
            Console.WriteLine("My dog wants to know how many dog treats do you have today. Enter number of treats:");
            int numb = Convert.ToInt32(Console.ReadLine());

            //bool is true when 8 is entered by user//
            bool isGuessed = numb == 8; 

            while (!isGuessed)
            {
                //loop cases//
                switch (numb)
                {
                    case 0:
                    case 1:
                        Console.WriteLine("You did not bring enough treats!");
                        Console.WriteLine("How many treats will you bring next time?");
                        numb = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 2:
                    case 3:
                        Console.WriteLine("You still did not bring enough treats but at least you brought something!");
                        Console.WriteLine("How many treats will you bring next time?");
                        numb = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 4:
                    case 5:

                        Console.WriteLine("You brought enough treats.  Thank you!");
                        Console.WriteLine("How many treats will you bring next time?");
                        numb = Convert.ToInt32(Console.ReadLine()); 
                        break;

             
                    case 6:
                    case 7:

                        Console.WriteLine("You brought extra treats! You are nice.");
                        Console.WriteLine("How many treats will you bring next time?");
                        numb = Convert.ToInt32(Console.ReadLine());
                        break;

                    
                    case 8:
                        Console.WriteLine("You are my favorite person!");
                        isGuessed = true;
                        break;

                    default:
                        Console.WriteLine("You brought too many treats!");
                        Console.WriteLine("How many treats will you bring next time?");
                        numb = Convert.ToInt32(Console.ReadLine());
                        break;


                }


            }
            Console.ReadLine();
        }
    }
}