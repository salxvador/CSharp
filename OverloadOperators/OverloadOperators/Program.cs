using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate emp1
            Employee emp1 = new Employee() { FirstName = "Salvador", LastName = "S", Id = 111 };
            //instantiate emp2 with matching Id
            Employee emp2 = new Employee() { FirstName = "Sal", LastName = "Sanchez", Id = 111 };
            //instantiate emp3 with unique Id
            Employee emp3 = new Employee() { FirstName = "Chloe", LastName = "Deen", Id = 222 };

            //Use overloaded operator on emp1 and emp2, print results
            Console.WriteLine(emp1 == emp2);

            //Use overloaded operator on emp2 and emp3, print results
            Console.WriteLine(emp2 == emp3);

            //Keep Console open
            Console.Read();
        }
    }
}
