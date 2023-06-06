using System;

namespace PalindromeExercise
{
	public class WordSmith
	{
		public bool IsAPalindrome(string word)
		{
			var reversed = "";

			for (int i = word.Length - 1; i >= 0; i--)
			{
				reversed += word[i];
			}

			// Compare the priginal woprd with the reversed...
			// return whether they are the same or not

			if (reversed == word)
			{
				return true;
			}
			else
			{
				return false;
			}

		}
	}
	
}

