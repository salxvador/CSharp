using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the Math object
            Math math = new Math();

            //Call the compute method passing in 2 args
            math.compute(40, 16);

            //Call the compute method specifying params by name
            math.compute(operand: 14, num2: 65);

            //Keep console open
            Console.Read();
        }
    }
}
