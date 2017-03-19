using NUnit.Framework;
using Refactoring.ReplaceTempWithQuery;

namespace Refactoring.Tests.ReplaceTempWithQuery
{
    [TestFixture]
    public class ProductPriceTest
    {
        [Test]
        public void ProductPriceIsQuantityTimesItemPriceReducedWithDiscount()
        {
            Assert.AreEqual(490.0, CalculateProductPrice(10, 50), 0.0);
        }

        [Test]
        public void ProductPriceGetsHigherDiscountIfBasePriceIsGreaterThen1000()
        {
            Assert.AreEqual(980.0, CalculateProductPrice(10, 100), 0.0);
            Assert.AreEqual(959.5, CalculateProductPrice(10, 101), 0.0);
        }

        private double CalculateProductPrice(int quantity, int itemPrice)
        {
            ProductPrice productPrice = new ProductPrice(quantity, itemPrice);
            return productPrice.GetPrice();
        }
    }
}