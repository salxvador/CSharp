using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //Ask user to enter day of the week ans store val in string variable
        Console.WriteLine("Please enter they day of the week: ");
        string day = Console.ReadLine();
        
        //Try to parse the string to daysOfTheWeek data type
        try
        {
            daysOfTheWeek enumDay = (daysOfTheWeek)Enum.Parse(typeof(daysOfTheWeek), day);
            //print the enumerated value and the data type:
            Console.WriteLine(enumDay);
            Console.WriteLine(enumDay.GetType());
        }
        catch (Exception)
        {
            //print this if the string cannot be matched to enumerated type
            Console.WriteLine("Please enter an actual day of the week.");
        }

        //Keep Console open
        Console.Read();
    }
}
// Enumerated days of the week
public enum daysOfTheWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}
