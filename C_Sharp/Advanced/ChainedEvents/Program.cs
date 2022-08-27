using System;

namespace ChainedEvents {
    public delegate void myEventHandler(string value);
    class EventBroadcaster {
        private string theVal;
        // declare event handler
        public event myEventHandler valueChanged;
        // use the EventArgs class
        public event EventHandler<ObjectValueChangedEvent> MyEvent;

        public string Val {
            set {
                this.theVal = value;
                // when value changes fire up the event handler
                this.valueChanged(theVal);
                // use the custom event handler
                this.MyEvent(this, new ObjectValueChangedEvent() {
                    PropertyChanged = "Val"
                });
            }
        }
    }
    public class ObjectValueChangedEvent : EventArgs {
            public string PropertyChanged;
        }
    class Program {
            static void Main(string[] args) {
            EventBroadcaster obj = new EventBroadcaster();

            // connect multiple event handlers
            obj.valueChanged += new myEventHandler(Listener1);
            obj.valueChanged += new myEventHandler(Listener2);

            // use anonymous delegates as the event handler
            obj.valueChanged += delegate(string s) {
                Console.WriteLine("This came from anonymous handler");
            };

            // listen for custom event defined with EventArgs
            obj.MyEvent += delegate(object sender, ObjectValueChangedEvent e) {
                Console.WriteLine("{0} had the {1} property changed", sender.GetType(), e.PropertyChanged);
            };

            string str;
            do {
                Console.WriteLine("Enter a value");
                str = Console.ReadLine();
                if(!str.Equals("exit"))
                    obj.Val = str;
            }while(str != "exit");
            Console.WriteLine("Goodbye!");
        }
        static void Listener1(string value) {
            Console.WriteLine("The value changed to {0}", value);
        }
        static void Listener2(string value) {
            Console.WriteLine("I also listened to the event, and got {0}", value);
        }
    }
}