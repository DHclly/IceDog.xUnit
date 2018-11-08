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
        [Trait("category","fruites")]
        public void Equal()
        {
            var first = _fruitList.First();
            Assert.Equal("Melon",first.Name);
        }

        [Fact(DisplayName = "Test the [Assert.NotEqual]")]
        [Trait("category", "fruites")]
        public void NotEqual()
        {
            var first = _fruitList.First();
            Assert.NotEqual("A Melon", first.Name);
        }

        [Fact(DisplayName = "Test the [Assert.False]")]
        [Trait("category", "fruites")]
        public void False()
        {
            var first = _fruitList.First();
            Assert.False(first.Discontinued);
        }

        [Fact(DisplayName = "Test the [Assert.True]")]
        [Trait("category", "beverages")]
        public void True()
        {
            var last = _beverageList.Last();
            Assert.True(last.Discontinued);
        }
        private int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
        /// <summary>
        /// Xunit并不是通过Attribute来标记异常捕获的，而是直接使用Assert.Throws断言函数来验证异常。
        /// </summary>
        [Fact(DisplayName = "Test the [Assert.Throws<DivideByZeroException>]")]
        public void ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => Divide(1, 0));
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact(DisplayName = "Test the [Assert.Throws<IndexOutOfRangeException>]")]
        [Trait("category", "beverages")]
        public void ThrowsIndexOutOfRangeException()
        {
            var last = _beverageList.Last();
            Assert.Throws<IndexOutOfRangeException>(() =>last.Name[10]);
        }
    }
}
