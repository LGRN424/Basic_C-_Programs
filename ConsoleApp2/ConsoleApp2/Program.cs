using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool hasTreats = false;

            
            while (!hasTreats)
            {
                Console.WriteLine("How many treats do you have?");
                int numbTreats = Convert.ToInt32(Console.ReadLine());

                if (numbTreats <= 4)
                {
                    Console.WriteLine("The dog will be disappointed");
                }
                else 
                {
                    Console.WriteLine("Your are the dog's favorite person until someone else brings more treats!");
                }
                break;

                

            }
            Console.ReadLine();
        }

    }
}
 
