using System;
using System.Collections.Generic;
using System.Linq;
using IceDog.xUnit.Test.Mocks;
using Xunit;

namespace IceDog.xUnit.Test
{
    public class xUnitSelfUnitTest
    {
        private readonly List<Product> _fruitList;
        private readonly List<Product> _beverageList;

        public xUnitSelfUnitTest()
        {
            ProductList _productList = new ProductList();
            _fruitList = _productList.Where(p => p.Category.Equals("Fruits")).ToList();
            _beverageList = _productList.Where(p => p.Category.Equals("Beverages")).ToList();
        }

        [Fact(DisplayName = "Test the [Fact.DisplayName],you will see me at the resource manager panel of vs")]
        public void FactDisplayName()
        {
            var first = _fruitList.First();
            Assert.False(first.Discontinued);
        }

        [Fact(DisplayName = "Test the [Fact.Skip]", Skip = "I will not run ,I will see on the ouput panel of vs")]
        public void FactSkip()
        {
            var first = _fruitList.First();
            Assert.True(first.Discontinued);//make error
        }

        [Theory(DisplayName = "Test the [Theory.DisplayName],you will see me at the resource manager panel of vs")]
        [InlineData("Melon")]
        public void TheoryDisplayName(string name)
        {
            var first = _fruitList.First();
            Assert.Equal(name,first.Name);
        }

        [Theory(DisplayName = "Test the [Theory.Skip]", Skip = "I will not run ,I will see on the ouput panel of vs")]
        [InlineData("Melon")]
        public void TheorySkip(string name)
        {
            name = name + "Change";
            var first = _fruitList.First();
            Assert.Equal(name,first.Name);//make error
        }

        [Theory(DisplayName = "Test the [InlineData]")]
        [InlineData("Melon", "Fruits",false)]
        public void InlineDataWithTheory(string name, string category, bool discontinued)
        {
            var first = _fruitList.First();
            Assert.Equal(name,first.Name);
            Assert.Equal(category,first.Category);
            Assert.Equal(discontinued,first.Discontinued);
        }

        [Theory(DisplayName = "Test a lot of [InlineData]")]
        [InlineData("Melon", "Fruits")]
        [InlineData("Pear", "Fruits")]
        [InlineData("Grape", "Fruits")]
        public void ManyInlineDataWithTheory(string name, string category)
        {
            Assert.Contains(name,_fruitList.Select(p=>p.Name));
            _fruitList.ForEach(p=> Assert.Equal(category,p.Category));
        }

        [Theory(DisplayName = "Test the [MemberData]")]
        [InlineData("Melon", "Fruits", false)]
        public void MemberDataWithTheory(string name, string category, bool discontinued)
        {
            var first = _fruitList.First();
            Assert.Equal(name, first.Name);
            Assert.Equal(category, first.Category);
            Assert.Equal(discontinued, first.Discontinued);
        }

        [Theory(DisplayName = "Test the [MemberData]")]
        [InlineData("Melon", "Fruits", false)]
        public void ClassDataWithTheory(string name, string category, bool discontinued)
        {
            var first = _fruitList.First();
            Assert.Equal(name, first.Name);
            Assert.Equal(category, first.Category);
            Assert.Equal(discontinued, first.Discontinued);
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
