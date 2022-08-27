using System;
namespace BaicEvents {
    public delegate void MyEventHandler(string value);
        
        class EventPublisher {
            private string _value;
            
            // declaring event
            public event MyEventHandler _valuechanged;
            public string val {
                set {
                    this._value = value;
                    this._valuechanged(_value);
                }
            }
        }
    class Program {
        static void Main(string[] args) {
            EventPublisher pub = new EventPublisher();
            // pub._valuechanged += new MyEventHandler(ObjectValueChanged);

            // to use an anonymous delegate as an event handler
            pub._valuechanged += delegate(string val) {
                Console.WriteLine("The value changed to {0}", val);
            };

            string str;
            do {
                Console.WriteLine("Enter a value: ");
                str = Console.ReadLine();
                if(!str.Equals("exit"))
                    pub.val = str;
            }while(str != "exit");
            Console.WriteLine("Have a nice day!");
        }
        // this funciton will run whenever value changed event triggers
        static void ObjectValueChanged(string value) {
            Console.WriteLine($"The value changed to {value}");
        }
    }
}