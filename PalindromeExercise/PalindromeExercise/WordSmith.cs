using System;
using System.Linq;

namespace PalindromeExercise;

public class WordSmith
{
    public bool IsPalindrome(string word)
    {
        string reversedString = "";
        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversedString += word[i];
        }

        if (reversedString == word)
        {
            return true;
        }
        return false;
    }
}