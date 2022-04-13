using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidOverloadStaticMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate myClass
            myClass mine = new myClass();

            //gether number from user, apply divTwo method to it
            Console.WriteLine("Please enter a whole number to be divided by 2:");
            int num = Convert.ToInt32(Console.ReadLine());

            //call the divTwo method
            mine.divTwo(num);

            //Collect user name
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();

            //Call sayHello method and print result to screen
            Console.WriteLine(mine.sayHello(firstName));

            //Collect last name
            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();

            //Call sayHello with two string params and print result
            Console.WriteLine(mine.sayHello(firstName, lastName));

            //print staticClass property (does not have to be instantiated)
            Console.WriteLine(staticClass.answer);

            //call staticClass Method and print result (squares int input)
            Console.WriteLine("staticClass.square(11) = " + staticClass.square(11));

            //Keep Console Open
            Console.Read();
        }
    }
}
