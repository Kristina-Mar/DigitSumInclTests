namespace DigitSum.Tests
{
    public class UnitTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(3, 3)]
        [InlineData(10, 1)]
        [InlineData(25, 7)]
        [InlineData(8477, 26)]
        [InlineData(3698524, 37)]
        public void TestSumDigitsMethod(int number, int sum)
        {
            Assert.Equal(sum, DigitSumMethod.SumDigits(number));
        }
    }
}