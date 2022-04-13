using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Maths
    {
        //First Method, add 5 with integer input and output
        public int doMath(int number)
        {
            //This version of doMath adds 5 to an integer
            int answer = number + 5;
            return answer;
        }

        //Second Method, do math with decimal input and integer output
        public int doMath(decimal number)
        {
            //This version of doMath multiplies decimal by 2, and returns int
            int answer = Convert.ToInt32(number * 2);
            return answer;
        }

        //Third Method, do math with string input and return integer
        public int doMath(string number)
        {
            //this version of doMath converts string to int, and divides it by two
            int answer = Convert.ToInt32(number) / 2;
            return answer;
        }
    }
}
