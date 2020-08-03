using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestPractice
{
    public class MainTests
    {
        [Fact]
        public void Calculate()
        {
            int x = 1;
            int y = 3;
            Assert.True(y > x);
            Assert.False(y < x);
            Assert.NotEqual(y, x);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(3, 7, 10)]
        [InlineData(1, 4, 5)]
        [InlineData(7, 2, 4)]//통과실패
        public void Add(int x, int y, int expected)
        {
            var z = x + y;
            Assert.True(z == expected);
        }
    }
}
