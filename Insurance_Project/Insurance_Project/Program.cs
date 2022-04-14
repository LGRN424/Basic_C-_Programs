﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Title of Program//
            Console.WriteLine("Car Insurance Approval");
            Console.WriteLine();

            //Age of applicant//
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            //DUI//
            Console.WriteLine("Have you ever had a DUI? True or False");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            //Speeding Tickets//
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            //Qualification for Insurance//
            bool isqualiFied = ((age >= 16) && (dui == false) && (tickets <= 3));
            Console.WriteLine("Qualified?");
            Console.WriteLine(isqualiFied ? true : false);

            Console.ReadLine();
        }
    }
}