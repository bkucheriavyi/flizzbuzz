using Xunit;

namespace flizzbuzz.tests
{
    public class FizzBuzzChallange1Tests
    {
        [Theory]
        [InlineData(1, 20)]
        public void FlizzBuzzChallange1(int from, int to)
        {
            //given
            var expecetedOutput = "1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz 16 17 fizz 19 ";

            //when
            var flizBuz = new FizzBuzzChallange();

            //then
            var result = flizBuz.Magic_3_5_15(from, to);
            Assert.Equal(expecetedOutput, result);
        }
    }
}
