// See https://aka.ms/new-console-template for more information

using System; // =import
using ClassLib;
using Humanizer;

namespace ConsoleApp5; // ~package

public class Program // public class need not match filename, need not be public
{
   
    public static void Main(string[] args) // UpperCamelCase
    {
        bool rePrompt;

        do
        {
            int a = Utilities.NumberPrompt(),
                b = Utilities.NumberPrompt();

            try
            {
                //Console.WriteLine($"{a.ToWords()} + {b.ToRoman(),7} = {Utilities.Add(a,b).ToOrdinalWords(), -10}"); // string interpolation

                var f = new Fraction(a, b);

                rePrompt = false;
            }
            catch (ArgumentException ae)
            {
                rePrompt = true;
                throw;
            }
        } while (rePrompt);
    }
}