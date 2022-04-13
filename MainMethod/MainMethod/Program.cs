using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the Maths Class
            Maths num = new Maths();

            //Create integer, decimal, and string variables
            int integer = 7;
            decimal dec = 4.62m;
            string str = "14";

            //print the result of the first method (add 5 using int)
            Console.WriteLine(num.doMath(integer));

            //print result of the second method (multiply decimal by 2, return int)
            Console.WriteLine(num.doMath(dec));

            //print result of the third method (divide string number by two, return int)
            Console.WriteLine(num.doMath(str));

            //Keep Console window open
            Console.Read();
        }
    }
}
