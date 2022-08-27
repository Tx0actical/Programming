using System;

namespace Conditionals
{
    class Program
    {
        static void Main (string[] args)
        {
            int theVal = 50;

            // If-else
            // if (theVal == 50)            
            //    Console.WriteLine ("The value is 50");
            if (theVal !=60)
                Console.WriteLine ("The value is not 60");
            else 
                Console.WriteLine ("The value os between 50 and 60");

            // ternary operator!
            Console.WriteLine(theVal < 50 ? "The value is small" : "The value is large");
        }
    }
}