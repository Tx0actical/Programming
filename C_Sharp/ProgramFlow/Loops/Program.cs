using System;

namespace Loops
{
    class Program
    {
        static void Main (string[] args)
        {
            int Value = 15;
            // Console.WriteLine("This program shows how to implement loops!");
            // // for loop!
            // for (int i =0 ; i< Value; i++)
            // {
            //     Console.WriteLine("The value of i is currently {0}", i);
            // }

            int[] array = new int[] {3, 1, 145, 234, 4, 4566, 56757};
            string str = "The quick brown fox jumps over the lazy dog";

            // foreach loop : This loop is used to iterate over sequences
            Console.WriteLine ("************foreach loop**********");
            foreach (int i in array)
            {
                Console.WriteLine("The value of i currently is {0}", i);
            }

            // strings are also sequences

            var count = 0;
            foreach (char c in str)
            {
                if (c== 'o')
                    count++;
            }
            Console.WriteLine("Counted {0} o characters", count);

            // while loop
            string inpustring = "";
            Console.WriteLine("Basic while loop");
            // while (inpustring != "exit")
            // {
            //     inpustring = Console.ReadLine();
            //     Console.WriteLine("You entered: {0}", inpustring);
            //     Console.WriteLine("Type exit to quit");
            //     if (inpustring == "exit")
            //         Environment.Exit(0); 
            // }

            // do while loop
            do
            {inpustring = Console.ReadLine();
                Console.WriteLine("You entered: {0}", inpustring);
                Console.WriteLine("Type exit to quit or else continue to input strings");
                if (inpustring == "exit")
                    Environment.Exit(0);
            }while (inpustring != "exit");
        }
    }
}