using System;

namespace InsuranceQualification
{
    class Program
    {
        static void Main()
        {
            // Collect data and convert strings to appropriate data type for processing:
            // Age (Short)
            Console.WriteLine("What is your age?");
            string age_str = Console.ReadLine();
            short age = Convert.ToInt16(age_str);

            // Duis (boolean)
            Console.WriteLine("Have you ever had a DUI? Please answer 'true' or 'false'");
            string duis_str = Console.ReadLine();
            bool duis = Convert.ToBoolean(duis_str);

            // Speeding Tickets (short)
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets_str = Console.ReadLine();
            short tickets = Convert.ToInt16(tickets_str);

            // Evaluate boolean of age > 15 AND duis = false AND speeding tickets <= 3:
            bool eval = age > 15 && !duis && tickets <= 3;

            //Print evaluation:
            Console.WriteLine("Qualified? \n" + eval.ToString());

            // Keep Console window open
            Console.ReadLine();
        }
    }
}
