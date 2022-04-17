using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Practice");

            //Declare strings//
            string namePic = "Captain Crunch ";
            string firstOfficer = "Wile E. Coyote";
            string todayCrew = "Today's flight crew: ";

            //Concantenate strings//
            string flightCrew = string.Concat(todayCrew,namePic,firstOfficer);
            Console.WriteLine(flightCrew);

            string upperstr1 = flightCrew.ToUpper();
            Console.WriteLine(upperstr1);

            //Stringbuilder using Append function to create paragraph//
            StringBuilder goats = new StringBuilder("Goats eat ");
            goats.Append("everything.");
            goats.AppendLine();

            //One sentence each new line//
            goats.AppendLine("Visitors are advised to park your car away from the goats.");
            goats.AppendLine("Our goats have been known to eat windshield wipers, vinyl car roofs and tires.");
            goats.AppendLine("Keep the windows closed lest the car interior becomes a snack for the goats.");
            Console.WriteLine(goats);


            Console.ReadLine();
        }
    }
}
