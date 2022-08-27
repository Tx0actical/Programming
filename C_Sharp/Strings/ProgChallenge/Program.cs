using System;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random Number between 0 to 20
            int Number = new Random().Next(20);

            // Game greetings and instructions
            Console.WriteLine("Let's Play 'Guess the Number'");
            Console.WriteLine("I'm thinking of a number between 0 and 20");

            int ParsedInput, GuessCount = 0;
            bool KeepGoing = true;

            do
            {
                Console.WriteLine("Enter your guess, or -1 to give up");
                string UserGuess = Console.ReadLine();
                try
                {
                    bool Result = Int32.TryParse(UserGuess, out ParsedInput);

                    if (ParsedInput == -1)
                    {
                        Console.WriteLine($"No worries! The number was {Number}");
                        KeepGoing = false;
                    }

                    else if (Result)
                    {
                        GuessCount++;
                        if (ParsedInput == Number)
                            Console.WriteLine($"Congrats! You got it in {++GuessCount} try!");

                        else
                        {
                            Console.WriteLine("The number is, {0} than that", ParsedInput < Number ? "higher" : "lower");
                        }
                    }
                    else
                    {
                        throw new ArgumentException("UserInput", "Hm, that doesn't kook like a number");
                    }
                }
                catch
                {
                    Console.WriteLine("Enter a valid number");
                }
            } while (KeepGoing);
        }
    }
}