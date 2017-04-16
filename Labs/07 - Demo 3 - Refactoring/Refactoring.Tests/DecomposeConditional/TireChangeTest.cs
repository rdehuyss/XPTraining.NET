using Refactoring.DecomposeConditional;
using Xunit;
using FluentAssertions;

namespace Refactoring.Tests.DecomposeConditional
{
    public class TireChangeTest
    {
        private const int SUMMERRATE = 20;
        private const int WINTERSERVICECHARGE = 15;
        private const int WINTERRATE = 10;
        private const int QUANTITY = 2;
        private TireChange tireChange;

        public TireChangeTest()
        {
            tireChange = new TireChange(QUANTITY, WINTERRATE, WINTERSERVICECHARGE, SUMMERRATE);
        }

        [Theory]
        [InlineData(1, QUANTITY * WINTERRATE + WINTERSERVICECHARGE)]
        [InlineData(2, QUANTITY * WINTERRATE + WINTERSERVICECHARGE)]
        [InlineData(3, QUANTITY * SUMMERRATE)]
        [InlineData(4, QUANTITY * SUMMERRATE)]
        [InlineData(5, QUANTITY * SUMMERRATE)]
        [InlineData(6, QUANTITY * SUMMERRATE)]
        [InlineData(7, QUANTITY * SUMMERRATE)]
        [InlineData(8, QUANTITY * SUMMERRATE)]
        [InlineData(9, QUANTITY * SUMMERRATE)]
        [InlineData(10, QUANTITY * SUMMERRATE)]
        [InlineData(11, QUANTITY * SUMMERRATE)]
        [InlineData(12, QUANTITY * WINTERRATE + WINTERSERVICECHARGE)]
        public void TireCharge(int month, int expectedResult)
        {
            var charge = tireChange.Charge(month);
            charge.Should().Be(expectedResult);
        }
        
    }
}