using System;
namespace Interpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            string make = "Mercedes-Benz";
            string model = "S Class";
            int year = 2020;
            float miles = 8_450.27f;
            decimal price = 60_275.0m;

            // Output information using formatting
            // Console.WriteLine("This car is a {0} {1} {2}, with {3} miles and costs {4}",
            // year, make, model, miles, price);

            // using string interpolation
            Console.WriteLine($"This car is a {year} {make} {model} , with {miles} miles and costs {price:C2}");

        }
    }
}