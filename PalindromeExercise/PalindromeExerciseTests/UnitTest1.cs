using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true )]
        [InlineData("hello", false )]
        [InlineData("noon", true )]
        [InlineData("false",  false )]
        [InlineData("civic", true)]
        public void IsPalindromeTest(string word, bool expected)
        {
            //Arrange
            var palindromeTester = new WordSmith();
            
            //Actual
            bool actual = palindromeTester.IsPalindrome(word);
            
            //Assert
            Assert.Equal(expected, actual);
            

        }
    }
}
