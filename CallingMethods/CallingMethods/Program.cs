using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // gather number input from user
            Console.WriteLine("Please enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            // use input to create new maths class, and assign it to number
            Maths numb = new Maths();

            //Call each method:
            Console.WriteLine("addTwo method: "+numb.addTwo(num));
            Console.WriteLine("multTwo method: " + numb.multTwo(num));
            Console.WriteLine("divTwo method: " + numb.divTwo(num));
            //keep console open
            Console.Read();
        }
    }
}
