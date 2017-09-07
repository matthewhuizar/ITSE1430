/*
 * Matthew Huizar
 * ITSE 1430
 * 9/6/17
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Host 
{
    class Program 
    {
        static void Main( string[] args )
        {
            int hours;

            hours = 10;
            //hours = Math.Min(hours, 56);

            string name = "John";

            //Concat
            name = name + " Williams";

            //Copy
            name = "Hello";

            //Verbatim string - no escape sequences
            string path = @"C:\Temp\test.txt";

            //Option 1
            string names = "John" + "William" + "Henry";

            //Option 2
            StringBuilder builder = new StringBuilder();
            builder.Append("John");
            builder.Append("William");
            string names2 = builder.ToString();

            //Option 3
            string names3 = String.Concat("John", " William", " Murphy", "Charles", " Henry");

            //String formatting
            //John worked 10 hours
            string format1 = name + " worked " + hours.ToString() + " hours";

            string format2 = String.Format("{0} worked for {1} hours", name, hours);

        }
    }
}
