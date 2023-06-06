using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData ("nursesrun", true)]
        [InlineData ("lemel", true )]
        [InlineData ("fork", false)]
        [InlineData("apple", false)]

        public void MyTest(string word, bool expected)
        {
            var test = new WordSmith();

            bool actual = test.IsAPalindrome(word);

            Assert.Equal(expected, actual);

        }
    }
}
