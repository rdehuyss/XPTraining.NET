using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace PetShop.UnitTests
{

    [TestFixture]
    public class ShopTests
    {
        private Shop _classUnderTest;

        [SetUp]
        public void CreateShop()
        {
            _classUnderTest = new Shop(); 
        }

        [Test]
        public void AddItem_AddsItemToStock()
        {
            const string item = "Doggy Gucci bag";
            _classUnderTest.AddItem(item);

            IEnumerable<string> items = _classUnderTest.GetItemsInStock();

            items.ToList().Should().Contain(item);
        }
    }
}
