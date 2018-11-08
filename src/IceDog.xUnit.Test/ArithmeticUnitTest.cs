using System;
using System.Collections.Generic;
using System.Text;
using IceDog.xUnit.Test.Mocks;
using Xunit;

namespace IceDog.xUnit.Test
{
    public class ArithmeticUnitTest
    {
        [Fact]
        public void Add()
        {
            Arithmetic a = new Arithmetic();
            int res = a.Add(1, 2);
            Assert.Equal(3, res);
        }

        [Fact]
        public void Divide()
        {
            Arithmetic a = new Arithmetic();
            Assert.Throws<DivideByZeroException>(() => a.Divide(1, 0));
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(1, 0)]
        [InlineData(0, 2)]
        public void AddMultiple(int parmaA, int parmaB)
        {
            Arithmetic a = new Arithmetic();
            int res = a.Add(parmaA, parmaB);
            Assert.Equal(parmaA + parmaB, res);
        }
    }
}
