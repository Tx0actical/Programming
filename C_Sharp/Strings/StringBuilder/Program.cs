using System;
using System.Text;

namespace stringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            int jumpCount = 10;
            string[] animals = {"goats", "cats", "pigs"};

            // creating a stringBuilder
            StringBuilder sb = new StringBuilder("Initial String\n", 200);

            // print basic stats about the stringBuilder
            Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");

            // Add some strings to the builder using Append
            sb.Append("The quick brown fox");
            sb.Append(" jumped over the lazy dog\n");

            // Appendline can be used to append formatted stirngs
            sb.AppendLine();

            // AppendFormat can be used to append formatted strings
            sb.AppendFormat("He did this {0} times", jumpCount);
            sb.AppendLine();

            // AppendJoin can iterate over a set of values
            sb.Append("He also jumped over ");
            sb.AppendJoin(',', animals);

            // Modify the content using replace
            sb.Replace("fox", "cat");

            // Insert string content
            sb.Insert(0, "This is the ");

            // Convert to a single string
            Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");
            Console.WriteLine(sb.ToString());

        }
    }
}