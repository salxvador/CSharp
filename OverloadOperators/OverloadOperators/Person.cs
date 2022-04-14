using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperators
{
    public class Person
    {
        //add FN LN properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //add SayName Method
        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}
