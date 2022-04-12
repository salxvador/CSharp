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

        //Create infinite loop then fix it. Empty List:
        List<int> numList = new List<int>();
        // counter variable
        int j = 0;

        while (j < 10)
        {
            numList.Add(j);
            // must increment j with each pass or loop will go on forever.
            j++;
        }

        // Print each element of the list
        foreach (int num in numList)
        {
            Console.WriteLine(num);
        }
        // Keep console window open for reading
        Console.Read();
    }
}
