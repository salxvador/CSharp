using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate Employee object
            Employee emp = new Employee() { LastName = "Student", FirstName = "Sample" };

            //Call the sayname method
            emp.SayName();

            //Keep console open
            Console.Read();
        }
    }
}
