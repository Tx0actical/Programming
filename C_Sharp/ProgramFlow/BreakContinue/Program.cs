using System;

namespace BreakContinue
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] array = {15, 7, 12, 23, 41, 28, 9, 17, 36};
            Console.WriteLine("Using Break and Continue statements ->");
            
            foreach (int value in array)
            {
                // if (value >= 20 && value <29)
                //     continue;
                // Console.WriteLine($"Value is currently {value}");
                if (value >= 40)
                    break;
                Console.WriteLine($"Value is currently {value}"); //Console.WriteLine("Value is currently {0}", value);
            }
        }
    }
}