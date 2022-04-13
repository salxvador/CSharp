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

            //Instantiate IQuittable object (inherited interfaceof employee)
            IQuittable worker = new Employee() { FirstName = "Jillian", LastName = "Michaels" };
            //Call Quit() Method
            worker.Quit();

            //Keep console open
            Console.Read();
        }
    }
}
