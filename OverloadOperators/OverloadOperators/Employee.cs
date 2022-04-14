using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperators
{
    public class Employee : Person //Inherits from Person
    {
        //Id Property
        public int Id { get; set; }

        //Overload == operator to see of two employees have the same Id number
        public static bool operator== (Employee emp1, Employee emp2)
        {
            return emp1.Id == emp2.Id;
        }

        //Overload != operator
        public static bool operator!= (Employee emp1, Employee emp2)
        {
            return emp1.Id != emp2.Id;
        }
    }
}
