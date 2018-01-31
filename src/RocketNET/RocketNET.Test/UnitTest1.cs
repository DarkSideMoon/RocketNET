using RocketNET.Core;
using System;
using Xunit;

namespace RocketNET.Test
{
    public class UnitTest1
    {
        [Fact]
        [Trait("", "Test")]
        public void Test1()
        {
            Assert.True(5 == 5);
        }

        [Fact]
        [Trait("", "Test")]
        public void Test_RocketGO()
        {
            RocketGO rocketGO = new RocketGO();

            Assert.True(rocketGO.GO == "GO!");
        }
    }
}
