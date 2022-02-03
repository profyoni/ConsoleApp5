namespace ClassLib
{
    public class Utilities
    {
        public static int NumberPrompt()
        {
            Console.WriteLine("Enter a number");
            var s = Console.ReadLine();
            return Int32.Parse(s??"0");
        }

        public static int Add(params int[] list) // var args
        {
            int total = 0;
            foreach (int val in list)
            {
                total += val;
            }
            return total;
        }

        public static void Swap(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;

        }

        public static void PassOut(out int x, out int y)
        {
            x = 3;
            y = 4;
        }

        public static (int, double, string) MultiType(int a)
        {
            return (a, (double)a, "" + a);
        }
    }
}