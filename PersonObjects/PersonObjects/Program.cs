using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate and initialize Employee object
            Employee emp = new Employee() { FirstName = "Sample", LastName = "Student" };

            //Call SayName() method (from super class)
            emp.SayName();

            //Keep Console Open
            Console.Read();
        }
    }
}
