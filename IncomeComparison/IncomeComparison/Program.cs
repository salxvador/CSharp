using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            // Collect Data from Person 1; Convert from Strings to doubles:
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1: \nHourly Rate?");
            string p1_hourly_str = Console.ReadLine();
            double p1_hourly = Convert.ToDouble(p1_hourly_str);
            
            Console.WriteLine("Hours worked per week?");
            string p1_week_hours_str = Console.ReadLine();
            double p1_week_hours = Convert.ToDouble(p1_week_hours_str);

            // Calculate Annual Salary for Person 1:
            double p1_salary = (p1_hourly * p1_week_hours) * 52;
            
            // Collect data for Person 2; Convert strings to doubles:
            Console.WriteLine("Person 2: \nHourly Rate?");
            string p2_hourly_str = Console.ReadLine();
            double p2_hourly = Convert.ToDouble(p2_hourly_str);

            Console.WriteLine("Hours worked per week?");
            string p2_week_hours_str = Console.ReadLine();
            double p2_week_hours = Convert.ToDouble(p2_week_hours_str);

            // Calculate Annual Salary for Person 2:
            double p2_salary = (p2_hourly * p2_week_hours) * 52;

            // Calculate if person 1 salary is greater than person2 salary:
            bool comp = p1_salary > p2_salary;

            // Write Salaries for each Person:
            Console.WriteLine("Annual salary of Person 1: \n" + p1_salary.ToString());
            Console.WriteLine("Annual salary of Person 2: \n" + p2_salary.ToString());
            
            // Print result of salary comparison: 
            Console.WriteLine("Does Person 1 make more money than Person 2? \n" + comp.ToString());

            //Keep the console open:
            Console.ReadLine();
        }
    }
}
