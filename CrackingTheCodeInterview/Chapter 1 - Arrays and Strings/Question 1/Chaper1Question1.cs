using System.Collections.Generic;

namespace CrackingTheCodeInterview.Chapter_1___Arrays_and_Strings.Question_1
{
    public static class Chaper1Question1
	{
		public static bool Solution1HashSet(string text)
		{
			if (text.Length > char.MaxValue)
				return false;

			HashSet<char> characters = new HashSet<char>();
			for (int i = 0; i < text.Length; i++)
			{
				char character = text[i];
				if (characters.Contains(character))
					return false;

				characters.Add(character);
			}

			return true;
		}

		public static bool Solution2BoolList(string text)
		{
			if (text.Length > char.MaxValue)
				return false;

			bool[] characters = new bool[char.MaxValue+1];
			for (int i = 0; i < text.Length; i++)
			{
				int charIndex = (int)text[i];
				if (characters[charIndex])
					return false;

				characters[charIndex] = true;
			}

			return true;
		}

		public static bool Solution3NoAdditionalStructure(string text)
		{
			if (text.Length > char.MaxValue)
				return false;

			for (int i = 0; i < text.Length; i++)
			{
				for (int j = i + 1; j < text.Length; j++)
				{
					if (text[i] == text[j])
						return false;
				}
			}

			return true;
		}
	}
}
