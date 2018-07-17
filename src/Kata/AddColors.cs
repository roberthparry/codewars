using System.Collections.Generic;
using System.Linq;

namespace Kata
{
	public static class AddColors
    {
        private static string[] _colors = new string[]
        {
            "Blue", "Green", "Cyan", "Red", "Magenta", "Yellow", "White"
        };

        private static Dictionary<string, int> _wordLookup = Enumerable.Range(1, 7).ToDictionary(n => _colors[n - 1], n => n);

        public static string AdditiveColors(string input)
        {
            int colorMix = 0;
            foreach (string color in input.Split(',').Select(s => s.Trim()).ToArray())
                colorMix |= _wordLookup[color];

			return _colors[colorMix - 1];
        }
    }
}
