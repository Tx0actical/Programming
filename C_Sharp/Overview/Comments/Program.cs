using System;

namespace Comments
{
    class Program
    {
        /// <summary>
        /// Descripton of main function
        /// </summary>
        /// <param name='args'> An array of string arguments from the command line</param>
        /// <return>There is no return value</return>
        static void Main(string[] args)
        {
            // single line comments start with two slashes
            Console.WriteLine("Hello world");
            /* This is a multi-line comment
            start with a slash and a star and can continue till multiple lines*/

            /// Three forward slashes means an XML comment
            /// They use a special syntax 
        }
    }
}