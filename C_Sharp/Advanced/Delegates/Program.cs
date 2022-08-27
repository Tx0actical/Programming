using System;

namespace Delegate {
    // declaring delegate type
    // public delegate string MyDelegate(int arg1, int arg2);

    class MyClass {
        public string instanceMethod1(int arg1, int arg2) {
            return((arg1 + arg2) * arg1).ToString();
        }
    }
    class Program {
        // creating functions to serve as delegate implementation
        // static string function1(int a, int b) {
        //         return (a + b).ToString();
        //     }
        // static string function2(int a, int b) {
        //     return (a * b).ToString();
        // }
        // public static void Main(string[] args) {
        //     // exercise each delegate function
        //     MyDelegate f = function1;
        //     Console.WriteLine("The number from function1 is: " + f(10, 20));
        //     f = function2;
        //     Console.WriteLine("The number from function2 is: " + f(10, 20));

        //     // using an instance function of a class as a delegate
        //     MyClass mc = new MyClass();
        //     f = mc.instanceMethod1;
        //     Console.WriteLine("The number from instanceMethod1 is: " + f(10, 10));
        // }
    }
}

namespace AnonymousDelegates {
    public delegate string MyDelegate(int arg1, int arg2);
    class Program {
        // static void Main(string[] args) {
        //     // Implementing anonymous delegates
        //     MyDelegate f = delegate(int arg1, int arg2) {
        //         return (arg1 + arg2).ToString();
        //     };
        //     Console.WriteLine("The result is " + f(10, 20));
        // }
    }
}

namespace ComposableDelgates {
    public delegate string MyDelegate(int arg1, ref int arg2);
    class Program {
        static string function1(int arg1, ref int arg2) {
            int result = arg1 + arg2;
            arg2 += 20;
            Console.WriteLine("The number from function1 is: ");
            return result.ToString();
        }
        static string function2(int arg1, ref int arg2) {
            int result = arg1 * arg2;
            Console.WriteLine("The number from function2 is: " + result);
            return result.ToString();
        }
        static void Main(string[] args) {
            MyDelegate f1 = function1;
            MyDelegate f2 = function2;
            // Composed delegate from f1 and f2
            MyDelegate f1f2 = f1 + f2;

            int a = 10;
            int b = 20;

            Console.WriteLine("Calling first delegate");
            f1(a, ref b);
            Console.WriteLine("Calling second delegate");
            f2(a, ref b);
            Console.WriteLine("\nCalling chained delegates");
            f1f2(a, ref b);

            // Subtracting delegates
            f1f2 -= f1;
            Console.WriteLine("\nCalling unchained delegates");
            f1f2(b, ref b);
        }
    }
}