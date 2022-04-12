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
        Console.WriteLine("Start of While-Loop Int List:");

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

        //Assignment 4. New List:
        List<string> namesList = new List<string>();
        //Create an array with the names I want in my list
        string[] myNames = { "Sal", "Julia", "Alex", "Jor", "Bela" };
        // Add these names to the list
        namesList.AddRange(myNames);

        // Ask user to input search term for the list
        Console.WriteLine("Please enter a name to search for in the list: ");
        string search = Console.ReadLine();
        // vars for match and k counter
        int match = 0;
        int k = 0;

        // if there are no matches and the counter is less than list lenght, keep going.
        while (match < 1 && k < namesList.Count)
        {
            // When search term matches a name, print the index (k) and update match var
            if (search == namesList[k])
            {
                match++;
                Console.WriteLine("'"+search+"' is at index " + k + " of the name list.");
            }
            else
            {
                // increment counter when no match is found.
                k++;
            }
        }
        // print message if not match is found in the list.
        if (match < 1)
        {
            Console.WriteLine("'"+ search +"' is not present in the list.");
        }

        // Assignment 5: New list with duplicate entries.
        List<string> cities = new List<string>();
        string[] site = { "Riverdale", "Portland", "Corona", "Portland", "Columbus", "Ostrander", "Columbus" };

        // Add array values to list
        cities.AddRange(site);

        // Ask user for serach term input
        Console.WriteLine("Please enter a city name to search for: \n(Examples: Portland, Riverdale)");
        string citySearch = Console.ReadLine();

        //variables to store number of matches and counter
        int cityMatch = 0;
        int t = 0;

        while (t < cities.Count)
        {
            if (citySearch == cities[t])
            {
                Console.WriteLine(citySearch + " is at index "+ t);
                cityMatch++;
                t++;
            }
            else
            {
                t++;
            }
        }

        // Print message if search term is not present in list.
        if (cityMatch == 0)
        {
            Console.WriteLine("'" + citySearch + "' is not present in the list.");
        }

        // Keep console window open for reading
        Console.Read();
    }
}
