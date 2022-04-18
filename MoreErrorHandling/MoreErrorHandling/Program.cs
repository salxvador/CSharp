using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user for age
            Console.WriteLine("Please enter your age:");
            string strAge = Console.ReadLine();
            //declare variable in global scopre
            int age = 0;
            //use try/catch to handle if age can't be converted.
            try
            {
                age = Convert.ToInt32(strAge);
            }
            // write error message and close program.
            catch (Exception)
            {
                Console.WriteLine("Invalid age entered. Please run the program again");
                Console.ReadLine();
                return;
            }

            //print age to screen
            Console.WriteLine("Your age is {0} years.", age);

            Console.Read();
        }
    }
}
