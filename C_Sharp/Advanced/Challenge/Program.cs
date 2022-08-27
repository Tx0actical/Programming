using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeSolution
{
    public class Shipping
    {

        // declare the delegate type used to calculate the fees
        public delegate void ShippingFeeDelegate(decimal thePrice, ref decimal fee);

        // base class used as a foundation for each of the destination zones
        abstract class ShippingDestination
        {
            public bool m_IsHighRisk;
            public virtual void calcFees(decimal price, ref decimal fee) { }

            // this static method returns an actual ShippingDestination object
            // given the name of the destination, or null if none exists
            public static ShippingDestination GetDesinationInfo(string destination)
            {
                if (destination.Equals("zone1"))
                    return new Dest_zone1();
                if (destination.Equals("zone2"))
                    return new Dest_zone2();
                if (destination.Equals("zone3"))
                    return new Dest_zone3();
                if (destination.Equals("zone4"))
                    return new Dest_zone4();

                return null;
            }

            // defining implementation of classes for each of the real shipping
            // destinations. We can add as many as we like as the need arises
            class Dest_zone1 : ShippingDestination
            {
                public Dest_zone1()
                {
                    this.m_IsHighRisk = false;
                }
                public override void calcFees(decimal price, ref decimal fee)
                {
                    fee = price * 0.25m;
                }
            }
            class Dest_zone2 : ShippingDestination
            {
                public Dest_zone2()
                {
                    this.m_IsHighRisk = true;
                }
                public override void calcFees(decimal price, ref decimal fee)
                {
                    fee = price * 0.12m;
                }
            }
            class Dest_zone3 : ShippingDestination
            {
                public Dest_zone3()
                {
                    this.m_IsHighRisk = false;
                }
                public override void calcFees(decimal price, ref decimal fee)
                {
                    fee = price * 0.08m;
                }
            }
            class Dest_zone4 : ShippingDestination
            {
                public Dest_zone4()
                {
                    this.m_IsHighRisk = true;
                }
                public override void calcFees(decimal price, ref decimal fee)
                {
                    fee = price * 0.04m;
                }
            }
        }
        static void Main(string[] args)
        {
            ShippingFeeDelegate theDel;
            ShippingDestination theDest;
            string theZone;

            do
            {
                // get destination zone
                Console.WriteLine("What is the destination zone?");
                theZone = Console.ReadLine();

                if (!theZone.Equals == "exit")
                {
                    // given the zone, retrive the associated shipping info
                    theDest = ShippingDestination.GetDestinationInfo(theZone);
                    if (theDest != null)
                    {
                        // ask for the price and convert the string to a decimal number
                        Console.WriteLine("What is the item price?");
                        string thePriceStr = Console.ReadLine();
                        decimal itemPrice = decimal.Parse(thePriceStr);

                        // each ShippingDestination object has a function called calcFees
                        // use that as the delegate for calculating the fee
                        theDel = theDest.calcFees;

                        // for high-risk zones, we track on the delegate that adds more cost
                        if (theDest.m_IsHighRisk)
                        {
                            theDel += delegate (decimal thePrice, ref decimal itemFee)
                            {
                                itemFee += 25.0m;
                            };
                        }

                        // call the delegate and output the shipping fee to the console
                        decimal theFee = 0.0m;
                        theDel(itemPrice, ref theFee);
                        Console.WriteLine("The shipping fees are: {0}", theFee);
                    }
                    else
                    {
                        Console.WriteLine("Looks like you have entered an unknown destination!");
                    }
                }
            } while (theZone != "exit");
        }
    }
}