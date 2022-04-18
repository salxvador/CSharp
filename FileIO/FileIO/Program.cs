using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for a number
            Console.WriteLine("Please enter a number to be logged in the file:");
            string num = Console.ReadLine();

            //path for log file
            string path = @".\log.txt";
            //append the number to log.txt
            using (StreamWriter file = new StreamWriter(path, true))
            {
                file.WriteLine(num);
            }

            //print file contents to the console:
            Console.WriteLine("Current contents of log.txt:");
            Console.WriteLine(File.ReadAllText(path));

            Console.Read();
        }
    }
}
