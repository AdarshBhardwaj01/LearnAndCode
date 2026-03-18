using Xunit;
using DivisorLib;

namespace DivisorTests
{
    public class Tests
    {
        [Fact]
        public void Example_Test()
        {
            Assert.Equal(2, DivisorCounter.CountValidN(15));
        }
    }
}