using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            // Ask DR questions and store each answer in a variable.
            // ReadLine() always returns string type.
            Console.WriteLine("The Tech Academy.\nStudent Daily Report.");
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();

            Console.WriteLine("What page number?");
            string page = Console.ReadLine();
            // Cast the string page to integer pageNum
            int pageNum = Convert.ToInt32(page);
            
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            // only 'true' or 'false' can be converted to boolean values.
            string help = Console.ReadLine();
            // convert to boolean
            bool needsHelp = Convert.ToBoolean(help);
            
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            
            Console.WriteLine("Is there any feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            ushort hoursStudied = Convert.ToUInt16(hours);
            
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}
