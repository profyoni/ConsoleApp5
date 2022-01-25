namespace ClassLib
{
    public class Utilities
    {
        public static int NumberPrompt()
        {
            Console.WriteLine("Enter a number");
            String s = Console.ReadLine();
            return Int32.Parse(s);
        }

        public static int Add(params int[] list) 
        {
            int total = 0;
            foreach (int val in list)
            {
                total += val;
            }
            return total;
        }


    }
}