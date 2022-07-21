using System;
namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith()
        {
        }

        public bool IsPalindrome(string word)
        {
            var reverse = "";

            for (int i = word.Length -1; i >= 0; i--)
            {
                reverse += word.ToLower()[i];
            }
            return reverse != word.ToLower() ? false : true;
        }
    }
}

