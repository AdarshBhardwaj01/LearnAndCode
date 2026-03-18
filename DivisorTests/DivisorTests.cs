using Xunit;
using DivisorLib;

namespace DivisorTests
{
    public class DivisorCounterTests
    {
        [Fact]
        public void ShouldReturnTwoForInputFifteen()
        {
            int result = DivisorCounter.CountNumbersWithEqualAdjacentDivisors(15);
            Assert.Equal(2, result);
        }
    }
}