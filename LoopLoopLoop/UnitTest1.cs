using System;
using Xunit;

namespace LoopLoopLoop
{
    public class UnitTest1
    {
        [Fact]
        public void HelloShouldReturnHello()
        {
            Assert.Equal("hello", LoopLoopLoop.Hello());
        }

    }
}
