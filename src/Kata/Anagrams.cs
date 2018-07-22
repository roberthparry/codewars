using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Kata
{
	public static class Anagrams
    {
        private static long[] primes = new long[] {
            2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41,
            43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101
        };

        public static List<string> FindAnagrams(string word, List<string> words)
        {
            var dict = word.Distinct()
			               .Select((ch, i) => new { Key = char.ToLower(ch), Value = primes[i] })
			               .ToDictionary(o => o.Key, o => o.Value);
			BigInteger encodedWord = Encode(word, dict);
			return words.Where(w => Encode(w, dict) == encodedWord).ToList();
        }

        private static BigInteger Encode(string word, Dictionary<char, long> primeLookup)
        {
            var encoded = new BigInteger(1);
            foreach (char ch in word)
            {
				long code;
				if (!primeLookup.TryGetValue(char.ToLower(ch), out code))
					return new BigInteger(-1);
				
                encoded *= code;
            }
            return encoded;
        }
    }	
}
