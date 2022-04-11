using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "Dame";
            string fname = "Helen";
            string lname = "Mirren";

            string actress = title +" "+fname +" "+ lname;

            string one = "Hello, this is a block of text about ";
            string two = "Dame Helen Mirren, a renowned actress. ";
            string three = "She was born on a year in a place to her parents.";

            StringBuilder sb = new StringBuilder();
            sb.Append(one + two + three);

            Console.WriteLine(actress);
            Console.WriteLine(actress.ToUpper());
            Console.WriteLine(sb);
            Console.Read();
        }
    }
}
