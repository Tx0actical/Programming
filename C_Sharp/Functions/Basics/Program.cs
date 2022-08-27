using System;

// Functions can provide defeault values for their parameters
void PrintWithPrefix(string thestr, string prefix="") // This is the default string used as prefix
{
    Console.WriteLine($"{prefix} {thestr}");
}

// Test the default value
PrintWithPrefix("Hello World!");
PrintWithPrefix("Hello World!", ">: ");

// calling named params
PrintWithPrefix(prefix: "** ", thestr: "Hello!");