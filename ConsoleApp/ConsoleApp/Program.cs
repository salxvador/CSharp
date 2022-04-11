using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create simple string array
        string[] names = { "Sal", "Julia", "Alex", "Jor", "Bela" };

        //Ask user to input text to be added to each element of the array
        Console.WriteLine("Please enter an adjective that describes a person: ");
        string adj = Console.ReadLine();

        // Loop through each element of the array and add the txt to it.
        for (int i=0; i<names.Length; i++)
        {
            names[i] += " is " + adj;
        }

        // Loop through array again and print each item
        for (int i=0; i<names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
        // Keep console window open for reading
        Console.Read();
    }
}
