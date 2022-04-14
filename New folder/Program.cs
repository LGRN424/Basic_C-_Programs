using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelsestatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Title and Instruction//
            Console.WriteLine("Welcome to Package Express.\nPlease follow the instructions below.\n");

            //Package Weight Limit//
            Console.WriteLine("Please enter the package weight in pounds");
            int packWeight = Convert.ToInt32(Console.ReadLine());

            if (packWeight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express.  Have a good day.");
            }
            //Package Dimensions//
            else 
            { 
                Console.WriteLine("Please enter package width in inches:");
                int packWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter package height in inches:");
                int packHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter package length in inches:");
                int packLength = Convert.ToInt32(Console.ReadLine());
            
                int totalDims = packWidth + packHeight + packLength;
                Console.WriteLine("The total dimensions are:  " + totalDims);
            //Package Dimensions Limit// 

                if (totalDims > 50)
                {
                    Console.WriteLine("Package is too big to be shipped via Package Express.");
                }
            //Shipping calculations based on package dimensions and weight//
                else 
                {
                    int multiDim = packWidth * packHeight * packLength;
                    int prodPack = (multiDim * packWeight) / 100;

            //Esitmate cost display//
                    decimal quoteCost = Convert.ToDecimal(prodPack);
                    Console.WriteLine("Your estimated total for shipping this package is $" + quoteCost + "\nThank you");
           
                }
            }
            
            Console.ReadLine();

        }
    }
}
