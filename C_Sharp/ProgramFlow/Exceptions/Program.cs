using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exception Handling: To catch errors before they are displayed
            // exceptions which are not handled are called unhandled exceptions
            // keeps the main program running

            int x = 10000;
            int y = 0;

            // catch handling
            try
            {
                if (x > 1000)
                    throw new ArgumentOutOfRangeException("x", "x has to be 1000 or less");               
                var result = x / y;
                Console.WriteLine($"The result is {result}: ");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Try Again!");
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Sorry, 1000 is the limit");
                Console.WriteLine(e.Message);
            }
            finally
            {   
                // this will always run
                Console.WriteLine("This code always run");
            }
            
        }
    }
}