using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate Modulo class
            Modulo mod = new Modulo();

            //Collect required input num1
            Console.WriteLine("Please enter a whole number to be modulated: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            //Collect optional input as modulator
            Console.WriteLine("Optional: enter a whole number modulator. 2 will be used by default: ");
            
            try
            {
                int num2 = Convert.ToInt32(Console.ReadLine());
                //Perform modulation with both arguments, print result
                int answer = mod.Modulate(num1, num2);
                Console.WriteLine(num1 + " modulus " + num2 + " equals: " + answer);
            }
            catch (Exception) // exception is thrown if no value is entered.
            {
                //Perform modulation with only 1 argument, print ressult
                int ans = mod.Modulate(num1);
                Console.WriteLine(num1 + " modulus 2 equals: " + ans);
            }

            //Keep Console open
            Console.Read();
        }
    }
}
