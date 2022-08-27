using System;

namespace Challenge2 {
    class Deposit {
        public delegate void DepositGoalReachedEvent_Handler(string value);
        private string _input;
        // public event EventHandler<DepositGoalReachedEvent> DepositEvent;
        public event DepositGoalReachedEvent_Handler GoalReached;
        public string DepositProperty {
            set {
                // this.DepositEvent(this, new DepositGoalReachedEvent() {
                //     UpdatedDeposit = "DepositProperty"
                // });
                this._input = value;
                this.GoalReached(_input);
            }
        }
    }
    // public class DepositGoalReachedEvent : EventArgs {
    //     public string UpdatedDeposit;
    // }
    class Program {
        static void Main(string[] args) {
            Deposit deposit_object = new Deposit();
            string input;
            string CurrentBalance, UpdatedBalance;
            do {
                Console.WriteLine("How much to deposit?");
                input = Console.ReadLine();
                CurrentBalance = input;
                if(!input.Equals("exit")) {

                    deposit_object.DepositProperty = input;
                    UpdatedBalance = CurrentBalance + input;
                    Console.WriteLine($"The balance amount is {UpdatedBalance}");
                    // deposit_object.DepositEvent += delegate(object sender, DepositGoalReachedEvent arg) {
            //     Console.WriteLine("You reached your savings goal! You have {0}", arg.Equals);
            // };
                    if (UpdatedBalance == "500") {
                    static void Listener1(string value) {
                            Console.WriteLine("You reached your savings goal! You have {0}", value);
                        }
                    }
                }
            } while(!input.Equals("exit"));
        }
    }
}