using System;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string outstr;
            string str1 = "The quick brown fox jumps over the lazy dog";
            string str2 = "This is a string";
            string str3 = "This is a STRING";
            string[] strs = {"one", "two", "three", "four", "five"};

            // length of a string
            Console.WriteLine(str1.Length);

            // access individual characters
            Console.WriteLine(str1[5]);

            // iterate over strings using loops
            foreach (char c in str1)
            {
                Console.Write(c);
                if (c == 'b')
                {
                    Console.WriteLine();
                    break;
                }
            }

            // string concatenation
            outstr = string.Concat(strs);
            Console.WriteLine(outstr);

            // join strings using join
            outstr = string.Join(' ', strs);
            Console.WriteLine(outstr);

            // string comparison
            // Compare will perform an ordinal comparison and return:
            // < 0 : first string comes before second in sort order
            // = 0 : first and second strings are same position in sort order
            // > 0 : first string comes after the second in sort order
            int result = string.Compare(str2, "This is a string");
            Console.WriteLine(result);

            // Equals just returns a regulat boolean
            bool isEqual = str2.Equals(str3);
            Console.WriteLine(isEqual);

            // string searching
            Console.WriteLine(str1.IndexOf('e'));
            Console.WriteLine(str1.IndexOf("fox"));

            Console.WriteLine(str1.LastIndexOf('e'));
            Console.WriteLine(str1.LastIndexOf("the"));

            outstr = str1.Replace("fox", "cat");
            Console.WriteLine(outstr);
            Console.WriteLine(outstr.IndexOf("fox"));
        }
    } 
}