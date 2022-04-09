using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Addition//
            int a, b;
            int sumab;

            Console.WriteLine("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            sumab = a + b;
            Console.WriteLine("{0} + {1} = {2}", a, b, sumab);
            

            //Subtraction//
            int d,e;
            int diff;

            Console.WriteLine("Enter first number: ");
            d = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter second number: ");
            e = Convert.ToInt32(Console.ReadLine());

            diff = d - e;
            Console.WriteLine("{0} + {1} = {2}", d,e,diff);


            //Multiplication//
            int g,h;
            int prodgh;

            Console.WriteLine("Enter first number: ");
            g = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter second number: ");
            h = Convert.ToInt32(Console.ReadLine());

            prodgh = g * h;
            Console.WriteLine("{0} + {1} = {2}", g, h, prodgh);


            //Division//
            int j, k;
            int resultjk;

            Console.WriteLine("Enter first number: ");
            j = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter second number: ");
            k = Convert.ToInt32(Console.ReadLine());

            resultjk = j / k;
            Console.WriteLine("{0} + {1} = {2}", j, k, resultjk);

            Console.ReadLine();

        }
    }
}