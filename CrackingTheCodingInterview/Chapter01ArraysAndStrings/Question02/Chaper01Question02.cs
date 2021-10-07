using System;
using System.Collections.Generic;
using System.Linq;

namespace CrackingTheCodingInterview.Chapter1ArraysAndStrings.Question1
{
    public static class Chaper01Question02
    {
		//I missunderstood the problem
		//public static object Solution1(string strA, string strB)
		//{
		//	strA = strA.ToLower();
		//	strB = strB.ToLower();
		//	for (int i = 0; i < strB.Length; i++)
		//	{
		//		if (strA == strB)
		//		{
		//			return true;
		//		}

		//		char tmp = strB[0];
		//		strB = strB.Remove(0,1);
		//		strB += tmp;
		//	}

		//	return false;
		//}


		//No library
		public static bool Solution1(string strA, string strB)
		{
			// O(n)
			strA = strA.ToLower();
			strB = strB.ToLower();
			if (strA.Length != strB.Length)
				return false;

			var counter = new int[256];
			for (int i = 0; i < strA.Length; i++)
			{
				counter[strA[i]]++;
				counter[strB[i]]--;
			}

			for (int i = 0; i < counter.Length; i++)
			{
				if (counter[i] != 0)
					return false;
			}

			return true;
		}

		//HashMap → Maybe optimize space
		public static bool Solution2(string strA, string strB)
		{
			strA = strA.ToLower();
			strB = strB.ToLower();
			if (strA.Length != strB.Length)
				return false;

			var dict = new Dictionary<char, int>();
			for (int i = 0; i < strA.Length; i++)
			{
				if (!dict.ContainsKey(strA[i]))
				{
					dict.Add(strA[i], 0);
				}
				if (!dict.ContainsKey(strB[i]))
				{
					dict.Add(strB[i], 0);
				}
				dict[strA[i]]++;
				dict[strB[i]]--;
			}

			for (int i = 0; i < dict.Count; i++)
			{
				if (dict.ElementAt(i).Value != 0)
					return false;
			}

			return true;
		}

		//HashMap → Maybe optimize+ O(n)
		public static bool Solution3(string strA, string strB)
		{
			strA = strA.ToLower();
			strB = strB.ToLower();
			if (strA.Length != strB.Length)
				return false;

			var dict = new Dictionary<char, int>();
			for (int i = 0; i < strA.Length; i++)
			{
				if (!dict.ContainsKey(strA[i]))
					dict.Add(strA[i], 0);

				if (!dict.ContainsKey(strB[i]))
					dict.Add(strB[i], 0);

				dict[strA[i]]++;
				dict[strB[i]]--;

				if (dict[strB[i]] == 0)
					dict.Remove(strB[i]); //This is taking more than expected

				if (dict[strA[i]] == 0)
					dict.Remove(strA[i]);
			}

			return dict.Count == 0;
		}

		//Sort → Maybe optimize+ O(n)
		public static bool Solution4(string strA, string strB)
		{
			if (strA.Length != strB.Length)
				return false;

			var arrA = strA.ToLower().ToCharArray();
			var arrB = strB.ToLower().ToCharArray();

			Array.Sort(arrA);
			Array.Sort(arrB);

			var dict = new Dictionary<char, int>();
			for (int i = 0; i < arrA.Length; i++)
			{
				if (arrA[i] != arrB[i])
					return false;
			}

			return true;
		}
	}
}
