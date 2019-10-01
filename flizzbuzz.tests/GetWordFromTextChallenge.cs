using System;
using Xunit;

namespace flizzbuzz.tests
{
    public class WordFromTextChallengeTests
    {
        [Theory]
        [InlineData("one two three", 2, "two")]
        [InlineData("one;two three        ", 2, "three")]
        [InlineData("     one;two three", 2, "three")]
        [InlineData("     one;two three      ", 2, "three")]
        [InlineData("one", 1, "one")]
        [InlineData("one       ", 1, "one")]
        [InlineData("     one", 1, "one")]
        [InlineData("     one     ", 1, "one")]
        public void GetWordFromText_ReturnsWordFromPos(string input, int pos, string expected)
        {
            //given
            var chall = new WordFromTextChallenge();

            //when
            var result = chall.GetWordFromText(input, pos);

            //then
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("one two three", -1)]
        [InlineData("one;two three", 5)]
        public void GetWordFromText_Throws(string input, int pos)
        {
            //given
            var chall = new WordFromTextChallenge();
            //when
            //then
            Assert.Throws<Exception>(() => chall.GetWordFromText(input, pos)); 
            
        }
    }
}
