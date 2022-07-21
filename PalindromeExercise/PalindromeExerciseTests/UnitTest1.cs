using System;
using Xunit;
using PalindromeExercise;
namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("civic", true)]
        [InlineData("madam", true)]
        [InlineData("chicken", false)]
        [InlineData("refer", true)]

        public void Tester(string word, bool expected)
        {
        //Arrange
        var wordSmith = new WordSmith();

        //act
        var actual = wordSmith.IsPalindrome(word);

        //assert
        Assert.Equal(expected, actual);
        }
    }
}
