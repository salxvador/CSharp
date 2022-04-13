using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Employee : Person, IQuittable //inherits from Person class and IQuittable Interface
    {
        //override the inherited implementation of SayName()
        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }

        //Must define Quit() from Quittable interface inheritance
        public void Quit()
        {
            Console.WriteLine("{0} tenders their resignation.", FirstName);
        }
    }
}
