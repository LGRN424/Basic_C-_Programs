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
            //Ask for number of treats//
            Console.WriteLine("My dog wants to know how many dog treats do you have today. Enter number of treats:");
            int numb = Convert.ToInt32(Console.ReadLine());

            //Correct number of treats is 8//
            bool isGuessed = numb == 8;


            do //Begin loop//
            {
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


                    //bool is true//
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
            while (!isGuessed);
            
            Console.ReadLine();
            
         }
    }
}