using Xunit;
using FluentAssertions;

namespace PetShop.Tests
{
    public class ShopTest
    {
        [Fact]
        public void AddItemToStock()
        {
            var shop = new Shop();
            shop.AddItemToStock("Doggy Gucci bag");
            shop.Stock.Should().Contain("Doggy Gucci bag");
        }
    }
}
