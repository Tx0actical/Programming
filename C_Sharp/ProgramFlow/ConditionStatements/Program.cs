using System;

namespace ConditionStatements
{
    class Program
    {
        static void Main (string[] args)
        {
            int theVal = 60;

            // If-else
            // if (theVal == 50)            
            //    Console.WriteLine ("The value is 50");
            // if (theVal !=60)
            //     Console.WriteLine ("The value is not 60");
            // else 
            //     Console.WriteLine ("The value os between 50 and 60");

            // ternary operator!
            // Console.WriteLine(theVal < 50 ? "The value is small" : "The value is large");

            
            // switch statement!
            switch (theVal)    // any non-null charater can be used
            {
                case 50:
                    Console.WriteLine("The value is 50");
                    break;
                case 51:
                    Console.WriteLine("The value is 51");
                    break;
                case 52:    // merging different case into one
                case 53:
                case 54:
                    Console.WriteLine("The value is between 52 and 54");
                    break;
                default:
                    Console.WriteLine("The value is something else");
                    break;
            }
        }
    }
}