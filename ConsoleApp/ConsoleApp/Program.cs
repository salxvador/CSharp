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

        // Use < operator to determine if loop should continue
        while (j < 10)
        {
            numList.Add(j);
            // must increment j with each pass or loop will go on forever.
            j++;
        }
        // Mark where this print statement begins in the console
        Console.WriteLine("Start of While-Loop  Int List:");

        // Print each element of the list
        foreach (int num in numList)
        {
            Console.WriteLine(num);
        }

        // Another empty list
        List<string> strList = new List<string>();
        int counter = 0;
        // will use this too keep adding pipes to list entries
        string pipe = "|";

        // Use <= opertaor to keep adding elements to the list
        while (counter <= 10)
        {
            strList.Add(pipe);
            pipe += "|"; // adds another | to the sequence
            counter++;
        }
        // Mark where this print statement begins in console
        Console.WriteLine("Start of while loop <= operator with string list:");

        //Print out the above list
        foreach (string item in strList)
        {
            Console.WriteLine(item);
        }

        // Keep console window open for reading
        Console.Read();
    }
}
