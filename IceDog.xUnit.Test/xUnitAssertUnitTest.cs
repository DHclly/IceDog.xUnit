using System;
using System.Collections.Generic;
using System.Linq;
using IceDog.xUnit.Test.Mocks;
using Xunit;

namespace IceDog.xUnit.Test
{
    public class xUnitAssertUnitTest
    {
        private readonly List<Product> _fruitList;
        private readonly List<Product> _beverageList;

        public xUnitAssertUnitTest()
        {
            ProductList _productList = new ProductList();
            _fruitList = _productList.Where(p => p.Category.Equals("Fruits")).ToList();
            _beverageList = _productList.Where(p => p.Category.Equals("Beverages")).ToList();
        }

        [Fact(DisplayName = "Test the [Assert.Equal]")]
        public void Equal()
        {
            var first = _fruitList.First();
            Assert.Equal("Melon",first.Name);
        }

        [Fact(DisplayName = "Test the [Assert.NotEqual]")]
        public void NotEqual()
        {
            var first = _fruitList.First();
            Assert.NotEqual("A Melon", first.Name);
        }

        [Fact(DisplayName = "Test the [Assert.False]")]
        public void False()
        {
            var first = _fruitList.First();
            Assert.False(first.Discontinued);
        }

        [Fact(DisplayName = "Test the [Assert.True]")]
        public void True()
        {
            var last = _beverageList.Last();
            Assert.True(last.Discontinued);
        }
    }
}
