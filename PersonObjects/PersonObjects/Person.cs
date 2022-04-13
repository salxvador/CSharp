using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonObjects
{
    public class Person
    {
        //add first/last name properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //add sayName method
        public void SayName()
        {
            //Format string to print first and last names
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}
