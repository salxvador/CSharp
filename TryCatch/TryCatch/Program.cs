using System;
using System.Collections.Generic; // need this for lists!

class Program
{
    static void Main(string[] args)
    {
        try
        {
            //Create list of integers
            List<int> integers = new List<int>() { 20, 23, 65, 45, 87, 96 };

            //Ask user for number to divide into each elem of list
            Console.WriteLine("Please enter a divisor:");
            int divisor = Convert.ToInt32(Console.ReadLine());

            //Loop through each int in list and divide. print quotient
            foreach (int integer in integers)
            {
                int quotient = integer / divisor;
                Console.WriteLine(integer + " divided by " + divisor + " equals " + quotient);
            }
        }
        // If user enters a 0, throw this exception:
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message + "\nDo not divide by 0.");
        }
        // If user enters a string:
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message + "\nPlease enter a whole number.");
        }
        // any other general exceptions:
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        // code outside of try/catch to check if program emerges:
        Console.WriteLine("The program moved past the try/catch block.");
        

        //Keep Console open
        Console.Read();
    }
}
