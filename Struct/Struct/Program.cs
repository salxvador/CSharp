using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate number object from struct
            Number num = new Number() { Amount = 53.62m };

            //print the amount
            Console.WriteLine(num.Amount);
            Console.Read();
        }
    }
}
