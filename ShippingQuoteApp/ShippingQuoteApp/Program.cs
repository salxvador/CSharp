using System;

namespace ShippingQuoteApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the package weight?");

            // store package weight as float
            float weight = Convert.ToSingle(Console.ReadLine());

            // Check if weight is greater than 50. If so, deny and close program
            if (weight > 50)
            {
                // print denial message and ceep console open
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
                Console.ReadLine();
            }
            else
            {
                // gather width and store as float
                Console.WriteLine("Please enter the package width:");
                float width = Convert.ToSingle(Console.ReadLine());

                // gather height
                Console.WriteLine("Please enter the package height:");
                float height = Convert.ToSingle(Console.ReadLine());

                // gather length
                Console.WriteLine("Please enter the package length:");
                float length = Convert.ToSingle(Console.ReadLine());

                // if sum of dimensions is greater than 50, deny and close program
                if ((width + height + length) > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    // for quote, multiply 3 dimensions together, mulitply by weight, then divide by 100.
                    float quote = length * width * height * weight / 100;

                    // print quote formatted as currency with two decimal places "c2":
                    Console.WriteLine("Your estimated total for shipping this package is: " + quote.ToString("c2"));
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}
