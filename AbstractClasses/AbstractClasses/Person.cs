using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class Person
    {
        //add FN LN properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //add abstract method for SayName()
        public abstract void SayName();
    }
}
