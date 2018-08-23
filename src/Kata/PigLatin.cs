using System.Linq;

namespace Kata
{
	public static class PigLatin
	{
		public static string PigIt(string str) => string.Join(" ", str.Split(' ').Select(Oink));

		private static string Oink(string word) => $"{word.Substring(1)}{word[0]}ay";
	}
}
