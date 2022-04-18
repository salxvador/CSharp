using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstsVarsConstructors
{
    public class Person
    {
        //First Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //Chained Constructor takes one argument for name, defaults age to 0.
        public Person(string name): this(name, 0) { }
        
        //properties of name and age
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
