using FluentAssertions;
using NUnit.Framework;

namespace PetShop.Tests
{
    [TestFixture]
    public class ShopTest
    {
        [Test]
        public void AddItemToStock()
        {
            var shop = new Shop();
            shop.AddItemToStock("Doggy Gucci bag");
            shop.Stock.Should().Contain("Doggy Gucci bag");
        }
    }
}
