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
            var expecetedOutput = "1 2 lucky 4 buzz fizz 7 8 fizz buzz 11 fizz lucky 14 fizzbuzz 16 17 fizz 19 ";

            //when
            var flizBuz = new FizzBuzzChallange();

            //then
            var result = flizBuz.Magic_3_5_15(from, to);
            
            Assert.Equal(expecetedOutput, result);
        }

        [Theory]
        [InlineData(1, 20)]
        public void FlizzBuzzChallange_GetsSummary(int from, int to)
        {
            //given
            var expecetedOutput = "1 2 lucky 4 buzz fizz 7 8 fizz buzz 11 fizz lucky 14 fizzbuzz 16 17 fizz 19 ";
            var expecetedSummary = $"fizz: 4\nbuzz: 2\nfizzbuzz: 1\nlucky: 2\ninteger: 10";

            //when
            var flizBuz = new FizzBuzzChallange();

            //then
            var result = flizBuz.Magic_3_5_15(from, to);
            var summaryInfo = flizBuz.GetSummary(result);

            Assert.Equal(expecetedOutput, result);
            Assert.Equal(expecetedSummary, summaryInfo);
        }
    }
}
