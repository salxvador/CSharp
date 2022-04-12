using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Maths
    { 
        //define properties of class (one int)
        public int number { get; set; }
        //method to add two to the number
        public int addTwo()
        {
            int answer = number + 2;
            return answer;
        }
        //method to multiply number by 2
        public int multTwo()
        {
            int answer = number * 2;
            return answer;
        }
        //method to divide number by two
        public int divTwo()
        {
            int answer = number / 2;
            return answer;
        }
    }
}
