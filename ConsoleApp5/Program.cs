// See https://aka.ms/new-console-template for more information

using System; // =import
using ClassLib;

namespace ConsoleApp5; // ~package

public class Program // public class need not match filename, need not be public
{
    public static void Main(string[] args) // UpperCamelCase
    {
        int a = Utilities.NumberPrompt(), 
            b = Utilities.NumberPrompt();
 
        Console.WriteLine("Hello, World!" + Utilities.Add(a,b));
    }
}