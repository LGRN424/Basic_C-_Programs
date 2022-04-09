using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Title with next line subtitle using \n escape sequence//

            Console.WriteLine("The Tech Academy \nStudent Daily Report");

            //Daily Report questions//

            //Name question with string data type//
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            //Course question with string data type//
            Console.WriteLine(yourName + ", What course are you on? ");
            string yourCourse = Console.ReadLine();

            //Page number converting string to int variable//
            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();
            int currentPage = Convert.ToInt32(pageNumber);

            //Question using boolean variable//
            Console.WriteLine("Do you need help with anything? Please answer True or False");
            string needsHelp = Console.ReadLine();
            bool help = Convert.ToBoolean(needsHelp);


            //Feedback using string text//
            Console.WriteLine("Are there any positive experiences you would like to share?  Please give specifics");
            string positiveExper = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide?  Please be specific.");
            string addFeedback = Console.ReadLine();

            //More string to int conversion practice//
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int todayHours = Convert.ToInt32(studyHours);

            //Print acknowlegdement of answers using \n escape sequence//

            Console.WriteLine("Thank you for your answers.\nAn instructor will respond to this shortly.\nHave a gread day!");

            Console.ReadLine();





        }
    }
}
