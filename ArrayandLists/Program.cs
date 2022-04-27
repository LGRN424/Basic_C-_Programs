using System;
using System.Collections.Generic;


    class Program
    {
        static void Main()
        {
               
        //Set up of string array
        String[] planes = new String[] { "Airbus", "Boeing", "Learjet" , "Embraer" };

        //Ask user for index
        Console.WriteLine("Please select an index for the planes string: ");

        //Index number converted to int
        int n = Convert.ToInt32 (Console.ReadLine());

        //Index not in range message
        if (n > planes.Length)
        {
            Console.WriteLine("You picked a index number that does not exist!");
        }

        //Display item within range
        else
        {
            Console.WriteLine("You picked: " + planes[n]);

        }
        //Set up of integer array
        int[] pilotsNeeded = new int[] { 4, 3, 1, 2 };

        //User input
        Console.WriteLine("Please select an index for the number of pilots array: ");
        int p = Convert.ToInt32 (Console.ReadLine());

        //Index out of range message
        if (p > pilotsNeeded.Length)
        {
            Console.WriteLine("You picked a index number that does not exist!");
        }

        //Display item within range
        else
        {
            Console.WriteLine("Your plane needs " + pilotsNeeded[p] + " pilot(s).");
        }

        //List of names
        List<string> crewNames = new List<string>()
        {"Yosemite Sam", "Sylvester the Cat", "Elmer Fudd", "Road Runner"};

        //User input of crewNames list index
        Console.WriteLine("Please select an index from the pilot names list: ");
        int c = Convert.ToInt32(Console.ReadLine());

        //Display content within range
        Console.WriteLine("Your pilot will be: " + crewNames[c]);


        Console.ReadLine();
        
        
        

    }
    }

