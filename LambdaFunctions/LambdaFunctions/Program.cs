using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate 10 employee objects and add them to the list
            Employee emp0 = new Employee() { FirstName = "Salvador", LastName = "Sanchez", Id =01 };
            Employee emp1 = new Employee() { FirstName = "Chloe", LastName = "Hartley", Id =02 };
            Employee emp2 = new Employee() { FirstName = "Joe", LastName = "DiMaggio", Id =03 };
            Employee emp3 = new Employee() { FirstName = "Jake", LastName = "Shears", Id =04 };
            Employee emp4 = new Employee() { FirstName = "Anna", LastName = "Matronic", Id =05 };
            Employee emp5 = new Employee() { FirstName = "Milo", LastName = "Otisson", Id =06 };
            Employee emp6 = new Employee() { FirstName = "Joe", LastName = "Dirt", Id =07 };
            Employee emp7 = new Employee() { FirstName = "Adil", LastName = "Ajaz", Id =08 };
            Employee emp8 = new Employee() { FirstName = "Karen", LastName = "Cooper", Id =09 };
            Employee emp9 = new Employee() { FirstName = "Deirdre", LastName = "Rollins", Id =10 };

            // list of employees
            List<Employee> empsList = new List<Employee>()
            {
                emp0, emp1, emp2, emp3, emp4, emp5, emp6, emp7, emp8, emp9
            };

            // foreach loop to create a new list with emplyees named Joe
            List<Employee> JoesFor = new List<Employee>();
            foreach (Employee emp in empsList)
            {
                if (emp.FirstName == "Joe")
                {
                    JoesFor.Add(emp);
                }
            }
            //write the list length to the console
            Console.WriteLine("foreach loop added " + JoesFor.Count + " Joes to the list\n");

            //Lambda fn version of this process
            List<Employee> JoesLambda = empsList.Where(e => e.FirstName == "Joe").ToList();
            Console.WriteLine("Lambda fn added " + JoesLambda.Count + " Joes to the list");

            Console.Read();
        }
    }
}
