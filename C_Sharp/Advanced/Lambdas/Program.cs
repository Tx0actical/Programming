using System;

namespace Lambdas {
    // define a few delegates
    public delegate int MyDelegate(int x);
    public delegate void MyDelegate2(int x, string prefix);
    public delegate bool ExpressionDelegate(int x);

    class Program {
        // static void Main(string[] args) {
        //     // basic delegate that squares a number
        //     MyDelegate d1 = (x) => x * x;
        //     Console.WriteLine("The value of d1 is: {0}", d1(5));
            
        //     // this can be dynamically changed
        //     d1 = (x) => x * 10;
        //     Console.WriteLine("The value of d1 is: {0}", d1(5));

        //     // create a delegate that takes multiple arguments
        //     MyDelegate2 d2 = (x, y) => {
        //         Console.WriteLine("The two argument Lambda: {1} {0}", x * 10, "string");
        //     };
        //     d2(25, "Some string");

        //     // Defining an expression delegate
        //     ExpressionDelegate d3 = (x) => x > 10;
        //     Console.WriteLine("Calling d3 with 5: {0}", d3(5));
        //     Console.WriteLine("Calling d3 with 15: {0}", d3(15));
        // }
    }
}

namespace LambdaDelegates {
    // define a delegate
    public delegate void myEventHandler(string value);

    class MyClass {
        private string theVal;
        public event myEventHandler valuechanged;

        public string Val {
            set {
                this.theVal = value;
                this.valuechanged(theVal);
            }
        }
    }
    class Program {
        static void Main(string[] args) {
            MyClass obj = new MyClass();

            // using Lambda expression to define an event handler
            // this statement is a lambda, due to use of {}
            obj.valuechanged += (x) => {
                Console.WriteLine("This value changed to {0}", x);
            };

            string str;
            do {
                str = Console.ReadLine();
                if(!str.Equals("exit"))
                obj.Val = str;
            } while (!str.Equals("exit"));

            Console.WriteLine("Goodbye!");
        }
    }
}