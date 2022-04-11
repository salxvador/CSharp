using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        // Create array of strings
        string[] stringArray = { "Sal", "Judi", "Loren", "Camirra", "Colin", "Shae" };
        // Create array of ints
        int[] intArray = { 25, 11, 30, 99, 42, 3 };
        
        // Create list of strings
        List<string> stringList = new List<string>();
        stringList.Add("Portland");
        stringList.Add("Ostrander");
        stringList.Add("Falmouth");
        stringList.Add("Riverside");
        stringList.Add("Bend");
        stringList.Add("Bar Harbor");

        // QUESTION 1:
        // Ask for input to choose index of string array
        Console.WriteLine("Pick an index 0-5 to display an item from the string Array");
        int index = Convert.ToInt32(Console.ReadLine());

        // Error Message:
        string msg = "Sorry, index '" + index + "' does not exist";

        // Check if index exists, and print the element. Give error msg if index is out of range.
        if (index < 0 || index > 5)
        {
            Console.WriteLine(msg);
        }
        else
        {
            Console.WriteLine(stringArray[index]);
        }

        // QUESTION 2: 
        // Ask for input to choose index of intArray
        Console.WriteLine("Pick an index 0-5 to display an item from the integer Array");
        index = Convert.ToInt32(Console.ReadLine());

        // Check if index exists, and print the element. Give error msg if index is out of range.
        if (index < 0 || index > 5)
        {
            Console.WriteLine(msg);
        }
        else
        {
            Console.WriteLine(intArray[index]);
        }

        // QUESTION 3:
        // Ask for input to choose index of stringList
        Console.WriteLine("Pick an index 0-5 to display an item from the string List");
        index = Convert.ToInt32(Console.ReadLine());

        // Check if index exists, and print the element. Give error msg if index is out of range.
        if (index < 0 || index > 5)
        {
            Console.WriteLine(msg);
        }
        else
        {
            Console.WriteLine(stringList[index]);
        }

        // Keep Console window open so user can read.
        Console.ReadLine();
    }
}
