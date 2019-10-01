using Xunit;

namespace flizzbuzz.tests
{
    public class ReverseMethodChallengeTests
    {
        [Theory]
        [InlineData("one", "eno")]
        [InlineData("abcd", "dcba")]
        [InlineData("", "")]
        [InlineData(null, "")]
        public void Reverse_GetsRevertedStringCorrectly(string input, string expected)
        {
            //given
            var chall = new ReverseMethodChallenge();

            //when
            var restul = chall.Reverse(input);

            //then
            Assert.Equal(expected, restul);
        }
    }
}
