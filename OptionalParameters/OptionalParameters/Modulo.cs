using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    public class Modulo
    {
        //Method takes input and modulates by 2 as default.
        //optional parameter can replace 2 as modulator
        public int Modulate(int num1, int num2 = 2)
        {
            int ans = num1 % num2;
            return ans;
        }
    }
}
