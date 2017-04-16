using Xunit;
using FluentAssertions;
using Refactoring.ReplaceTempWithQuery;

namespace Refactoring.Tests.ReplaceTempWithQuery
{
    public class ProductPriceTest
    {
        [Fact]
        public void ProductPriceIsQuantityTimesItemPriceReducedWithDiscount()
        {
            CalculateProductPrice(10, 50).Should().Be(490.0);
        }

        [Fact]
        public void ProductPriceGetsHigherDiscountIfBasePriceIsGreaterThen1000()
        {
            CalculateProductPrice(10, 100).Should().Be(980.0);
            CalculateProductPrice(10, 101).Should().Be(959.5);
        }

        private double CalculateProductPrice(int quantity, int itemPrice)
        {
            ProductPrice productPrice = new ProductPrice(quantity, itemPrice);
            return productPrice.GetPrice();
        }
    }
}