// See https://aka.ms/new-console-template for more information

using System; // =import
using ClassLib;
using Humanizer;

namespace ConsoleApp5; // ~package

public class Program // public class need not match filename, need not be public
{
    public static void Main(string[] args) // UpperCamelCase
    {
        int a = Utilities.NumberPrompt(), 
            b = Utilities.NumberPrompt();
 
        Console.WriteLine($"{a.ToWords()} + {b.ToRoman(),7} = {Utilities.Add(a,b).ToOrdinalWords(), -10}"); // string interpolation
    }
}