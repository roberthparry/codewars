using System;
using System.Collections.Generic;

namespace Kata
{
    public class RomanDecode
    {
        private static Dictionary<char, int> _charValue = new Dictionary<char, int> {
        {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
    };

        public static int Solution(string roman)
        {
            int result = 0;
            int i = 0;
            while (i < roman.Length)
            {
                int value1 = _charValue[roman[i]];

                if (i + 1 < roman.Length)
                {
                    int value2 = _charValue[roman[i + 1]];

                    if (value1 >= value2)
                    {
                        result += value1;
                    }
                    else
                    {
                        result += value2 - value1;
                        i++;
                    }
                }
                else
                {
                    result += value1;
                    i++;
                }
                i++;
            }
            return result;
        }
    }  
}
