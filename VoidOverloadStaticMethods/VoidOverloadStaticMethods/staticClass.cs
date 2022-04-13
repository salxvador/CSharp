using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidOverloadStaticMethods
{
    //6. Create a static Class
    public static class staticClass
    {
        //static property
        public static string answer = "The answer to life is 42";
        // static method squares int input
        public static int square(int num)
        {
            return num * num;
        }
    }
}
