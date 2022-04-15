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
            Console.WriteLine("Guess a number:");
            int numb =  Convert.ToInt32(Console.ReadLine());
            bool isGuessed = numb == 12;

            while (!isGuessed)
            {
                switch (numb)
                {
                    case 62:
                        Console.WriteLine("You guessed 62.  Try again!");
                        Console.WriteLine("Guess a number:");
                        numb = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 29:
                        Console.WriteLine("You guessed 29.  Try again!");
                        Console.WriteLine("Guess a number:");
                        numb = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 12:
                        Console.WriteLine("You guessed 12.  That is correct!");
                        isGuessed = true;
                        break;

                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number:");
                        numb = Convert.ToInt32(Console.ReadLine());
                        break;


                }
            }
            Console.ReadLine();
        }
    }
}
