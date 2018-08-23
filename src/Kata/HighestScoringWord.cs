using System.Linq;

namespace Kata
{
	public static class HighestScoringWord
	{
		public static string HighSimple(string s)
		{
			int maxScorePos = -1;
			int maxScore = -1;
			string[] words = s.Split(' ');
			for (int i = 0; i < words.Length; i++)
			{
				string word = words[i];
				int score = word.Select(ch => (int)(ch - 'a')).Sum();
				if (score > maxScore)
				{
					maxScore = score;
					maxScorePos = i;
				}
			}
			return words[maxScorePos];
		}

		private static int Score(string s) => s.Select(e => e - 96).Sum();
        public static string High(string s) => s.Split(' ').Aggregate((r, e) => Score(r) < Score(e) ? e : r);
	}
}
