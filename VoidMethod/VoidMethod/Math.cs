using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Math
    {
        //Create void method named compute
        public void compute(int operand, int num2)
        {
            //do math on the first argument and print the result; print the second argument.
            int sum = operand + 12;
            Console.WriteLine("The sum of the first argument and 12 is: " + sum);
            Console.WriteLine("The second argument is " + num2);
        }
    }
}
