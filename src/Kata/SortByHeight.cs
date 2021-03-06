using System.Linq;

namespace Kata
{
    using System;
    
    public class SortedByHeight
    {
        public int[] SortByHeight(int[] a)
        {
            int[] heightsOnly = a.Where(e => e != -1).ToArray();
            Array.Sort(heightsOnly);
            for (int i = 0, j = 0; i < a.Length; i++)
                if (a[i] != -1) a[i] = heightsOnly[j++];

            return a;
        }
    }
}