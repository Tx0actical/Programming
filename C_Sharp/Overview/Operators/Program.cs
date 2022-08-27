using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Decalre some variables
            int x = 10, y = 5;
            string a = "abcd", b="efgh";

            Console.WriteLine("***********Basic Math************");
            Console.WriteLine((x / y) * x);
            Console.WriteLine(a + b);

            Console.WriteLine ("***********Shorthand************");
            x++;
            y--;
            Console.WriteLine(x);
            Console.WriteLine(y);

            a +=b; // strings can be added using math operators
            Console.WriteLine(a); // update the value of a to a+b

            // Logical operators
            Console.WriteLine(x > y && y>=5);
            Console.WriteLine(x > y || y>=5);

            // null coalescing operators
            string str = "not null";
            // ?? uses the left operator if not null, or the right one if it is
            Console.WriteLine(str ?? "UnknownString");
            // ??= assigns the right operand if the left one is null
            Console.WriteLine(str ??= "KnownString");
            
            
        }
    }
}