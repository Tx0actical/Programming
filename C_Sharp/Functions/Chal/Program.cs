using System;
using System.Text.RegularExpressions; // for using regex
using System.Text; // for using stringbuilder

namespace Palindrome
{
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Let's begin:");
            x : string InputString = Console.ReadLine();

            if (InputString != "!exit") {
                (bool, int) result = IsPalindrome(InputString);
                Console.WriteLine($"Palindrome: {result.Item1}, Length: {result.Item2}");
            }

            else if(InputString == "!exit")
                Environment.Exit(0);
            else
                goto x;
        }
        static (bool, int) IsPalindrome (string _instr) {
            bool CheckPalindrome = false;
            string _reversestr = string.Empty;

            // Function to remove punctuation
            _instr = RemovePunctuation (_instr);
            // Function to remove spaces
            _instr = Regex.Replace(_instr, @"s", "" );
            // Function to convert upper to lower case
            _instr = _instr.ToLower(); // *********Not converting to lowercase*******

            if(_instr != null) {
                for (int i = _instr.Length - 1; i >= 0; i--) {
                    _reversestr += _instr[i].ToString();
                }
                if (_reversestr == _instr)
                    CheckPalindrome = true;
                return (CheckPalindrome, _reversestr.Length);
            }
            else
                return (CheckPalindrome, _reversestr.Length);
        }

        static string RemovePunctuation (string _instr) {
            
            var sb = new StringBuilder();

            foreach (char c in _instr) {
            if (!char.IsPunctuation(c))
                sb.Append(c);
            }
            _instr = sb.ToString();

            Console.WriteLine(_instr);
            return _instr;
            }
    }
}