using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstsVarsConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create const variable.
            const string x = "darling";
            Console.WriteLine("Hello, " + x+".");

            //use keyword var: first constructor
            var sal = new Person("Sal", 147);
            //use keyword var: chained constructor
            var chloe = new Person("Chloe");

            //Print const and deets for each person.
            //first variable capitalizes the first letter of the string in 'x'
            Console.WriteLine("{0}, {1} is {2} years old.", char.ToUpper(x[0]) + x.Substring(1), sal.Name, sal.Age);
            Console.WriteLine("{0}, {1} is {2} years old.", char.ToUpper(x[0]) + x.Substring(1), chloe.Name, chloe.Age);

            //Keep Console open
            Console.ReadLine();
        }
    }
}
