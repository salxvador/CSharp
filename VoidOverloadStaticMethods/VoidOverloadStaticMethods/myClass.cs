using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidOverloadStaticMethods
{
    class myClass
    {
        //1. Void method that prints and integer (divide input by 2)
        public void divTwo(int num)
        {
            int answer = num / 2;
            //print the result; can't return it because it's void.
            Console.WriteLine(num + "/2 = " + answer);
        } 

        //4. Method with output params
        public string sayHello(string name)
        {
            //create a message for the name input.
            string msg = "Hello, "+name+". It's nice to meet you.";
            //return the message (string)
            return msg;
        }

        //5. Overload the sayHello Method by taking an extra argument
        public string sayHello(string firstName, string lastName)
        {
            string msg = firstName + " " + lastName + "! Fancy meeting you here.";
            return msg;
        }
    }
}
