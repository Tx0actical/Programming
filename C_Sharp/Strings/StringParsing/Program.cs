using System;
using System.Globalization;

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string numstr1 = "1";
            string numstr2 = "2.00";
            string numstr3 = "3,000";
            string numstr4 = "3,000.00";

            // The Parse Function attempts to parse a string into a
            // number but it might throw an exception, so we need to catch that
            int targetNum = 0;
            try
            {
                // Use Parse to try a simple integer
                targetNum = int.Parse(numstr1);
                Console.WriteLine(targetNum);
                
                // use Parse to try a floating point number
                // only works if the decimal value is zero
                targetNum = int.Parse(numstr2, NumberStyles.Float);
                Console.WriteLine(targetNum);

                // try a number with a thousands marker
                targetNum = int.Parse(numstr3, NumberStyles.AllowThousands);
                Console.WriteLine(targetNum);

                // Try with a number with a thousands and decimal marker
                targetNum = int.Parse(numstr4, NumberStyles.Float | NumberStyles.AllowThousands);
                Console.WriteLine(targetNum);

                // Works with other types as well
                Console.WriteLine($"{bool.Parse("True")}");

                // or floating point numbers
                Console.WriteLine($"{float.Parse("1.235"):F2}");
            }
            catch
            {
                Console.WriteLine("Conversion Failed");
            }

            // TryParse function
            bool succedded = false;
            succedded = Int32.TryParse(numstr1, out targetNum);
            if (succedded)
                Console.WriteLine($"{targetNum}");
        }
    }
}