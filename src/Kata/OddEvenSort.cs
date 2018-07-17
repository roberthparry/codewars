using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class OddEvenSort
    {
        public static string SortMyString(string s)
        {
            IEnumerable<int> indices = Enumerable.Range(1, s.Length);
            var evens = indices.Where(i => (i % 2) == 0).Select(i => s[i - 1]);
            var odds = indices.Where(i => (i % 2) != 0).Select(i => s[i - 1]);
            return $"{new string(odds.ToArray())} {new string(evens.ToArray())}";
        }
    }
}
