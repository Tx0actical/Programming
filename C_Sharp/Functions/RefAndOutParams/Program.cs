using System;

namespace RefAndOutParams
{
    class Program
    {
        // Ordinary arguments cannot be modified by the function
        // because they are a copy of the original value

        static void TestFun1(int arg1)
        {
            arg1 += 10;
            Console.WriteLine($"{arg1}");
        }

        // arguments passed by reference can be modified
        // by the function and reflected back to the caller
        static void TestFun2(ref int arg1)
        {
            arg1 += 10;
            Console.WriteLine($"{arg1}");
        }
        static void Arithmetic(int arg1, int arg2, out int sum, out int product) {
                sum = arg1 + arg2;
                product = arg1 * arg2;                
        }


        static void Main(string[] args) {
            int val1 = 10;
            int val2 = 20;

            // Functions don't modify value arguments
            TestFun1(val1);
            Console.WriteLine($"{val1}");

            // using 'ref' keyword, arguments can be passed by reference
            // this allows the function to modify them
            TestFun2(ref val1);
            Console.WriteLine($"{val1}");

            // 'out' keyword means that the parameter returns a value
            // instead of supplying data to the function
            // this enables function to return multiple values
            int a, b;
            Arithmetic(val1, val2, out a, out b);
            Console.WriteLine($"{a}, {b}");
        }
    }
}