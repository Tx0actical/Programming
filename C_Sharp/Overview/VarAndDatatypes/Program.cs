using System;

namespace VarsAndData
{
    class Program
    {
        static void Main(string[] args)
        {
            //basic value types variables
            int i = 10;
            float f = 2.0f;
            decimal d = 10.0m;
            bool b = true;
            char c = 'c';

            //declare a string 
            string str = "a string";

            // Declare implicit variable
            var x = 10;
            var z = "Hello";

            // Array of values
            int[] vals = new int[5];
            string[] strs = { "one", "two", "three" };

            // Print values using formatting strings
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", i, c, b, str, f, d, x, z);

            //null value
            object obj = null;
            Console.WriteLine(obj); // This will print a blank line because obj is set to null
            
            // Implicit type conversion
            long bignum;
            bignum = i;
            Console.WriteLine(bignum);

            // Explicit type conversion
            float i_to_f = (float)i;
            Console.WriteLine("{0}", i_to_f);

            int f_to_i = (int)f;
            Console.WriteLine("{0}", f_to_i);
        }
    }
}