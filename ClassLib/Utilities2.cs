using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public delegate double MathFunction(double d); // delegate type
    public delegate double MathFunction2(double a, double b);

    public  class Utilities2
    {
        public static IEnumerable<int> Range(int min, int max)
        {
            for (int i = min; i < max; i++)
                yield return i;
        }

        // Requires the construction of a full list of elts
        public static List<int> RangeList(int min, int max)
        {
            var ret = new List<int>();
            for (int i=min;i<max;i++)
                ret.Add(i);
            return ret;
        }

        public static void Transform(List<double> list, MathFunction myMethod)
        {
            for (int i = 0; i < list.Count; i++)
                list[i] = myMethod(list[i]);
        }
        public static void Transform(List<double> list, MathFunction2 myMethod)
        {
            for (int i = 0; i < list.Count; i++)
                list[i] = myMethod(list[i],2);
        }
    }
}
