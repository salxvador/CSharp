using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTimeOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //print out the current date and time
            DateTime now = DateTime.Now;
            Console.WriteLine("The current date and time are:\n" + now);

            //Collect number to be added to now (hours)
            Console.WriteLine("How many hours would you like to add to this time?");
            int hours = Convert.ToInt32(Console.ReadLine());

            //add hours to now, then print out new time.
            DateTime newTime = now.AddHours(hours);
            Console.WriteLine(hours+" hours from now it will be:\n"+newTime);
            
            //keep console open
            Console.Read();
        }
    }
}
