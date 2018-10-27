using System;
using System.Linq;
using IceDog.xUnit.Test.Mocks;
using Xunit;

namespace IceDog.xUnit.Test
{
    public class UnitTest1
    {
        private ProductList  _productList= new ProductList();

        [Fact(DisplayName = "Test the [Fact.DisplayName],you will see me at the resource manager panel of vs")]
        public void DisplayName()
        {
            Assert.False(false);
        }

        [Fact(DisplayName = "Test the [Fact.Skip]", Skip = "I will not run ,I will see on the ouput panel of vs")]
        public void Skip()
        {
            Assert.False(true);//make error
        }

        [Fact(DisplayName = "Test the [Assert.Equal]")]
        public void Equal()
        {
            var first = _productList.First();
            Assert.Equal("Melon",first.Name);
        }

        [Fact(DisplayName = "Test the [Assert.NotEqual]")]
        public void NotEqual()
        {
            var first = _productList.First();
            Assert.NotEqual("A Melon", first.Name);
        }

        [Fact(DisplayName = "Test the [Assert.False]")]
        public void False()
        {
            var first = _productList.First();
            Assert.False(first.Discontinued);
        }

        [Fact(DisplayName = "Test the [Assert.True]")]
        public void True()
        {
            var last = _productList.Last();
            Assert.True(last.Discontinued);
        }
    }
}
